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
            this.pnl_top_header = new System.Windows.Forms.Panel();
            this.pcbx_info = new System.Windows.Forms.PictureBox();
            this.lbl_maxPerm = new System.Windows.Forms.Label();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_respostas = new System.Windows.Forms.Panel();
            this.pnl_bottom_bar = new System.Windows.Forms.Panel();
            this.btn_desmarcarTudo = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_responder = new System.Windows.Forms.Button();
            this.tltp_infos = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_top_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_info)).BeginInit();
            this.pnl_bottom_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top_header
            // 
            this.pnl_top_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_top_header.Controls.Add(this.pcbx_info);
            this.pnl_top_header.Controls.Add(this.lbl_maxPerm);
            this.pnl_top_header.Controls.Add(this.lbl_pergunta);
            this.pnl_top_header.Controls.Add(this.label8);
            this.pnl_top_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_top_header.Name = "pnl_top_header";
            this.pnl_top_header.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnl_top_header.Size = new System.Drawing.Size(1008, 120);
            this.pnl_top_header.TabIndex = 0;
            // 
            // pcbx_info
            // 
            this.pcbx_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbx_info.BackgroundImage = global::SurveyDataEntry.Properties.Resources.ic_info;
            this.pcbx_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbx_info.Location = new System.Drawing.Point(956, 16);
            this.pcbx_info.Name = "pcbx_info";
            this.pcbx_info.Size = new System.Drawing.Size(28, 28);
            this.pcbx_info.TabIndex = 18;
            this.pcbx_info.TabStop = false;
            // 
            // lbl_maxPerm
            // 
            this.lbl_maxPerm.AutoSize = true;
            this.lbl_maxPerm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxPerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lbl_maxPerm.Location = new System.Drawing.Point(24, 88);
            this.lbl_maxPerm.Name = "lbl_maxPerm";
            this.lbl_maxPerm.Size = new System.Drawing.Size(142, 17);
            this.lbl_maxPerm.TabIndex = 17;
            this.lbl_maxPerm.Text = "(Assinale no máximo: x)";
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pergunta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergunta.ForeColor = System.Drawing.Color.White;
            this.lbl_pergunta.Location = new System.Drawing.Point(24, 38);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(915, 45);
            this.lbl_pergunta.TabIndex = 14;
            this.lbl_pergunta.Text = "Carregando pergunta...";
            this.lbl_pergunta.TextChanged += new System.EventHandler(this.lbl_pergunta_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label8.Location = new System.Drawing.Point(24, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "QUESTIONÁRIO EM EXECUÇÃO";
            // 
            // pnl_respostas
            // 
            this.pnl_respostas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_respostas.AutoScroll = true;
            this.pnl_respostas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnl_respostas.Location = new System.Drawing.Point(20, 136);
            this.pnl_respostas.Name = "pnl_respostas";
            this.pnl_respostas.Padding = new System.Windows.Forms.Padding(12);
            this.pnl_respostas.Size = new System.Drawing.Size(968, 456);
            this.pnl_respostas.TabIndex = 1;
            // 
            // pnl_bottom_bar
            // 
            this.pnl_bottom_bar.BackColor = System.Drawing.Color.White;
            this.pnl_bottom_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bottom_bar.Controls.Add(this.btn_desmarcarTudo);
            this.pnl_bottom_bar.Controls.Add(this.btn_voltar);
            this.pnl_bottom_bar.Controls.Add(this.btn_responder);
            this.pnl_bottom_bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom_bar.Location = new System.Drawing.Point(0, 608);
            this.pnl_bottom_bar.Name = "pnl_bottom_bar";
            this.pnl_bottom_bar.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnl_bottom_bar.Size = new System.Drawing.Size(1008, 74);
            this.pnl_bottom_bar.TabIndex = 2;
            // 
            // btn_desmarcarTudo
            // 
            this.btn_desmarcarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btn_desmarcarTudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desmarcarTudo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_desmarcarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desmarcarTudo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcarTudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_desmarcarTudo.Location = new System.Drawing.Point(176, 17);
            this.btn_desmarcarTudo.Name = "btn_desmarcarTudo";
            this.btn_desmarcarTudo.Size = new System.Drawing.Size(220, 40);
            this.btn_desmarcarTudo.TabIndex = 1;
            this.btn_desmarcarTudo.TabStop = false;
            this.btn_desmarcarTudo.Text = "Desmarcar Alternativas";
            this.btn_desmarcarTudo.UseVisualStyleBackColor = false;
            this.btn_desmarcarTudo.Click += new System.EventHandler(this.btn_desmarcarTudo_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btn_voltar.Location = new System.Drawing.Point(20, 17);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(140, 40);
            this.btn_voltar.TabIndex = 0;
            this.btn_voltar.TabStop = false;
            this.btn_voltar.Text = "<< Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_responder
            // 
            this.btn_responder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_responder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_responder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_responder.FlatAppearance.BorderSize = 0;
            this.btn_responder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_responder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_responder.ForeColor = System.Drawing.Color.White;
            this.btn_responder.Location = new System.Drawing.Point(788, 15);
            this.btn_responder.Name = "btn_responder";
            this.btn_responder.Size = new System.Drawing.Size(196, 42);
            this.btn_responder.TabIndex = 2;
            this.btn_responder.TabStop = false;
            this.btn_responder.Text = "Responder >>";
            this.btn_responder.UseVisualStyleBackColor = false;
            this.btn_responder.Click += new System.EventHandler(this.btn_responder_Click);
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
            // frm_responder_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.pnl_respostas);
            this.Controls.Add(this.pnl_bottom_bar);
            this.Controls.Add(this.pnl_top_header);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frm_responder_pesquisa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coleta de Respostas da Pesquisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_responder_persquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_responder_pesquisa_KeyDown);
            this.pnl_top_header.ResumeLayout(false);
            this.pnl_top_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_info)).EndInit();
            this.pnl_bottom_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top_header;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.Label lbl_maxPerm;
        private System.Windows.Forms.PictureBox pcbx_info;
        private System.Windows.Forms.Panel pnl_respostas;
        private System.Windows.Forms.Panel pnl_bottom_bar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_desmarcarTudo;
        private System.Windows.Forms.Button btn_responder;
        private System.Windows.Forms.ToolTip tltp_infos;
    }
}
