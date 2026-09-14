-- =============================================================================
-- Views de Tabulação e Consolidação de Resultados
-- =============================================================================

USE `survey_db`;

-- -----------------------------------------------------------------------------
-- View: parteum_somenterespostatipoum_contabilizarresultados
-- Contabilização de respostas de escolha única sem texto (tipo 1)
-- -----------------------------------------------------------------------------
CREATE OR REPLACE VIEW `parteum_somenterespostatipoum_contabilizarresultados` AS
SELECT 
    `pf`.`id_formulario` AS `id_formulario`,
    `pf`.`posicao_noFormulario` AS `posicao_noFormulario`,
    CONCAT(`pf`.`posicao_noFormulario`, '. ', `pf`.`nomenclatura`) AS `pergunta`,
    `rp`.`nomenclatura` AS `resposta`,
    COUNT(`cdr`.`id_coleta_dados_resposta`) AS `qtd_respondida`,
    `rp`.`id_tipo_resposta_fk` AS `id_tipo_resposta_fk`,
    `cdrt`.`texto` AS `texto`
FROM `pergunta_formulario` `pf`
INNER JOIN `resposta_pergunta` `rp` 
    ON `rp`.`id_pergunta` = `pf`.`id_pergunta`
LEFT JOIN `coleta_dados_resposta` `cdr` 
    ON `cdr`.`id_resposta_fk` = `rp`.`id_resposta`
LEFT JOIN `coleta_dados_resposta_texto` `cdrt` 
    ON `cdrt`.`id_coleta_dados_resposta_fk` = `cdr`.`id_coleta_dados_resposta`
WHERE `pf`.`estado_ativo` = 's' 
  AND `rp`.`id_tipo_resposta_fk` = 1
GROUP BY `pf`.`id_formulario`, `pf`.`posicao_noFormulario`, `pf`.`nomenclatura`, `rp`.`id_resposta`, `rp`.`nomenclatura`, `rp`.`id_tipo_resposta_fk`, `cdrt`.`texto`;

-- -----------------------------------------------------------------------------
-- View: partedois_somenterespostatipodois_contabilizarresultados
-- Contabilização de respostas com texto dissertativo livre (tipo 2)
-- -----------------------------------------------------------------------------
CREATE OR REPLACE VIEW `partedois_somenterespostatipodois_contabilizarresultados` AS
SELECT 
    `pf`.`id_formulario` AS `id_formulario`,
    `pf`.`posicao_noFormulario` AS `posicao_noFormulario`,
    CONCAT(`pf`.`posicao_noFormulario`, '. ', `pf`.`nomenclatura`) AS `pergunta`,
    `rp`.`nomenclatura` AS `resposta`,
    COUNT(`cdr`.`id_coleta_dados_resposta`) AS `qtd_respondida`,
    `rp`.`id_tipo_resposta_fk` AS `id_tipo_resposta_fk`,
    `cdrt`.`texto` AS `texto`
FROM `pergunta_formulario` `pf`
INNER JOIN `resposta_pergunta` `rp` 
    ON `rp`.`id_pergunta` = `pf`.`id_pergunta`
LEFT JOIN `coleta_dados_resposta` `cdr` 
    ON `cdr`.`id_resposta_fk` = `rp`.`id_resposta`
LEFT JOIN `coleta_dados_resposta_texto` `cdrt` 
    ON `cdrt`.`id_coleta_dados_resposta_fk` = `cdr`.`id_coleta_dados_resposta`
WHERE `pf`.`estado_ativo` = 's' 
  AND `rp`.`id_tipo_resposta_fk` = 2
GROUP BY `pf`.`id_formulario`, `pf`.`posicao_noFormulario`, `pf`.`nomenclatura`, `rp`.`nomenclatura`, `rp`.`id_tipo_resposta_fk`, `cdrt`.`texto`;

-- -----------------------------------------------------------------------------
-- View: partetres_somenterespostatipotres_contabilizarresultados
-- Contabilização de respostas de múltipla escolha quantitativa (tipo 3)
-- -----------------------------------------------------------------------------
CREATE OR REPLACE VIEW `partetres_somenterespostatipotres_contabilizarresultados` AS
SELECT 
    `pf`.`id_formulario` AS `id_formulario`,
    `pf`.`posicao_noFormulario` AS `posicao_noFormulario`,
    CONCAT(`pf`.`posicao_noFormulario`, '. ', `pf`.`nomenclatura`) AS `pergunta`,
    `rp`.`nomenclatura` AS `resposta`,
    COUNT(`cdr`.`id_coleta_dados_resposta`) AS `qtd_respondida`,
    `rp`.`id_tipo_resposta_fk` AS `id_tipo_resposta_fk`,
    `cdrt`.`texto` AS `texto`
FROM `pergunta_formulario` `pf`
INNER JOIN `resposta_pergunta` `rp` 
    ON `rp`.`id_pergunta` = `pf`.`id_pergunta`
LEFT JOIN `coleta_dados_resposta` `cdr` 
    ON `cdr`.`id_resposta_fk` = `rp`.`id_resposta`
LEFT JOIN `coleta_dados_resposta_texto` `cdrt` 
    ON `cdrt`.`id_coleta_dados_resposta_fk` = `cdr`.`id_coleta_dados_resposta`
WHERE `pf`.`estado_ativo` = 's' 
  AND `rp`.`id_tipo_resposta_fk` = 3
GROUP BY `pf`.`id_formulario`, `pf`.`posicao_noFormulario`, `pf`.`nomenclatura`, `rp`.`id_resposta`, `rp`.`nomenclatura`, `rp`.`id_tipo_resposta_fk`, `cdrt`.`texto`;

-- -----------------------------------------------------------------------------
-- View: contabilizar_resultados_unificados
-- Visão consolidada de todos os tipos de respostas unificadas por formulário
-- -----------------------------------------------------------------------------
CREATE OR REPLACE VIEW `contabilizar_resultados_unificados` AS
SELECT * FROM `parteum_somenterespostatipoum_contabilizarresultados`
UNION ALL
SELECT * FROM `partedois_somenterespostatipodois_contabilizarresultados`
UNION ALL
SELECT * FROM `partetres_somenterespostatipotres_contabilizarresultados`;
