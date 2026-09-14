namespace SurveyDataEntry
{
    partial class frm_cadastrar_perguntas
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
            this.btn_cad_pergunta = new System.Windows.Forms.Button();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.txt_pergunta = new System.Windows.Forms.TextBox();
            this.txt_posicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_nulo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maxPermitido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cad_pergunta
            // 
            this.btn_cad_pergunta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cad_pergunta.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cad_pergunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad_pergunta.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_cad_pergunta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cad_pergunta.Location = new System.Drawing.Point(11, 109);
            this.btn_cad_pergunta.Name = "btn_cad_pergunta";
            this.btn_cad_pergunta.Size = new System.Drawing.Size(448, 98);
            this.btn_cad_pergunta.TabIndex = 4;
            this.btn_cad_pergunta.Text = "Cadastrar Pergunta";
            this.btn_cad_pergunta.UseVisualStyleBackColor = true;
            this.btn_cad_pergunta.Click += new System.EventHandler(this.btn_cad_pergunta_Click);
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_perg.Location = new System.Drawing.Point(12, 9);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(104, 25);
            this.lbl_perg.TabIndex = 1;
            this.lbl_perg.Text = "Pergunta:";
            // 
            // txt_pergunta
            // 
            this.txt_pergunta.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pergunta.Location = new System.Drawing.Point(17, 37);
            this.txt_pergunta.Name = "txt_pergunta";
            this.txt_pergunta.Size = new System.Drawing.Size(966, 33);
            this.txt_pergunta.TabIndex = 1;
            // 
            // txt_posicao
            // 
            this.txt_posicao.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicao.Location = new System.Drawing.Point(905, 88);
            this.txt_posicao.Name = "txt_posicao";
            this.txt_posicao.Size = new System.Drawing.Size(79, 33);
            this.txt_posicao.TabIndex = 2;
            this.txt_posicao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(718, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordem/Posição N°:";
            // 
            // chk_nulo
            // 
            this.chk_nulo.AutoSize = true;
            this.chk_nulo.Checked = true;
            this.chk_nulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_nulo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chk_nulo.Location = new System.Drawing.Point(17, 76);
            this.chk_nulo.Name = "chk_nulo";
            this.chk_nulo.Size = new System.Drawing.Size(200, 23);
            this.chk_nulo.TabIndex = 2;
            this.chk_nulo.TabStop = false;
            this.chk_nulo.Text = "Permite Responder Nulo";
            this.chk_nulo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(602, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número Máximo de Respostas :";
            // 
            // txt_maxPermitido
            // 
            this.txt_maxPermitido.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxPermitido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txt_maxPermitido.Location = new System.Drawing.Point(905, 136);
            this.txt_maxPermitido.Name = "txt_maxPermitido";
            this.txt_maxPermitido.Size = new System.Drawing.Size(78, 33);
            this.txt_maxPermitido.TabIndex = 3;
            // 
            // frm_cadastrar_perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 218);
            this.Controls.Add(this.txt_maxPermitido);
            this.Controls.Add(this.txt_posicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_nulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pergunta);
            this.Controls.Add(this.lbl_perg);
            this.Controls.Add(this.btn_cad_pergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frm_cadastrar_perguntas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_cadastrar_perguntas_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_perguntas_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cad_pergunta;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.TextBox txt_pergunta;
        private System.Windows.Forms.TextBox txt_posicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_nulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maxPermitido;
    }
}