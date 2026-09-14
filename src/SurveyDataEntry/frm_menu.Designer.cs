namespace SurveyDataEntry
{
    partial class frm_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_registro = new System.Windows.Forms.Panel();
            this.pnl_db_dados = new System.Windows.Forms.Panel();
            this.btn_aplicarLocalDB = new System.Windows.Forms.Button();
            this.chk_localDB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_localDB = new System.Windows.Forms.TextBox();
            this.pnl_seta_DBLocal = new System.Windows.Forms.Panel();
            this.btn_cadastrar_cliente = new System.Windows.Forms.Button();
            this.btn_cadastrar_formulario = new System.Windows.Forms.Button();
            this.btn_cad_posto_coleta = new System.Windows.Forms.Button();
            this.btn_cadastrar_perguntas = new System.Windows.Forms.Button();
            this.btn_cadastrar_respostas = new System.Windows.Forms.Button();
            this.tltp_setaLocalDB = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_resultado_balanco = new System.Windows.Forms.Panel();
            this.pnl_fechar_balanco = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_result_balanco = new System.Windows.Forms.ListBox();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.btn_responder_pesquisa = new System.Windows.Forms.Button();
            this.pnl_hero = new System.Windows.Forms.Panel();
            this.pnl_destravar_area_cadastro = new System.Windows.Forms.Panel();
            this.pnl_registro.SuspendLayout();
            this.pnl_db_dados.SuspendLayout();
            this.pnl_resultado_balanco.SuspendLayout();
            this.pnl_fechar_balanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(-2, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 123);
            this.panel1.TabIndex = 13;
            // 
            // pnl_registro
            // 
            this.pnl_registro.Controls.Add(this.pnl_db_dados);
            this.pnl_registro.Controls.Add(this.pnl_seta_DBLocal);
            this.pnl_registro.Controls.Add(this.btn_cadastrar_cliente);
            this.pnl_registro.Controls.Add(this.btn_cadastrar_formulario);
            this.pnl_registro.Controls.Add(this.btn_cad_posto_coleta);
            this.pnl_registro.Controls.Add(this.btn_cadastrar_perguntas);
            this.pnl_registro.Controls.Add(this.btn_cadastrar_respostas);
            this.pnl_registro.Location = new System.Drawing.Point(11, 12);
            this.pnl_registro.Name = "pnl_registro";
            this.pnl_registro.Size = new System.Drawing.Size(444, 580);
            this.pnl_registro.TabIndex = 14;
            this.pnl_registro.Visible = false;
            this.pnl_registro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_registro_Paint);
            // 
            // pnl_db_dados
            // 
            this.pnl_db_dados.Controls.Add(this.btn_aplicarLocalDB);
            this.pnl_db_dados.Controls.Add(this.chk_localDB);
            this.pnl_db_dados.Controls.Add(this.label1);
            this.pnl_db_dados.Controls.Add(this.txt_localDB);
            this.pnl_db_dados.Location = new System.Drawing.Point(259, 11);
            this.pnl_db_dados.Name = "pnl_db_dados";
            this.pnl_db_dados.Size = new System.Drawing.Size(170, 128);
            this.pnl_db_dados.TabIndex = 17;
            this.pnl_db_dados.Visible = false;
            this.pnl_db_dados.VisibleChanged += new System.EventHandler(this.pnl_db_dados_VisibleChanged);
            // 
            // btn_aplicarLocalDB
            // 
            this.btn_aplicarLocalDB.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_aplicarLocalDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aplicarLocalDB.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_aplicarLocalDB.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_aplicarLocalDB.Location = new System.Drawing.Point(13, 84);
            this.btn_aplicarLocalDB.Name = "btn_aplicarLocalDB";
            this.btn_aplicarLocalDB.Size = new System.Drawing.Size(145, 31);
            this.btn_aplicarLocalDB.TabIndex = 3;
            this.btn_aplicarLocalDB.Text = "Aplicar!";
            this.btn_aplicarLocalDB.UseVisualStyleBackColor = true;
            this.btn_aplicarLocalDB.Click += new System.EventHandler(this.btn_aplicarLocalDB_Click);
            // 
            // chk_localDB
            // 
            this.chk_localDB.AutoSize = true;
            this.chk_localDB.Location = new System.Drawing.Point(100, 63);
            this.chk_localDB.Name = "chk_localDB";
            this.chk_localDB.Size = new System.Drawing.Size(58, 17);
            this.chk_localDB.TabIndex = 2;
            this.chk_localDB.Text = "É local";
            this.chk_localDB.UseVisualStyleBackColor = true;
            this.chk_localDB.CheckedChanged += new System.EventHandler(this.chk_localDB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local da Database:";
            // 
            // txt_localDB
            // 
            this.txt_localDB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_localDB.Location = new System.Drawing.Point(13, 32);
            this.txt_localDB.Name = "txt_localDB";
            this.txt_localDB.Size = new System.Drawing.Size(145, 26);
            this.txt_localDB.TabIndex = 0;
            // 
            // pnl_seta_DBLocal
            // 
            this.pnl_seta_DBLocal.BackgroundImage = global::SurveyDataEntry.Properties.Resources.seta_01;
            this.pnl_seta_DBLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_seta_DBLocal.Location = new System.Drawing.Point(227, 34);
            this.pnl_seta_DBLocal.Name = "pnl_seta_DBLocal";
            this.pnl_seta_DBLocal.Size = new System.Drawing.Size(25, 36);
            this.pnl_seta_DBLocal.TabIndex = 16;
            this.tltp_setaLocalDB.SetToolTip(this.pnl_seta_DBLocal, "Dois cliques para configurar a localização da base de dados!");
            this.pnl_seta_DBLocal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnl_setaDBLocal_MouseDoubleClick);
            // 
            // btn_cadastrar_cliente
            // 
            this.btn_cadastrar_cliente.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cadastrar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastrar_cliente.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_cliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadastrar_cliente.Location = new System.Drawing.Point(3, 13);
            this.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente";
            this.btn_cadastrar_cliente.Size = new System.Drawing.Size(218, 76);
            this.btn_cadastrar_cliente.TabIndex = 6;
            this.btn_cadastrar_cliente.Text = "Cadastrar Cliente";
            this.btn_cadastrar_cliente.UseVisualStyleBackColor = true;
            this.btn_cadastrar_cliente.Click += new System.EventHandler(this.btn_cadastrar_cliente_Click_1);
            this.btn_cadastrar_cliente.MouseHover += new System.EventHandler(this.btn_cadastrar_cliente_MouseHover);
            // 
            // btn_cadastrar_formulario
            // 
            this.btn_cadastrar_formulario.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cadastrar_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastrar_formulario.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_formulario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadastrar_formulario.Location = new System.Drawing.Point(3, 203);
            this.btn_cadastrar_formulario.Name = "btn_cadastrar_formulario";
            this.btn_cadastrar_formulario.Size = new System.Drawing.Size(218, 76);
            this.btn_cadastrar_formulario.TabIndex = 7;
            this.btn_cadastrar_formulario.Text = "Cadastrar Formulário";
            this.btn_cadastrar_formulario.UseVisualStyleBackColor = true;
            this.btn_cadastrar_formulario.Click += new System.EventHandler(this.btn_cadastrar_formulario_Click);
            this.btn_cadastrar_formulario.MouseHover += new System.EventHandler(this.btn_cadastrar_formulario_MouseHover);
            // 
            // btn_cad_posto_coleta
            // 
            this.btn_cad_posto_coleta.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cad_posto_coleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cad_posto_coleta.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_posto_coleta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cad_posto_coleta.Location = new System.Drawing.Point(3, 111);
            this.btn_cad_posto_coleta.Name = "btn_cad_posto_coleta";
            this.btn_cad_posto_coleta.Size = new System.Drawing.Size(218, 76);
            this.btn_cad_posto_coleta.TabIndex = 10;
            this.btn_cad_posto_coleta.Text = "Cadastrar Posto de Coleta";
            this.btn_cad_posto_coleta.UseVisualStyleBackColor = true;
            this.btn_cad_posto_coleta.Click += new System.EventHandler(this.btn_cad_posto_coleta_Click);
            this.btn_cad_posto_coleta.MouseHover += new System.EventHandler(this.btn_cad_posto_coleta_MouseHover);
            // 
            // btn_cadastrar_perguntas
            // 
            this.btn_cadastrar_perguntas.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cadastrar_perguntas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastrar_perguntas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_perguntas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadastrar_perguntas.Location = new System.Drawing.Point(3, 303);
            this.btn_cadastrar_perguntas.Name = "btn_cadastrar_perguntas";
            this.btn_cadastrar_perguntas.Size = new System.Drawing.Size(218, 76);
            this.btn_cadastrar_perguntas.TabIndex = 8;
            this.btn_cadastrar_perguntas.Text = "Cadastrar Perguntas";
            this.btn_cadastrar_perguntas.UseVisualStyleBackColor = true;
            this.btn_cadastrar_perguntas.Click += new System.EventHandler(this.btn_cadastrar_perguntas_Click);
            this.btn_cadastrar_perguntas.MouseHover += new System.EventHandler(this.btn_cadastrar_perguntas_MouseHover);
            // 
            // btn_cadastrar_respostas
            // 
            this.btn_cadastrar_respostas.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_cadastrar_respostas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastrar_respostas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_respostas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cadastrar_respostas.Location = new System.Drawing.Point(3, 396);
            this.btn_cadastrar_respostas.Name = "btn_cadastrar_respostas";
            this.btn_cadastrar_respostas.Size = new System.Drawing.Size(218, 76);
            this.btn_cadastrar_respostas.TabIndex = 9;
            this.btn_cadastrar_respostas.Text = "Cadastrar Respostas";
            this.btn_cadastrar_respostas.UseVisualStyleBackColor = true;
            this.btn_cadastrar_respostas.Click += new System.EventHandler(this.btn_cadastrar_respostas_Click);
            this.btn_cadastrar_respostas.MouseHover += new System.EventHandler(this.btn_cadastrar_respostas_MouseHover);
            // 
            // tltp_setaLocalDB
            // 
            this.tltp_setaLocalDB.AutomaticDelay = 20;
            this.tltp_setaLocalDB.AutoPopDelay = 5000;
            this.tltp_setaLocalDB.InitialDelay = 20;
            this.tltp_setaLocalDB.IsBalloon = true;
            this.tltp_setaLocalDB.ReshowDelay = 4;
            this.tltp_setaLocalDB.Tag = "database";
            this.tltp_setaLocalDB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tltp_setaLocalDB.ToolTipTitle = "Informação!";
            // 
            // pnl_resultado_balanco
            // 
            this.pnl_resultado_balanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_resultado_balanco.BackColor = System.Drawing.Color.Transparent;
            this.pnl_resultado_balanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_resultado_balanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_resultado_balanco.Controls.Add(this.pnl_fechar_balanco);
            this.pnl_resultado_balanco.Controls.Add(this.lst_result_balanco);
            this.pnl_resultado_balanco.Location = new System.Drawing.Point(879, 223);
            this.pnl_resultado_balanco.Name = "pnl_resultado_balanco";
            this.pnl_resultado_balanco.Size = new System.Drawing.Size(244, 369);
            this.pnl_resultado_balanco.TabIndex = 17;
            this.pnl_resultado_balanco.Visible = false;
            // 
            // pnl_fechar_balanco
            // 
            this.pnl_fechar_balanco.Controls.Add(this.label3);
            this.pnl_fechar_balanco.Controls.Add(this.label2);
            this.pnl_fechar_balanco.Location = new System.Drawing.Point(3, 5);
            this.pnl_fechar_balanco.Name = "pnl_fechar_balanco";
            this.pnl_fechar_balanco.Size = new System.Drawing.Size(236, 29);
            this.pnl_fechar_balanco.TabIndex = 1;
            this.pnl_fechar_balanco.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_fechar_balanco_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantidade Respondida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(214, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_fechar_balanco_MouseClick);
            // 
            // lst_result_balanco
            // 
            this.lst_result_balanco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_result_balanco.FormattingEnabled = true;
            this.lst_result_balanco.ItemHeight = 16;
            this.lst_result_balanco.Location = new System.Drawing.Point(15, 45);
            this.lst_result_balanco.Name = "lst_result_balanco";
            this.lst_result_balanco.Size = new System.Drawing.Size(211, 308);
            this.lst_result_balanco.TabIndex = 0;
            // 
            // pnl_logo
            // 
            this.pnl_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_logo.BackgroundImage = global::SurveyDataEntry.Properties.Resources.logo_survey;
            this.pnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_logo.Location = new System.Drawing.Point(835, 25);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(291, 193);
            this.pnl_logo.TabIndex = 11;
            this.pnl_logo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnl_logo_MouseDoubleClick);
            // 
            // btn_responder_pesquisa
            // 
            this.btn_responder_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_responder_pesquisa.BackgroundImage = global::SurveyDataEntry.Properties.Resources.btn_01;
            this.btn_responder_pesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_responder_pesquisa.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_responder_pesquisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_responder_pesquisa.Location = new System.Drawing.Point(11, 602);
            this.btn_responder_pesquisa.Name = "btn_responder_pesquisa";
            this.btn_responder_pesquisa.Size = new System.Drawing.Size(521, 152);
            this.btn_responder_pesquisa.TabIndex = 4;
            this.btn_responder_pesquisa.Text = "Responder Pesquisa";
            this.btn_responder_pesquisa.UseVisualStyleBackColor = true;
            this.btn_responder_pesquisa.Click += new System.EventHandler(this.btn_responder_pesquisa_Click);
            // 
            // pnl_hero
            // 
            this.pnl_hero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_hero.BackgroundImage = global::SurveyDataEntry.Properties.Resources.survey_hero;
            this.pnl_hero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_hero.Location = new System.Drawing.Point(461, 12);
            this.pnl_hero.Name = "pnl_hero";
            this.pnl_hero.Size = new System.Drawing.Size(546, 580);
            this.pnl_hero.TabIndex = 12;
            // 
            // pnl_destravar_area_cadastro
            // 
            this.pnl_destravar_area_cadastro.BackgroundImage = global::SurveyDataEntry.Properties.Resources.lock_03;
            this.pnl_destravar_area_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_destravar_area_cadastro.Location = new System.Drawing.Point(31, 24);
            this.pnl_destravar_area_cadastro.Name = "pnl_destravar_area_cadastro";
            this.pnl_destravar_area_cadastro.Size = new System.Drawing.Size(40, 50);
            this.pnl_destravar_area_cadastro.TabIndex = 15;
            this.pnl_destravar_area_cadastro.MouseLeave += new System.EventHandler(this.pnl_destravar_area_cadastro_MouseLeave);
            this.pnl_destravar_area_cadastro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnl_destravar_area_cadastro_MouseDoubleClick);
            this.pnl_destravar_area_cadastro.MouseHover += new System.EventHandler(this.pnl_destravar_area_cadastro_MouseHover);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1146, 762);
            this.Controls.Add(this.pnl_resultado_balanco);
            this.Controls.Add(this.btn_responder_pesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.pnl_hero);
            this.Controls.Add(this.pnl_registro);
            this.Controls.Add(this.pnl_destravar_area_cadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survey Data Entry - Tabulador de Pesquisas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_menu_KeyUp);
            this.pnl_registro.ResumeLayout(false);
            this.pnl_db_dados.ResumeLayout(false);
            this.pnl_db_dados.PerformLayout();
            this.pnl_resultado_balanco.ResumeLayout(false);
            this.pnl_fechar_balanco.ResumeLayout(false);
            this.pnl_fechar_balanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_responder_pesquisa;
        private System.Windows.Forms.Button btn_cad_posto_coleta;
        private System.Windows.Forms.Button btn_cadastrar_respostas;
        private System.Windows.Forms.Button btn_cadastrar_perguntas;
        private System.Windows.Forms.Button btn_cadastrar_formulario;
        private System.Windows.Forms.Button btn_cadastrar_cliente;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_hero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_registro;
        private System.Windows.Forms.Panel pnl_destravar_area_cadastro;
        private System.Windows.Forms.Panel pnl_seta_DBLocal;
        private System.Windows.Forms.Panel pnl_db_dados;
        private System.Windows.Forms.CheckBox chk_localDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_localDB;
        private System.Windows.Forms.Button btn_aplicarLocalDB;
        private System.Windows.Forms.ToolTip tltp_setaLocalDB;
        private System.Windows.Forms.Panel pnl_resultado_balanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_result_balanco;
        private System.Windows.Forms.Panel pnl_fechar_balanco;
        private System.Windows.Forms.Label label3;
    }
}

