# Plano -- Restauração e Modernização do Sistema de Coleta de Pesquisas (WinForms + SQLite)

## 1. Contexto

Este repositório continha em `.refs/` o código-fonte legado de um sistema desktop desenvolvido em C# WinForms (.NET Framework). O sistema permite cadastrar clientes, formulários de pesquisa, perguntas, respostas, postos de coleta e aplicar questionários em campo, além de contabilizar resultados por meio de views no banco de dados.

O objetivo foi trazer esse sistema para a raiz do repositório de forma limpa e funcional, refatorar a camada de dados para SQLite eliminando qualquer dependência de servidores externos (como MySQL), garantir auto-inicialização na primeira execução e documentar tudo com um README profissional sem emojis e sem citações a marcas ou empresas legadas.

---

## 2. Estrutura das Fases Executadas

### Fase 1 -- Organização do Código-Fonte na Raiz
- Estruturação em `src/SurveyDataEntry/` com solução `src/SurveyDataEntry.sln`.
- Eliminação de caminhos absolutos locais legados.
- Inclusão do arquivo `.gitignore` configurado para o Visual Studio, artefatos de compilação e bases SQLite (`*.db`, `*.db-journal`).

### Fase 2 -- Scripts SQL e Migração Estrutural (`database/`)
- `database/01_schema.sql`: DDL completo para SQLite com 11 tabelas, chaves primárias autoincrementais (`INTEGER PRIMARY KEY AUTOINCREMENT`), integridade referencial com chaves estrangeiras ativas (`PRAGMA foreign_keys = ON;`) e triggers para integridade de deleção.
- `database/02_views.sql`: Views analíticas de tabulação adaptadas para o padrão SQLite (usando concatenação padrão `||`).
- `database/03_seed_tipos.sql`: Carga inicial dos 3 tipos estruturais de resposta e das UFs brasileiras para autocompletar (`INSERT OR IGNORE`).

### Fase 3 -- README Profissional
- `README.md` redigido com padrão técnico corporativo, sem emojis e sem referências a marcas comerciais do software legado.

### Fase 4 -- Melhorias Arquiteturais Implementadas
1. **Namespace Unificado**: Atualização completa de `dataChico_tabulador_pesquisas` para `SurveyDataEntry`.
2. **Externalização da String de Conexão**: Suporte nativo a `connectionStrings` e `userSettings` no `app.config`, com persistência via `Properties.Settings.Default.Save()`.
3. **Prevenção de Vazamento de Conexão e Leitores**: Uso de blocos `using (SQLiteCommand ...)` e `using (SQLiteDataReader ...)`.
4. **Eliminação de Execuções Redundantes**: Removido o `ExecuteNonQuery()` desnecessário antes de `ExecuteReader()`.
5. **Parametrização Total das Consultas**: Consultas protegidas contra SQL Injection utilizando parâmetros tipados (`@param`).
6. **Validação de Formulários**: Validação de campos obrigatórios e conversão segura de tipos em todas as telas de cadastro.
7. **Identidade Visual Neutra e Substituição de Imagens de Marcas**:
   - `logo_dtChico.png` substituído por `logo_survey.png` (801x559 px).
   - `chico_001.png` substituído por `survey_hero.png` (902x1852 px).
   - Título da janela principal padronizado para `"Survey Data Entry - Tabulador de Pesquisas"`.
   - Credenciais de acesso administrativo padronizadas para `admin` / `admin`.

### Fase 5 -- Refinamento Visual de Layout e Documentação Fotográfica
1. **Modernização Tipográfica e Cromática**: Adoção de Segoe UI, paleta corporativa neutra (Slate / Blue) e botões planos com feedback visual.
2. **Reestruturação dos Formulários**:
   - `frm_menu`: Top bar corporativa com indicadores de status, cartões de ação e painel deslizante de gestão.
   - `frm_acesso_restrito`: Caixa de diálogo modal compacta com foco automático e atalhos de confirmação/cancelamento.
   - `frm_seletor`: Diálogo seletor redimensionado para proporções amigáveis.
   - `frm_cadastrar_*`: Telas de cadastro (Cliente, Posto, Formulário, Pergunta, Resposta) com cabeçalhos padronizados e eliminação de larguras excessivas.
   - `frm_responder_pesquisa` & `resposta`: Substituição de gradientes antigos por cartões de resposta claros com destaque em azul quando assinalados.
   - `tela_final`: Tela de confirmação com cartão centralizado e opções claras de navegação.
3. **Automação de Captura de Telas (`scripts/capture_screenshots.ps1`)**: Script para renderização e exportação off-screen dos formulários para PNG em alta definição na pasta `docs/screenshots/`.
4. **Atualização do `README.md`**: Inclusão da seção visual completa com todas as capturas de tela e tabelas descritivas.

### Fase 6 -- Migração Completa para SQLite
1. **Substituição de Provedor de Dados**:
   - Remoção de `MySql.Data.dll`.
   - Adição da biblioteca oficial `System.Data.SQLite` (.NET Framework 4.8) com seus módulos nativos `x86/SQLite.Interop.dll` e `x64/SQLite.Interop.dll` configurados no `.csproj` para cópia automática na pasta de saída.
2. **Auto-inicialização de Banco de Dados (`ConexaoBD.cs`)**:
   - Detecção automática da presença de `survey.db`. Caso o arquivo não exista ou esteja com 0 bytes, a classe cria e executa automaticamente as tabelas, triggers, views e dados semente (seed) embutidos, permitindo execução direta sem configurações prévias.
   - Suporte a execução silenciosa para testes e scripts (`ConexaoBD.Silencioso`).
   - Resolução robusta de diretórios de base para execução em tempo de execução, scripts e testes de integração.
3. **Adequação da Camada de Acesso a Dados (`camada_dados.cs` e `frm_responder_pesquisa.cs`)**:
   - Conversão de todas as classes para a família `SQLite*` (`SQLiteConnection`, `SQLiteCommand`, `SQLiteDataReader`, `SQLiteTransaction`).
   - Criação de métodos auxiliares seguros (`safeGetInt32`, `safeGetString`, `safeGetChar`) para tratamento de tipos numéricos e textuais nativos do SQLite.
   - Atualização da função de recuperação do identificador gerado de `SELECT LAST_INSERT_ID()` para `SELECT last_insert_rowid();`.
   - Atualização de data do sistema de `CURDATE()` para `DATE('now')`.
   - Ajuste de parâmetros booleanos para texto explícito (`"s"` e `"n"`), garantindo correspondência com constraints do SQLite.
4. **Indicador Visual na Interface**:
   - Atualização do selo de status da barra superior em `frm_menu` para `"● SQLite: survey.db"`.
5. **Atualização de Capturas de Tela**:
   - Execução do script automatizado para regerar todas as imagens de demonstração refletindo o novo status do SQLite.

---

## 3. Status de Validação

- Compilação limpa no MSBuild para configurações `Debug` e `Release` com 0 erros e 0 avisos.
- Verificação funcional com teste de integração automatizado cobrindo criação de base, inserções relacionais, transações atômicas e consultas em cascata.
- Geração completa e automatizada dos 10 prints demonstrativos em `docs/screenshots/`.
