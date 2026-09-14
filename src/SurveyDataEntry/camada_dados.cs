using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using MySql.Data.MySqlClient;

namespace SurveyDataEntry
{
    public class camada_dados
    {
        // Campos Formulario
        public const string FORMULARIO_TABELA = "formulario_pesquisa";
        public const string
            FORMULARIO_ID = "id_formulario",
            FORMULARIO_ID_CLIENTE = "id_cliente_req",
            FORMULARIO_TITULO = "titulo_formulario",
            FORMULARIO_DT_CRIACAO = "data_criacao",
            FORMULARIO_DT_ENTREGA = "data_entrega",
            FORMULARIO_SITUACAO = "estado_situacao",
            FORMULARIO_ATIVO = "estado_ativo";

        // Campos Pergunta
        public const string PERGUNTA_TABELA = "pergunta_formulario";
        public const string
            PERGUNTA_ID = "id_pergunta",
            PERGUNTA_ID_FORMULARIO = "id_formulario",
            PERGUNTA_ATIVO = "estado_ativo",
            PERGUNTA_NOMECLATURA = "nomenclatura",
            PERGUNTA_POSICAO = "posicao_noFormulario",
            PERGUNTA_NULO = "permite_nulo",
            PERGUNTA_RESP_MAX = "respostas_maxPermitidas";

        // Campos Questionario
        public const string COLETA_QUESTIONARIO_TABELA = "coleta_dados_questionario";
        public const string
            COLETA_QUESTIONARIO_ID = "id_questionario",
            COLETA_QUESTIONARIO_ID_POSTO_COLETA = "id_posto_coleta",
            COLETA_QUESTIONARIO_ID_FORMULARIO = "id_formulario_fk";

        // Campos Resposta
        public const string RESPOSTA_TABELA = "resposta_pergunta";
        public const string
            RESPOSTA_ID = "id_resposta",
            RESPOSTA_ID_TIPO = "id_tipo_resposta_fk",
            RESPOSTA_ID_PERGUNTA = "id_pergunta",
            RESPOSTA_NOMECLATURA = "nomenclatura",
            RESPOSTA_POSICAO = "posicao_naPergunta",
            RESPOSTA_ATIVO = "estado_ativo";

        // Campos Tipo_Resposta
        public const string TIPO_RESPOSTA_TABELA = "tipo_resposta";
        public const string
            TIPO_RESPOSTA_ID = "id_tipo_resposta",
            TIPO_RESPOSTA_NOMECLATURA = "nomenclatura",
            TIPO_RESPOSTA_ATIVO = "estado_ativo";

        // Campos Cliente
        public const string CLIENTE_TABELA = "cliente_requerente";
        public const string
            CLIENTE_ID = "id_cliente_req",
            CLIENTE_NOME = "nome_cliente",
            CLIENTE_DATA_CRIACAO = "data_criacao";

        // Campos coleta_dados_resposta
        public const string COLETA_DADOS_TABELA = "coleta_dados_resposta";
        public const string
            COLETA_DADOS_ID = "id_coleta_dados_resposta",
            COLETA_DADOS_ID_RESPOSTA = "id_resposta_fk",
            COLETA_DADOS_ID_QUESTIONARIO = "id_questionario_fk",
            COLETA_DADOS_ID_PERGUNTA = "id_pergunta_fk";

        // Campos coleta_dados_resposta_texto
        public const string COLETA_DADOS_TEXTO_TABELA = "coleta_dados_resposta_texto";
        public const string
            COLETA_DADOS_TEXTO_ID = "id_coleta_dados_resposta_texto",
            COLETA_DADOS_TEXTO_COLETA_DADOS_ID_RESPOSTA = "id_coleta_dados_resposta_fk",
            COLETA_DADOS_TEXTO_TEXTO = "texto";

        // Campos coleta_posto
        public const string COLETA_POSTO_TABELA = "coleta_posto";
        public const string
            COLETA_POSTO_ID = "id_posto",
            COLETA_POSTO_NOME = "nome",
            COLETA_POSTO_DATA_CRIACAO = "data_criacao";

        // Campos cidade
        public const string CIDADE_TABELA = "cidade";
        public const string
            CIDADE_ID = "id_cidade",
            CIDADE_NOME = "nome",
            CIDADE_ID_ESTADO = "id_estado_fk";

        // Campos estados
        public const string ESTADO_TABELA = "estado";
        public const string
            ESTADO_ID = "id_estado",
            ESTADO_NOME = "nome",
            ESTADO_UF = "uf",
            ESTADO_ID_PAIS = "id_pais_fk";

        // Auxiliares
        private char identificar_SimNao_BoolToChar(bool nulo)
        {
            return nulo ? 's' : 'n';
        }

        // =========================================================================
        // SELECTS - PERGUNTAS
        // =========================================================================

        public List<int> selecionarID_TodasPerguntasDoFormulario(int id_form)
        {
            List<int> resultados = new List<int>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " + PERGUNTA_ID + " FROM " + PERGUNTA_TABELA +
                    " WHERE " + PERGUNTA_ID_FORMULARIO + " = @IdForm AND " + PERGUNTA_ATIVO + " = 's' ORDER BY " + PERGUNTA_POSICAO + " ASC",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@IdForm", id_form);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultados.Add(leitor.GetInt32(PERGUNTA_ID));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarID_TodasPerguntasDoFormulario: " + ex.Message);
            }
            return resultados;
        }

        public objeto_pergunta selecionarUltimaPerguntaCadastrada()
        {
            objeto_pergunta resultado = new objeto_pergunta();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    PERGUNTA_ID + "," +
                    PERGUNTA_ID_FORMULARIO + "," +
                    PERGUNTA_NOMECLATURA + "," +
                    PERGUNTA_NULO + "," +
                    PERGUNTA_POSICAO + "," +
                    PERGUNTA_RESP_MAX +
                    " FROM " + PERGUNTA_TABELA +
                    " WHERE " + PERGUNTA_ID + " = (SELECT max(" + PERGUNTA_ID + ") FROM " + PERGUNTA_TABELA + " LIMIT 1)",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultado.id_pergunta = leitor.GetInt32(PERGUNTA_ID);
                            resultado.posicao = leitor.GetInt32(PERGUNTA_POSICAO);
                            resultado.nomenclatura = leitor.GetString(PERGUNTA_NOMECLATURA);
                            resultado.permite_nulo = leitor.GetChar(PERGUNTA_NULO);
                            resultado.maxResp = leitor.GetInt32(PERGUNTA_RESP_MAX);
                            resultado.id_formulario = leitor.GetInt32(PERGUNTA_ID_FORMULARIO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarUltimaPerguntaCadastrada: " + ex.Message);
            }
            return resultado;
        }

        public objeto_pergunta selecionarPerguntaMaiorPosicao_porIdForm(int id_form)
        {
            objeto_pergunta resultado = new objeto_pergunta();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    PERGUNTA_ID + "," +
                    PERGUNTA_ID_FORMULARIO + "," +
                    PERGUNTA_NOMECLATURA + "," +
                    PERGUNTA_NULO + "," +
                    PERGUNTA_POSICAO + "," +
                    PERGUNTA_RESP_MAX +
                    " FROM " + PERGUNTA_TABELA +
                    " WHERE " + PERGUNTA_POSICAO + " = (SELECT max(" + PERGUNTA_POSICAO + ") FROM " + PERGUNTA_TABELA + " WHERE " + PERGUNTA_ID_FORMULARIO + " = @Id_form LIMIT 1) AND " + PERGUNTA_ID_FORMULARIO + " = @Id_form ",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id_form", id_form);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultado.id_pergunta = leitor.GetInt32(PERGUNTA_ID);
                            resultado.posicao = leitor.GetInt32(PERGUNTA_POSICAO);
                            resultado.nomenclatura = leitor.GetString(PERGUNTA_NOMECLATURA);
                            resultado.permite_nulo = leitor.GetChar(PERGUNTA_NULO);
                            resultado.maxResp = leitor.GetInt32(PERGUNTA_RESP_MAX);
                            resultado.id_formulario = leitor.GetInt32(PERGUNTA_ID_FORMULARIO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarPerguntaMaiorPosicao_porIdForm: " + ex.Message);
            }
            return resultado;
        }

        public objeto_pergunta selecionarPergunta_porID(int id_pergunta)
        {
            objeto_pergunta resultado = new objeto_pergunta();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    PERGUNTA_ID + "," +
                    PERGUNTA_ID_FORMULARIO + "," +
                    PERGUNTA_NOMECLATURA + "," +
                    PERGUNTA_NULO + "," +
                    PERGUNTA_POSICAO + "," +
                    PERGUNTA_RESP_MAX +
                    " FROM " + PERGUNTA_TABELA +
                    " WHERE " + PERGUNTA_ID + " = @IdPerg LIMIT 1",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@IdPerg", id_pergunta);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultado.id_pergunta = leitor.GetInt32(PERGUNTA_ID);
                            resultado.posicao = leitor.GetInt32(PERGUNTA_POSICAO);
                            resultado.nomenclatura = leitor.GetString(PERGUNTA_NOMECLATURA);
                            resultado.permite_nulo = leitor.GetChar(PERGUNTA_NULO);
                            resultado.maxResp = leitor.GetInt32(PERGUNTA_RESP_MAX);
                            resultado.id_formulario = leitor.GetInt32(PERGUNTA_ID_FORMULARIO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarPergunta_porID: " + ex.Message);
            }
            return resultado;
        }

        public List<objeto_pergunta> selecionarTodasPerguntasCadastradasEAtivas_porIDForm(int id_form)
        {
            List<objeto_pergunta> resultados = new List<objeto_pergunta>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    PERGUNTA_ID + "," +
                    PERGUNTA_ID_FORMULARIO + "," +
                    PERGUNTA_NOMECLATURA + "," +
                    PERGUNTA_NULO + "," +
                    PERGUNTA_POSICAO + "," +
                    PERGUNTA_RESP_MAX +
                    " FROM " + PERGUNTA_TABELA +
                    " WHERE " + PERGUNTA_ATIVO + " = 's' AND " + PERGUNTA_ID_FORMULARIO + " = @idForm ORDER BY " + PERGUNTA_POSICAO + " ASC",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@idForm", id_form);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            objeto_pergunta resultado = new objeto_pergunta();
                            resultado.id_pergunta = leitor.GetInt32(PERGUNTA_ID);
                            resultado.posicao = leitor.GetInt32(PERGUNTA_POSICAO);
                            resultado.nomenclatura = leitor.GetString(PERGUNTA_NOMECLATURA);
                            resultado.permite_nulo = leitor.GetChar(PERGUNTA_NULO);
                            resultado.maxResp = leitor.GetInt32(PERGUNTA_RESP_MAX);
                            resultado.id_formulario = leitor.GetInt32(PERGUNTA_ID_FORMULARIO);
                            resultados.Add(resultado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodasPerguntasCadastradasEAtivas_porIDForm: " + ex.Message);
            }
            return resultados;
        }

        // =========================================================================
        // SELECTS - RESPOSTAS
        // =========================================================================

        public List<objeto_resposta> selecionarTodasRespostasAtivas_deUmaPerguntaID(int id_pergunta)
        {
            List<objeto_resposta> resultados = new List<objeto_resposta>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    RESPOSTA_ID + "," +
                    RESPOSTA_ID_TIPO + "," +
                    RESPOSTA_NOMECLATURA + "," +
                    RESPOSTA_POSICAO +
                    " FROM " + RESPOSTA_TABELA +
                    " WHERE " + RESPOSTA_ID_PERGUNTA + " = @IdPergunta AND " + RESPOSTA_ATIVO + " = 's' ORDER BY " + RESPOSTA_POSICAO + " ASC",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@IdPergunta", id_pergunta);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            objeto_resposta obj_resp = new objeto_resposta();
                            obj_resp.id_resposta = leitor.GetInt32(RESPOSTA_ID);
                            obj_resp.tipo = leitor.GetInt32(RESPOSTA_ID_TIPO);
                            obj_resp.nomenclatura = leitor.GetString(RESPOSTA_NOMECLATURA);
                            obj_resp.posicao = leitor.GetInt32(RESPOSTA_POSICAO);
                            resultados.Add(obj_resp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodasRespostasAtivas_deUmaPerguntaID: " + ex.Message);
            }
            return resultados;
        }

        public objeto_resposta selecionarPosicaoUltimaRespostaAtiva_deUmaPerguntaID(int id_pergunta)
        {
            objeto_resposta obj_resp = new objeto_resposta();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    RESPOSTA_ID + "," +
                    RESPOSTA_ID_TIPO + "," +
                    RESPOSTA_NOMECLATURA + "," +
                    RESPOSTA_POSICAO +
                    " FROM " + RESPOSTA_TABELA +
                    " WHERE " + RESPOSTA_POSICAO + " = (SELECT max(" + RESPOSTA_POSICAO + ") FROM " + RESPOSTA_TABELA + " WHERE " + RESPOSTA_ID_PERGUNTA + " = @IdPergunta AND " + RESPOSTA_ATIVO + " = 's' LIMIT 1) AND " + RESPOSTA_ID_PERGUNTA + " = @IdPergunta AND " + RESPOSTA_ATIVO + " = 's' LIMIT 1",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@IdPergunta", id_pergunta);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            obj_resp.id_resposta = leitor.GetInt32(RESPOSTA_ID);
                            obj_resp.tipo = leitor.GetInt32(RESPOSTA_ID_TIPO);
                            obj_resp.nomenclatura = leitor.GetString(RESPOSTA_NOMECLATURA);
                            obj_resp.posicao = leitor.GetInt32(RESPOSTA_POSICAO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarPosicaoUltimaRespostaAtiva_deUmaPerguntaID: " + ex.Message);
            }
            return obj_resp;
        }

        public objeto_resposta selecionarIDUltimaRespostaAtiva_deUmaPerguntaID(int id_pergunta)
        {
            objeto_resposta obj_resp = new objeto_resposta();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    RESPOSTA_ID + "," +
                    RESPOSTA_ID_TIPO + "," +
                    RESPOSTA_NOMECLATURA + "," +
                    RESPOSTA_POSICAO +
                    " FROM " + RESPOSTA_TABELA +
                    " WHERE " + RESPOSTA_ID + " = (SELECT max(" + RESPOSTA_ID + ") FROM " + RESPOSTA_TABELA + " WHERE " + RESPOSTA_ID_PERGUNTA + " = @IdPerg AND " + RESPOSTA_ATIVO + " = 's' LIMIT 1) AND " + RESPOSTA_ID_PERGUNTA + " = @IdPerg AND " + RESPOSTA_ATIVO + " = 's' LIMIT 1",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@IdPerg", id_pergunta);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            obj_resp.id_resposta = leitor.GetInt32(RESPOSTA_ID);
                            obj_resp.tipo = leitor.GetInt32(RESPOSTA_ID_TIPO);
                            obj_resp.nomenclatura = leitor.GetString(RESPOSTA_NOMECLATURA);
                            obj_resp.posicao = leitor.GetInt32(RESPOSTA_POSICAO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarIDUltimaRespostaAtiva_deUmaPerguntaID: " + ex.Message);
            }
            return obj_resp;
        }

        // =========================================================================
        // RESPOSTA TEXTO
        // =========================================================================

        public List<string> selecionarTodasRespostasTextoDistintas_deUmaRespostaID(int id_resposta)
        {
            List<string> resultados = new List<string>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT distinct(" + COLETA_DADOS_TEXTO_TABELA + "." + COLETA_DADOS_TEXTO_TEXTO + ") as " + COLETA_DADOS_TEXTO_TEXTO + " FROM " + COLETA_DADOS_TEXTO_TABELA +
                    " INNER JOIN " + COLETA_DADOS_TABELA + " ON " + COLETA_DADOS_TABELA + "." + COLETA_DADOS_ID + " = " + COLETA_DADOS_TEXTO_TABELA + "." + COLETA_DADOS_TEXTO_COLETA_DADOS_ID_RESPOSTA +
                    " INNER JOIN " + RESPOSTA_TABELA + " ON " + RESPOSTA_TABELA + "." + RESPOSTA_ID + " = " + COLETA_DADOS_TABELA + "." + COLETA_DADOS_ID_RESPOSTA +
                    " WHERE " + RESPOSTA_TABELA + "." + RESPOSTA_ID + " = @IdResp ORDER BY " + COLETA_DADOS_TEXTO_TABELA + "." + COLETA_DADOS_TEXTO_TEXTO + " ASC",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@IdResp", id_resposta);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultados.Add(leitor.GetString(COLETA_DADOS_TEXTO_TEXTO));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodasRespostasTextoDistintas_deUmaRespostaID: " + ex.Message);
            }
            return resultados;
        }

        // =========================================================================
        // CIDADES E ESTADOS
        // =========================================================================

        public List<string> selecionarTodasCidadesDistintas()
        {
            List<string> resultados = new List<string>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT distinct(" + CIDADE_NOME + ") FROM " + CIDADE_TABELA + " ORDER BY " + CIDADE_NOME + " ASC",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultados.Add(leitor.GetString(CIDADE_NOME));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodasCidadesDistintas: " + ex.Message);
            }
            return resultados;
        }

        public List<string> selecionarTodosEstadosDistintos()
        {
            List<string> resultados = new List<string>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT distinct(" + ESTADO_UF + ") FROM " + ESTADO_TABELA + " ORDER BY " + ESTADO_UF + " ASC",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultados.Add(leitor.GetString(ESTADO_UF));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodosEstadosDistintos: " + ex.Message);
            }
            return resultados;
        }

        // =========================================================================
        // CLIENTES
        // =========================================================================

        public List<objeto_cliente> selecionarTodosClientes()
        {
            List<objeto_cliente> resultados = new List<objeto_cliente>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " + CLIENTE_ID + "," + CLIENTE_NOME + " FROM " + CLIENTE_TABELA + " ORDER BY " + CLIENTE_NOME + " ASC",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            objeto_cliente cliente = new objeto_cliente();
                            cliente.id_cliente = leitor.GetInt32(CLIENTE_ID);
                            cliente.nome = leitor.GetString(CLIENTE_NOME);
                            resultados.Add(cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodosClientes: " + ex.Message);
            }
            return resultados;
        }

        public objeto_cliente selecionarUmCliente_porIDCliente(int id)
        {
            objeto_cliente cliente = new objeto_cliente();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " + CLIENTE_ID + "," + CLIENTE_NOME + " FROM " + CLIENTE_TABELA + " WHERE " + CLIENTE_ID + " = @Id LIMIT 1",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            cliente.id_cliente = leitor.GetInt32(CLIENTE_ID);
                            cliente.nome = leitor.GetString(CLIENTE_NOME);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarUmCliente_porIDCliente: " + ex.Message);
            }
            return cliente;
        }

        // =========================================================================
        // FORMULARIOS
        // =========================================================================

        public List<objeto_formulario> selecionarTodosFormularios()
        {
            List<objeto_formulario> resultados = new List<objeto_formulario>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    FORMULARIO_ID + "," +
                    FORMULARIO_ID_CLIENTE + "," +
                    FORMULARIO_TITULO + "," +
                    FORMULARIO_DT_CRIACAO + "," +
                    FORMULARIO_DT_ENTREGA + "," +
                    FORMULARIO_SITUACAO + "," +
                    FORMULARIO_ATIVO +
                    " FROM " + FORMULARIO_TABELA + " ORDER BY " + FORMULARIO_DT_CRIACAO + " DESC",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            objeto_formulario form = new objeto_formulario();
                            form.id_formulario = leitor.GetInt32(FORMULARIO_ID);
                            form.id_cliente = leitor.GetInt32(FORMULARIO_ID_CLIENTE);
                            form.titulo = leitor.GetString(FORMULARIO_TITULO);
                            form.data_criacao = leitor.IsDBNull(leitor.GetOrdinal(FORMULARIO_DT_CRIACAO)) ? "" : leitor.GetString(FORMULARIO_DT_CRIACAO);
                            form.data_entrega = leitor.IsDBNull(leitor.GetOrdinal(FORMULARIO_DT_ENTREGA)) ? "" : leitor.GetString(FORMULARIO_DT_ENTREGA);
                            form.situacao = leitor.GetChar(FORMULARIO_SITUACAO);
                            form.ativo = leitor.GetChar(FORMULARIO_ATIVO);
                            resultados.Add(form);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodosFormularios: " + ex.Message);
            }
            return resultados;
        }

        public List<objeto_formulario> selecionarTodosFormularios_somenteEmAndamento()
        {
            List<objeto_formulario> resultados = new List<objeto_formulario>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    FORMULARIO_ID + "," +
                    FORMULARIO_ID_CLIENTE + "," +
                    FORMULARIO_TITULO + "," +
                    FORMULARIO_DT_CRIACAO + "," +
                    FORMULARIO_DT_ENTREGA + "," +
                    FORMULARIO_SITUACAO + "," +
                    FORMULARIO_ATIVO +
                    " FROM " + FORMULARIO_TABELA + " WHERE " + FORMULARIO_SITUACAO + " = 'a' ORDER BY " + FORMULARIO_DT_CRIACAO + " DESC",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            objeto_formulario form = new objeto_formulario();
                            form.id_formulario = leitor.GetInt32(FORMULARIO_ID);
                            form.id_cliente = leitor.GetInt32(FORMULARIO_ID_CLIENTE);
                            form.titulo = leitor.GetString(FORMULARIO_TITULO);
                            form.data_criacao = leitor.IsDBNull(leitor.GetOrdinal(FORMULARIO_DT_CRIACAO)) ? "" : leitor.GetString(FORMULARIO_DT_CRIACAO);
                            form.data_entrega = leitor.IsDBNull(leitor.GetOrdinal(FORMULARIO_DT_ENTREGA)) ? "" : leitor.GetString(FORMULARIO_DT_ENTREGA);
                            form.situacao = leitor.GetChar(FORMULARIO_SITUACAO);
                            form.ativo = leitor.GetChar(FORMULARIO_ATIVO);
                            resultados.Add(form);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodosFormularios_somenteEmAndamento: " + ex.Message);
            }
            return resultados;
        }

        public objeto_formulario selecionarUmFormulario_porID(int id)
        {
            objeto_formulario resultado = new objeto_formulario();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " +
                    FORMULARIO_ID + "," +
                    FORMULARIO_ID_CLIENTE + "," +
                    FORMULARIO_TITULO + "," +
                    FORMULARIO_DT_CRIACAO + "," +
                    FORMULARIO_DT_ENTREGA + "," +
                    FORMULARIO_SITUACAO + "," +
                    FORMULARIO_ATIVO +
                    " FROM " + FORMULARIO_TABELA + " WHERE " + FORMULARIO_ID + " = @Id LIMIT 1",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultado.id_formulario = leitor.GetInt32(FORMULARIO_ID);
                            resultado.id_cliente = leitor.GetInt32(FORMULARIO_ID_CLIENTE);
                            resultado.titulo = leitor.GetString(FORMULARIO_TITULO);
                            resultado.data_criacao = leitor.IsDBNull(leitor.GetOrdinal(FORMULARIO_DT_CRIACAO)) ? "" : leitor.GetString(FORMULARIO_DT_CRIACAO);
                            resultado.data_entrega = leitor.IsDBNull(leitor.GetOrdinal(FORMULARIO_DT_ENTREGA)) ? "" : leitor.GetString(FORMULARIO_DT_ENTREGA);
                            resultado.situacao = leitor.GetChar(FORMULARIO_SITUACAO);
                            resultado.ativo = leitor.GetChar(FORMULARIO_ATIVO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarUmFormulario_porID: " + ex.Message);
            }
            return resultado;
        }

        // =========================================================================
        // QUESTIONARIOS
        // =========================================================================

        public int selecionarQtdQuestionariosRespondidos_porIDForm(int id_form)
        {
            int resultados = 0;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT count(" + COLETA_QUESTIONARIO_ID + ") FROM " + COLETA_QUESTIONARIO_TABELA +
                    " WHERE " + COLETA_QUESTIONARIO_ID_FORMULARIO + " = @Id_form",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id_form", id_form);
                    object scalar = cmd.ExecuteScalar();
                    if (scalar != null && scalar != DBNull.Value)
                    {
                        resultados = Convert.ToInt32(scalar);
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarQtdQuestionariosRespondidos_porIDForm: " + ex.Message);
            }
            return resultados;
        }

        // =========================================================================
        // POSTO DE COLETA
        // =========================================================================

        public List<objeto_posto_coleta> selecionarTodosPostos_Coleta()
        {
            List<objeto_posto_coleta> resultados = new List<objeto_posto_coleta>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " + COLETA_POSTO_ID + "," + COLETA_POSTO_NOME + "," + COLETA_POSTO_DATA_CRIACAO +
                    " FROM " + COLETA_POSTO_TABELA + " ORDER BY " + COLETA_POSTO_DATA_CRIACAO + " DESC",
                    ConexaoBD.getConexao()))
                {
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            objeto_posto_coleta posto = new objeto_posto_coleta();
                            posto.id_posto = leitor.GetInt32(COLETA_POSTO_ID);
                            posto.nome = leitor.GetString(COLETA_POSTO_NOME);
                            posto.data_criacao = leitor.IsDBNull(leitor.GetOrdinal(COLETA_POSTO_DATA_CRIACAO)) ? "" : leitor.GetString(COLETA_POSTO_DATA_CRIACAO);
                            resultados.Add(posto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarTodosPostos_Coleta: " + ex.Message);
            }
            return resultados;
        }

        public objeto_posto_coleta selecionarUmPosto_Coleta_porID(int id)
        {
            objeto_posto_coleta resultado = new objeto_posto_coleta();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT " + COLETA_POSTO_ID + "," + COLETA_POSTO_NOME + "," + COLETA_POSTO_DATA_CRIACAO +
                    " FROM " + COLETA_POSTO_TABELA + " WHERE " + COLETA_POSTO_ID + " = @Id LIMIT 1",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            resultado.id_posto = leitor.GetInt32(COLETA_POSTO_ID);
                            resultado.nome = leitor.GetString(COLETA_POSTO_NOME);
                            resultado.data_criacao = leitor.IsDBNull(leitor.GetOrdinal(COLETA_POSTO_DATA_CRIACAO)) ? "" : leitor.GetString(COLETA_POSTO_DATA_CRIACAO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em selecionarUmPosto_Coleta_porID: " + ex.Message);
            }
            return resultado;
        }

        // =========================================================================
        // INSERTS
        // =========================================================================

        public int inserir_umQuestionarioEReceberIDdele(int id_posto_coleta, int id_form, MySqlTransaction transacaoRecebida)
        {
            if (id_posto_coleta <= 0 || id_form <= 0)
            {
                return 0;
            }

            try
            {
                MySqlConnection conn = transacaoRecebida != null ? transacaoRecebida.Connection : ConexaoBD.getConexao();
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + COLETA_QUESTIONARIO_TABELA + " (" +
                    COLETA_QUESTIONARIO_ID_POSTO_COLETA + "," + COLETA_QUESTIONARIO_ID_FORMULARIO + ") VALUES (@Id_posto, @Id_form)",
                    conn, transacaoRecebida))
                {
                    cmd.Parameters.AddWithValue("@Id_posto", id_posto_coleta);
                    cmd.Parameters.AddWithValue("@Id_form", id_form);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    cmd.Parameters.Clear();
                    object scalar = cmd.ExecuteScalar();
                    if (scalar != null && scalar != DBNull.Value)
                    {
                        return Convert.ToInt32(scalar);
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umQuestionarioEReceberIDdele: " + ex.Message);
            }
            return 0;
        }

        public bool inserir_umaPerguntaNoFormulario(int id_form, bool estado_ativo, string nomenclatura, int posicao, bool aceita_nulo, int maxRespostas)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + PERGUNTA_TABELA + " (" +
                    PERGUNTA_ID_FORMULARIO + "," +
                    PERGUNTA_ATIVO + "," +
                    PERGUNTA_NOMECLATURA + "," +
                    PERGUNTA_POSICAO + "," +
                    PERGUNTA_NULO + "," +
                    PERGUNTA_RESP_MAX + ")" +
                    " VALUES (@Id_Form, @Ativo, @Nomenclatura, @Posicao, @Nulo, @MaxResp)",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id_Form", id_form);
                    cmd.Parameters.AddWithValue("@Ativo", identificar_SimNao_BoolToChar(estado_ativo));
                    cmd.Parameters.AddWithValue("@Nomenclatura", nomenclatura);
                    cmd.Parameters.AddWithValue("@Posicao", posicao);
                    cmd.Parameters.AddWithValue("@Nulo", identificar_SimNao_BoolToChar(aceita_nulo));
                    cmd.Parameters.AddWithValue("@MaxResp", maxRespostas);

                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umaPerguntaNoFormulario: " + ex.Message);
                return false;
            }
        }

        public bool inserir_umaRespostaNaPergunta(int id_pergunta, bool estado_ativo, string nomenclatura, int posicao, int tipo_resposta)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + RESPOSTA_TABELA + " (" +
                    RESPOSTA_ID_PERGUNTA + "," +
                    RESPOSTA_ATIVO + "," +
                    RESPOSTA_NOMECLATURA + "," +
                    RESPOSTA_POSICAO + "," +
                    RESPOSTA_ID_TIPO + ")" +
                    " VALUES (@Id_Perg, @Ativo, @Nomenclatura, @Posicao, @Tipo)",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Id_Perg", id_pergunta);
                    cmd.Parameters.AddWithValue("@Ativo", identificar_SimNao_BoolToChar(estado_ativo));
                    cmd.Parameters.AddWithValue("@Nomenclatura", nomenclatura);
                    cmd.Parameters.AddWithValue("@Posicao", posicao);
                    cmd.Parameters.AddWithValue("@Tipo", tipo_resposta);

                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umaRespostaNaPergunta: " + ex.Message);
                return false;
            }
        }

        public bool inserir_umaRespostaCompleta_texto(int id_pergunta, int id_resposta, string texto, int id_questionario, MySqlTransaction transacaoRecebida)
        {
            try
            {
                MySqlConnection conn = transacaoRecebida != null ? transacaoRecebida.Connection : ConexaoBD.getConexao();
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + COLETA_DADOS_TABELA + " (" +
                    COLETA_DADOS_ID_RESPOSTA + "," +
                    COLETA_DADOS_ID_QUESTIONARIO + "," +
                    COLETA_DADOS_ID_PERGUNTA + ")" +
                    " VALUES (@Id_Resp, @Id_q, @Id_Perg)",
                    conn, transacaoRecebida))
                {
                    cmd.Parameters.AddWithValue("@Id_Resp", id_resposta);
                    cmd.Parameters.AddWithValue("@Id_Perg", id_pergunta);
                    cmd.Parameters.AddWithValue("@Id_q", id_questionario);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        cmd.Parameters.Clear();
                        object scalar = cmd.ExecuteScalar();
                        int id_resposta_coletada = scalar != null && scalar != DBNull.Value ? Convert.ToInt32(scalar) : 0;

                        if (id_resposta_coletada > 0)
                        {
                            cmd.CommandText = "INSERT INTO " + COLETA_DADOS_TEXTO_TABELA + " (" +
                                COLETA_DADOS_TEXTO_COLETA_DADOS_ID_RESPOSTA + "," +
                                COLETA_DADOS_TEXTO_TEXTO + ") VALUES (@Id_cl_Resp, @Texto)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id_cl_Resp", id_resposta_coletada);
                            cmd.Parameters.AddWithValue("@Texto", (texto ?? "").Trim().ToUpper());

                            return cmd.ExecuteNonQuery() == 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umaRespostaCompleta_texto: " + ex.Message);
            }
            return false;
        }

        public bool inserir_umaRespostaCompleta(int id_pergunta, int id_resposta, int id_questionario, MySqlTransaction transacaoRecebida)
        {
            try
            {
                MySqlConnection conn = transacaoRecebida != null ? transacaoRecebida.Connection : ConexaoBD.getConexao();
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + COLETA_DADOS_TABELA + " (" +
                    COLETA_DADOS_ID_RESPOSTA + "," +
                    COLETA_DADOS_ID_PERGUNTA + "," +
                    COLETA_DADOS_ID_QUESTIONARIO + ")" +
                    " VALUES (@Id_Resp, @Id_Perg, @Id_q)",
                    conn, transacaoRecebida))
                {
                    cmd.Parameters.AddWithValue("@Id_Resp", id_resposta);
                    cmd.Parameters.AddWithValue("@Id_Perg", id_pergunta);
                    cmd.Parameters.AddWithValue("@Id_q", id_questionario);

                    return cmd.ExecuteNonQuery() == 1;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umaRespostaCompleta: " + ex.Message);
                return false;
            }
        }

        public bool inserir_umPostoColeta(string nome)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + COLETA_POSTO_TABELA + " (" +
                    COLETA_POSTO_NOME + "," +
                    COLETA_POSTO_DATA_CRIACAO + ") VALUES (@Nome, CURDATE())",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Nome", (nome ?? "").Trim());
                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umPostoColeta: " + ex.Message);
                return false;
            }
        }

        public bool inserir_umFormulario(string nome, int id_cliente, string Dtentrega)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + FORMULARIO_TABELA + " (" +
                    FORMULARIO_TITULO + "," +
                    FORMULARIO_SITUACAO + "," +
                    FORMULARIO_DT_CRIACAO + "," +
                    FORMULARIO_ATIVO + "," +
                    FORMULARIO_ID_CLIENTE + "," +
                    FORMULARIO_DT_ENTREGA + ")" +
                    " VALUES (@Nome, 'a', CURDATE(), 's', @IdCliente, @DTEntrega)",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Nome", (nome ?? "").Trim());
                    cmd.Parameters.AddWithValue("@IdCliente", id_cliente);
                    cmd.Parameters.AddWithValue("@DTEntrega", Dtentrega);

                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umFormulario: " + ex.Message);
                return false;
            }
        }

        public bool inserir_umCliente(string nome)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO " + CLIENTE_TABELA + " (" +
                    CLIENTE_NOME + ", " +
                    CLIENTE_DATA_CRIACAO + ") VALUES (@Nome, CURDATE())",
                    ConexaoBD.getConexao()))
                {
                    cmd.Parameters.AddWithValue("@Nome", (nome ?? "").Trim());
                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Erro em inserir_umCliente: " + ex.Message);
                return false;
            }
        }
    }
}
