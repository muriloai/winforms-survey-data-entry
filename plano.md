# Plano -- Restauração do Sistema de Coleta de Pesquisas (WinForms + MySQL)

## 1. Contexto

Este repositório continha em `.refs/` o código-fonte legado de um sistema desktop desenvolvido em C# WinForms (.NET Framework) com banco de dados MySQL. O sistema permite cadastrar clientes, formulários de pesquisa, perguntas, respostas, postos de coleta e aplicar questionários em campo, além de contabilizar resultados por meio de views no banco.

O objetivo foi trazer esse sistema para a raiz do repositório de forma limpa e funcional, gerar o script SQL de criação do banco e documentar tudo com um README profissional sem emojis e sem citações a marcas ou empresas legadas.

---

## 2. Estrutura das Fases Executadas

### Fase 1 -- Organização do Código-Fonte na Raiz
- Estruturação em `src/SurveyDataEntry/` com solução `src/SurveyDataEntry.sln`.
- Configuração de referências locais em `src/SurveyDataEntry/lib/MySql.Data.dll`, eliminando caminhos absolutos como `D:\...`.
- Inclusão do arquivo `.gitignore` para o Visual Studio e artefatos de compilação.

### Fase 2 -- Scripts SQL (`database/`)
- `database/01_schema.sql`: DDL completo do banco `survey_db` (`utf8mb4`) com 11 tabelas, chaves primárias, integridade referencial com `FOREIGN KEY ... ON DELETE CASCADE` e triggers.
- `database/02_views.sql`: Views analíticas de tabulação (`parteum_...`, `partedois_...`, `partetres_...` e `contabilizar_resultados_unificados`).
- `database/03_seed_tipos.sql`: Carga inicial dos 3 tipos estruturais de resposta e das UFs brasileiras para autocompletar.

### Fase 3 -- README Profissional
- `README.md` redigido com padrão técnico, sem emojis e sem referências a marcas comerciais do software legado.

### Fase 4 -- Melhorias Implementadas
1. **Namespace Unificado**: Atualização completa de `dataChico_tabulador_pesquisas` para `SurveyDataEntry`.
2. **Externalização da String de Conexão**: Suporte nativo a `connectionStrings` e `userSettings` no `app.config`, com persistência via `Properties.Settings.Default.Save()`.
3. **Prevenção de Vazamento de Conexão e Leitores**: Uso de `using (MySqlCommand ...)` e `using (MySqlDataReader ...)` em `camada_dados.cs` e eliminação de campos compartilhados.
4. **Eliminação de Execuções Redundantes**: Removido o `ExecuteNonQuery()` desnecessário antes de `ExecuteReader()`.
5. **Parametrização Total das Consultas**: Consultas protegidas contra SQL Injection utilizando parâmetros tipados (`@param`).
6. **Validação de Formulários**: Validação de campos obrigatórios e conversão segura de tipos em todas as telas de cadastro.
7. **Identidade Visual Neutra e Substituição de Imagens de Marcas**:
   - `logo_dtChico.png` substituído por `logo_survey.png` (801x559 px).
   - `chico_001.png` substituído por `survey_hero.png` (902x1852 px).
   - Título da janela principal padronizado para `"Survey Data Entry - Tabulador de Pesquisas"`.
   - Credenciais de acesso administrativo padronizadas para `admin` / `admin`.

---

## 3. Status de Validação

- Compilação limpa no MSBuild para configurações `Debug` e `Release` com 0 erros e 0 avisos.
