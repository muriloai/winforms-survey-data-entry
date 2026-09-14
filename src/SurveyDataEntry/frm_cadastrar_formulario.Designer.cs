namespace SurveyDataEntry
{
    partial class frm_cadastrar_formulario
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
            this.txt_formulario = new System.Windows.Forms.TextBox();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.btn_cad_formulario = new System.Windows.Forms.Button();
            this.dtpck_entrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cliente_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_formulario
            // 
            this.txt_formulario.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_formulario.Location = new System.Drawing.Point(12, 47);
            this.txt_formulario.Name = "txt_formulario";
            this.txt_formulario.Size = new System.Drawing.Size(991, 33);
            this.txt_formulario.TabIndex = 7;
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_perg.Location = new System.Drawing.Point(7, 12);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(270, 25);
            this.lbl_perg.TabIndex = 8;
            this.lbl_perg.Text = "Nome/Título do Formulário:";
            // 
            // btn_cad_formulario
            // 
            this.btn_cad_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cad_formulario.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cad_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cad_formulario.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btn_cad_formulario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cad_formulario.Location = new System.Drawing.Point(636, 94);
            this.btn_cad_formulario.Name = "btn_cad_formulario";
            this.btn_cad_formulario.Size = new System.Drawing.Size(367, 98);
            this.btn_cad_formulario.TabIndex = 9;
            this.btn_cad_formulario.Text = "Cadastrar Formulário";
            this.btn_cad_formulario.UseVisualStyleBackColor = true;
            // 
            // dtpck_entrega
            // 
            this.dtpck_entrega.CalendarFont = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpck_entrega.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dtpck_entrega.Location = new System.Drawing.Point(12, 119);
            this.dtpck_entrega.Name = "dtpck_entrega";
            this.dtpck_entrega.Size = new System.Drawing.Size(394, 30);
            this.dtpck_entrega.TabIndex = 10;
            this.dtpck_entrega.Value = new System.DateTime(2014, 10, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data de Entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente:";
            // 
            // lbl_cliente_nome
            // 
            this.lbl_cliente_nome.AutoSize = true;
            this.lbl_cliente_nome.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lbl_cliente_nome.Location = new System.Drawing.Point(96, 163);
            this.lbl_cliente_nome.Name = "lbl_cliente_nome";
            this.lbl_cliente_nome.Size = new System.Drawing.Size(44, 25);
            this.lbl_cliente_nome.TabIndex = 13;
            this.lbl_cliente_nome.Text = "----";
            // 
            // frm_cadastrar_formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1015, 204);
            this.Controls.Add(this.lbl_cliente_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpck_entrega);
            this.Controls.Add(this.btn_cad_formulario);
            this.Controls.Add(this.txt_formulario);
            this.Controls.Add(this.lbl_perg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastrar_formulario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR FORMULÁRIO";
            this.Load += new System.EventHandler(this.frm_cadastrar_posto_coleta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_formulario_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_formulario;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.Button btn_cad_formulario;
        private System.Windows.Forms.DateTimePicker dtpck_entrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cliente_nome;
    }
}