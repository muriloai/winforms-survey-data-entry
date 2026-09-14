namespace SurveyDataEntry
{
    partial class frm_cadastrar_posto_coleta
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
            this.txt_posto_nome = new System.Windows.Forms.TextBox();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.btn_cad_posto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_posto_nome
            // 
            this.txt_posto_nome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posto_nome.Location = new System.Drawing.Point(12, 42);
            this.txt_posto_nome.Name = "txt_posto_nome";
            this.txt_posto_nome.Size = new System.Drawing.Size(984, 33);
            this.txt_posto_nome.TabIndex = 7;
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_perg.Location = new System.Drawing.Point(7, 12);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(255, 25);
            this.lbl_perg.TabIndex = 8;
            this.lbl_perg.Text = "Nome do Posto de Coleta:";
            // 
            // btn_cad_posto
            // 
            this.btn_cad_posto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cad_posto.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cad_posto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad_posto.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_cad_posto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cad_posto.Location = new System.Drawing.Point(575, 86);
            this.btn_cad_posto.Name = "btn_cad_posto";
            this.btn_cad_posto.Size = new System.Drawing.Size(421, 98);
            this.btn_cad_posto.TabIndex = 9;
            this.btn_cad_posto.Text = "Cadastrar Posto";
            this.btn_cad_posto.UseVisualStyleBackColor = true;
            this.btn_cad_posto.Click += new System.EventHandler(this.btn_cad_posto_Click);
            // 
            // frm_cadastrar_posto_coleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 196);
            this.Controls.Add(this.btn_cad_posto);
            this.Controls.Add(this.txt_posto_nome);
            this.Controls.Add(this.lbl_perg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastrar_posto_coleta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR POSTO DE COLETA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_posto_nome;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.Button btn_cad_posto;
    }
}