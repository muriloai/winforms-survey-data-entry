using System;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_cadastrar_perguntas : Form
    {
        private int ID_formulario = 0;
        private camada_dados dados = new camada_dados();

        public frm_cadastrar_perguntas(int ID_formulario)
        {
            this.ID_formulario = ID_formulario;
            InitializeComponent();
        }

        private void frm_cadastrar_perguntas_Load(object sender, EventArgs e)
        {
            captar_ultimoValorPosicao_cadastrado();
            txt_maxPermitido.Text = "1";
        }

        private void captar_ultimoValorPosicao_cadastrado()
        {
            if (ConexaoBD.abrirConexao())
            {
                objeto_pergunta pergunta = dados.selecionarPerguntaMaiorPosicao_porIdForm(ID_formulario);
                txt_posicao.Text = (pergunta.posicao + 1).ToString();
            }
        }

        private bool checar_nulo()
        {
            return chk_nulo.Checked;
        }

        private void btn_cad_pergunta_Click(object sender, EventArgs e)
        {
            string textoPergunta = (txt_pergunta.Text ?? "").Trim();
            if (string.IsNullOrEmpty(textoPergunta))
            {
                MessageBox.Show("Por favor, digite o texto da pergunta.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pergunta.Focus();
                return;
            }

            int posicao;
            if (!int.TryParse(txt_posicao.Text, out posicao) || posicao <= 0)
            {
                MessageBox.Show("Por favor, informe uma posição válida (número positivo).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_posicao.Focus();
                return;
            }

            int max;
            if (!int.TryParse(txt_maxPermitido.Text, out max) || max <= 0)
            {
                MessageBox.Show("Por favor, informe um número máximo de respostas permitido válido (mínimo 1).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_maxPermitido.Focus();
                return;
            }

            if (MessageBox.Show("Deseja realmente registrar esta pergunta?\n" + textoPergunta, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ConexaoBD.abrirConexao())
                {
                    if (dados.inserir_umaPerguntaNoFormulario(ID_formulario, true, textoPergunta, posicao, checar_nulo(), max))
                    {
                        MessageBox.Show("Pergunta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja cadastrar mais uma pergunta neste formulário?", "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txt_pergunta.Text = "";
                            captar_ultimoValorPosicao_cadastrado();
                            txt_maxPermitido.Text = "1";
                            txt_pergunta.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar pergunta. Verifique a conexão com o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frm_cadastrar_perguntas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_pergunta.Focused && !string.IsNullOrEmpty((txt_pergunta.Text ?? "").Trim()))
            {
                btn_cad_pergunta_Click(this, null);
            }
        }
    }
}
