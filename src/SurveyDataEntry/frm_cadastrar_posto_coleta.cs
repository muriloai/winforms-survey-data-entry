using System;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_cadastrar_posto_coleta : Form
    {
        private camada_dados dados = new camada_dados();

        public frm_cadastrar_posto_coleta()
        {
            InitializeComponent();
        }

        private void btn_cad_posto_Click(object sender, EventArgs e)
        {
            string nome = (this.txt_posto_nome.Text ?? "").Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, informe o nome do posto de coleta.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_posto_nome.Focus();
                return;
            }

            if (MessageBox.Show("Deseja realmente registrar esse posto de coleta?\n'" + nome + "'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ConexaoBD.abrirConexao())
                {
                    if (dados.inserir_umPostoColeta(nome))
                    {
                        MessageBox.Show("Posto de coleta registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja cadastrar mais um posto de coleta?", "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_posto_nome.Text = "";
                            txt_posto_nome.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao gravar o posto de coleta. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
