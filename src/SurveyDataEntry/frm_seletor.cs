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
    public partial class frm_seletor : Form
    {
        /*codigos de tipo para completar no combobox!
         *1=cliente
         * 2=formulario
         * 3=pergunta
         */
        //camada de dados
        camada_dados dados = new camada_dados();
        int tipo = 0, id_formulario = 0;
        Object frm;
        
        public frm_seletor(int tipo, Object frm)
        {
            this.tipo = tipo;
            this.frm = frm;
            InitializeComponent();
        }
        public frm_seletor(int tipo, int id_formulario, Object frm)
        {
            this.tipo = tipo;
            this.frm = frm;
            this.id_formulario = id_formulario;
            InitializeComponent();
        }

        private void frm_seletor_Load(object sender, EventArgs e)
        {
            if (ConexaoBD.abrirConexao())
            {
               preencherCBX(this.tipo);
            }
           if(this.tipo==1)
           {
               this.Text = this.Text + " "+"Cliente";
               this.lbl_tipo.Text = "Selecione o Cliente:";
           }
           if (this.tipo == 2)
           {
               this.Text = this.Text + " " + "Formulário";
               this.lbl_tipo.Text = "Selecione o Formulário:";
           }
           if (this.tipo == 3)
           {
               this.Text = this.Text + " " + "Pergunta";
               this.lbl_tipo.Text = "Selecione a Pergunta:";
           }
           if (this.tipo == 4)
           {
               this.Text = this.Text + " " + "Posto";
               this.lbl_tipo.Text = "Selecione o Posto de Coleta:";
           }
        }
        private void preencherCBX(int tipo)
        {
            
            //limpo o combobox!
            cbx_resultado.DataSource=null;
            cbx_resultado.Items.Clear();
            //crio o padrao!
            DataTable dt = new DataTable();
            dt.Columns.Add("ValueMember");
            dt.Columns.Add("DisplayMember");
            int cont=0;
            //dependendo do tipo adiciono no cbx valores referentes!
            switch (tipo)
            { 
                case 1:
                    List<objeto_cliente> clientes = new List<objeto_cliente>();
                    clientes = dados.selecionarTodosClientes();
                    for (cont = 0; cont < clientes.Count; cont++)
                    {
                        dt.Rows.Add(clientes[cont].id_cliente,clientes[cont].nome);
                    }
                        break;
                case 2:
                    List<objeto_formulario> forms = new List<objeto_formulario>();
                    forms = dados.selecionarTodosFormularios_somenteEmAndamento();
                    for (cont = 0; cont < forms.Count; cont++)
                    {
                        dt.Rows.Add(forms[cont].id_formulario, "ID: "+forms[cont].id_formulario + " - "+forms[cont].titulo + " - " + dados.selecionarUmCliente_porIDCliente(forms[cont].id_cliente).nome);
                    }
                    break;
                case 3:
                    if (this.id_formulario != 0)
                    {
                        List<objeto_pergunta> perguntas = new List<objeto_pergunta>();
                        perguntas = dados.selecionarTodasPerguntasCadastradasEAtivas_porIDForm(id_formulario);
                        for (cont = 0; cont < perguntas.Count; cont++)
                        {
                            dt.Rows.Add(perguntas[cont].id_pergunta, "Nº:" + perguntas[cont].posicao + ": " + corteAcimaDe50Char(perguntas[cont].nomenclatura));
                        }
                    }
                    break;
                case 4:
                        List<objeto_posto_coleta> postos = new List<objeto_posto_coleta>();
                        postos = dados.selecionarTodosPostos_Coleta();
                        for (cont = 0; cont < postos.Count; cont++)
                        {
                            dt.Rows.Add(postos[cont].id_posto, "COD:" + postos[cont].id_posto + ": " + corteAcimaDe50Char(postos[cont].nome));
                        }
                    break;
            }
            cbx_resultado.DataSource = dt;
            cbx_resultado.DisplayMember = "DisplayMember";
            cbx_resultado.ValueMember = "ValueMember";
           
        }
        private String corteAcimaDe50Char(String s)
        {
            if (s.Length > 50)
            {
                return s.Substring(0, 50) + "...";
            }
            else
            {
                return s + "...";
            }
        }
        private void cbx_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {            
           /* int id;
            try
            {
                id = Convert.ToInt32(cbx_resultado.SelectedValue);
                MessageBox.Show((cbx_resultado.SelectedValue + "").ToString());
            }catch
            {}*/
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(null, "Deseja Realmente Selecionar: \n"+(cbx_resultado.Text)+"\n?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                switch (tipo)
                {
                    case 1:
                        //se o receptor for o menu faça assim:
                        if (frm.GetType() == typeof(frm_menu))
                        {
                            frm_menu frmx = new frm_menu();
                            frmx = (frm_menu)frm;
                            frmx.idDoObjetoVindoSeletor_cli = Convert.ToInt32(cbx_resultado.SelectedValue);
                            this.Close();
                        }//***
                        break;
                    case 2:
                        //se o receptor for o menu faça assim:
                        if(frm.GetType() == typeof(frm_menu))
                        {
                           frm_menu frmx = new frm_menu();
                           frmx = (frm_menu)frm;
                           frmx.idDoObjetoVindoSeletor_form = Convert.ToInt32(cbx_resultado.SelectedValue);
                           this.Close();
                        }//***
                        break;
                    case 3:
                        //se o receptor for o menu faça assim:
                        if (frm.GetType() == typeof(frm_menu))
                        {
                            frm_menu frmx = new frm_menu();
                            frmx = (frm_menu)frm;
                            frmx.idDoObjetoVindoSeletor_perg = Convert.ToInt32(cbx_resultado.SelectedValue);
                            this.Close();
                        }//***
                        break;
                    case 4:
                        //se o receptor for o menu faça assim:
                        if (frm.GetType() == typeof(frm_menu))
                        {
                            frm_menu frmx = new frm_menu();
                            frmx = (frm_menu)frm;
                            frmx.idDoObjetoVindoSeletor_posto = Convert.ToInt32(cbx_resultado.SelectedValue);
                            this.Close();
                        }//***
                        break;
                }

            }
        }

        private void frm_seletor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
