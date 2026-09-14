using System;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_cadastrar_cliente : Form
    {
        private camada_dados dados = new camada_dados();

        public frm_cadastrar_cliente()
        {
            InitializeComponent();
        }

        private void btn_cad_cliente_Click(object sender, EventArgs e)
        {
            string nome = (this.txt_cliente_nome.Text ?? "").Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, preencha o nome do cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_cliente_nome.Focus();
                return;
            }

            if (MessageBox.Show("Deseja realmente registrar esse cliente?\n'" + nome + "'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ConexaoBD.abrirConexao())
                {
                    if (dados.inserir_umCliente(nome))
                    {
                        MessageBox.Show("Cliente registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja cadastrar mais um cliente?", "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_cliente_nome.Text = "";
                            txt_cliente_nome.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao gravar o cliente no banco de dados. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frm_cadastrar_posto_coleta_Load(object sender, EventArgs e)
        {
        }

        private void frm_cadastrar_cliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty((this.txt_cliente_nome.Text ?? "").Trim()))
            {
                btn_cad_cliente_Click(this, null);
            }
        }
    }
}