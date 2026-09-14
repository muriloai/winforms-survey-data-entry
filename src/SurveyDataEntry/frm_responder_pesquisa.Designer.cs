namespace SurveyDataEntry
{
    partial class frm_responder_pesquisa
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.pnl_respostas = new System.Windows.Forms.Panel();
            this.btn_desmarcarTudo = new System.Windows.Forms.Button();
            this.lbl_maxPerm = new System.Windows.Forms.Label();
            this.tltp_infos = new System.Windows.Forms.ToolTip(this.components);
            this.pcbx_info = new System.Windows.Forms.PictureBox();
            this.btn_responder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_info)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label8.Location = new System.Drawing.Point(22, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pergunta:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_voltar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_voltar.Location = new System.Drawing.Point(180, 559);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(237, 118);
            this.btn_voltar.TabIndex = 13;
            this.btn_voltar.TabStop = false;
            this.btn_voltar.Text = "<< Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.AutoSize = true;
            this.lbl_pergunta.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_pergunta.Location = new System.Drawing.Point(27, 62);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(36, 25);
            this.lbl_pergunta.TabIndex = 14;
            this.lbl_pergunta.Text = "---";
            this.lbl_pergunta.TextChanged += new System.EventHandler(this.lbl_pergunta_TextChanged);
            // 
            // pnl_respostas
            // 
            this.pnl_respostas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_respostas.AutoScroll = true;
            this.pnl_respostas.AutoSize = true;
            this.pnl_respostas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_respostas.Location = new System.Drawing.Point(12, 190);
            this.pnl_respostas.Name = "pnl_respostas";
            this.pnl_respostas.Size = new System.Drawing.Size(984, 320);
            this.pnl_respostas.TabIndex = 15;
            // 
            // btn_desmarcarTudo
            // 
            this.btn_desmarcarTudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_desmarcarTudo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcarTudo.Location = new System.Drawing.Point(12, 516);
            this.btn_desmarcarTudo.Name = "btn_desmarcarTudo";
            this.btn_desmarcarTudo.Size = new System.Drawing.Size(984, 37);
            this.btn_desmarcarTudo.TabIndex = 16;
            this.btn_desmarcarTudo.TabStop = false;
            this.btn_desmarcarTudo.Text = "Desmarcar Todas as Respostas Acima ^";
            this.btn_desmarcarTudo.UseVisualStyleBackColor = true;
            this.btn_desmarcarTudo.Click += new System.EventHandler(this.btn_desmarcarTudo_Click);
            // 
            // lbl_maxPerm
            // 
            this.lbl_maxPerm.AutoSize = true;
            this.lbl_maxPerm.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_maxPerm.Location = new System.Drawing.Point(10, 167);
            this.lbl_maxPerm.Name = "lbl_maxPerm";
            this.lbl_maxPerm.Size = new System.Drawing.Size(172, 19);
            this.lbl_maxPerm.TabIndex = 17;
            this.lbl_maxPerm.Text = "(Assinale até x opções)";
            // 
            // tltp_infos
            // 
            this.tltp_infos.AutomaticDelay = 10;
            this.tltp_infos.AutoPopDelay = 6000;
            this.tltp_infos.InitialDelay = 10;
            this.tltp_infos.IsBalloon = true;
            this.tltp_infos.ReshowDelay = 0;
            this.tltp_infos.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pcbx_info
            // 
            this.pcbx_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbx_info.BackgroundImage = global::SurveyDataEntry.Properties.Resources.ic_info;
            this.pcbx_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_info.Location = new System.Drawing.Point(957, 6);
            this.pcbx_info.Name = "pcbx_info";
            this.pcbx_info.Size = new System.Drawing.Size(45, 42);
            this.pcbx_info.TabIndex = 18;
            this.pcbx_info.TabStop = false;
            // 
            // btn_responder
            // 
            this.btn_responder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_responder.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_responder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_responder.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_responder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_responder.Location = new System.Drawing.Point(559, 560);
            this.btn_responder.Name = "btn_responder";
            this.btn_responder.Size = new System.Drawing.Size(237, 118);
            this.btn_responder.TabIndex = 0;
            this.btn_responder.TabStop = false;
            this.btn_responder.Text = "Responder >>";
            this.btn_responder.UseVisualStyleBackColor = true;
            this.btn_responder.Click += new System.EventHandler(this.btn_responder_Click);
            // 
            // frm_responder_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.pcbx_info);
            this.Controls.Add(this.lbl_maxPerm);
            this.Controls.Add(this.btn_desmarcarTudo);
            this.Controls.Add(this.pnl_respostas);
            this.Controls.Add(this.lbl_pergunta);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_responder);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frm_responder_pesquisa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responder Pesquisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_responder_persquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_responder_pesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_responder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.Panel pnl_respostas;
        private System.Windows.Forms.Button btn_desmarcarTudo;
        private System.Windows.Forms.Label lbl_maxPerm;
        private System.Windows.Forms.PictureBox pcbx_info;
        private System.Windows.Forms.ToolTip tltp_infos;
    }
}