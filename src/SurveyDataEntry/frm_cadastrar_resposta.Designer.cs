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
            this.pnl_top_opcoes = new System.Windows.Forms.Panel();
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
            this.btn_cadResp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_posicao = new System.Windows.Forms.TextBox();
            this.pnl_previewResposta = new System.Windows.Forms.Panel();
            this.lbl_pergPreview = new System.Windows.Forms.Label();
            this.pnl_top_opcoes.SuspendLayout();
            this.tbctr_resposta.SuspendLayout();
            this.tbpg_Un_S_Texto.SuspendLayout();
            this.tbpg_Un_C_Texto.SuspendLayout();
            this.tbpg_Mu_Q.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top_opcoes
            // 
            this.pnl_top_opcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_top_opcoes.Controls.Add(this.rbtn_Mu_Q);
            this.pnl_top_opcoes.Controls.Add(this.rbtn_Un_C_Texto);
            this.pnl_top_opcoes.Controls.Add(this.rbtn_Un_S_Texto);
            this.pnl_top_opcoes.Location = new System.Drawing.Point(12, 12);
            this.pnl_top_opcoes.Name = "pnl_top_opcoes";
            this.pnl_top_opcoes.Size = new System.Drawing.Size(1198, 83);
            this.pnl_top_opcoes.TabIndex = 0;
            // 
            // rbtn_Mu_Q
            // 
            this.rbtn_Mu_Q.AutoSize = true;
            this.rbtn_Mu_Q.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rbtn_Mu_Q.Location = new System.Drawing.Point(815, 24);
            this.rbtn_Mu_Q.Name = "rbtn_Mu_Q";
            this.rbtn_Mu_Q.Size = new System.Drawing.Size(325, 31);
            this.rbtn_Mu_Q.TabIndex = 5;
            this.rbtn_Mu_Q.Text = "Multipla Escolha - Quantitativa";
            this.rbtn_Mu_Q.UseVisualStyleBackColor = true;
            this.rbtn_Mu_Q.CheckedChanged += new System.EventHandler(this.rbtn_Mu_Q_CheckedChanged);
            // 
            // rbtn_Un_C_Texto
            // 
            this.rbtn_Un_C_Texto.AutoSize = true;
            this.rbtn_Un_C_Texto.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rbtn_Un_C_Texto.Location = new System.Drawing.Point(405, 24);
            this.rbtn_Un_C_Texto.Name = "rbtn_Un_C_Texto";
            this.rbtn_Un_C_Texto.Size = new System.Drawing.Size(287, 31);
            this.rbtn_Un_C_Texto.TabIndex = 3;
            this.rbtn_Un_C_Texto.Text = "Escolha Única - COM texto";
            this.rbtn_Un_C_Texto.UseVisualStyleBackColor = true;
            this.rbtn_Un_C_Texto.CheckedChanged += new System.EventHandler(this.rbtn_Un_C_Texto_CheckedChanged);
            // 
            // rbtn_Un_S_Texto
            // 
            this.rbtn_Un_S_Texto.AutoSize = true;
            this.rbtn_Un_S_Texto.Checked = true;
            this.rbtn_Un_S_Texto.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rbtn_Un_S_Texto.Location = new System.Drawing.Point(45, 24);
            this.rbtn_Un_S_Texto.Name = "rbtn_Un_S_Texto";
            this.rbtn_Un_S_Texto.Size = new System.Drawing.Size(282, 31);
            this.rbtn_Un_S_Texto.TabIndex = 0;
            this.rbtn_Un_S_Texto.TabStop = true;
            this.rbtn_Un_S_Texto.Text = "Escolha Única - SEM texto";
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
            this.tbctr_resposta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctr_resposta.Location = new System.Drawing.Point(12, 138);
            this.tbctr_resposta.Name = "tbctr_resposta";
            this.tbctr_resposta.SelectedIndex = 0;
            this.tbctr_resposta.Size = new System.Drawing.Size(1198, 236);
            this.tbctr_resposta.TabIndex = 1;
            this.tbctr_resposta.TabStop = false;
            // 
            // tbpg_Un_S_Texto
            // 
            this.tbpg_Un_S_Texto.BackColor = System.Drawing.Color.Gainsboro;
            this.tbpg_Un_S_Texto.Controls.Add(this.txt_resp_un_s_texto);
            this.tbpg_Un_S_Texto.Controls.Add(this.lbl_perg);
            this.tbpg_Un_S_Texto.Location = new System.Drawing.Point(4, 32);
            this.tbpg_Un_S_Texto.Name = "tbpg_Un_S_Texto";
            this.tbpg_Un_S_Texto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_Un_S_Texto.Size = new System.Drawing.Size(1190, 200);
            this.tbpg_Un_S_Texto.TabIndex = 0;
            this.tbpg_Un_S_Texto.Text = "tbpg_Un_S_Texto";
            // 
            // txt_resp_un_s_texto
            // 
            this.txt_resp_un_s_texto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_un_s_texto.Location = new System.Drawing.Point(42, 50);
            this.txt_resp_un_s_texto.Name = "txt_resp_un_s_texto";
            this.txt_resp_un_s_texto.Size = new System.Drawing.Size(1104, 33);
            this.txt_resp_un_s_texto.TabIndex = 1;
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_perg.Location = new System.Drawing.Point(6, 16);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(102, 25);
            this.lbl_perg.TabIndex = 6;
            this.lbl_perg.Text = "Resposta:";
            // 
            // tbpg_Un_C_Texto
            // 
            this.tbpg_Un_C_Texto.BackColor = System.Drawing.Color.Gainsboro;
            this.tbpg_Un_C_Texto.Controls.Add(this.txt_resp_un_c_texto);
            this.tbpg_Un_C_Texto.Controls.Add(this.label3);
            this.tbpg_Un_C_Texto.Location = new System.Drawing.Point(4, 32);
            this.tbpg_Un_C_Texto.Name = "tbpg_Un_C_Texto";
            this.tbpg_Un_C_Texto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_Un_C_Texto.Size = new System.Drawing.Size(1190, 200);
            this.tbpg_Un_C_Texto.TabIndex = 2;
            this.tbpg_Un_C_Texto.Text = "tbpg_Un_C_Texto";
            // 
            // txt_resp_un_c_texto
            // 
            this.txt_resp_un_c_texto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_un_c_texto.Location = new System.Drawing.Point(42, 50);
            this.txt_resp_un_c_texto.Name = "txt_resp_un_c_texto";
            this.txt_resp_un_c_texto.Size = new System.Drawing.Size(1104, 33);
            this.txt_resp_un_c_texto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resposta:";
            // 
            // tbpg_Mu_Q
            // 
            this.tbpg_Mu_Q.BackColor = System.Drawing.Color.Gainsboro;
            this.tbpg_Mu_Q.Controls.Add(this.txt_resp_Mu_q);
            this.tbpg_Mu_Q.Controls.Add(this.label5);
            this.tbpg_Mu_Q.Location = new System.Drawing.Point(4, 32);
            this.tbpg_Mu_Q.Name = "tbpg_Mu_Q";
            this.tbpg_Mu_Q.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_Mu_Q.Size = new System.Drawing.Size(1190, 200);
            this.tbpg_Mu_Q.TabIndex = 4;
            this.tbpg_Mu_Q.Text = "tbpg_Mu_Q";
            // 
            // txt_resp_Mu_q
            // 
            this.txt_resp_Mu_q.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_Mu_q.Location = new System.Drawing.Point(42, 50);
            this.txt_resp_Mu_q.Name = "txt_resp_Mu_q";
            this.txt_resp_Mu_q.Size = new System.Drawing.Size(1104, 33);
            this.txt_resp_Mu_q.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resposta:";
            // 
            // btn_cadResp
            // 
            this.btn_cadResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadResp.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cadResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cadResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadResp.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadResp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadResp.Location = new System.Drawing.Point(829, 379);
            this.btn_cadResp.Name = "btn_cadResp";
            this.btn_cadResp.Size = new System.Drawing.Size(381, 92);
            this.btn_cadResp.TabIndex = 2;
            this.btn_cadResp.Text = "Cadastrar Opção de Resposta";
            this.btn_cadResp.UseVisualStyleBackColor = true;
            this.btn_cadResp.Click += new System.EventHandler(this.btn_cadResp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(949, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ordem/Posição N°:";
            // 
            // txt_posicao
            // 
            this.txt_posicao.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicao.Location = new System.Drawing.Point(1136, 107);
            this.txt_posicao.Name = "txt_posicao";
            this.txt_posicao.Size = new System.Drawing.Size(74, 33);
            this.txt_posicao.TabIndex = 10;
            // 
            // pnl_previewResposta
            // 
            this.pnl_previewResposta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_previewResposta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_previewResposta.Location = new System.Drawing.Point(9, 478);
            this.pnl_previewResposta.Name = "pnl_previewResposta";
            this.pnl_previewResposta.Size = new System.Drawing.Size(1205, 207);
            this.pnl_previewResposta.TabIndex = 11;
            // 
            // lbl_pergPreview
            // 
            this.lbl_pergPreview.AutoSize = true;
            this.lbl_pergPreview.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_pergPreview.Location = new System.Drawing.Point(9, 450);
            this.lbl_pergPreview.Name = "lbl_pergPreview";
            this.lbl_pergPreview.Size = new System.Drawing.Size(115, 25);
            this.lbl_pergPreview.TabIndex = 12;
            this.lbl_pergPreview.Text = "Pergunta...";
            // 
            // frm_cadastrar_resposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1222, 688);
            this.Controls.Add(this.lbl_pergPreview);
            this.Controls.Add(this.pnl_previewResposta);
            this.Controls.Add(this.btn_cadResp);
            this.Controls.Add(this.txt_posicao);
            this.Controls.Add(this.tbctr_resposta);
            this.Controls.Add(this.pnl_top_opcoes);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frm_cadastrar_resposta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR UMA RESPOSTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cadastrar_resposta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_resposta_KeyUp);
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

        private System.Windows.Forms.Panel pnl_top_opcoes;
        private System.Windows.Forms.RadioButton rbtn_Un_S_Texto;
        private System.Windows.Forms.RadioButton rbtn_Un_C_Texto;
        private System.Windows.Forms.RadioButton rbtn_Mu_Q;
        private System.Windows.Forms.TabControl tbctr_resposta;
        private System.Windows.Forms.TabPage tbpg_Un_S_Texto;
        private System.Windows.Forms.TabPage tbpg_Un_C_Texto;
        private System.Windows.Forms.TabPage tbpg_Mu_Q;
        private System.Windows.Forms.Button btn_cadResp;
        private System.Windows.Forms.TextBox txt_resp_un_s_texto;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.TextBox txt_resp_un_c_texto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_posicao;
        private System.Windows.Forms.TextBox txt_resp_Mu_q;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_previewResposta;
        private System.Windows.Forms.Label lbl_pergPreview;
    }
}