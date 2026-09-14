namespace SurveyDataEntry
{
    partial class frm_cadastrar_cliente
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
            this.txt_cliente_nome = new System.Windows.Forms.TextBox();
            this.lbl_cli = new System.Windows.Forms.Label();
            this.btn_cad_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cliente_nome
            // 
            this.txt_cliente_nome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente_nome.Location = new System.Drawing.Point(12, 47);
            this.txt_cliente_nome.Name = "txt_cliente_nome";
            this.txt_cliente_nome.Size = new System.Drawing.Size(991, 33);
            this.txt_cliente_nome.TabIndex = 7;
            // 
            // lbl_cli
            // 
            this.lbl_cli.AutoSize = true;
            this.lbl_cli.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_cli.Location = new System.Drawing.Point(7, 12);
            this.lbl_cli.Name = "lbl_cli";
            this.lbl_cli.Size = new System.Drawing.Size(174, 25);
            this.lbl_cli.TabIndex = 8;
            this.lbl_cli.Text = "Nome do Cliente:";
            // 
            // btn_cad_cliente
            // 
            this.btn_cad_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cad_cliente.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cad_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad_cliente.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_cad_cliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cad_cliente.Location = new System.Drawing.Point(636, 94);
            this.btn_cad_cliente.Name = "btn_cad_cliente";
            this.btn_cad_cliente.Size = new System.Drawing.Size(367, 98);
            this.btn_cad_cliente.TabIndex = 9;
            this.btn_cad_cliente.Text = "Cadastrar Cliente";
            this.btn_cad_cliente.UseVisualStyleBackColor = true;
            this.btn_cad_cliente.Click += new System.EventHandler(this.btn_cad_cliente_Click);
            // 
            // frm_cadastrar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1015, 204);
            this.Controls.Add(this.btn_cad_cliente);
            this.Controls.Add(this.txt_cliente_nome);
            this.Controls.Add(this.lbl_cli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastrar_cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR CLIENTE";
            this.Load += new System.EventHandler(this.frm_cadastrar_posto_coleta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_cliente_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cliente_nome;
        private System.Windows.Forms.Label lbl_cli;
        private System.Windows.Forms.Button btn_cad_cliente;
    }
}