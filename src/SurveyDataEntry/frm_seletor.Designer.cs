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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_header_title = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.cbx_resultado = new System.Windows.Forms.ComboBox();
            this.pnl_header.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_header.Controls.Add(this.lbl_tipo);
            this.pnl_header.Controls.Add(this.lbl_header_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(560, 68);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lbl_tipo.Location = new System.Drawing.Point(20, 39);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(193, 15);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Selecione um registro na lista abaixo";
            // 
            // lbl_header_title
            // 
            this.lbl_header_title.AutoSize = true;
            this.lbl_header_title.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header_title.ForeColor = System.Drawing.Color.White;
            this.lbl_header_title.Location = new System.Drawing.Point(19, 13);
            this.lbl_header_title.Name = "lbl_header_title";
            this.lbl_header_title.Size = new System.Drawing.Size(161, 23);
            this.lbl_header_title.TabIndex = 0;
            this.lbl_header_title.Text = "Seleção de Registro";
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.Controls.Add(this.btn_cancelar);
            this.pnl_body.Controls.Add(this.btn_selecionar);
            this.pnl_body.Controls.Add(this.cbx_resultado);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 68);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.pnl_body.Size = new System.Drawing.Size(560, 142);
            this.pnl_body.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_cancelar.Location = new System.Drawing.Point(264, 80);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 36);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selecionar.FlatAppearance.BorderSize = 0;
            this.btn_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selecionar.ForeColor = System.Drawing.Color.White;
            this.btn_selecionar.Location = new System.Drawing.Point(380, 80);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(156, 36);
            this.btn_selecionar.TabIndex = 1;
            this.btn_selecionar.Text = "Confirmar Seleção";
            this.btn_selecionar.UseVisualStyleBackColor = false;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // cbx_resultado
            // 
            this.cbx_resultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_resultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_resultado.FormattingEnabled = true;
            this.cbx_resultado.Location = new System.Drawing.Point(24, 25);
            this.cbx_resultado.Name = "cbx_resultado";
            this.cbx_resultado.Size = new System.Drawing.Size(512, 28);
            this.cbx_resultado.TabIndex = 0;
            this.cbx_resultado.SelectedIndexChanged += new System.EventHandler(this.cbx_resultado_SelectedIndexChanged);
            // 
            // frm_seletor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(560, 210);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_seletor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Item";
            this.Load += new System.EventHandler(this.frm_seletor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_seletor_KeyUp);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_header_title;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.ComboBox cbx_resultado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_selecionar;
    }
}
