namespace SurveyDataEntry
{
    partial class frm_acesso_restrito
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pnl_campos_login = new System.Windows.Forms.Panel();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_campos_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN:";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_entrar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_entrar.Location = new System.Drawing.Point(96, 155);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(185, 64);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // pnl_campos_login
            // 
            this.pnl_campos_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_campos_login.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.pnl_campos_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_campos_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_campos_login.Controls.Add(this.txt_senha);
            this.pnl_campos_login.Controls.Add(this.label2);
            this.pnl_campos_login.Controls.Add(this.txt_login);
            this.pnl_campos_login.Controls.Add(this.label1);
            this.pnl_campos_login.Location = new System.Drawing.Point(-43, 14);
            this.pnl_campos_login.Name = "pnl_campos_login";
            this.pnl_campos_login.Size = new System.Drawing.Size(475, 138);
            this.pnl_campos_login.TabIndex = 2;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(162, 77);
            this.txt_senha.MaxLength = 500;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(232, 40);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "SENHA:";
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(162, 15);
            this.txt_login.MaxLength = 500;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(232, 40);
            this.txt_login.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SurveyDataEntry.Properties.Resources.lock_02;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(-56, -56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 269);
            this.panel2.TabIndex = 3;
            // 
            // frm_acesso_restrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(384, 219);
            this.Controls.Add(this.pnl_campos_login);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_acesso_restrito";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN DE ACESSO!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_acesso_restrito_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_acesso_restrito_KeyUp);
            this.pnl_campos_login.ResumeLayout(false);
            this.pnl_campos_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Panel pnl_campos_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Panel panel2;
    }
}