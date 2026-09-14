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
    public partial class tela_final : Form
    {
        frm_responder_pesquisa frm;
        public tela_final(frm_responder_pesquisa frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void btn_deNovoPesquisa_Click(object sender, EventArgs e)
        {
            seguirOusair();
        }
        private void seguirOusair()
        {
            if (frm.get_qtdIDS_pergunta() > 0) //se tiver pergunta pra ser respondida!
            {
                if (MessageBox.Show(null, "Deseja Responder Mais Uma em Seguida?", "MAIS UMA RODADA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.frm.Close();
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show(null, "Cadatre Perguntas ao Formulário para Prossiguir!","ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    this.frm.Enabled = false;
                    this.frm.Close();
                    this.Close();
                }
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm.Close();
            this.Close();
        }

        private void tela_final_Load(object sender, EventArgs e)
        {
            btn_deNovoPesquisa.Focus();
            if (frm.get_qtdIDS_pergunta() > 0) //se tiver pergunta pra ser respondida!
            {
            }
            else 
            {
                this.btn_deNovoPesquisa.Text = "Voltar e Registrar Algumas Perguntas";
                this.btn_voltar.Visible = false;
            }
        }

        private void tela_final_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
            }
        }
    }
}
