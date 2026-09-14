-- =============================================================================
-- Database Schema: Sistema de Coleta e Tabulação de Pesquisas
-- Engine: MySQL 5.5+ / 8.0+ / MariaDB 10+
-- Encoding: UTF-8 (utf8mb4)
-- =============================================================================

CREATE DATABASE IF NOT EXISTS `survey_db`
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE `survey_db`;

SET FOREIGN_KEY_CHECKS = 0;

-- -----------------------------------------------------------------------------
-- Tabela: tipo_resposta
-- Tipos de resposta suportados (único sem texto, único com texto, multiescolha)
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `tipo_resposta`;
CREATE TABLE `tipo_resposta` (
  `id_tipo_resposta` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nomenclatura` VARCHAR(100) NOT NULL,
  `estado_ativo` CHAR(1) NOT NULL DEFAULT 's',
  PRIMARY KEY (`id_tipo_resposta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: cliente_requerente
-- Clientes ou solicitantes que demandam formulários de pesquisa
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `cliente_requerente`;
CREATE TABLE `cliente_requerente` (
  `id_cliente_req` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome_cliente` VARCHAR(150) NOT NULL,
  `data_criacao` DATE NOT NULL,
  `estado_ativo` CHAR(1) NOT NULL DEFAULT 's',
  PRIMARY KEY (`id_cliente_req`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: coleta_posto
-- Postos ou locais físicos onde a pesquisa de campo é realizada
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `coleta_posto`;
CREATE TABLE `coleta_posto` (
  `id_posto` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `data_criacao` DATE NOT NULL,
  PRIMARY KEY (`id_posto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: formulario_pesquisa
-- Formulários e questionários vinculados a um cliente solicitante
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `formulario_pesquisa`;
CREATE TABLE `formulario_pesquisa` (
  `id_formulario` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_cliente_req` INT UNSIGNED NOT NULL,
  `titulo_formulario` VARCHAR(255) NOT NULL,
  `data_criacao` DATE NOT NULL,
  `data_entrega` DATE DEFAULT NULL,
  `estado_situacao` CHAR(1) NOT NULL DEFAULT 'a' COMMENT 'a=andamento, f=finalizado, c=cancelado',
  `estado_ativo` CHAR(1) NOT NULL DEFAULT 's',
  PRIMARY KEY (`id_formulario`),
  INDEX `idx_form_cliente` (`id_cliente_req`),
  CONSTRAINT `fk_formulario_cliente`
    FOREIGN KEY (`id_cliente_req`)
    REFERENCES `cliente_requerente` (`id_cliente_req`)
    ON UPDATE CASCADE
    ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: pergunta_formulario
-- Perguntas vinculadas a um formulário específico
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `pergunta_formulario`;
CREATE TABLE `pergunta_formulario` (
  `id_pergunta` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_formulario` INT UNSIGNED NOT NULL,
  `nomenclatura` VARCHAR(500) NOT NULL,
  `posicao_noFormulario` INT UNSIGNED NOT NULL,
  `permite_nulo` CHAR(1) NOT NULL DEFAULT 's',
  `respostas_maxPermitidas` INT NOT NULL DEFAULT 1,
  `estado_ativo` CHAR(1) NOT NULL DEFAULT 's',
  PRIMARY KEY (`id_pergunta`),
  INDEX `idx_pergunta_form` (`id_formulario`),
  CONSTRAINT `fk_pergunta_formulario`
    FOREIGN KEY (`id_formulario`)
    REFERENCES `formulario_pesquisa` (`id_formulario`)
    ON UPDATE CASCADE
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: resposta_pergunta
-- Opções de resposta pré-configuradas para cada pergunta
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `resposta_pergunta`;
CREATE TABLE `resposta_pergunta` (
  `id_resposta` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_tipo_resposta_fk` INT UNSIGNED NOT NULL,
  `id_pergunta` INT UNSIGNED NOT NULL,
  `nomenclatura` TEXT NOT NULL,
  `posicao_naPergunta` INT UNSIGNED NOT NULL,
  `estado_ativo` CHAR(1) NOT NULL DEFAULT 's',
  PRIMARY KEY (`id_resposta`),
  INDEX `idx_resposta_tipo` (`id_tipo_resposta_fk`),
  INDEX `idx_resposta_pergunta` (`id_pergunta`),
  CONSTRAINT `fk_resposta_tipo`
    FOREIGN KEY (`id_tipo_resposta_fk`)
    REFERENCES `tipo_resposta` (`id_tipo_resposta`)
    ON UPDATE CASCADE
    ON DELETE RESTRICT,
  CONSTRAINT `fk_resposta_pergunta`
    FOREIGN KEY (`id_pergunta`)
    REFERENCES `pergunta_formulario` (`id_pergunta`)
    ON UPDATE CASCADE
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: coleta_dados_questionario
-- Registro da aplicação de um questionário em um determinado posto de coleta
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `coleta_dados_questionario`;
CREATE TABLE `coleta_dados_questionario` (
  `id_questionario` INT NOT NULL AUTO_INCREMENT,
  `id_posto_coleta` INT NOT NULL,
  `id_formulario_fk` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`id_questionario`),
  INDEX `idx_coleta_posto` (`id_posto_coleta`),
  INDEX `idx_coleta_form` (`id_formulario_fk`),
  CONSTRAINT `fk_coleta_quest_posto`
    FOREIGN KEY (`id_posto_coleta`)
    REFERENCES `coleta_posto` (`id_posto`)
    ON UPDATE CASCADE
    ON DELETE RESTRICT,
  CONSTRAINT `fk_coleta_quest_formulario`
    FOREIGN KEY (`id_formulario_fk`)
    REFERENCES `formulario_pesquisa` (`id_formulario`)
    ON UPDATE CASCADE
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: coleta_dados_resposta
-- Respostas assinaladas em cada questionário aplicado
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `coleta_dados_resposta`;
CREATE TABLE `coleta_dados_resposta` (
  `id_coleta_dados_resposta` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_questionario_fk` INT NOT NULL,
  `id_pergunta_fk` INT UNSIGNED NOT NULL,
  `id_resposta_fk` INT UNSIGNED DEFAULT NULL,
  PRIMARY KEY (`id_coleta_dados_resposta`),
  INDEX `idx_coleta_resp_quest` (`id_questionario_fk`),
  INDEX `idx_coleta_resp_perg` (`id_pergunta_fk`),
  INDEX `idx_coleta_resp_resp` (`id_resposta_fk`),
  CONSTRAINT `fk_coleta_dados_quest`
    FOREIGN KEY (`id_questionario_fk`)
    REFERENCES `coleta_dados_questionario` (`id_questionario`)
    ON UPDATE CASCADE
    ON DELETE CASCADE,
  CONSTRAINT `fk_coleta_dados_perg`
    FOREIGN KEY (`id_pergunta_fk`)
    REFERENCES `pergunta_formulario` (`id_pergunta`)
    ON UPDATE CASCADE
    ON DELETE CASCADE,
  CONSTRAINT `fk_coleta_dados_resp`
    FOREIGN KEY (`id_resposta_fk`)
    REFERENCES `resposta_pergunta` (`id_resposta`)
    ON UPDATE CASCADE
    ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabela: coleta_dados_resposta_texto
-- Complementos textuais digitados pelo operador para respostas dissertativas
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `coleta_dados_resposta_texto`;
CREATE TABLE `coleta_dados_resposta_texto` (
  `id_coleta_dados_resposta_texto` INT NOT NULL AUTO_INCREMENT,
  `id_coleta_dados_resposta_fk` INT UNSIGNED NOT NULL,
  `texto` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id_coleta_dados_resposta_texto`),
  INDEX `idx_coleta_texto_resp` (`id_coleta_dados_resposta_fk`),
  CONSTRAINT `fk_coleta_dados_resp_texto`
    FOREIGN KEY (`id_coleta_dados_resposta_fk`)
    REFERENCES `coleta_dados_resposta` (`id_coleta_dados_resposta`)
    ON UPDATE CASCADE
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -----------------------------------------------------------------------------
-- Tabelas auxiliares opcionais: estado e cidade (suporte a autocomplete)
-- -----------------------------------------------------------------------------
DROP TABLE IF EXISTS `cidade`;
DROP TABLE IF EXISTS `estado`;

CREATE TABLE `estado` (
  `id_estado` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `uf` CHAR(2) NOT NULL,
  `id_pais_fk` INT UNSIGNED DEFAULT 1,
  PRIMARY KEY (`id_estado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE `cidade` (
  `id_cidade` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `id_estado_fk` INT UNSIGNED DEFAULT NULL,
  PRIMARY KEY (`id_cidade`),
  INDEX `idx_cidade_estado` (`id_estado_fk`),
  CONSTRAINT `fk_cidade_estado`
    FOREIGN KEY (`id_estado_fk`)
    REFERENCES `estado` (`id_estado`)
    ON UPDATE CASCADE
    ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

SET FOREIGN_KEY_CHECKS = 1;

-- -----------------------------------------------------------------------------
-- Triggers de integridade (úteis para MyISAM ou quando FKs são desabilitadas)
-- -----------------------------------------------------------------------------
DELIMITER //

DROP TRIGGER IF EXISTS `trg_apagar_respostas_se_apagar_questionario`//
CREATE TRIGGER `trg_apagar_respostas_se_apagar_questionario`
AFTER DELETE ON `coleta_dados_questionario`
FOR EACH ROW
BEGIN
  DELETE FROM `coleta_dados_resposta`
  WHERE `id_questionario_fk` = OLD.`id_questionario`;
END//

DROP TRIGGER IF EXISTS `trg_apagar_textos_se_apagar_resposta`//
CREATE TRIGGER `trg_apagar_textos_se_apagar_resposta`
AFTER DELETE ON `coleta_dados_resposta`
FOR EACH ROW
BEGIN
  DELETE FROM `coleta_dados_resposta_texto`
  WHERE `id_coleta_dados_resposta_fk` = OLD.`id_coleta_dados_resposta`;
END//

DELIMITER ;
