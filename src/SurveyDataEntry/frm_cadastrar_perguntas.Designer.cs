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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.chk_nulo = new System.Windows.Forms.CheckBox();
            this.txt_maxPermitido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_posicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pergunta = new System.Windows.Forms.TextBox();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cad_pergunta = new System.Windows.Forms.Button();
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
            this.pnl_header.Size = new System.Drawing.Size(660, 68);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(20, 39);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(350, 15);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Defina o enunciado, ordem de apresentação e limites de respostas";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(19, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(188, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cadastro de Pergunta";
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.Controls.Add(this.chk_nulo);
            this.pnl_body.Controls.Add(this.txt_maxPermitido);
            this.pnl_body.Controls.Add(this.label2);
            this.pnl_body.Controls.Add(this.txt_posicao);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.txt_pergunta);
            this.pnl_body.Controls.Add(this.lbl_perg);
            this.pnl_body.Controls.Add(this.btn_cancelar);
            this.pnl_body.Controls.Add(this.btn_cad_pergunta);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 68);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
            this.pnl_body.Size = new System.Drawing.Size(660, 272);
            this.pnl_body.TabIndex = 1;
            // 
            // chk_nulo
            // 
            this.chk_nulo.AutoSize = true;
            this.chk_nulo.Checked = true;
            this.chk_nulo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_nulo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_nulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.chk_nulo.Location = new System.Drawing.Point(24, 180);
            this.chk_nulo.Name = "chk_nulo";
            this.chk_nulo.Size = new System.Drawing.Size(239, 21);
            this.chk_nulo.TabIndex = 4;
            this.chk_nulo.Text = "Permite resposta em branco / nulo";
            this.chk_nulo.UseVisualStyleBackColor = true;
            // 
            // txt_maxPermitido
            // 
            this.txt_maxPermitido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maxPermitido.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxPermitido.Location = new System.Drawing.Point(240, 140);
            this.txt_maxPermitido.Name = "txt_maxPermitido";
            this.txt_maxPermitido.Size = new System.Drawing.Size(90, 26);
            this.txt_maxPermitido.TabIndex = 3;
            this.txt_maxPermitido.Text = "1";
            this.txt_maxPermitido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(237, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Máx. de Respostas Permitidas:";
            // 
            // txt_posicao
            // 
            this.txt_posicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_posicao.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_posicao.Location = new System.Drawing.Point(24, 140);
            this.txt_posicao.Name = "txt_posicao";
            this.txt_posicao.Size = new System.Drawing.Size(90, 26);
            this.txt_posicao.TabIndex = 2;
            this.txt_posicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordem / Posição Nº:";
            // 
            // txt_pergunta
            // 
            this.txt_pergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pergunta.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pergunta.Location = new System.Drawing.Point(24, 38);
            this.txt_pergunta.Multiline = true;
            this.txt_pergunta.Name = "txt_pergunta";
            this.txt_pergunta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_pergunta.Size = new System.Drawing.Size(612, 64);
            this.txt_pergunta.TabIndex = 1;
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_perg.Location = new System.Drawing.Point(21, 16);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(155, 17);
            this.lbl_perg.TabIndex = 1;
            this.lbl_perg.Text = "Enunciado da Pergunta:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_cancelar.Location = new System.Drawing.Point(368, 218);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 36);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cad_pergunta
            // 
            this.btn_cad_pergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_cad_pergunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_pergunta.FlatAppearance.BorderSize = 0;
            this.btn_cad_pergunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_pergunta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_pergunta.ForeColor = System.Drawing.Color.White;
            this.btn_cad_pergunta.Location = new System.Drawing.Point(474, 218);
            this.btn_cad_pergunta.Name = "btn_cad_pergunta";
            this.btn_cad_pergunta.Size = new System.Drawing.Size(162, 36);
            this.btn_cad_pergunta.TabIndex = 5;
            this.btn_cad_pergunta.Text = "Salvar Pergunta";
            this.btn_cad_pergunta.UseVisualStyleBackColor = false;
            this.btn_cad_pergunta.Click += new System.EventHandler(this.btn_cad_pergunta_Click);
            // 
            // frm_cadastrar_perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(660, 340);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastrar_perguntas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pergunta";
            this.Load += new System.EventHandler(this.frm_cadastrar_perguntas_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_perguntas_KeyUp);
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
        private System.Windows.Forms.Button btn_cancelar;
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
