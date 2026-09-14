-- =============================================================================
-- Carga Inicial de Dados do Sistema (Seed)
-- Apenas dados estruturais do sistema (sem dados comerciais ou marcas)
-- =============================================================================

USE `survey_db`;

-- -----------------------------------------------------------------------------
-- Tipos de resposta suportados pela aplicação
-- -----------------------------------------------------------------------------
INSERT INTO `tipo_resposta` (`id_tipo_resposta`, `nomenclatura`, `estado_ativo`) VALUES
(1, 'Único Sem Texto', 's'),
(2, 'Único Com Texto', 's'),
(3, 'Multiescolha Quantitativa', 's')
ON DUPLICATE KEY UPDATE `nomenclatura` = VALUES(`nomenclatura`), `estado_ativo` = VALUES(`estado_ativo`);

-- -----------------------------------------------------------------------------
-- Unidades Federativas do Brasil (suporte para respostas geográficas)
-- -----------------------------------------------------------------------------
INSERT INTO `estado` (`id_estado`, `nome`, `uf`, `id_pais_fk`) VALUES
(1, 'Acre', 'AC', 1),
(2, 'Alagoas', 'AL', 1),
(3, 'Amapá', 'AP', 1),
(4, 'Amazonas', 'AM', 1),
(5, 'Bahia', 'BA', 1),
(6, 'Ceará', 'CE', 1),
(7, 'Distrito Federal', 'DF', 1),
(8, 'Espírito Santo', 'ES', 1),
(9, 'Goiás', 'GO', 1),
(10, 'Maranhão', 'MA', 1),
(11, 'Mato Grosso', 'MT', 1),
(12, 'Mato Grosso do Sul', 'MS', 1),
(13, 'Minas Gerais', 'MG', 1),
(14, 'Pará', 'PA', 1),
(15, 'Paraíba', 'PB', 1),
(16, 'Paraná', 'PR', 1),
(17, 'Pernambuco', 'PE', 1),
(18, 'Piauí', 'PI', 1),
(19, 'Rio de Janeiro', 'RJ', 1),
(20, 'Rio Grande do Norte', 'RN', 1),
(21, 'Rio Grande do Sul', 'RS', 1),
(22, 'Rondônia', 'RO', 1),
(23, 'Roraima', 'RR', 1),
(24, 'Santa Catarina', 'SC', 1),
(25, 'São Paulo', 'SP', 1),
(26, 'Sergipe', 'SE', 1),
(27, 'Tocantins', 'TO', 1)
ON DUPLICATE KEY UPDATE `nome` = VALUES(`nome`), `uf` = VALUES(`uf`);
