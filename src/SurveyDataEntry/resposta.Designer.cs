namespace SurveyDataEntry
{
    partial class resposta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_resposta = new System.Windows.Forms.Label();
            this.chk_marcador = new System.Windows.Forms.CheckBox();
            this.pnl_resposta = new System.Windows.Forms.Panel();
            this.tbctr_resposta = new System.Windows.Forms.TabControl();
            this.tbpg_texto = new System.Windows.Forms.TabPage();
            this.txt_texto_resposta = new System.Windows.Forms.TextBox();
            this.lbl_pergunta_texto_reposta = new System.Windows.Forms.Label();
            this.tbpg_escala = new System.Windows.Forms.TabPage();
            this.rdbtn_tres = new System.Windows.Forms.RadioButton();
            this.rdbtn_dois = new System.Windows.Forms.RadioButton();
            this.rdbtn_um = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_resposta.SuspendLayout();
            this.tbctr_resposta.SuspendLayout();
            this.tbpg_texto.SuspendLayout();
            this.tbpg_escala.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_resposta
            // 
            this.lbl_resposta.AutoSize = true;
            this.lbl_resposta.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbl_resposta.Location = new System.Drawing.Point(72, 18);
            this.lbl_resposta.Name = "lbl_resposta";
            this.lbl_resposta.Size = new System.Drawing.Size(137, 24);
            this.lbl_resposta.TabIndex = 0;
            this.lbl_resposta.Text = "Sem conteudo";
            // 
            // chk_marcador
            // 
            this.chk_marcador.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_marcador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chk_marcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chk_marcador.Location = new System.Drawing.Point(6, 10);
            this.chk_marcador.Name = "chk_marcador";
            this.chk_marcador.Size = new System.Drawing.Size(62, 38);
            this.chk_marcador.TabIndex = 1;
            this.chk_marcador.Text = "X.";
            this.chk_marcador.UseVisualStyleBackColor = false;
            this.chk_marcador.CheckedChanged += new System.EventHandler(this.chk_marcador_CheckedChanged);
            // 
            // pnl_resposta
            // 
            this.pnl_resposta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnl_resposta.AutoSize = true;
            this.pnl_resposta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_resposta.Controls.Add(this.tbctr_resposta);
            this.pnl_resposta.Controls.Add(this.chk_marcador);
            this.pnl_resposta.Controls.Add(this.label1);
            this.pnl_resposta.Controls.Add(this.lbl_resposta);
            this.pnl_resposta.Location = new System.Drawing.Point(3, 6);
            this.pnl_resposta.Name = "pnl_resposta";
            this.pnl_resposta.Size = new System.Drawing.Size(901, 133);
            this.pnl_resposta.TabIndex = 3;
            this.pnl_resposta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_resposta_Paint);
            // 
            // tbctr_resposta
            // 
            this.tbctr_resposta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctr_resposta.Controls.Add(this.tbpg_texto);
            this.tbctr_resposta.Controls.Add(this.tbpg_escala);
            this.tbctr_resposta.Location = new System.Drawing.Point(6, 51);
            this.tbctr_resposta.Name = "tbctr_resposta";
            this.tbctr_resposta.SelectedIndex = 0;
            this.tbctr_resposta.Size = new System.Drawing.Size(890, 78);
            this.tbctr_resposta.TabIndex = 4;
            // 
            // tbpg_texto
            // 
            this.tbpg_texto.Controls.Add(this.txt_texto_resposta);
            this.tbpg_texto.Controls.Add(this.lbl_pergunta_texto_reposta);
            this.tbpg_texto.Location = new System.Drawing.Point(4, 22);
            this.tbpg_texto.Name = "tbpg_texto";
            this.tbpg_texto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_texto.Size = new System.Drawing.Size(882, 52);
            this.tbpg_texto.TabIndex = 0;
            this.tbpg_texto.Text = "tbpg_texto";
            this.tbpg_texto.UseVisualStyleBackColor = true;
            // 
            // txt_texto_resposta
            // 
            this.txt_texto_resposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_texto_resposta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_texto_resposta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_texto_resposta.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txt_texto_resposta.Location = new System.Drawing.Point(107, 10);
            this.txt_texto_resposta.Name = "txt_texto_resposta";
            this.txt_texto_resposta.Size = new System.Drawing.Size(765, 36);
            this.txt_texto_resposta.TabIndex = 2;
            // 
            // lbl_pergunta_texto_reposta
            // 
            this.lbl_pergunta_texto_reposta.AutoSize = true;
            this.lbl_pergunta_texto_reposta.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lbl_pergunta_texto_reposta.Location = new System.Drawing.Point(6, 15);
            this.lbl_pergunta_texto_reposta.Name = "lbl_pergunta_texto_reposta";
            this.lbl_pergunta_texto_reposta.Size = new System.Drawing.Size(104, 24);
            this.lbl_pergunta_texto_reposta.TabIndex = 4;
            this.lbl_pergunta_texto_reposta.Text = "Responda:";
            // 
            // tbpg_escala
            // 
            this.tbpg_escala.Controls.Add(this.rdbtn_tres);
            this.tbpg_escala.Controls.Add(this.rdbtn_dois);
            this.tbpg_escala.Controls.Add(this.rdbtn_um);
            this.tbpg_escala.Location = new System.Drawing.Point(4, 22);
            this.tbpg_escala.Name = "tbpg_escala";
            this.tbpg_escala.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_escala.Size = new System.Drawing.Size(882, 52);
            this.tbpg_escala.TabIndex = 1;
            this.tbpg_escala.Text = "tbpg_escala";
            this.tbpg_escala.UseVisualStyleBackColor = true;
            // 
            // rdbtn_tres
            // 
            this.rdbtn_tres.AutoSize = true;
            this.rdbtn_tres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbtn_tres.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rdbtn_tres.Location = new System.Drawing.Point(123, 13);
            this.rdbtn_tres.Name = "rdbtn_tres";
            this.rdbtn_tres.Size = new System.Drawing.Size(39, 28);
            this.rdbtn_tres.TabIndex = 5;
            this.rdbtn_tres.Text = "3";
            this.rdbtn_tres.UseVisualStyleBackColor = false;
            // 
            // rdbtn_dois
            // 
            this.rdbtn_dois.AutoSize = true;
            this.rdbtn_dois.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbtn_dois.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rdbtn_dois.Location = new System.Drawing.Point(69, 13);
            this.rdbtn_dois.Name = "rdbtn_dois";
            this.rdbtn_dois.Size = new System.Drawing.Size(39, 28);
            this.rdbtn_dois.TabIndex = 4;
            this.rdbtn_dois.Text = "2";
            this.rdbtn_dois.UseVisualStyleBackColor = false;
            // 
            // rdbtn_um
            // 
            this.rdbtn_um.AutoSize = true;
            this.rdbtn_um.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbtn_um.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rdbtn_um.Location = new System.Drawing.Point(20, 13);
            this.rdbtn_um.Name = "rdbtn_um";
            this.rdbtn_um.Size = new System.Drawing.Size(39, 28);
            this.rdbtn_um.TabIndex = 3;
            this.rdbtn_um.Text = "1";
            this.rdbtn_um.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "_______________________________";
            // 
            // resposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnl_resposta);
            this.Name = "resposta";
            this.Size = new System.Drawing.Size(907, 144);
            this.Load += new System.EventHandler(this.resposta_Load);
            this.pnl_resposta.ResumeLayout(false);
            this.pnl_resposta.PerformLayout();
            this.tbctr_resposta.ResumeLayout(false);
            this.tbpg_texto.ResumeLayout(false);
            this.tbpg_texto.PerformLayout();
            this.tbpg_escala.ResumeLayout(false);
            this.tbpg_escala.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resposta;
        private System.Windows.Forms.CheckBox chk_marcador;
        private System.Windows.Forms.Panel pnl_resposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbctr_resposta;
        private System.Windows.Forms.TabPage tbpg_texto;
        private System.Windows.Forms.TextBox txt_texto_resposta;
        private System.Windows.Forms.TabPage tbpg_escala;
        private System.Windows.Forms.RadioButton rdbtn_tres;
        private System.Windows.Forms.RadioButton rdbtn_dois;
        private System.Windows.Forms.RadioButton rdbtn_um;
        private System.Windows.Forms.Label lbl_pergunta_texto_reposta;
    }
}
