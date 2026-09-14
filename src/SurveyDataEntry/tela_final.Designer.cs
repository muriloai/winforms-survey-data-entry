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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_deNovoPesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_voltar.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btn_voltar.Location = new System.Drawing.Point(448, 346);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(272, 78);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "&Voltar Para o Menu Principal";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_deNovoPesquisa
            // 
            this.btn_deNovoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deNovoPesquisa.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deNovoPesquisa.Location = new System.Drawing.Point(419, 221);
            this.btn_deNovoPesquisa.Name = "btn_deNovoPesquisa";
            this.btn_deNovoPesquisa.Size = new System.Drawing.Size(342, 102);
            this.btn_deNovoPesquisa.TabIndex = 2;
            this.btn_deNovoPesquisa.Text = "&Responder Mais Uma Pesquisa";
            this.btn_deNovoPesquisa.UseVisualStyleBackColor = true;
            this.btn_deNovoPesquisa.Click += new System.EventHandler(this.btn_deNovoPesquisa_Click);
            // 
            // tela_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1180, 663);
            this.ControlBox = false;
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_deNovoPesquisa);
            this.KeyPreview = true;
            this.Name = "tela_final";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENCERROU, PARABÉNS!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tela_final_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tela_final_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_deNovoPesquisa;
    }
}