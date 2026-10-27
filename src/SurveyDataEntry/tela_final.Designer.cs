namespace SurveyDataEntry
{
    partial class tela_final
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
            this.pnl_card = new System.Windows.Forms.Panel();
            this.lbl_sucesso_icon = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.btn_deNovoPesquisa = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pnl_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_card
            // 
            this.pnl_card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_card.BackColor = System.Drawing.Color.White;
            this.pnl_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_card.Controls.Add(this.lbl_sucesso_icon);
            this.pnl_card.Controls.Add(this.lbl_titulo);
            this.pnl_card.Controls.Add(this.lbl_mensagem);
            this.pnl_card.Controls.Add(this.btn_deNovoPesquisa);
            this.pnl_card.Controls.Add(this.btn_voltar);
            this.pnl_card.Location = new System.Drawing.Point(260, 110);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Padding = new System.Windows.Forms.Padding(36);
            this.pnl_card.Size = new System.Drawing.Size(660, 420);
            this.pnl_card.TabIndex = 0;
            // 
            // lbl_sucesso_icon
            // 
            this.lbl_sucesso_icon.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucesso_icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lbl_sucesso_icon.Location = new System.Drawing.Point(36, 25);
            this.lbl_sucesso_icon.Name = "lbl_sucesso_icon";
            this.lbl_sucesso_icon.Size = new System.Drawing.Size(588, 65);
            this.lbl_sucesso_icon.TabIndex = 4;
            this.lbl_sucesso_icon.Text = "[OK]";
            this.lbl_sucesso_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lbl_titulo.Location = new System.Drawing.Point(36, 100);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(588, 38);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Questionário Concluído com Sucesso!";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl_mensagem.Location = new System.Drawing.Point(36, 148);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(588, 45);
            this.lbl_mensagem.TabIndex = 1;
            this.lbl_mensagem.Text = "Todas as respostas coletadas foram registradas com sucesso na base de dados.";
            this.lbl_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_deNovoPesquisa
            // 
            this.btn_deNovoPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_deNovoPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deNovoPesquisa.FlatAppearance.BorderSize = 0;
            this.btn_deNovoPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deNovoPesquisa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deNovoPesquisa.ForeColor = System.Drawing.Color.White;
            this.btn_deNovoPesquisa.Location = new System.Drawing.Point(140, 225);
            this.btn_deNovoPesquisa.Name = "btn_deNovoPesquisa";
            this.btn_deNovoPesquisa.Size = new System.Drawing.Size(380, 48);
            this.btn_deNovoPesquisa.TabIndex = 2;
            this.btn_deNovoPesquisa.Text = "&Responder Mais Uma Pesquisa";
            this.btn_deNovoPesquisa.UseVisualStyleBackColor = false;
            this.btn_deNovoPesquisa.Click += new System.EventHandler(this.btn_deNovoPesquisa_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_voltar.Location = new System.Drawing.Point(140, 290);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(380, 42);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "&Voltar Para o Menu Principal";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // tela_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1180, 663);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_card);
            this.KeyPreview = true;
            this.Name = "tela_final";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionário Concluído";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tela_final_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tela_final_KeyUp);
            this.pnl_card.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_card;
        private System.Windows.Forms.Label lbl_sucesso_icon;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_deNovoPesquisa;
    }
}
