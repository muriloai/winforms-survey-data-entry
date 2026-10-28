namespace SurveyDataEntry
{
    partial class frm_cadastrar_resposta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_top_opcoes = new System.Windows.Forms.Panel();
            this.lbl_tipo_opcao = new System.Windows.Forms.Label();
            this.rbtn_Mu_Q = new System.Windows.Forms.RadioButton();
            this.rbtn_Un_C_Texto = new System.Windows.Forms.RadioButton();
            this.rbtn_Un_S_Texto = new System.Windows.Forms.RadioButton();
            this.tbctr_resposta = new System.Windows.Forms.TabControl();
            this.tbpg_Un_S_Texto = new System.Windows.Forms.TabPage();
            this.txt_resp_un_s_texto = new System.Windows.Forms.TextBox();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.tbpg_Un_C_Texto = new System.Windows.Forms.TabPage();
            this.txt_resp_un_c_texto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpg_Mu_Q = new System.Windows.Forms.TabPage();
            this.txt_resp_Mu_q = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_posicao = new System.Windows.Forms.TextBox();
            this.btn_cadResp = new System.Windows.Forms.Button();
            this.lbl_pergPreview = new System.Windows.Forms.Label();
            this.pnl_previewResposta = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.pnl_top_opcoes.SuspendLayout();
            this.tbctr_resposta.SuspendLayout();
            this.tbpg_Un_S_Texto.SuspendLayout();
            this.tbpg_Un_C_Texto.SuspendLayout();
            this.tbpg_Mu_Q.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_header.Controls.Add(this.lbl_subtitulo);
            this.pnl_header.Controls.Add(this.lbl_titulo);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1008, 68);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(20, 39);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(395, 15);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Configure alternativas e opções de preenchimento para a pergunta selecionada";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(19, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(268, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cadastro de Opções de Resposta";
            // 
            // pnl_top_opcoes
            // 
            this.pnl_top_opcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_top_opcoes.BackColor = System.Drawing.Color.White;
            this.pnl_top_opcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_top_opcoes.Controls.Add(this.lbl_tipo_opcao);
            this.pnl_top_opcoes.Controls.Add(this.rbtn_Mu_Q);
            this.pnl_top_opcoes.Controls.Add(this.rbtn_Un_C_Texto);
            this.pnl_top_opcoes.Controls.Add(this.rbtn_Un_S_Texto);
            this.pnl_top_opcoes.Location = new System.Drawing.Point(20, 80);
            this.pnl_top_opcoes.Name = "pnl_top_opcoes";
            this.pnl_top_opcoes.Size = new System.Drawing.Size(968, 64);
            this.pnl_top_opcoes.TabIndex = 1;
            // 
            // lbl_tipo_opcao
            // 
            this.lbl_tipo_opcao.AutoSize = true;
            this.lbl_tipo_opcao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_opcao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lbl_tipo_opcao.Location = new System.Drawing.Point(12, 6);
            this.lbl_tipo_opcao.Name = "lbl_tipo_opcao";
            this.lbl_tipo_opcao.Size = new System.Drawing.Size(164, 15);
            this.lbl_tipo_opcao.TabIndex = 3;
            this.lbl_tipo_opcao.Text = "Modalidade de Preenchimento:";
            // 
            // rbtn_Mu_Q
            // 
            this.rbtn_Mu_Q.AutoSize = true;
            this.rbtn_Mu_Q.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Mu_Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.rbtn_Mu_Q.Location = new System.Drawing.Point(540, 26);
            this.rbtn_Mu_Q.Name = "rbtn_Mu_Q";
            this.rbtn_Mu_Q.Size = new System.Drawing.Size(248, 23);
            this.rbtn_Mu_Q.TabIndex = 2;
            this.rbtn_Mu_Q.Text = "Múltipla Escolha (Escala 1 a 3)";
            this.rbtn_Mu_Q.UseVisualStyleBackColor = true;
            this.rbtn_Mu_Q.CheckedChanged += new System.EventHandler(this.rbtn_Mu_Q_CheckedChanged);
            // 
            // rbtn_Un_C_Texto
            // 
            this.rbtn_Un_C_Texto.AutoSize = true;
            this.rbtn_Un_C_Texto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Un_C_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.rbtn_Un_C_Texto.Location = new System.Drawing.Point(260, 26);
            this.rbtn_Un_C_Texto.Name = "rbtn_Un_C_Texto";
            this.rbtn_Un_C_Texto.Size = new System.Drawing.Size(252, 23);
            this.rbtn_Un_C_Texto.TabIndex = 1;
            this.rbtn_Un_C_Texto.Text = "Escolha Única (Com campo de texto)";
            this.rbtn_Un_C_Texto.UseVisualStyleBackColor = true;
            this.rbtn_Un_C_Texto.CheckedChanged += new System.EventHandler(this.rbtn_Un_C_Texto_CheckedChanged);
            // 
            // rbtn_Un_S_Texto
            // 
            this.rbtn_Un_S_Texto.AutoSize = true;
            this.rbtn_Un_S_Texto.Checked = true;
            this.rbtn_Un_S_Texto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Un_S_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.rbtn_Un_S_Texto.Location = new System.Drawing.Point(15, 26);
            this.rbtn_Un_S_Texto.Name = "rbtn_Un_S_Texto";
            this.rbtn_Un_S_Texto.Size = new System.Drawing.Size(217, 23);
            this.rbtn_Un_S_Texto.TabIndex = 0;
            this.rbtn_Un_S_Texto.TabStop = true;
            this.rbtn_Un_S_Texto.Text = "Escolha Única Padrão (Simples)";
            this.rbtn_Un_S_Texto.UseVisualStyleBackColor = true;
            this.rbtn_Un_S_Texto.CheckedChanged += new System.EventHandler(this.rbtn_Un_S_Texto_CheckedChanged);
            // 
            // tbctr_resposta
            // 
            this.tbctr_resposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctr_resposta.Controls.Add(this.tbpg_Un_S_Texto);
            this.tbctr_resposta.Controls.Add(this.tbpg_Un_C_Texto);
            this.tbctr_resposta.Controls.Add(this.tbpg_Mu_Q);
            this.tbctr_resposta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctr_resposta.Location = new System.Drawing.Point(20, 152);
            this.tbctr_resposta.Name = "tbctr_resposta";
            this.tbctr_resposta.SelectedIndex = 0;
            this.tbctr_resposta.Size = new System.Drawing.Size(968, 86);
            this.tbctr_resposta.TabIndex = 2;
            // 
            // tbpg_Un_S_Texto
            // 
            this.tbpg_Un_S_Texto.BackColor = System.Drawing.Color.White;
            this.tbpg_Un_S_Texto.Controls.Add(this.txt_resp_un_s_texto);
            this.tbpg_Un_S_Texto.Controls.Add(this.lbl_perg);
            this.tbpg_Un_S_Texto.Location = new System.Drawing.Point(4, 26);
            this.tbpg_Un_S_Texto.Name = "tbpg_Un_S_Texto";
            this.tbpg_Un_S_Texto.Padding = new System.Windows.Forms.Padding(12);
            this.tbpg_Un_S_Texto.Size = new System.Drawing.Size(960, 56);
            this.tbpg_Un_S_Texto.TabIndex = 0;
            this.tbpg_Un_S_Texto.Text = "Padrão";
            // 
            // txt_resp_un_s_texto
            // 
            this.txt_resp_un_s_texto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resp_un_s_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resp_un_s_texto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_un_s_texto.Location = new System.Drawing.Point(150, 14);
            this.txt_resp_un_s_texto.MaxLength = 200;
            this.txt_resp_un_s_texto.Name = "txt_resp_un_s_texto";
            this.txt_resp_un_s_texto.Size = new System.Drawing.Size(790, 27);
            this.txt_resp_un_s_texto.TabIndex = 1;
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_perg.Location = new System.Drawing.Point(12, 17);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(127, 17);
            this.lbl_perg.TabIndex = 0;
            this.lbl_perg.Text = "Texto da Resposta:";
            // 
            // tbpg_Un_C_Texto
            // 
            this.tbpg_Un_C_Texto.BackColor = System.Drawing.Color.White;
            this.tbpg_Un_C_Texto.Controls.Add(this.txt_resp_un_c_texto);
            this.tbpg_Un_C_Texto.Controls.Add(this.label3);
            this.tbpg_Un_C_Texto.Location = new System.Drawing.Point(4, 26);
            this.tbpg_Un_C_Texto.Name = "tbpg_Un_C_Texto";
            this.tbpg_Un_C_Texto.Padding = new System.Windows.Forms.Padding(12);
            this.tbpg_Un_C_Texto.Size = new System.Drawing.Size(960, 56);
            this.tbpg_Un_C_Texto.TabIndex = 1;
            this.tbpg_Un_C_Texto.Text = "Com Texto";
            // 
            // txt_resp_un_c_texto
            // 
            this.txt_resp_un_c_texto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resp_un_c_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resp_un_c_texto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_un_c_texto.Location = new System.Drawing.Point(150, 14);
            this.txt_resp_un_c_texto.MaxLength = 200;
            this.txt_resp_un_c_texto.Name = "txt_resp_un_c_texto";
            this.txt_resp_un_c_texto.Size = new System.Drawing.Size(790, 27);
            this.txt_resp_un_c_texto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Texto da Resposta:";
            // 
            // tbpg_Mu_Q
            // 
            this.tbpg_Mu_Q.BackColor = System.Drawing.Color.White;
            this.tbpg_Mu_Q.Controls.Add(this.txt_resp_Mu_q);
            this.tbpg_Mu_Q.Controls.Add(this.label5);
            this.tbpg_Mu_Q.Location = new System.Drawing.Point(4, 26);
            this.tbpg_Mu_Q.Name = "tbpg_Mu_Q";
            this.tbpg_Mu_Q.Padding = new System.Windows.Forms.Padding(12);
            this.tbpg_Mu_Q.Size = new System.Drawing.Size(960, 56);
            this.tbpg_Mu_Q.TabIndex = 2;
            this.tbpg_Mu_Q.Text = "Escala";
            // 
            // txt_resp_Mu_q
            // 
            this.txt_resp_Mu_q.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resp_Mu_q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resp_Mu_q.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_Mu_q.Location = new System.Drawing.Point(150, 14);
            this.txt_resp_Mu_q.MaxLength = 200;
            this.txt_resp_Mu_q.Name = "txt_resp_Mu_q";
            this.txt_resp_Mu_q.Size = new System.Drawing.Size(790, 27);
            this.txt_resp_Mu_q.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Texto da Resposta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(24, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordem / Posição Nº:";
            // 
            // txt_posicao
            // 
            this.txt_posicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_posicao.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicao.Location = new System.Drawing.Point(160, 248);
            this.txt_posicao.Name = "txt_posicao";
            this.txt_posicao.Size = new System.Drawing.Size(70, 26);
            this.txt_posicao.TabIndex = 4;
            this.txt_posicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cadResp
            // 
            this.btn_cadResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_cadResp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadResp.FlatAppearance.BorderSize = 0;
            this.btn_cadResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadResp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadResp.ForeColor = System.Drawing.Color.White;
            this.btn_cadResp.Location = new System.Drawing.Point(768, 244);
            this.btn_cadResp.Name = "btn_cadResp";
            this.btn_cadResp.Size = new System.Drawing.Size(220, 36);
            this.btn_cadResp.TabIndex = 5;
            this.btn_cadResp.Text = "+ Salvar Opção de Resposta";
            this.btn_cadResp.UseVisualStyleBackColor = false;
            this.btn_cadResp.Click += new System.EventHandler(this.btn_cadResp_Click);
            // 
            // lbl_pergPreview
            // 
            this.lbl_pergPreview.AutoSize = true;
            this.lbl_pergPreview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lbl_pergPreview.Location = new System.Drawing.Point(24, 296);
            this.lbl_pergPreview.Name = "lbl_pergPreview";
            this.lbl_pergPreview.Size = new System.Drawing.Size(183, 19);
            this.lbl_pergPreview.TabIndex = 6;
            this.lbl_pergPreview.Text = "Pré-visualização da Pergunta";
            // 
            // pnl_previewResposta
            // 
            this.pnl_previewResposta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_previewResposta.AutoScroll = true;
            this.pnl_previewResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnl_previewResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_previewResposta.Location = new System.Drawing.Point(20, 322);
            this.pnl_previewResposta.Name = "pnl_previewResposta";
            this.pnl_previewResposta.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_previewResposta.Size = new System.Drawing.Size(968, 330);
            this.pnl_previewResposta.TabIndex = 7;
            // 
            // frm_cadastrar_resposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.Controls.Add(this.pnl_previewResposta);
            this.Controls.Add(this.lbl_pergPreview);
            this.Controls.Add(this.btn_cadResp);
            this.Controls.Add(this.txt_posicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbctr_resposta);
            this.Controls.Add(this.pnl_top_opcoes);
            this.Controls.Add(this.pnl_header);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "frm_cadastrar_resposta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Respostas";
            this.Load += new System.EventHandler(this.frm_cadastrar_resposta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_resposta_KeyUp);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_top_opcoes.ResumeLayout(false);
            this.pnl_top_opcoes.PerformLayout();
            this.tbctr_resposta.ResumeLayout(false);
            this.tbpg_Un_S_Texto.ResumeLayout(false);
            this.tbpg_Un_S_Texto.PerformLayout();
            this.tbpg_Un_C_Texto.ResumeLayout(false);
            this.tbpg_Un_C_Texto.PerformLayout();
            this.tbpg_Mu_Q.ResumeLayout(false);
            this.tbpg_Mu_Q.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_top_opcoes;
        private System.Windows.Forms.Label lbl_tipo_opcao;
        private System.Windows.Forms.RadioButton rbtn_Un_S_Texto;
        private System.Windows.Forms.RadioButton rbtn_Un_C_Texto;
        private System.Windows.Forms.RadioButton rbtn_Mu_Q;
        private System.Windows.Forms.TabControl tbctr_resposta;
        private System.Windows.Forms.TabPage tbpg_Un_S_Texto;
        private System.Windows.Forms.TabPage tbpg_Un_C_Texto;
        private System.Windows.Forms.TabPage tbpg_Mu_Q;
        private System.Windows.Forms.TextBox txt_resp_un_s_texto;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.TextBox txt_resp_un_c_texto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_resp_Mu_q;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_posicao;
        private System.Windows.Forms.Button btn_cadResp;
        private System.Windows.Forms.Label lbl_pergPreview;
        private System.Windows.Forms.Panel pnl_previewResposta;
    }
}
