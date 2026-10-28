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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cad_posto = new System.Windows.Forms.Button();
            this.txt_posto_nome = new System.Windows.Forms.TextBox();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_header.Controls.Add(this.lbl_subtitulo);
            this.pnl_header.Controls.Add(this.lbl_titulo);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(560, 68);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(20, 39);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(309, 15);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Cadastre locais físicos ou unidades de coleta de respostas";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(19, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(228, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cadastro de Posto de Coleta";
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.Controls.Add(this.btn_cancelar);
            this.pnl_body.Controls.Add(this.btn_cad_posto);
            this.pnl_body.Controls.Add(this.txt_posto_nome);
            this.pnl_body.Controls.Add(this.lbl_perg);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 68);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.pnl_body.Size = new System.Drawing.Size(560, 152);
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
            this.btn_cancelar.Location = new System.Drawing.Point(264, 85);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 36);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cad_posto
            // 
            this.btn_cad_posto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_cad_posto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_posto.FlatAppearance.BorderSize = 0;
            this.btn_cad_posto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_posto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_posto.ForeColor = System.Drawing.Color.White;
            this.btn_cad_posto.Location = new System.Drawing.Point(370, 85);
            this.btn_cad_posto.Name = "btn_cad_posto";
            this.btn_cad_posto.Size = new System.Drawing.Size(166, 36);
            this.btn_cad_posto.TabIndex = 1;
            this.btn_cad_posto.Text = "Salvar Posto de Coleta";
            this.btn_cad_posto.UseVisualStyleBackColor = false;
            this.btn_cad_posto.Click += new System.EventHandler(this.btn_cad_posto_Click);
            // 
            // txt_posto_nome
            // 
            this.txt_posto_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_posto_nome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posto_nome.Location = new System.Drawing.Point(24, 40);
            this.txt_posto_nome.MaxLength = 200;
            this.txt_posto_nome.Name = "txt_posto_nome";
            this.txt_posto_nome.Size = new System.Drawing.Size(512, 27);
            this.txt_posto_nome.TabIndex = 0;
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_perg.Location = new System.Drawing.Point(21, 18);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(164, 17);
            this.lbl_perg.TabIndex = 8;
            this.lbl_perg.Text = "Nome do Posto de Coleta:";
            // 
            // frm_cadastrar_posto_coleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(560, 220);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastrar_posto_coleta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Posto de Coleta";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_posto_coleta_KeyUp);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.TextBox txt_posto_nome;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cad_posto;
    }
}
