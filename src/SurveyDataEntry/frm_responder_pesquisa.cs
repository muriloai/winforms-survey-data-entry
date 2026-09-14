using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurveyDataEntry
{
    public partial class frm_responder_pesquisa : Form
    {
        //id do formulario!
        int ID_formulario = new int();
        //id_posto de coleta da pesquisa!
        int id_posto_coleta = new int();
        //index da fila da pergunta que está sendo exibida na tela!
        int indexPerguntaAtual=-1;
        //lista de ids das perguntas liberadas para listagem!
        private List<int> IDs_perguntas;
        //camada de dados!
        private camada_dados dados = new camada_dados();       
        //objeto atualizante da pergunta que esta sendo exibido, para aproveitar o maxPerm + nulo!
        objeto_pergunta perguntaDoMomento = new objeto_pergunta();
        //lista que carrega tudo o que faz!
        List<objeto_pergunta_respondida> ListaDeRespostasEfetuadas = new List<objeto_pergunta_respondida>();
        //objeto padrao que usa no form para efetuar a resposta final!
        private objeto_pergunta_respondida novaResposta;
        //freio de gravação final, porque se clicar rápido enter capaz que grave mais vezes seguidas!
        private Boolean gravou = false;

        public int get_qtdIDS_pergunta()
        {
            //metodo montado para saber se tem algum id de perguntas carregado!
            return this.IDs_perguntas.Count;
        }
        public frm_responder_pesquisa(int ID_formulario, int id_posto_coleta)
        {
            //recebo o numero do formulario de onde as perguntas irão ser listadas!
            this.ID_formulario = ID_formulario;
            this.id_posto_coleta = id_posto_coleta;
            InitializeComponent();
        }

        private void frm_responder_persquisa_Load(object sender, EventArgs e)
        {
            //ao carregar!
            if(ConexaoBD.abrirConexao())
            {
                //capturo os ids das perguntas validas do formulario selecionado! 
                this.IDs_perguntas = dados.selecionarID_TodasPerguntasDoFormulario(ID_formulario);
                carregarProximaPergunta();
                this.tltp_infos.ToolTipTitle = "Informação!";
                tltp_infos.SetToolTip(this.pcbx_info, "Referente ao Formulário: "+dados.selecionarUmFormulario_porID(ID_formulario).titulo.ToString()+"\n"+"Posto de Coleta: "+dados.selecionarUmPosto_Coleta_porID(id_posto_coleta).nome.ToString());
            }            
        }
        //***********************ANTERIOR*************
        private void carregarAnteriorPergunta()
        {
            if (ConexaoBD.abrirConexao())
            {
                //recolho o indice na lista da primeira pergunta!
                int indexPergAtual = getIdAnteriorPergunta();
                //enquanto estiver dentro da qtd captada de perguntas para este formulario!
                if ((indexPerguntaAtual < IDs_perguntas.Count) && (indexPergAtual >= 0))
                {
                    //carrego a pergunta!
                    carregarUmaPergunta(indexPergAtual);
                    //carrego as opçoes de respostas!
                    carregarOpcoesRespostas(indexPergAtual);
                    //recupera respostas antigas se tiver!
                    carregarRespostaGravada(indexPergAtual);
                }
                else
                {
                    //caso primeira pergunta! nao fazer nada!
                }
            }
        }
        private int getIdAnteriorPergunta()
        {
            //se  o index estiver dentro da qtd das perguntas existentes para este Formulario!
            if (indexPerguntaAtual <= IDs_perguntas.Count)
            {
                //se for ser mostrado a ultima pergunta carregar esse texto!
                if (indexPerguntaAtual == IDs_perguntas.Count - 1)
                {
                    this.btn_responder.Text = "Responder e Encerrar!";
                }
                else
                {
                    this.btn_responder.Text = "Responder >>";
                    //se for mostrar a primeira pergunta esconder o voltar!
                    if (indexPerguntaAtual == 1)
                    {
                        this.btn_voltar.Visible = false;
                    }
                    else
                    {
                        this.btn_voltar.Visible = true;
                    }
                }
                return --indexPerguntaAtual;
            }
            else
            {
                return 0;
            }
        }
        //**********************PROXIMA****************
        private void carregarProximaPergunta()
        {            
            if (ConexaoBD.abrirConexao())
            {                
                //recolho o indice na lista da primeira pergunta!
                int indexPergAtual = getIdProximaPergunta();
                //enquanto estiver dentro da qtd captada de perguntas para este formulario!
                if ((indexPerguntaAtual < IDs_perguntas.Count)&&(indexPergAtual >= 0))
                {
                    //carrego a pergunta!
                    carregarUmaPergunta(indexPergAtual);
                    //carrego as opçoes de respostas!
                    carregarOpcoesRespostas(indexPergAtual);
                    //recupera respostas antigas se tiver!
                    carregarRespostaGravada(indexPergAtual);
                }
                else
                {
                    tela_final tf = new tela_final(this);
                    if (this.gravou == false)//freio de gravar duas vezes seguidas por cliques de enters rápidos!
                    {
                        this.gravou = true;
                        this.KeyPreview = false;
                        if (gravandoNoBDPesquisaRespondida())
                        {
                            //retiro porque com o dialog capaz de ativar o enter e gravar denovo!
                            tf.ShowDialog();                            
                            //caso ultima pergunta! renovar!
                            renovarFormulario();
                            
                        }
                        else
                        {                           
                            MessageBox.Show(null, "Problemas ao Cadatrar! \nPorém, Fique Tranquilo Nenhum Dado foi Inserido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        this.gravou = false;
                        this.KeyPreview = true;
                    }
                }
            }      
        }
        private void renovarFormulario()
        {
          try
                {
                //zerar elementos!
                indexPerguntaAtual = -1;
                ListaDeRespostasEfetuadas.Clear();                
                novaResposta.remover_todasRespostas();
                if (ConexaoBD.abrirConexao())
                {
                    //capturo os ids das perguntas validas do formulario selecionado! 
                    this.IDs_perguntas = dados.selecionarID_TodasPerguntasDoFormulario(ID_formulario);
                    carregarProximaPergunta();
                }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine("Erro ao carregar perguntas: " + ex.Message);
                    this.Close();
                }
           
        }
        private int getIdProximaPergunta()
        {
            //se  o index estiver dentro da qtd das perguntas existentes para este Formulario!
            if (indexPerguntaAtual < IDs_perguntas.Count-1)
            {
                //se for ser mostrado a ultima pergunta carregar esse texto!
                if (indexPerguntaAtual == IDs_perguntas.Count - 2)
                {
                    this.btn_responder.Text = "Responder e Encerrar!";
                }
                else
                {
                    this.btn_responder.Text = "Responder >>";
                    //se for mostrar a primeira pergunta esconder o voltar!
                    if (indexPerguntaAtual < 0)
                    {
                        this.btn_voltar.Visible = false;
                    }
                    else
                    {
                        this.btn_voltar.Visible = true;
                    }
                }
                //incrementando aqui em ultimo lugar pq vem de zero no inicio!
                return ++indexPerguntaAtual;
            }
            else
            {
                return -1;
            }
        }
        //********************AUXILIARES************************
        public void focarNoPrimeiro()
        {
            int qtd = 0;
            foreach (Control i in pnl_respostas.Controls)
            {
                ++qtd;
                if (qtd == 1)
                {
                    resposta resp = (resposta)i;
                    resp.focarNoPrimeiroCampo(resp.getTipoResposta());
                }
            }
        }
        private void carregarRespostaGravada(int indexPergunta)
        { 
            int cont=0;
            //verifico em todos as perguntas respondidas que fiz!
            for (cont = 0; cont < ListaDeRespostasEfetuadas.Count; cont++)
            {
                //Verifica se o id_pergunta que esta na lista é o que vou carregar! 
                if(ListaDeRespostasEfetuadas[cont].getId_pergunta()==IDs_perguntas[indexPergunta])
                {
                    //encontrado, agora é encontrar o control que precisa ser setado! 
                    foreach (Control i in pnl_respostas.Controls)
                    {                        
                        resposta resp = (resposta)i;
                        int cont_um=0;
                        List<objeto_resposta_respondida> lista = new List<objeto_resposta_respondida>();
                        //a lista tem todas as respostas da pergunta atual!
                        lista=ListaDeRespostasEfetuadas[cont].getTodasResposta();
                        //encontrar a resposta com mesmo id_resposta do Control atual!
                        for(cont_um=0;cont_um<lista.Count;cont_um++)
                        {
                          if(resp.ler_idResposta()==lista[cont_um].id_resposta)
                          {
                              //encontrado!
                              switch(lista[cont_um].tipo) //dependendo do tipo tem uma setagem especifica!
                              {
                                  case 1:
                                      resp.selecionarEsteComponente();
                                      break;
                                  case 2:
                                  resp.selecionarEsteComponente();
                                  resp.escrever_textoDigitadoNaResposta(lista[cont_um].texto);
                                  break;
                                  case 3:
                                  resp.selecionarEsteComponente();

                                  resp.selecionar_valorQttvoSelecionado(Convert.ToInt32(lista[cont_um].valorQuantitativo));
                                  break;
                              }
                          }
                        }
                    }
                }
                else
                {
                    //faça nada, checaremos o proximo!
                }
              }
        }        
        private int getQtdRespDisponiveis()
        {           
            int qtdOpcoes = 0;
            foreach (Control i in pnl_respostas.Controls)
            {
                //identifica quantos opções de respostas tem!
                ++qtdOpcoes;
            }
            return qtdOpcoes;
        }
        private void marcarSeForUnicaOpcao()
        {
            int qtdOpcoes = getQtdRespDisponiveis();
            //se tiver so uma opcao ele a marca automaticamente!
            if ((qtdOpcoes <= 1) && (qtdOpcoes > 0))
            {
                foreach (Control i in pnl_respostas.Controls)
                {
                    resposta componente = (resposta)i;
                    //marcando como selecionado!
                    componente.selecionarEsteComponente();
                }
            }
        }
        public int getQtdRespJaMarcada()
        {          
            int qtdOpcoes = 0;
            foreach (Control i in pnl_respostas.Controls)
            {
                resposta resp = (resposta)i;
                if (resp.verificar_seEstaSelecionado())
                {
                    ++qtdOpcoes;
                }
            }
            return qtdOpcoes;
        }       
        //**************RESPONDER******************
        private Boolean captarOsDadosESalvar()
        {
            //dentro do maxPerm + NAO permNulo + Marcadas Um ou +!
            if (ConexaoBD.abrirConexao())
            {
                //vou em cada resposta e faço o teste recolhendo seus valores respondidos conforme o tipo!
                foreach (Control i in pnl_respostas.Controls)
                {
                    resposta resp = (resposta)i;
                    //se está selecionada como resposta!
                    if (resp.verificar_seEstaSelecionado())
                    {
                        //vejo o tipo que ela é e faço a resp nova alocada aqui receber o valor quadro da resp atual!
                        switch (resp.getTipoResposta())
                        {
                            case 1:
                                novaResposta.item_respondido(resp.ler_idResposta());
                                break;
                            case 2:
                                if (resp.ler_textoDigitadoNaResposta() != String.Empty)
                                {
                                    novaResposta.item_respondido(resp.ler_idResposta(), resp.ler_textoDigitadoNaResposta());
                                }
                                break;
                            case 3:
                                novaResposta.item_respondido(resp.ler_idResposta(), resp.ler_valorQttvoSelecionado());
                                break;
                        }
                    }
                }
                //nova resposta adquire o id da pergunta
                novaResposta.setID_pergunta(IDs_perguntas[indexPerguntaAtual]);
                //se respondidas são mais que nenhuma!
                if ((novaResposta.getQtdRespondida() > 0))
                {
                    int cont =0;
                    for (cont = 0; cont < ListaDeRespostasEfetuadas.Count; cont++)
                    {
                        //se achar uma pergunta completa respondida antiga com o mesmo id da resposta nova, já removo!
                        if (ListaDeRespostasEfetuadas[cont].getId_pergunta() == novaResposta.getId_pergunta())
                        {
                            //removo!
                            ListaDeRespostasEfetuadas.Remove(ListaDeRespostasEfetuadas[cont]);
                        }
                    }
                    //insiro na lista como resposta efetuada!                    
                    ListaDeRespostasEfetuadas.Add(novaResposta);
                    return true;
                }
                //se permite nulo tudo bem!
                else if (perguntaDoMomento.permite_nulo == 's')
                { 
                    //se tiver uma antiga ja respondida e a nova for nula e possivel por permitir nulo, já a removo!
                    int cont = 0;
                    for (cont = 0; cont < ListaDeRespostasEfetuadas.Count; cont++)
                    {
                            //se achar uma pergunta completa respondida antiga com o mesmo id da resposta nova, já removo!
                            if (ListaDeRespostasEfetuadas[cont].getId_pergunta() == novaResposta.getId_pergunta())
                            {
                                //removo!
                                ListaDeRespostasEfetuadas.Remove(ListaDeRespostasEfetuadas[cont]);
                            }
                   }                        
                 return true;
                }
                //senao avisa urgentemente!
                else
                {
                    MessageBox.Show("Revise, completando os campos e tente novamente!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Conecte-se a Fonte do Banco de Dados, para Conseguir Registrar esses dados!");
                return false;
            }
        }      
        //*********************************
        private void carregarUmaPergunta(int indexPergunta)
        {           
            if (ConexaoBD.abrirConexao())
            {
                objeto_pergunta pergunta = new objeto_pergunta();
                pergunta = dados.selecionarPergunta_porID(IDs_perguntas[indexPergunta]);
                //Escrevo a pergunta!
                lbl_pergunta.Text = pergunta.posicao + ". " + pergunta.nomenclatura;
                //Escrevo o aviso de máximas escolhas! 
                lbl_maxPerm.Text = "(Assinale no máximo: "+pergunta.maxResp + " !)";                 
                this.perguntaDoMomento = pergunta;                
            }       
        }
        private void carregarOpcoesRespostas(int indexPergunta)
        {
            //libera no painel de respostas nas opções que preciso!
            pnl_respostas.AutoScroll = true;
            pnl_respostas.AutoSize = false;
            pnl_respostas.VerticalScroll.Enabled = true;
            pnl_respostas.HorizontalScroll.Enabled = false;
            pnl_respostas.Controls.Clear();
            //carregamento das respostas da pergunta!
            List<objeto_resposta> listaRespostas = dados.selecionarTodasRespostasAtivas_deUmaPerguntaID(IDs_perguntas[indexPergunta]);

            //items para usar na criacao de componentes!
            int cont = 0;
            resposta novo;
            int qtdRespostas = listaRespostas.Count;

            //cria-se os objetos das respostas e altera seus valores internos!
            for (cont = 0; cont < qtdRespostas; cont++)
            {
                //gero ocomponente!
                novo = new resposta();
                //preencho a largura, batendo com o tamanho do painel!
                novo.alterarComprimentoPainel((pnl_respostas.Width-30));
                //altero a componente!
                novo.alterar_posicao_resposta(listaRespostas[cont].posicao);
                novo.alterar_idResposta(listaRespostas[cont].id_resposta);
                novo.alterar_resposta(listaRespostas[cont].nomenclatura);
                novo.alterar_tipoResposta(listaRespostas[cont].tipo);
                pnl_respostas.Controls.Add(novo);
            }
            //inicia em -1 porque dá se a contagem logo somando a 0!
            int qtd = -1;
            foreach (Control i in pnl_respostas.Controls)
            {
                //identifica quantos objetos tem!
                qtd++;
                //adapta a posicao conforme a quantidade de items!            
                i.SetBounds(i.Location.X, (i.Location.Y + i.Size.Height) * qtd, i.Width, i.Height, BoundsSpecified.All);
            }
            marcarSeForUnicaOpcao();
            focarNoPrimeiro();
        }        
        private void btn_responder_Click(object sender, EventArgs e)
        {
            //nova posicao a cada pergunta carregada!
            this.novaResposta = new objeto_pergunta_respondida();
            //O Formulario fica sabendo a qtd permitida de máximas escolhas!            
            this.novaResposta.setMaxPerm(perguntaDoMomento.maxResp);
            //se as oplçoes marcadas forem menores ou iguais a qtd de maxPermitido!
            if (getQtdRespJaMarcada() <= novaResposta.getMaxPerm())
            {
                //se a pergunta NAO permite nulo!
                if ((this.perguntaDoMomento.permite_nulo == 'n'))
                {
                    //se a qtd de opções marcadas for menor ou igual a zero!
                    if((getQtdRespJaMarcada() <= 0))
                    {
                        MessageBox.Show(null,"Esta Pergunta não Permite ser Registrada sem Escolher Nenhuma Opção!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //se captou e salvou
                        if (captarOsDadosESalvar())
                        {
                            carregarProximaPergunta();
                        }
                    }
                }
                else
                {                   
                    if (getQtdRespJaMarcada() <= 0) //permite nulo não tem nenhum selecionado!
                    {
                        //se captou nada e salvou nada
                        if (captarOsDadosESalvar())
                        {
                            carregarProximaPergunta();
                        }
                    }
                    else //permite nulo mas alguma opção foi escolhida!
                    {
                        //se captou e salvou
                        if (captarOsDadosESalvar())
                        {
                            carregarProximaPergunta();
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show(null,"O Limite de opções Marcadas é de: "+novaResposta.getMaxPerm()+"\nDesmarque algumas opções e tente novamente!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            carregarAnteriorPergunta();
        }
        private void btn_desmarcarTudo_Click(object sender, EventArgs e)
        {
            int qtdElementos = 0;
            foreach (Control i in pnl_respostas.Controls)
            {
                qtdElementos++;
            }
            if ((qtdElementos == 1) && (qtdElementos != 0))
            {
            }
            else
            {
                foreach (Control i in pnl_respostas.Controls)
                {
                    resposta resp = new resposta();
                    resp = (resposta)i;
                    resp.deSelecionarEsteComponente();
                }
            }
        }
        private void frm_responder_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {

                if ((btn_voltar.Visible == true))
                {
                    //objeto de teste!
                    resposta resp = new resposta();
                    try
                    {
                      resp=(resposta)ActiveControl;
                    //se esta sendo editado algum texto dentro da resposta, o que precisa do backspace para apagar e nao para andar pra tras!                    
                    if (resp.verificarSeTextoEstaSendoDigitado()) 
                    {
                    }
                    else
                    {
                        btn_voltar_Click(this, null);
                    }
                    }
                    catch (Exception)
                    {
                        btn_voltar_Click(this, null);
                    }
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn_responder_Click(this, null);
            }
            else
            {
                if(new List<Keys>{Keys.D1,Keys.D2,Keys.D3,Keys.D4,Keys.D5,Keys.D6,Keys.D7,Keys.D8,Keys.D9}.Contains(e.KeyCode))
                {
                    selecionaPerguntaPorNumeroDePosicao(Convert.ToInt32(e.KeyCode.ToString().Substring(1, 1)));
                }
            }
        }
        private Boolean gravandoNoBDPesquisaRespondida()
        {
            if (ConexaoBD.abrirConexao())
            {
                int cont = 0;
                MySqlTransaction transacao = ConexaoBD.getConexao().BeginTransaction();
                //gero registro de um novo questionario de dependencia!
                int id_questionario = dados.inserir_umQuestionarioEReceberIDdele(id_posto_coleta, ID_formulario, transacao);
                for (cont = 0; cont < ListaDeRespostasEfetuadas.Count; cont++)
                {
                    //lista das respostas efetuadas dentro de uma pergunta!
                    List<objeto_resposta_respondida> lista = new List<objeto_resposta_respondida>();
                    //recebo todas as respostas do item em questao!
                    lista = ListaDeRespostasEfetuadas[cont].getTodasResposta();
                    int cont_um = 0;                   
                    for (cont_um = 0; cont_um < lista.Count; cont_um++)
                    {
                        if (lista[cont_um].tipo == 1)//se for respota do tipo sem texto!
                        {                            
                            if (id_questionario != 0)
                            {
                                if (dados.inserir_umaRespostaCompleta(ListaDeRespostasEfetuadas[cont].getId_pergunta(), lista[cont_um].id_resposta, id_questionario,transacao))
                                {
                                    
                                }
                                else
                                {
                                    transacao.Rollback();
                                    return false;
                                }
                            }
                            else
                            {
                                transacao.Rollback();
                                return false;
                            }
                        }
                        else if (lista[cont_um].tipo == 2)//se for respota do tipo com texto!
                        {                               
                            if(id_questionario !=0)
                            {
                            if (dados.inserir_umaRespostaCompleta_texto(ListaDeRespostasEfetuadas[cont].getId_pergunta(), lista[cont_um].id_resposta, lista[cont_um].texto, id_questionario,transacao))
                            {
                               
                            }
                            else
                            {
                                transacao.Rollback();
                                return false;
                            }
                            }
                            else
                            {
                                transacao.Rollback();
                                return false;
                            }
                        }
                        else if (lista[cont_um].tipo == 3)//se for respota do tipo qttiva!
                        {
                            if (id_questionario != 0)
                            {
                                if (dados.inserir_umaRespostaCompleta_texto(ListaDeRespostasEfetuadas[cont].getId_pergunta(), lista[cont_um].id_resposta, lista[cont_um].valorQuantitativo, id_questionario, transacao))
                                {

                                }
                                else
                                {
                                    transacao.Rollback();
                                    return false;
                                }
                            }
                            else
                            {
                                transacao.Rollback();
                                return false;
                            }
                        }
                    }
                }
                transacao.Commit();
                return true;
            }
            else
            {
                MessageBox.Show("Conecte-se a Fonte do Banco de Dados, para Conseguir Registrar esses dados!");
                return false;
            }
        }

        private void lbl_pergunta_TextChanged(object sender, EventArgs e)
        {
            int fatorDeCorte = 0;
            if (this.lbl_pergunta.Text.Length > 95)
            {
                int cont = 1;
               // falta por object quebra cetinho 2 vezes ta repetindo muito!
                fatorDeCorte = lbl_pergunta.Text.Length / 95;
                for (cont = 1; cont < fatorDeCorte; cont++)
                {
                    int contEspaco = 95;
                    for (contEspaco = 95; contEspaco > 85; contEspaco--)
                    {
                        if (lbl_pergunta.Text.Substring(contEspaco, 1).Equals(" "))
                        {
                            lbl_pergunta.Text = lbl_pergunta.Text.Substring(0, cont*(contEspaco - 1)) + "\n" + lbl_pergunta.Text.Substring(contEspaco + 1 , lbl_pergunta.Text.Length - (contEspaco + 1));
                            break;
                        }
                    }
                }
            }
        }
        private void selecionaPerguntaPorNumeroDePosicao(int posicao)
        {
            int qtd = 0, existentes = 0;
            foreach (Control i in pnl_respostas.Controls)
            {
                existentes++;
            }
            if(existentes>1)//não sendo unico nem zerado faça!
            {
                //vou em cada um e checo sua posicao e se for igual ao que quero eu seleciono e foco nele!
                foreach (Control i in pnl_respostas.Controls)
                {
                    qtd = qtd + 1;
                    resposta resp = (resposta)i;
                    if (qtd==posicao)
                    {
                        if (resp.verificar_seEstaSelecionado())
                        {
                            resp.deSelecionarEsteComponente();                            
                        }
                        else
                        {
                            resp.selecionarEsteComponente();
                            resp.focarNoPrimeiroCampo(resp.ler_tipoResposta());
                        }
                    }
                }
            }
        }
    }
}
