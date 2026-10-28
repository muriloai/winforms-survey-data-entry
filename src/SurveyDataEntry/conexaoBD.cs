using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace SurveyDataEntry
{
    public class ConexaoBD
    {
        public static bool Silencioso { get; set; } = false;
        private static string conexaoString;
        private static SQLiteConnection conexao;
        private static string databasePath;

        public ConexaoBD()
        {
            setar();
        }

        public static string getConnectionString()
        {
            setar();
            return conexaoString;
        }

        public static string getDatabasePath()
        {
            if (string.IsNullOrEmpty(databasePath))
            {
                setar();
            }
            return databasePath;
        }

        public static void setDatabasePath(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                databasePath = path;
                Properties.Settings.Default.serverLocal = path;
                try
                {
                    Properties.Settings.Default.Save();
                }
                catch { }

                fecharConexao();
                conexao = null;
                conexaoString = null;
                setar();
            }
        }

        private static void setar()
        {
            try
            {
                string configuredPath = Properties.Settings.Default.serverLocal;

                if (string.IsNullOrEmpty(configuredPath) || configuredPath.Equals("localhost", StringComparison.OrdinalIgnoreCase))
                {
                    configuredPath = "survey.db";
                    Properties.Settings.Default.serverLocal = configuredPath;
                }

                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                try
                {
                    string asmLoc = typeof(ConexaoBD).Assembly.Location;
                    if (!string.IsNullOrEmpty(asmLoc))
                    {
                        string asmDir = Path.GetDirectoryName(asmLoc);
                        if (!string.IsNullOrEmpty(asmDir) && (baseDir.IndexOf("system32", StringComparison.OrdinalIgnoreCase) >= 0 || !Directory.Exists(baseDir)))
                        {
                            baseDir = asmDir;
                        }
                    }
                }
                catch { }

                if (!Path.IsPathRooted(configuredPath))
                {
                    databasePath = Path.Combine(baseDir, configuredPath);
                }
                else
                {
                    databasePath = configuredPath;
                }

                conexaoString = string.Format("Data Source={0};Version=3;Foreign Keys=True;", databasePath);

                if (conexao == null || conexao.ConnectionString != conexaoString)
                {
                    if (conexao != null)
                    {
                        try { conexao.Dispose(); } catch { }
                    }
                    conexao = new SQLiteConnection(conexaoString);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao configurar conexão SQLite: " + ex.Message);
            }
        }

        public static bool abrirConexao()
        {
            try
            {
                setar();

                bool precisaInicializar = !File.Exists(databasePath) || (new FileInfo(databasePath).Length == 0);

                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    return true;
                }

                if (conexao != null)
                {
                    conexao.Open();

                    using (SQLiteCommand cmdFk = new SQLiteCommand("PRAGMA foreign_keys = ON;", conexao))
                    {
                        cmdFk.ExecuteNonQuery();
                    }

                    if (precisaInicializar)
                    {
                        inicializarBancoDeDados(conexao);
                    }

                    return conexao.State == ConnectionState.Open;
                }

                return false;
            }
            catch (Exception erro)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao abrir conexão SQLite: " + erro.Message);
                if (!Silencioso)
                {
                    MessageBox.Show(
                        "Não foi possível abrir o banco de dados SQLite.\n\n" +
                        "Arquivo: " + databasePath + "\n\n" +
                        "Detalhes: " + erro.Message,
                        "Falha na Conexão com SQLite",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                return false;
            }
        }

        public static void fecharConexao()
        {
            try
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao fechar conexão SQLite: " + ex.Message);
            }
        }

        public static SQLiteConnection getConexao()
        {
            if (conexao == null)
            {
                setar();
            }
            if (conexao.State != ConnectionState.Open)
            {
                abrirConexao();
            }
            return conexao;
        }

        private static void inicializarBancoDeDados(SQLiteConnection conn)
        {
            try
            {
                string ddl = @"
CREATE TABLE IF NOT EXISTS tipo_resposta (
  id_tipo_resposta INTEGER PRIMARY KEY AUTOINCREMENT,
  nomenclatura TEXT NOT NULL,
  estado_ativo TEXT NOT NULL DEFAULT 's'
);

CREATE TABLE IF NOT EXISTS cliente_requerente (
  id_cliente_req INTEGER PRIMARY KEY AUTOINCREMENT,
  nome_cliente TEXT NOT NULL,
  data_criacao TEXT NOT NULL,
  estado_ativo TEXT NOT NULL DEFAULT 's'
);

CREATE TABLE IF NOT EXISTS coleta_posto (
  id_posto INTEGER PRIMARY KEY AUTOINCREMENT,
  nome TEXT NOT NULL,
  data_criacao TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS formulario_pesquisa (
  id_formulario INTEGER PRIMARY KEY AUTOINCREMENT,
  id_cliente_req INTEGER NOT NULL,
  titulo_formulario TEXT NOT NULL,
  data_criacao TEXT NOT NULL,
  data_entrega TEXT,
  estado_situacao TEXT NOT NULL DEFAULT 'a',
  estado_ativo TEXT NOT NULL DEFAULT 's',
  FOREIGN KEY (id_cliente_req) REFERENCES cliente_requerente (id_cliente_req) ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE INDEX IF NOT EXISTS idx_form_cliente ON formulario_pesquisa (id_cliente_req);

CREATE TABLE IF NOT EXISTS pergunta_formulario (
  id_pergunta INTEGER PRIMARY KEY AUTOINCREMENT,
  id_formulario INTEGER NOT NULL,
  nomenclatura TEXT NOT NULL,
  posicao_noFormulario INTEGER NOT NULL,
  permite_nulo TEXT NOT NULL DEFAULT 's',
  respostas_maxPermitidas INTEGER NOT NULL DEFAULT 1,
  estado_ativo TEXT NOT NULL DEFAULT 's',
  FOREIGN KEY (id_formulario) REFERENCES formulario_pesquisa (id_formulario) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_pergunta_form ON pergunta_formulario (id_formulario);

CREATE TABLE IF NOT EXISTS resposta_pergunta (
  id_resposta INTEGER PRIMARY KEY AUTOINCREMENT,
  id_tipo_resposta_fk INTEGER NOT NULL,
  id_pergunta INTEGER NOT NULL,
  nomenclatura TEXT NOT NULL,
  posicao_naPergunta INTEGER NOT NULL,
  estado_ativo TEXT NOT NULL DEFAULT 's',
  FOREIGN KEY (id_tipo_resposta_fk) REFERENCES tipo_resposta (id_tipo_resposta) ON UPDATE CASCADE ON DELETE RESTRICT,
  FOREIGN KEY (id_pergunta) REFERENCES pergunta_formulario (id_pergunta) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_resposta_tipo ON resposta_pergunta (id_tipo_resposta_fk);
CREATE INDEX IF NOT EXISTS idx_resposta_pergunta ON resposta_pergunta (id_pergunta);

CREATE TABLE IF NOT EXISTS coleta_dados_questionario (
  id_questionario INTEGER PRIMARY KEY AUTOINCREMENT,
  id_posto_coleta INTEGER NOT NULL,
  id_formulario_fk INTEGER NOT NULL,
  FOREIGN KEY (id_posto_coleta) REFERENCES coleta_posto (id_posto) ON UPDATE CASCADE ON DELETE RESTRICT,
  FOREIGN KEY (id_formulario_fk) REFERENCES formulario_pesquisa (id_formulario) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_coleta_posto ON coleta_dados_questionario (id_posto_coleta);
CREATE INDEX IF NOT EXISTS idx_coleta_form ON coleta_dados_questionario (id_formulario_fk);

CREATE TABLE IF NOT EXISTS coleta_dados_resposta (
  id_coleta_dados_resposta INTEGER PRIMARY KEY AUTOINCREMENT,
  id_questionario_fk INTEGER NOT NULL,
  id_pergunta_fk INTEGER NOT NULL,
  id_resposta_fk INTEGER DEFAULT NULL,
  FOREIGN KEY (id_questionario_fk) REFERENCES coleta_dados_questionario (id_questionario) ON UPDATE CASCADE ON DELETE CASCADE,
  FOREIGN KEY (id_pergunta_fk) REFERENCES pergunta_formulario (id_pergunta) ON UPDATE CASCADE ON DELETE CASCADE,
  FOREIGN KEY (id_resposta_fk) REFERENCES resposta_pergunta (id_resposta) ON UPDATE CASCADE ON DELETE SET NULL
);

CREATE INDEX IF NOT EXISTS idx_coleta_resp_quest ON coleta_dados_resposta (id_questionario_fk);
CREATE INDEX IF NOT EXISTS idx_coleta_resp_perg ON coleta_dados_resposta (id_pergunta_fk);
CREATE INDEX IF NOT EXISTS idx_coleta_resp_resp ON coleta_dados_resposta (id_resposta_fk);

CREATE TABLE IF NOT EXISTS coleta_dados_resposta_texto (
  id_coleta_dados_resposta_texto INTEGER PRIMARY KEY AUTOINCREMENT,
  id_coleta_dados_resposta_fk INTEGER NOT NULL,
  texto TEXT NOT NULL,
  FOREIGN KEY (id_coleta_dados_resposta_fk) REFERENCES coleta_dados_resposta (id_coleta_dados_resposta) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_coleta_texto_resp ON coleta_dados_resposta_texto (id_coleta_dados_resposta_fk);

CREATE TABLE IF NOT EXISTS estado (
  id_estado INTEGER PRIMARY KEY AUTOINCREMENT,
  nome TEXT NOT NULL,
  uf TEXT NOT NULL,
  id_pais_fk INTEGER DEFAULT 1
);

CREATE TABLE IF NOT EXISTS cidade (
  id_cidade INTEGER PRIMARY KEY AUTOINCREMENT,
  nome TEXT NOT NULL,
  id_estado_fk INTEGER DEFAULT NULL,
  FOREIGN KEY (id_estado_fk) REFERENCES estado (id_estado) ON UPDATE CASCADE ON DELETE SET NULL
);

CREATE INDEX IF NOT EXISTS idx_cidade_estado ON cidade (id_estado_fk);

CREATE TRIGGER IF NOT EXISTS trg_apagar_respostas_se_apagar_questionario
AFTER DELETE ON coleta_dados_questionario
FOR EACH ROW
BEGIN
  DELETE FROM coleta_dados_resposta WHERE id_questionario_fk = OLD.id_questionario;
END;

CREATE TRIGGER IF NOT EXISTS trg_apagar_textos_se_apagar_resposta
AFTER DELETE ON coleta_dados_resposta
FOR EACH ROW
BEGIN
  DELETE FROM coleta_dados_resposta_texto WHERE id_coleta_dados_resposta_fk = OLD.id_coleta_dados_resposta;
END;

CREATE VIEW IF NOT EXISTS parteum_somenterespostatipoum_contabilizarresultados AS
SELECT 
    pf.id_formulario AS id_formulario,
    pf.posicao_noFormulario AS posicao_noFormulario,
    (pf.posicao_noFormulario || '. ' || pf.nomenclatura) AS pergunta,
    rp.nomenclatura AS resposta,
    COUNT(cdr.id_coleta_dados_resposta) AS qtd_respondida,
    rp.id_tipo_resposta_fk AS id_tipo_resposta_fk,
    cdrt.texto AS texto
FROM pergunta_formulario pf
INNER JOIN resposta_pergunta rp ON rp.id_pergunta = pf.id_pergunta
LEFT JOIN coleta_dados_resposta cdr ON cdr.id_resposta_fk = rp.id_resposta
LEFT JOIN coleta_dados_resposta_texto cdrt ON cdrt.id_coleta_dados_resposta_fk = cdr.id_coleta_dados_resposta
WHERE pf.estado_ativo = 's' AND rp.id_tipo_resposta_fk = 1
GROUP BY pf.id_formulario, pf.posicao_noFormulario, pf.nomenclatura, rp.id_resposta, rp.nomenclatura, rp.id_tipo_resposta_fk, cdrt.texto;

CREATE VIEW IF NOT EXISTS partedois_somenterespostatipodois_contabilizarresultados AS
SELECT 
    pf.id_formulario AS id_formulario,
    pf.posicao_noFormulario AS posicao_noFormulario,
    (pf.posicao_noFormulario || '. ' || pf.nomenclatura) AS pergunta,
    rp.nomenclatura AS resposta,
    COUNT(cdr.id_coleta_dados_resposta) AS qtd_respondida,
    rp.id_tipo_resposta_fk AS id_tipo_resposta_fk,
    cdrt.texto AS texto
FROM pergunta_formulario pf
INNER JOIN resposta_pergunta rp ON rp.id_pergunta = pf.id_pergunta
LEFT JOIN coleta_dados_resposta cdr ON cdr.id_resposta_fk = rp.id_resposta
LEFT JOIN coleta_dados_resposta_texto cdrt ON cdrt.id_coleta_dados_resposta_fk = cdr.id_coleta_dados_resposta
WHERE pf.estado_ativo = 's' AND rp.id_tipo_resposta_fk = 2
GROUP BY pf.id_formulario, pf.posicao_noFormulario, pf.nomenclatura, rp.nomenclatura, rp.id_tipo_resposta_fk, cdrt.texto;

CREATE VIEW IF NOT EXISTS partetres_somenterespostatipotres_contabilizarresultados AS
SELECT 
    pf.id_formulario AS id_formulario,
    pf.posicao_noFormulario AS posicao_noFormulario,
    (pf.posicao_noFormulario || '. ' || pf.nomenclatura) AS pergunta,
    rp.nomenclatura AS resposta,
    COUNT(cdr.id_coleta_dados_resposta) AS qtd_respondida,
    rp.id_tipo_resposta_fk AS id_tipo_resposta_fk,
    cdrt.texto AS texto
FROM pergunta_formulario pf
INNER JOIN resposta_pergunta rp ON rp.id_pergunta = pf.id_pergunta
LEFT JOIN coleta_dados_resposta cdr ON cdr.id_resposta_fk = rp.id_resposta
LEFT JOIN coleta_dados_resposta_texto cdrt ON cdrt.id_coleta_dados_resposta_fk = cdr.id_coleta_dados_resposta
WHERE pf.estado_ativo = 's' AND rp.id_tipo_resposta_fk = 3
GROUP BY pf.id_formulario, pf.posicao_noFormulario, pf.nomenclatura, rp.id_resposta, rp.nomenclatura, rp.id_tipo_resposta_fk, cdrt.texto;

CREATE VIEW IF NOT EXISTS contabilizar_resultados_unificados AS
SELECT * FROM parteum_somenterespostatipoum_contabilizarresultados
UNION ALL
SELECT * FROM partedois_somenterespostatipodois_contabilizarresultados
UNION ALL
SELECT * FROM partetres_somenterespostatipotres_contabilizarresultados;

INSERT OR IGNORE INTO tipo_resposta (id_tipo_resposta, nomenclatura, estado_ativo) VALUES
(1, 'Único Sem Texto', 's'),
(2, 'Único Com Texto', 's'),
(3, 'Multiescolha Quantitativa', 's');

INSERT OR IGNORE INTO estado (id_estado, nome, uf, id_pais_fk) VALUES
(1, 'Acre', 'AC', 1), (2, 'Alagoas', 'AL', 1), (3, 'Amapá', 'AP', 1), (4, 'Amazonas', 'AM', 1),
(5, 'Bahia', 'BA', 1), (6, 'Ceará', 'CE', 1), (7, 'Distrito Federal', 'DF', 1), (8, 'Espírito Santo', 'ES', 1),
(9, 'Goiás', 'GO', 1), (10, 'Maranhão', 'MA', 1), (11, 'Mato Grosso', 'MT', 1), (12, 'Mato Grosso do Sul', 'MS', 1),
(13, 'Minas Gerais', 'MG', 1), (14, 'Pará', 'PA', 1), (15, 'Paraíba', 'PB', 1), (16, 'Paraná', 'PR', 1),
(17, 'Pernambuco', 'PE', 1), (18, 'Piauí', 'PI', 1), (19, 'Rio de Janeiro', 'RJ', 1), (20, 'Rio Grande do Norte', 'RN', 1),
(21, 'Rio Grande do Sul', 'RS', 1), (22, 'Rondônia', 'RO', 1), (23, 'Roraima', 'RR', 1), (24, 'Santa Catarina', 'SC', 1),
(25, 'São Paulo', 'SP', 1), (26, 'Sergipe', 'SE', 1), (27, 'Tocantins', 'TO', 1);
";
                using (SQLiteCommand cmd = new SQLiteCommand(ddl, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao inicializar banco SQLite: " + ex.Message);
            }
        }
    }
}
