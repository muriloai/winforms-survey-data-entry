using System;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_cadastrar_formulario : Form
    {
        private camada_dados dados = new camada_dados();
        private int id_cliente = 0;

        public frm_cadastrar_formulario(int id_cliente)
        {
            this.id_cliente = id_cliente;
            InitializeComponent();
        }

        private void btn_cad_formulario_Click(object sender, EventArgs e)
        {
            string titulo = (this.txt_formulario.Text ?? "").Trim();
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Por favor, preencha o nome/título do formulário.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_formulario.Focus();
                return;
            }

            if (MessageBox.Show("Deseja realmente registrar esse formulário?\n'" + titulo + "'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ConexaoBD.abrirConexao())
                {
                    string dataEntrega = dtpck_entrega.Value.ToString("yyyy-MM-dd");
                    if (dados.inserir_umFormulario(titulo, id_cliente, dataEntrega))
                    {
                        MessageBox.Show("Formulário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja cadastrar mais um formulário para este cliente?", "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_formulario.Text = "";
                            txt_formulario.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao gravar o formulário no banco de dados. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frm_cadastrar_posto_coleta_Load(object sender, EventArgs e)
        {
            if (this.id_cliente > 0)
            {
                if (ConexaoBD.abrirConexao())
                {
                    objeto_cliente cli = dados.selecionarUmCliente_porIDCliente(id_cliente);
                    this.lbl_cliente_nome.Text = cli != null ? cli.nome : "Cliente ID " + id_cliente;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void frm_cadastrar_formulario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty((this.txt_formulario.Text ?? "").Trim()))
            {
                btn_cad_formulario_Click(this, null);
            }
        }
    }
}