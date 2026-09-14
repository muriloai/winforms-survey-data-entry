using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class resposta : UserControl
    {
        int id_resposta;
        int tipoResposta;
        camada_dados dados = new camada_dados();
        public resposta()
        {            
            InitializeComponent();
        }
        //*****************************variaveis internas - incio**********************
        public void alterar_tipoResposta(int tipo)
        {
            //tipos 1=unico sem texto, 2=unico com texto, 3=multi quantitativa
            this.tipoResposta = tipo;
            if (this.tipoResposta == 1)
            {
                escolherOpcao(null);
                foreach (Control i in this.pnl_resposta.Controls)
                {
                    i.TabStop = false;
                }
                this.chk_marcador.TabStop = true;
                this.chk_marcador.TabIndex = 1;
            }
            if (tipoResposta == 2)
            {
                escolherOpcao(tbpg_texto);
                linkarDados();                

            }
            if (tipoResposta == 3)
            {
                escolherOpcao(tbpg_escala);
                selecionar_valorQttvoSelecionado(1);                
            }
            if (!((System.Environment.OSVersion.Version.Minor != 0) && (System.Environment.OSVersion.Version.Major==6)))
            {
                //CASO FOR NAO Win7 ELE MUDA A COR DAS BARRAS!
                this.pnl_resposta.BackColor = Color.LightSteelBlue;
            }
        }
        public int ler_tipoResposta()
        {
            return this.tipoResposta;
        }
        public void alterar_idResposta(int id)
        {
            this.id_resposta = id;
        }
        public int ler_idResposta()
        {
            return this.id_resposta;
        }
        public String ler_textoDigitadoNaResposta()
        {
            return this.txt_texto_resposta.Text;
        }
        public void escrever_textoDigitadoNaResposta(String escrito)
        {
            this.txt_texto_resposta.Text = escrito;
        }
        public int ler_valorQttvoSelecionado()
        {
            if (this.rdbtn_um.Checked == true)
            { return 1; }
            if (this.rdbtn_dois.Checked == true)
            { return 2; } 
            if (this.rdbtn_tres.Checked == true)
            { return 3; }
            return 0;
        }
        public void selecionar_valorQttvoSelecionado(int valor)
        {
            switch(valor)
            {
                case 1:
                this.rdbtn_um.Checked = true;
                break;
                case 2:
                this.rdbtn_dois.Checked = true;
                break;
                case 3:
                this.rdbtn_tres.Checked = true;
                break;
                default:
                    //this.rdbtn_um.Checked = true;
                    break;
            }            
        }
        public Boolean verificar_seEstaSelecionado()
        {
            if(this.chk_marcador.Checked==true)
            {
                return true;
            }
            return false;
        }
        public void linkarDados()
        {
            if (ConexaoBD.abrirConexao())
            {
                //listo historico de digitração antiga no textbox para auxiliar a pessoa na hora de preencher o campo texto!
                List<String> lista = this.dados.selecionarTodasRespostasTextoDistintas_deUmaRespostaID(this.id_resposta);
                AutoCompleteStringCollection colecao = new AutoCompleteStringCollection();
                int cont = 0;
                for (cont = 0; cont < lista.Count; cont++)
                {
                    colecao.Add(lista[cont]);
                }
                //se for estilo cidades carregarei o arquivo completo de cidades do BrasiL!
                if ((colecao.Contains("SÃO PAULO")) && (colecao.Contains("LIMEIRA")))
                {
                    colecao.Clear();
                    lista.Clear();
                    lista = dados.selecionarTodasCidadesDistintas();
                    cont = 0;
                    //cidades de todo BRasil!
                    for (cont = 0; cont < lista.Count; cont++)
                    {
                        colecao.Add(lista[cont]);
                    }
                }
                if ((colecao.Contains("SP")) && (colecao.Contains("SC")))
                {
                    colecao.Clear();
                    lista.Clear();
                    lista = dados.selecionarTodosEstadosDistintos();
                    cont = 0;
                    //estados de todo BRasil!
                    for (cont = 0; cont < lista.Count; cont++)
                    {
                        colecao.Add(lista[cont]);
                    }
                }
                //seto como fonte de dados!
                this.txt_texto_resposta.AutoCompleteCustomSource = colecao;
                this.txt_texto_resposta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            else 
            {
                MessageBox.Show(null,"Impossivel obter dados de autocompletar, verifique a conexão com o banco de dados!","Atenção!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //**********************variaveis internas - fim*********************
        //********************componentes internos - inicio**************************
        public void alterar_resposta(String resposta)
        {
            this.lbl_resposta.Text = resposta;
        }
        public void alterar_pergunta_texto_resposta(String pergunta)
        {
            lbl_pergunta_texto_reposta.Text = pergunta;
        }
        public void alterar_posicao_resposta(int posicao)
        {
            chk_marcador.Text = posicao + ".";
        }
        public void alterarComprimentoPainel(int tam)
        {
            pnl_resposta.Size = new Size(tam, (pnl_resposta.Height));
        }
        public void selecionarEsteComponente()
        {
            this.chk_marcador.Checked = true;
        }
        public void deSelecionarEsteComponente()
        {
            this.chk_marcador.Checked = false;
        }
        public int getTipoResposta()
        {
            return this.tipoResposta;
        }
        //***************componentes internos*********fim***********
        private void escolherOpcao(TabPage tabEscolhida)
        {
            //deixa as tabs invisiveis! 
            this.tbctr_resposta.Appearance = TabAppearance.FlatButtons;
            this.tbctr_resposta.ItemSize = new Size(0, 1);
            this.tbctr_resposta.SizeMode = TabSizeMode.Fixed;

            //exibir e esconde as tabs!
            foreach (TabPage i in tbctr_resposta.TabPages)
            {
                if (i != tabEscolhida)
                {
                    i.Hide();
                    this.tbctr_resposta.TabPages[i.Name].Hide();
                }
                else
                {
                    i.Show();
                    this.tbctr_resposta.SelectedTab = i;
                }
                if (tabEscolhida == null)
                {
                    i.Hide();
                    this.tbctr_resposta.Hide();
                }
            }
        }
        public Boolean verificarSeTextoEstaSendoDigitado()
        {
            if (this.txt_texto_resposta.Focused)
            {
                return true;
            }
            return false;
        }      
        private void chk_marcador_CheckedChanged(object sender, EventArgs e)
        {
            //marca com cor as selecionadas!
            if (this.chk_marcador.Checked == true)
            {
                this.BackColor = Color.DarkOrange;
                this.chk_marcador.BackColor = Color.DarkOrange;
                //caso for qttvo autoseleciona o proximo indece de 1 a 3 que falta, na ordem, para cada seleção que faz!
                if (this.tipoResposta == 3)
                {
                    try
                    {
                        int qtdJaSelecionado = 0;
                        foreach (Control i in this.Parent.Controls)
                        {
                            resposta alvo;

                            alvo = (resposta)i;
                            if ((alvo.verificar_seEstaSelecionado()) && (alvo != this))
                            {
                                qtdJaSelecionado++;
                            }
                        }
                        switch (qtdJaSelecionado)
                        {
                            case 0:
                                this.rdbtn_um.Checked = true;
                                break;
                            case 1:
                                this.rdbtn_dois.Checked = true;
                                break;
                            case 2:
                                this.rdbtn_tres.Checked = true;
                                break;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            else 
            {
                this.BackColor = Color.White;
                this.chk_marcador.BackColor = Color.White;
            }
        }
        public void autoPreencherEstadoPelaCidade(String cidade)
        {//se for multi-escolha quantitativa faço a previsão por ordem de selecao e vou auto checando em sequencia: 1,2,3!
            
        }
        public void focarNoPrimeiroCampo(int deUmaTres)
        {
            //tenta o foco no primeiro campo disponivel depedendo do tipo da resposta!
            switch(deUmaTres)
            {
                case 1:
                    this.chk_marcador.Focus();
                    break;
                case 2:
                    this.txt_texto_resposta.Focus();
                    break;
                case 3:
                    if (rdbtn_um.Checked == true)
                    {
                        rdbtn_um.Focus();
                    }
                    if (rdbtn_dois.Checked == true)
                    {
                        rdbtn_dois.Focus();
                    }
                    if (rdbtn_tres.Checked == true)
                    {
                        rdbtn_tres.Focus();
                    }
                     break;
                   
            }
        }

        private void pnl_resposta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resposta_Load(object sender, EventArgs e)
        {

        }       
        //componentes internos - fim
    }
}
