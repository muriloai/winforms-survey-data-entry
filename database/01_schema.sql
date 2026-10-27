-- =============================================================================
-- Database Schema: Sistema de Coleta e Tabulação de Pesquisas (SQLite)
-- Encoding: UTF-8
-- =============================================================================

PRAGMA foreign_keys = ON;

-- -----------------------------------------------------------------------------
-- Tabela: tipo_resposta
-- Tipos de resposta suportados (único sem texto, único com texto, multiescolha)
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS tipo_resposta (
  id_tipo_resposta INTEGER PRIMARY KEY AUTOINCREMENT,
  nomenclatura TEXT NOT NULL,
  estado_ativo TEXT NOT NULL DEFAULT 's'
);

-- -----------------------------------------------------------------------------
-- Tabela: cliente_requerente
-- Clientes ou solicitantes que demandam formulários de pesquisa
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS cliente_requerente (
  id_cliente_req INTEGER PRIMARY KEY AUTOINCREMENT,
  nome_cliente TEXT NOT NULL,
  data_criacao TEXT NOT NULL,
  estado_ativo TEXT NOT NULL DEFAULT 's'
);

-- -----------------------------------------------------------------------------
-- Tabela: coleta_posto
-- Postos ou locais físicos onde a pesquisa de campo é realizada
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS coleta_posto (
  id_posto INTEGER PRIMARY KEY AUTOINCREMENT,
  nome TEXT NOT NULL,
  data_criacao TEXT NOT NULL
);

-- -----------------------------------------------------------------------------
-- Tabela: formulario_pesquisa
-- Formulários e questionários vinculados a um cliente solicitante
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS formulario_pesquisa (
  id_formulario INTEGER PRIMARY KEY AUTOINCREMENT,
  id_cliente_req INTEGER NOT NULL,
  titulo_formulario TEXT NOT NULL,
  data_criacao TEXT NOT NULL,
  data_entrega TEXT,
  estado_situacao TEXT NOT NULL DEFAULT 'a',
  estado_ativo TEXT NOT NULL DEFAULT 's',
  FOREIGN KEY (id_cliente_req) REFERENCES cliente_requerente (id_cliente_req)
    ON UPDATE CASCADE
    ON DELETE RESTRICT
);

CREATE INDEX IF NOT EXISTS idx_form_cliente ON formulario_pesquisa (id_cliente_req);

-- -----------------------------------------------------------------------------
-- Tabela: pergunta_formulario
-- Perguntas vinculadas a um formulário específico
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS pergunta_formulario (
  id_pergunta INTEGER PRIMARY KEY AUTOINCREMENT,
  id_formulario INTEGER NOT NULL,
  nomenclatura TEXT NOT NULL,
  posicao_noFormulario INTEGER NOT NULL,
  permite_nulo TEXT NOT NULL DEFAULT 's',
  respostas_maxPermitidas INTEGER NOT NULL DEFAULT 1,
  estado_ativo TEXT NOT NULL DEFAULT 's',
  FOREIGN KEY (id_formulario) REFERENCES formulario_pesquisa (id_formulario)
    ON UPDATE CASCADE
    ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_pergunta_form ON pergunta_formulario (id_formulario);

-- -----------------------------------------------------------------------------
-- Tabela: resposta_pergunta
-- Opções de resposta pré-configuradas para cada pergunta
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS resposta_pergunta (
  id_resposta INTEGER PRIMARY KEY AUTOINCREMENT,
  id_tipo_resposta_fk INTEGER NOT NULL,
  id_pergunta INTEGER NOT NULL,
  nomenclatura TEXT NOT NULL,
  posicao_naPergunta INTEGER NOT NULL,
  estado_ativo TEXT NOT NULL DEFAULT 's',
  FOREIGN KEY (id_tipo_resposta_fk) REFERENCES tipo_resposta (id_tipo_resposta)
    ON UPDATE CASCADE
    ON DELETE RESTRICT,
  FOREIGN KEY (id_pergunta) REFERENCES pergunta_formulario (id_pergunta)
    ON UPDATE CASCADE
    ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_resposta_tipo ON resposta_pergunta (id_tipo_resposta_fk);
CREATE INDEX IF NOT EXISTS idx_resposta_pergunta ON resposta_pergunta (id_pergunta);

-- -----------------------------------------------------------------------------
-- Tabela: coleta_dados_questionario
-- Registro da aplicação de um questionário em um determinado posto de coleta
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS coleta_dados_questionario (
  id_questionario INTEGER PRIMARY KEY AUTOINCREMENT,
  id_posto_coleta INTEGER NOT NULL,
  id_formulario_fk INTEGER NOT NULL,
  FOREIGN KEY (id_posto_coleta) REFERENCES coleta_posto (id_posto)
    ON UPDATE CASCADE
    ON DELETE RESTRICT,
  FOREIGN KEY (id_formulario_fk) REFERENCES formulario_pesquisa (id_formulario)
    ON UPDATE CASCADE
    ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_coleta_posto ON coleta_dados_questionario (id_posto_coleta);
CREATE INDEX IF NOT EXISTS idx_coleta_form ON coleta_dados_questionario (id_formulario_fk);

-- -----------------------------------------------------------------------------
-- Tabela: coleta_dados_resposta
-- Respostas assinaladas em cada questionário aplicado
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS coleta_dados_resposta (
  id_coleta_dados_resposta INTEGER PRIMARY KEY AUTOINCREMENT,
  id_questionario_fk INTEGER NOT NULL,
  id_pergunta_fk INTEGER NOT NULL,
  id_resposta_fk INTEGER DEFAULT NULL,
  FOREIGN KEY (id_questionario_fk) REFERENCES coleta_dados_questionario (id_questionario)
    ON UPDATE CASCADE
    ON DELETE CASCADE,
  FOREIGN KEY (id_pergunta_fk) REFERENCES pergunta_formulario (id_pergunta)
    ON UPDATE CASCADE
    ON DELETE CASCADE,
  FOREIGN KEY (id_resposta_fk) REFERENCES resposta_pergunta (id_resposta)
    ON UPDATE CASCADE
    ON DELETE SET NULL
);

CREATE INDEX IF NOT EXISTS idx_coleta_resp_quest ON coleta_dados_resposta (id_questionario_fk);
CREATE INDEX IF NOT EXISTS idx_coleta_resp_perg ON coleta_dados_resposta (id_pergunta_fk);
CREATE INDEX IF NOT EXISTS idx_coleta_resp_resp ON coleta_dados_resposta (id_resposta_fk);

-- -----------------------------------------------------------------------------
-- Tabela: coleta_dados_resposta_texto
-- Complementos textuais digitados pelo operador para respostas dissertativas
-- -----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS coleta_dados_resposta_texto (
  id_coleta_dados_resposta_texto INTEGER PRIMARY KEY AUTOINCREMENT,
  id_coleta_dados_resposta_fk INTEGER NOT NULL,
  texto TEXT NOT NULL,
  FOREIGN KEY (id_coleta_dados_resposta_fk) REFERENCES coleta_dados_resposta (id_coleta_dados_resposta)
    ON UPDATE CASCADE
    ON DELETE CASCADE
);

CREATE INDEX IF NOT EXISTS idx_coleta_texto_resp ON coleta_dados_resposta_texto (id_coleta_dados_resposta_fk);

-- -----------------------------------------------------------------------------
-- Tabelas auxiliares: estado e cidade (suporte a autocompletar)
-- -----------------------------------------------------------------------------
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
  FOREIGN KEY (id_estado_fk) REFERENCES estado (id_estado)
    ON UPDATE CASCADE
    ON DELETE SET NULL
);

CREATE INDEX IF NOT EXISTS idx_cidade_estado ON cidade (id_estado_fk);

-- -----------------------------------------------------------------------------
-- Triggers de integridade referencial
-- -----------------------------------------------------------------------------
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
