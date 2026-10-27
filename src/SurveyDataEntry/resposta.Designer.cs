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
            this.pnl_resposta = new System.Windows.Forms.Panel();
            this.tbctr_resposta = new System.Windows.Forms.TabControl();
            this.tbpg_texto = new System.Windows.Forms.TabPage();
            this.txt_texto_resposta = new System.Windows.Forms.TextBox();
            this.lbl_pergunta_texto_reposta = new System.Windows.Forms.Label();
            this.tbpg_escala = new System.Windows.Forms.TabPage();
            this.rdbtn_tres = new System.Windows.Forms.RadioButton();
            this.rdbtn_dois = new System.Windows.Forms.RadioButton();
            this.rdbtn_um = new System.Windows.Forms.RadioButton();
            this.lbl_escala_titulo = new System.Windows.Forms.Label();
            this.lbl_resposta = new System.Windows.Forms.Label();
            this.chk_marcador = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_resposta.SuspendLayout();
            this.tbctr_resposta.SuspendLayout();
            this.tbpg_texto.SuspendLayout();
            this.tbpg_escala.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_resposta
            // 
            this.pnl_resposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_resposta.BackColor = System.Drawing.Color.White;
            this.pnl_resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_resposta.Controls.Add(this.tbctr_resposta);
            this.pnl_resposta.Controls.Add(this.lbl_resposta);
            this.pnl_resposta.Controls.Add(this.chk_marcador);
            this.pnl_resposta.Controls.Add(this.label1);
            this.pnl_resposta.Location = new System.Drawing.Point(4, 4);
            this.pnl_resposta.Name = "pnl_resposta";
            this.pnl_resposta.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnl_resposta.Size = new System.Drawing.Size(920, 115);
            this.pnl_resposta.TabIndex = 0;
            this.pnl_resposta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_resposta_Paint);
            // 
            // tbctr_resposta
            // 
            this.tbctr_resposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctr_resposta.Controls.Add(this.tbpg_texto);
            this.tbctr_resposta.Controls.Add(this.tbpg_escala);
            this.tbctr_resposta.Location = new System.Drawing.Point(12, 52);
            this.tbctr_resposta.Name = "tbctr_resposta";
            this.tbctr_resposta.SelectedIndex = 0;
            this.tbctr_resposta.Size = new System.Drawing.Size(894, 52);
            this.tbctr_resposta.TabIndex = 3;
            // 
            // tbpg_texto
            // 
            this.tbpg_texto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tbpg_texto.Controls.Add(this.txt_texto_resposta);
            this.tbpg_texto.Controls.Add(this.lbl_pergunta_texto_reposta);
            this.tbpg_texto.Location = new System.Drawing.Point(4, 22);
            this.tbpg_texto.Name = "tbpg_texto";
            this.tbpg_texto.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbpg_texto.Size = new System.Drawing.Size(886, 26);
            this.tbpg_texto.TabIndex = 0;
            this.tbpg_texto.Text = "Texto";
            // 
            // txt_texto_resposta
            // 
            this.txt_texto_resposta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_texto_resposta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_texto_resposta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_texto_resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_texto_resposta.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto_resposta.Location = new System.Drawing.Point(135, 6);
            this.txt_texto_resposta.Name = "txt_texto_resposta";
            this.txt_texto_resposta.Size = new System.Drawing.Size(740, 26);
            this.txt_texto_resposta.TabIndex = 1;
            // 
            // lbl_pergunta_texto_reposta
            // 
            this.lbl_pergunta_texto_reposta.AutoSize = true;
            this.lbl_pergunta_texto_reposta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergunta_texto_reposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_pergunta_texto_reposta.Location = new System.Drawing.Point(8, 9);
            this.lbl_pergunta_texto_reposta.Name = "lbl_pergunta_texto_reposta";
            this.lbl_pergunta_texto_reposta.Size = new System.Drawing.Size(121, 17);
            this.lbl_pergunta_texto_reposta.TabIndex = 0;
            this.lbl_pergunta_texto_reposta.Text = "Detalhe / Opinião:";
            // 
            // tbpg_escala
            // 
            this.tbpg_escala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tbpg_escala.Controls.Add(this.rdbtn_tres);
            this.tbpg_escala.Controls.Add(this.rdbtn_dois);
            this.tbpg_escala.Controls.Add(this.rdbtn_um);
            this.tbpg_escala.Controls.Add(this.lbl_escala_titulo);
            this.tbpg_escala.Location = new System.Drawing.Point(4, 22);
            this.tbpg_escala.Name = "tbpg_escala";
            this.tbpg_escala.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbpg_escala.Size = new System.Drawing.Size(886, 26);
            this.tbpg_escala.TabIndex = 1;
            this.tbpg_escala.Text = "Escala";
            // 
            // rdbtn_tres
            // 
            this.rdbtn_tres.AutoSize = true;
            this.rdbtn_tres.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_tres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.rdbtn_tres.Location = new System.Drawing.Point(260, 6);
            this.rdbtn_tres.Name = "rdbtn_tres";
            this.rdbtn_tres.Size = new System.Drawing.Size(84, 23);
            this.rdbtn_tres.TabIndex = 3;
            this.rdbtn_tres.Text = "3 - Alto";
            this.rdbtn_tres.UseVisualStyleBackColor = true;
            // 
            // rdbtn_dois
            // 
            this.rdbtn_dois.AutoSize = true;
            this.rdbtn_dois.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_dois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.rdbtn_dois.Location = new System.Drawing.Point(165, 6);
            this.rdbtn_dois.Name = "rdbtn_dois";
            this.rdbtn_dois.Size = new System.Drawing.Size(89, 23);
            this.rdbtn_dois.TabIndex = 2;
            this.rdbtn_dois.Text = "2 - Médio";
            this.rdbtn_dois.UseVisualStyleBackColor = true;
            // 
            // rdbtn_um
            // 
            this.rdbtn_um.AutoSize = true;
            this.rdbtn_um.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_um.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.rdbtn_um.Location = new System.Drawing.Point(80, 6);
            this.rdbtn_um.Name = "rdbtn_um";
            this.rdbtn_um.Size = new System.Drawing.Size(79, 23);
            this.rdbtn_um.TabIndex = 1;
            this.rdbtn_um.Text = "1 - Baixo";
            this.rdbtn_um.UseVisualStyleBackColor = true;
            // 
            // lbl_escala_titulo
            // 
            this.lbl_escala_titulo.AutoSize = true;
            this.lbl_escala_titulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_escala_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_escala_titulo.Location = new System.Drawing.Point(8, 9);
            this.lbl_escala_titulo.Name = "lbl_escala_titulo";
            this.lbl_escala_titulo.Size = new System.Drawing.Size(65, 17);
            this.lbl_escala_titulo.TabIndex = 0;
            this.lbl_escala_titulo.Text = "Nível / Grau:";
            // 
            // lbl_resposta
            // 
            this.lbl_resposta.AutoSize = true;
            this.lbl_resposta.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lbl_resposta.Location = new System.Drawing.Point(68, 16);
            this.lbl_resposta.Name = "lbl_resposta";
            this.lbl_resposta.Size = new System.Drawing.Size(125, 21);
            this.lbl_resposta.TabIndex = 1;
            this.lbl_resposta.Text = "Opção / Resposta";
            // 
            // chk_marcador
            // 
            this.chk_marcador.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_marcador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.chk_marcador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_marcador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.chk_marcador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_marcador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_marcador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.chk_marcador.Location = new System.Drawing.Point(12, 10);
            this.chk_marcador.Name = "chk_marcador";
            this.chk_marcador.Size = new System.Drawing.Size(46, 34);
            this.chk_marcador.TabIndex = 0;
            this.chk_marcador.Text = "1.";
            this.chk_marcador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_marcador.UseVisualStyleBackColor = false;
            this.chk_marcador.CheckedChanged += new System.EventHandler(this.chk_marcador_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 1F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 2);
            this.label1.TabIndex = 4;
            this.label1.Visible = false;
            // 
            // resposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_resposta);
            this.Name = "resposta";
            this.Size = new System.Drawing.Size(928, 125);
            this.Load += new System.EventHandler(this.resposta_Load);
            this.pnl_resposta.ResumeLayout(false);
            this.pnl_resposta.PerformLayout();
            this.tbctr_resposta.ResumeLayout(false);
            this.tbpg_texto.ResumeLayout(false);
            this.tbpg_texto.PerformLayout();
            this.tbpg_escala.ResumeLayout(false);
            this.tbpg_escala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_resposta;
        private System.Windows.Forms.Label lbl_resposta;
        private System.Windows.Forms.CheckBox chk_marcador;
        private System.Windows.Forms.TabControl tbctr_resposta;
        private System.Windows.Forms.TabPage tbpg_texto;
        private System.Windows.Forms.TextBox txt_texto_resposta;
        private System.Windows.Forms.Label lbl_pergunta_texto_reposta;
        private System.Windows.Forms.TabPage tbpg_escala;
        private System.Windows.Forms.RadioButton rdbtn_tres;
        private System.Windows.Forms.RadioButton rdbtn_dois;
        private System.Windows.Forms.RadioButton rdbtn_um;
        private System.Windows.Forms.Label lbl_escala_titulo;
        private System.Windows.Forms.Label label1;
    }
}
