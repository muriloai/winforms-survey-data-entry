using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_menu : Form
    {
        public int idDoObjetoVindoSeletor_form = 0;
        public int idDoObjetoVindoSeletor_cli = 0;
        public int idDoObjetoVindoSeletor_perg = 0;
        public int idDoObjetoVindoSeletor_posto = 0;
        camada_dados dados = new camada_dados();
        int liberar_area_restrita = 0;
        public frm_menu()
        {
            InitializeComponent();
        }
        public void resetar_idDoObjetoVindoSeletor()
        {
            idDoObjetoVindoSeletor_form = 0;
            idDoObjetoVindoSeletor_cli = 0;
            idDoObjetoVindoSeletor_perg = 0;
            idDoObjetoVindoSeletor_posto = 0;
        }
        private void btn_cadastrar_respostas_Click(object sender, EventArgs e)
        {
            //seletor de Perguntas, tipo=3!
            resetar_idDoObjetoVindoSeletor();
            frm_seletor seletorForm = new frm_seletor(2, this);
            frm_seletor seletorPerg;
            seletorForm.ShowDialog();
            frm_cadastrar_resposta cad_resposta;
            if (idDoObjetoVindoSeletor_form != 0)
            {
                seletorPerg = new frm_seletor(3, idDoObjetoVindoSeletor_form, this);
                seletorPerg.ShowDialog();
                if (idDoObjetoVindoSeletor_perg != 0)
                {
                    cad_resposta = new frm_cadastrar_resposta(idDoObjetoVindoSeletor_perg);
                    cad_resposta.ShowDialog();
                }
            }
            resetar_idDoObjetoVindoSeletor();
        }

        public void btn_responder_pesquisa_Click(object sender, EventArgs e)
        {
            //seletor de Formularios, tipo=2!
            frm_seletor seletor = new frm_seletor(2, this);
            seletor.ShowDialog();
            //seletor de Postos de coleta, tipo=4!
            seletor = new frm_seletor(4, this);
            seletor.ShowDialog();
            if ((idDoObjetoVindoSeletor_form != 0) && (idDoObjetoVindoSeletor_posto != 0))
            {
                frm_responder_pesquisa cad_responder = new frm_responder_pesquisa(idDoObjetoVindoSeletor_form, idDoObjetoVindoSeletor_posto);
                cad_responder.ShowDialog();
            }
            resetar_idDoObjetoVindoSeletor();
        }

        private void btn_cadastrar_perguntas_Click(object sender, EventArgs e)
        {
            //seletor de Formularios, tipo=2!
            resetar_idDoObjetoVindoSeletor();
            frm_seletor seletor = new frm_seletor(2, this);
            seletor.ShowDialog();
            if (idDoObjetoVindoSeletor_form != 0)
            {
                frm_cadastrar_perguntas cad_perguntas = new frm_cadastrar_perguntas(idDoObjetoVindoSeletor_form);
                cad_perguntas.ShowDialog();
            }
            resetar_idDoObjetoVindoSeletor();
        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            /*
            frm_seletor seletor = new frm_seletor(2,this);
            seletor.ShowDialog();
            */
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            this.txt_localDB.Text = Properties.Settings.Default.serverLocal;
        }

        private void btn_cadastrar_formulario_Click(object sender, EventArgs e)
        {
            //seletor de Clientes, tipo=1!
            resetar_idDoObjetoVindoSeletor();
            frm_seletor seletor = new frm_seletor(1, this);
            idDoObjetoVindoSeletor_cli = 0;
            seletor.ShowDialog();
            if (idDoObjetoVindoSeletor_cli != 0)
            {
                frm_cadastrar_formulario form = new frm_cadastrar_formulario(idDoObjetoVindoSeletor_cli);
                form.ShowDialog();
            }
        }

        private void btn_cad_posto_coleta_Click(object sender, EventArgs e)
        {
            resetar_idDoObjetoVindoSeletor();
            frm_cadastrar_posto_coleta posto = new frm_cadastrar_posto_coleta();
            posto.ShowDialog();
        }

        private void btn_cadastrar_cliente_Click_1(object sender, EventArgs e)
        {
            resetar_idDoObjetoVindoSeletor();
            frm_cadastrar_cliente cliente = new frm_cadastrar_cliente();
            cliente.ShowDialog();
        }

        private void pnl_destravar_area_cadastro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.pnl_destravar_area_cadastro.BackgroundImage = Properties.Resources.lock_02;
            frm_acesso_restrito restrito = new frm_acesso_restrito(this);
            restrito.ShowDialog();
            if (liberar_area_restrita == 0)
            {
                this.pnl_registro.Visible = false;
            }
            else
            {
                this.pnl_registro.Visible = true;
            }
        }
        public void liberar_areaRestrita(int lib)
        {
            this.liberar_area_restrita = lib;
        }

        private void pnl_setaDBLocal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.pnl_db_dados.Visible = true;
            this.pnl_db_dados.Location = new Point(pnl_seta_DBLocal.Location.X, pnl_seta_DBLocal.Location.Y - 20);
        }

        private void btn_aplicarLocalDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null, "Deseja realmente aplicar esta configuração?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.serverLocal = txt_localDB.Text.Trim();
                Properties.Settings.Default.Save();
                this.pnl_db_dados.Visible = false;
                MessageBox.Show("Servidor configurado para: " + Properties.Settings.Default.serverLocal, "Configuração Aplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //esc para sumir com o config de caminho do BD e a cada aparição o texto gravado vem á caixa!
        private void frm_menu_KeyUp(object sender, KeyEventArgs e)
        {
            if ((this.pnl_db_dados.Visible == true) && (e.KeyCode == Keys.Escape))
            {
                this.txt_localDB.Text = Properties.Settings.Default.serverLocal;
                this.pnl_db_dados.Visible = false;

            }
            else if ((this.pnl_registro.Visible == true) && (this.pnl_db_dados.Visible == false) && (e.KeyCode == Keys.Escape))
            {                
                 this.pnl_registro.Visible = false;               
            }
            else if ((this.pnl_db_dados.Visible == true) && (e.KeyCode == Keys.Enter))
            {
                this.btn_aplicarLocalDB_Click(this, null);
            }
        }
        //seleciono o check de é local o texto localhost vai na caixa de texto!
        private void chk_localDB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_localDB.Checked == true)
            {
                this.txt_localDB.Text = "localhost";
            }
            else
            {
                this.txt_localDB.Text = Properties.Settings.Default.serverLocal;
            }
        }
        //movimento da seta que segue o botão!
        private void pnl_destravar_area_cadastro_MouseHover(object sender, EventArgs e)
        {
            this.pnl_destravar_area_cadastro.BackgroundImage = Properties.Resources.lock_01;
        }

        private void pnl_destravar_area_cadastro_MouseLeave(object sender, EventArgs e)
        {
            this.pnl_destravar_area_cadastro.BackgroundImage = Properties.Resources.lock_03;
        }

        private void btn_cadastrar_cliente_MouseHover(object sender, EventArgs e)
        {
            pnl_seta_DBLocal.Location = new Point(pnl_seta_DBLocal.Location.X, 35);
        }

        private void btn_cad_posto_coleta_MouseHover(object sender, EventArgs e)
        {
            pnl_seta_DBLocal.Location = new Point(pnl_seta_DBLocal.Location.X, 128);
        }

        private void btn_cadastrar_formulario_MouseHover(object sender, EventArgs e)
        {
            pnl_seta_DBLocal.Location = new Point(pnl_seta_DBLocal.Location.X, 222);
        }

        private void btn_cadastrar_perguntas_MouseHover(object sender, EventArgs e)
        {
            pnl_seta_DBLocal.Location = new Point(pnl_seta_DBLocal.Location.X, 320);
        }

        private void btn_cadastrar_respostas_MouseHover(object sender, EventArgs e)
        {
            pnl_seta_DBLocal.Location = new Point(pnl_seta_DBLocal.Location.X, 415);
        }

        private void pnl_db_dados_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_db_dados.Visible == true)
            {
                pnl_seta_DBLocal.Visible = false;
            }
            else
            {
                pnl_seta_DBLocal.Visible = true;
            }
        }
        private String reduzir(String txt)
        {
            if (txt.Length > 12)
            {
                return txt.Substring(0, 12) + "";
            }
            else
            {
                return txt+"";
            }
        }
        private String pontos(int qtd)
        {
            int cont = 0;
            String pontos="";
            for(cont=0;cont<qtd;cont++)
            {
                pontos+=(".");
            }
            return pontos;
        }
        private void pnl_logo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (ConexaoBD.abrirConexao())
                {
                    List<objeto_formulario> resultados = new List<objeto_formulario>();
                    resultados = dados.selecionarTodosFormularios_somenteEmAndamento();
                    int cont = 0;
                    String res="";
                    this.lst_result_balanco.Items.Clear();                    
                    for (cont = 0; cont < resultados.Count; cont++)
                    {
                       int qtd = dados.selecionarQtdQuestionariosRespondidos_porIDForm(resultados[cont].id_formulario);
                       res="ID:" + resultados[cont].id_formulario + "-" + reduzir(resultados[cont].titulo.ToString()) + ": "+ pontos(10-qtd.ToString().Length) +" " +qtd ;
                       lst_result_balanco.Items.Add(res);                        
                    }
                    pnl_resultado_balanco.Visible = true;
                }
                else
                {
                   //nada
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao carregar balanço: " + ex.Message);
            }
        }

        private void pnl_fechar_balanco_MouseClick(object sender, MouseEventArgs e)
        {
            this.pnl_resultado_balanco.Visible = false;
        }

        private void pnl_registro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
