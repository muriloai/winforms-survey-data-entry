namespace SurveyDataEntry
{
    partial class frm_seletor
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
            this.cbx_resultado = new System.Windows.Forms.ComboBox();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_resultado
            // 
            this.cbx_resultado.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbx_resultado.FormattingEnabled = true;
            this.cbx_resultado.Location = new System.Drawing.Point(24, 85);
            this.cbx_resultado.Name = "cbx_resultado";
            this.cbx_resultado.Size = new System.Drawing.Size(748, 33);
            this.cbx_resultado.TabIndex = 0;
            this.cbx_resultado.SelectedIndexChanged += new System.EventHandler(this.cbx_resultado_SelectedIndexChanged);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_selecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_selecionar.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn_selecionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_selecionar.Location = new System.Drawing.Point(781, 69);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(187, 66);
            this.btn_selecionar.TabIndex = 1;
            this.btn_selecionar.Text = "> Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(16, 25);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(44, 42);
            this.lbl_tipo.TabIndex = 2;
            this.lbl_tipo.Text = "--";
            // 
            // frm_seletor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(976, 147);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.cbx_resultado);
            this.Controls.Add(this.btn_selecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_seletor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECIONE: ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_seletor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_seletor_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_resultado;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Label lbl_tipo;
    }
}