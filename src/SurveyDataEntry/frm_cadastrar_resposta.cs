using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SurveyDataEntry
{
    public partial class frm_cadastrar_resposta : Form
    {
        private int ID_pergunta = 0;
        private objeto_pergunta pergunta;
        private camada_dados dados = new camada_dados();

        public frm_cadastrar_resposta(int ID_pergunta)
        {
            this.ID_pergunta = ID_pergunta;
            InitializeComponent();
        }

        private void frm_cadastrar_resposta_Load(object sender, EventArgs e)
        {
            this.pergunta = new objeto_pergunta();
            if (ConexaoBD.abrirConexao())
            {
                this.pergunta = dados.selecionarPergunta_porID(ID_pergunta);
                if (!string.IsNullOrEmpty(this.pergunta.nomenclatura))
                {
                    if (this.pergunta.nomenclatura.Length > 100)
                    {
                        lbl_pergPreview.Text = pergunta.nomenclatura.Substring(0, 100) + "...";
                    }
                    else
                    {
                        lbl_pergPreview.Text = pergunta.nomenclatura;
                    }
                }
            }
            rbtn_Un_C_Texto.Checked = true;
            rbtn_Un_S_Texto.Checked = true;
            captar_ultimoValorPosicaoPerguntaCadastrada();
            carregarOpcoesRespostas();
        }

        private void captar_ultimoValorPosicaoPerguntaCadastrada()
        {
            if (ConexaoBD.abrirConexao())
            {
                objeto_resposta resposta = dados.selecionarPosicaoUltimaRespostaAtiva_deUmaPerguntaID(ID_pergunta);
                txt_posicao.Text = (resposta.posicao + 1).ToString();
            }
        }

        private void escolherOpcao(TabPage tabEscolhida)
        {
            tbctr_resposta.Appearance = TabAppearance.FlatButtons;
            tbctr_resposta.ItemSize = new Size(0, 1);
            tbctr_resposta.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage i in tbctr_resposta.TabPages)
            {
                if (i != tabEscolhida)
                {
                    i.Hide();
                    tbctr_resposta.TabPages[i.Name].Hide();
                }
                else
                {
                    i.Show();
                    tbctr_resposta.SelectedTab = i;
                }
            }
        }

        private void rbtn_Un_S_Texto_CheckedChanged(object sender, EventArgs e)
        {
            escolherOpcao(tbpg_Un_S_Texto);
            txt_resp_un_s_texto.Focus();
        }

        private void rbtn_Un_C_Texto_CheckedChanged(object sender, EventArgs e)
        {
            escolherOpcao(tbpg_Un_C_Texto);
            txt_resp_un_c_texto.Focus();
        }

        private void rbtn_Mu_Q_CheckedChanged(object sender, EventArgs e)
        {
            escolherOpcao(tbpg_Mu_Q);
            txt_resp_Mu_q.Focus();
        }

        private void limparCampos()
        {
            txt_resp_un_c_texto.Text = "";
            txt_resp_Mu_q.Text = "";
            txt_resp_un_s_texto.Text = "";
        }

        private int idDependenciaNoBD()
        {
            if (rbtn_Un_S_Texto.Checked)
            {
                return 1;
            }
            if (rbtn_Un_C_Texto.Checked)
            {
                return 2;
            }
            if (rbtn_Mu_Q.Checked)
            {
                return 3;
            }
            return 0;
        }

        private void btn_cadResp_Click(object sender, EventArgs e)
        {
            string texto = "";
            int tipo = idDependenciaNoBD();
            if (tipo == 1)
            {
                texto = (txt_resp_un_s_texto.Text ?? "").Trim();
            }
            else if (tipo == 2)
            {
                texto = (txt_resp_un_c_texto.Text ?? "").Trim();
            }
            else if (tipo == 3)
            {
                texto = (txt_resp_Mu_q.Text ?? "").Trim();
            }

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Por favor, preencha o texto da resposta.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int posicao;
            if (!int.TryParse(txt_posicao.Text, out posicao) || posicao <= 0)
            {
                MessageBox.Show("Por favor, informe uma posição válida (número positivo).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_posicao.Focus();
                return;
            }

            if (MessageBox.Show("Deseja realmente registrar esta resposta?\n" + texto, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ConexaoBD.abrirConexao())
                {
                    if (dados.inserir_umaRespostaNaPergunta(ID_pergunta, true, texto, posicao, tipo))
                    {
                        MessageBox.Show("Resposta cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja cadastrar mais uma resposta?", "Novo Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limparCampos();
                            captar_ultimoValorPosicaoPerguntaCadastrada();
                            carregarOpcoesRespostas();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao gravar a resposta. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frm_cadastrar_resposta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_cadResp_Click(this, null);
            }
        }

        private void carregarOpcoesRespostas()
        {
            pnl_previewResposta.AutoScroll = true;
            pnl_previewResposta.AutoSize = false;
            pnl_previewResposta.VerticalScroll.Enabled = true;
            pnl_previewResposta.HorizontalScroll.Enabled = false;
            pnl_previewResposta.Controls.Clear();

            List<objeto_resposta> listaRespostas = dados.selecionarTodasRespostasAtivas_deUmaPerguntaID(ID_pergunta);

            int cont = 0;
            resposta novo;
            int qtdRespostas = listaRespostas.Count;

            for (cont = 0; cont < qtdRespostas; cont++)
            {
                novo = new resposta();
                novo.alterarComprimentoPainel(pnl_previewResposta.Width - 30);
                novo.alterar_posicao_resposta(listaRespostas[cont].posicao);
                novo.alterar_idResposta(listaRespostas[cont].id_resposta);
                novo.alterar_resposta(listaRespostas[cont].nomenclatura);
                novo.alterar_tipoResposta(listaRespostas[cont].tipo);
                pnl_previewResposta.Controls.Add(novo);
            }

            int qtd = -1;
            foreach (Control i in pnl_previewResposta.Controls)
            {
                qtd++;
                i.SetBounds(i.Location.X, (i.Location.Y + i.Size.Height) * qtd, i.Width, i.Height, BoundsSpecified.All);
            }
        }
    }
}
