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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_cliente_info = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cliente_nome = new System.Windows.Forms.Label();
            this.lbl_perg = new System.Windows.Forms.Label();
            this.txt_formulario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpck_entrega = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cad_formulario = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.pnl_body.SuspendLayout();
            this.pnl_cliente_info.SuspendLayout();
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
            this.pnl_header.Size = new System.Drawing.Size(580, 68);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lbl_subtitulo.Location = new System.Drawing.Point(20, 39);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(325, 15);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Cadastre um novo questionário vinculado ao cliente escolhido";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(19, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(256, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Novo Formulário de Pesquisa";
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.Controls.Add(this.pnl_cliente_info);
            this.pnl_body.Controls.Add(this.lbl_perg);
            this.pnl_body.Controls.Add(this.txt_formulario);
            this.pnl_body.Controls.Add(this.label1);
            this.pnl_body.Controls.Add(this.dtpck_entrega);
            this.pnl_body.Controls.Add(this.btn_cancelar);
            this.pnl_body.Controls.Add(this.btn_cad_formulario);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 68);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
            this.pnl_body.Size = new System.Drawing.Size(580, 262);
            this.pnl_body.TabIndex = 1;
            // 
            // pnl_cliente_info
            // 
            this.pnl_cliente_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnl_cliente_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cliente_info.Controls.Add(this.label2);
            this.pnl_cliente_info.Controls.Add(this.lbl_cliente_nome);
            this.pnl_cliente_info.Location = new System.Drawing.Point(24, 14);
            this.pnl_cliente_info.Name = "pnl_cliente_info";
            this.pnl_cliente_info.Size = new System.Drawing.Size(532, 38);
            this.pnl_cliente_info.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente Selecionado:";
            // 
            // lbl_cliente_nome
            // 
            this.lbl_cliente_nome.AutoSize = true;
            this.lbl_cliente_nome.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lbl_cliente_nome.Location = new System.Drawing.Point(134, 9);
            this.lbl_cliente_nome.Name = "lbl_cliente_nome";
            this.lbl_cliente_nome.Size = new System.Drawing.Size(28, 17);
            this.lbl_cliente_nome.TabIndex = 13;
            this.lbl_cliente_nome.Text = "----";
            // 
            // lbl_perg
            // 
            this.lbl_perg.AutoSize = true;
            this.lbl_perg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lbl_perg.Location = new System.Drawing.Point(21, 64);
            this.lbl_perg.Name = "lbl_perg";
            this.lbl_perg.Size = new System.Drawing.Size(188, 17);
            this.lbl_perg.TabIndex = 8;
            this.lbl_perg.Text = "Título / Nome do Formulário:";
            // 
            // txt_formulario
            // 
            this.txt_formulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_formulario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_formulario.Location = new System.Drawing.Point(24, 85);
            this.txt_formulario.MaxLength = 250;
            this.txt_formulario.Name = "txt_formulario";
            this.txt_formulario.Size = new System.Drawing.Size(532, 27);
            this.txt_formulario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data Limite de Resposta:";
            // 
            // dtpck_entrega
            // 
            this.dtpck_entrega.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpck_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpck_entrega.Location = new System.Drawing.Point(24, 147);
            this.dtpck_entrega.Name = "dtpck_entrega";
            this.dtpck_entrega.Size = new System.Drawing.Size(200, 26);
            this.dtpck_entrega.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btn_cancelar.Location = new System.Drawing.Point(286, 204);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 36);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cad_formulario
            // 
            this.btn_cad_formulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btn_cad_formulario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_formulario.FlatAppearance.BorderSize = 0;
            this.btn_cad_formulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_formulario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_formulario.ForeColor = System.Drawing.Color.White;
            this.btn_cad_formulario.Location = new System.Drawing.Point(392, 204);
            this.btn_cad_formulario.Name = "btn_cad_formulario";
            this.btn_cad_formulario.Size = new System.Drawing.Size(164, 36);
            this.btn_cad_formulario.TabIndex = 3;
            this.btn_cad_formulario.Text = "Salvar Formulário";
            this.btn_cad_formulario.UseVisualStyleBackColor = false;
            this.btn_cad_formulario.Click += new System.EventHandler(this.btn_cad_formulario_Click);
            // 
            // frm_cadastrar_formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(580, 330);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastrar_formulario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Formulário de Pesquisa";
            this.Load += new System.EventHandler(this.frm_cadastrar_posto_coleta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_cadastrar_formulario_KeyUp);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.pnl_cliente_info.ResumeLayout(false);
            this.pnl_cliente_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.Panel pnl_cliente_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cliente_nome;
        private System.Windows.Forms.TextBox txt_formulario;
        private System.Windows.Forms.Label lbl_perg;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cad_formulario;
        private System.Windows.Forms.DateTimePicker dtpck_entrega;
        private System.Windows.Forms.Label label1;
    }
}
