using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace SurveyDataEntry
{
    public class ConexaoBD
    {
        private static string conexaoString;
        private static MySqlConnection conexao;

        public ConexaoBD()
        {
            setar();
        }

        public static string getConnectionString()
        {
            setar();
            return conexaoString;
        }

        private static void setar()
        {
            try
            {
                string server = Properties.Settings.Default.serverLocal;
                string db = Properties.Settings.Default.bdNome;
                string user = Properties.Settings.Default.usuario1;
                string pwd = Properties.Settings.Default.senha1;

                if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(db))
                {
                    conexaoString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset=utf8;", server, db, user, pwd);
                }
                else if (ConfigurationManager.ConnectionStrings["SurveyDbConnection"] != null)
                {
                    conexaoString = ConfigurationManager.ConnectionStrings["SurveyDbConnection"].ConnectionString;
                }
                else
                {
                    conexaoString = "Server=localhost;Database=survey_db;Uid=root;Pwd=;Charset=utf8;";
                }

                if (conexao == null || conexao.ConnectionString != conexaoString)
                {
                    conexao = new MySqlConnection(conexaoString);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao configurar string de conexão: " + ex.Message);
            }
        }

        public static bool abrirConexao()
        {
            try
            {
                setar();
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    return true;
                }

                if (conexao != null)
                {
                    conexao.Open();
                    return conexao.State == ConnectionState.Open;
                }

                return false;
            }
            catch (Exception erro)
            {
                System.Diagnostics.Trace.WriteLine("Erro ao abrir conexão com o banco de dados: " + erro.Message);
                MessageBox.Show(
                    "Não foi possível conectar ao banco de dados MySQL.\n\n" +
                    "Detalhes: " + erro.Message + "\n\n" +
                    "Verifique se o serviço MySQL está ativo e se os dados de acesso no menu de configuração estão corretos.",
                    "Falha na Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                System.Diagnostics.Trace.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }

        public static MySqlConnection getConexao()
        {
            if (conexao == null)
            {
                setar();
            }
            return conexao;
        }
    }
}
