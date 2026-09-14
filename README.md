# Survey Data Entry

Sistema desktop de 2018 feito em Windows Forms (C# / .NET Framework) integrado ao banco de dados MySQL para coleta, controle e tabulação de pesquisas quantitativas e qualitativas de campo.

---

## 1. Visão Geral

O Survey Data Entry foi desenvolvido para gerenciar o ciclo operacional de pesquisas presenciais: desde o cadastramento de formulários e questionários estruturados até a aplicação das entrevistas em postos de coleta e a consolidação dos resultados tabulados.

A arquitetura desacopla a camada de persistência através de rotinas otimizadas com comandos SQL parametrizados e controle transacional, garantindo integridade dos dados durante a aplicação simultânea de questionários.

---

## 2. Principais Funcionalidades

- **Gestão de Clientes Solicitantes**: Cadastro e manutenção de clientes demandantes de pesquisas.
- **Estruturação de Formulários**: Criação de questionários associados a clientes com prazos de entrega e controle de status.
- **Definição Dinâmica de Perguntas**: Suporte a ordem/sequência de apresentação, obrigatoriedade de preenchimento e limite máximo de alternativas assinaladas.
- **Tipos de Resposta Suportados**:
  - Escolha única sem campo aberto.
  - Escolha única com campo dissertativo (texto complementar livre).
  - Múltipla escolha quantitativa / escala de avaliação.
- **Controle de Postos de Coleta**: Mapeamento de unidades e locais físicos de coleta de dados.
- **Módulo de Aplicação de Pesquisas**: Interface de preenchimento ágil para operadores com suporte a navegação por teclado, atalhos rápidos e autocompletar.
- **Controle Transacional de Gravação**: Gravação atômica do questionário e de suas respostas filhas via transações MySQL (commit/rollback automático).
- **Consolidação e Tabulação de Resultados**: Views SQL para apuração estatística e contagem de respostas agrupadas por tipo.
- **Área Restrita Administrativa**: Acesso protegido por autenticação para gestão estrutural do sistema.
- **Configuração Dinâmica de Conexão**: Interface para ajuste do servidor de banco de dados diretamente pelo menu ou via arquivo de configuração.

---

## 3. Pré-requisitos

Para compilação e execução do projeto em ambiente Windows:

- **Sistema Operacional**: Windows 7 SP1, Windows 10, Windows 11 ou Windows Server 2012+
- **.NET Framework**: Versão 4.8 (ou compatível com .NET 3.5+)
- **IDE / Compilador**: Visual Studio 2017 / 2019 / 2022 ou MSBuild v15.0+
- **Banco de Dados**: MySQL Server 5.5 ou superior, ou MariaDB 10.0 ou superior
- **Driver de Conexão**: MySQL Connector/NET (`MySql.Data.dll` v6.9+, já incluído localmente em `src/SurveyDataEntry/lib/`)

---

## 4. Configuração do Banco de Dados

Os scripts SQL necessários para a criação do banco de dados, estrutura de tabelas, integridade referencial, views de tabulação e carga inicial encontram-se na pasta `database/`.

Execute os scripts na ordem numérica indicada abaixo:

### Passo 1: Criação do Schema e Tabelas

Execute o script `database/01_schema.sql` no cliente MySQL (MySQL Workbench, DBeaver, HeidiSQL ou CLI):

```bash
mysql -u root -p < database/01_schema.sql
```

Este script cria:

- A base de dados `survey_db` com codificação `utf8mb4`.
- Todas as tabelas relacionais com chaves primárias, índices e constraints `FOREIGN KEY` em cascata.
- Triggers de integridade para deleção em cascata.

### Passo 2: Criação das Views de Tabulação

Execute o script `database/02_views.sql`:

```bash
mysql -u root -p < database/02_views.sql
```

Este script cria as views analíticas:

- `parteum_somenterespostatipoum_contabilizarresultados`
- `partedois_somenterespostatipodois_contabilizarresultados`
- `partetres_somenterespostatipotres_contabilizarresultados`
- `contabilizar_resultados_unificados`

### Passo 3: Carga Inicial Estrutural (Seed)

Execute o script `database/03_seed_tipos.sql`:

```bash
mysql -u root -p < database/03_seed_tipos.sql
```

Este script popula a tabela de tipos de resposta com as definições essenciais do sistema e os estados para autocompletar geográfico.

---

## 5. Configuração da Aplicação

A conexão com o banco de dados pode ser ajustada de duas formas:

### Opção A: Via Arquivo `app.config`

Abra o arquivo `src/SurveyDataEntry/app.config` e configure a string de conexão ou as propriedades de usuário:

```xml
<connectionStrings>
    <add name="SurveyDbConnection"
         connectionString="Server=localhost;Database=survey_db;Uid=root;Pwd=;"
         providerName="MySql.Data.MySqlClient" />
</connectionStrings>

<userSettings>
    <SurveyDataEntry.Properties.Settings>
        <setting name="serverLocal" serializeAs="String">
            <value>localhost</value>
        </setting>
        <setting name="bdNome" serializeAs="String">
            <value>survey_db</value>
        </setting>
        <setting name="usuario1" serializeAs="String">
            <value>root</value>
        </setting>
        <setting name="senha1" serializeAs="String">
            <value></value>
        </setting>
    </SurveyDataEntry.Properties.Settings>
</userSettings>
```

### Opção B: Pela Interface do Sistema

1. Na tela principal, localize o painel de configuração do servidor no rodapé.
2. Informe o hostname ou endereço IP do servidor MySQL (por exemplo: `localhost` ou `192.168.1.100`).
3. Clique em **Aplicar!** para salvar a configuração permanentemente.

### Credenciais Padrão de Acesso Administrativo

Para liberar os botões de cadastro na tela principal:

- Dê um duplo-clique no ícone de cadeado.
- Usuário: `admin`
- Senha: `admin` (ou `admin123`)

---

## 6. Compilação e Execução

### Via Visual Studio

1. Abra a solução `src/SurveyDataEntry.sln` no Visual Studio.
2. Selecione a configuração desejada (`Debug` ou `Release`) e a plataforma `Any CPU`.
3. Pressione **Ctrl + Shift + B** para compilar a solução.
4. Pressione **F5** para iniciar a execução.

### Via Linha de Comando (MSBuild)

Abra o prompt de comando do Visual Studio ou o PowerShell e execute:

```powershell
msbuild src\SurveyDataEntry.sln /p:Configuration=Release
```

O executável binário final estará disponível em:
`src/SurveyDataEntry/bin/Release/SurveyDataEntry.exe`

---

## 7. Estrutura do Repositório

```
.
|-- .gitignore                  # Regras de exclusao do Git para artefatos e binarios
|-- README.md                   # Documentacao tecnica do projeto
|-- plano.md                    # Planejamento e registro de execucao das etapas
|-- database/                   # Scripts SQL para implantacao do banco de dados
|   |-- 01_schema.sql           # DDL: definicao de tabelas, chaves e constraints
|   |-- 02_views.sql            # Views para tabulacao e consolidacao de respostas
|   `-- 03_seed_tipos.sql       # Dados estruturais iniciais (tipos de resposta, estados)
`-- src/                        # Codigo-fonte da aplicacao
    |-- SurveyDataEntry.sln     # Arquivo de solucao do Visual Studio
    `-- SurveyDataEntry/        # Projeto C# Windows Forms
        |-- SurveyDataEntry.csproj # Configuracao de build do projeto
        |-- app.config          # Configuracoes de conexao e parametros
        |-- Program.cs          # Ponto de entrada do executavel
        |-- conexaoBD.cs        # Gerenciamento de conexoes MySQL
        |-- camada_dados.cs     # Camada de acesso a dados (consultas parametrizadas)
        |-- objeto_*.cs         # Entidades de dominio e modelos de dados
        |-- frm_*.cs            # Formularios de interface com usuario e logica de telas
        |-- resposta.cs         # Controle de usuario para renderizacao de alternativas
        |-- tela_final.cs       # Tela de conclusao da aplicacao de questionario
        |-- lib/                # Dependencias binarias locais (MySql.Data.dll)
        |-- Properties/         # Metadados de montagem, recursos e settings
        `-- Resources/          # Ativos visuais e icones de suporte
```

---

## 8. Modelo de Dados Relacional

```
[ cliente_requerente ]
       | 1
       |
       | N
[ formulario_pesquisa ]
       | 1
       |
       +-------------------------------+
       | N                             | N
[ pergunta_formulario ]     [ coleta_dados_questionario ] <--- [ coleta_posto ]
       | 1                             | 1
       |                               |
       | N                             | N
[ resposta_pergunta ] <-----+      [ coleta_dados_resposta ]
   (tipo_resposta)          |          | 1
                            +----------+
                                       | N
                            [ coleta_dados_resposta_texto ]
```

---
