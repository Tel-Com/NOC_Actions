# NOC_Actions

Repositório oficial para automações e ferramentas de suporte ao NOC (Network Operation Center), utilizando .NET e arquitetura baseada em módulos de interface (WinForms/UserControls) para gerenciamento operacional.

## Índice

- [Visão Geral](#visão-geral)
- [Estrutura dos arquivos](#estrutura-dos-arquivos)
- [Funcionalidades](#funcionalidades-principais)
- [Como usar](#como-usar)
- [Histórico de Atualizações](#histórico-de-atualizações)
- [Build & Execução](#build--execução)
- [Colaboradores](#colaboradores)

---

## Visão Geral

O **NOC_Actions** é um sistema destinado à automação de processos, gestão de eventos operacionais e integração de painéis informativos relacionados ao setor de NOC. Possui múltiplos módulos independentes, facilitando manutenção e expansão.

- **Plataforma:** .NET/WinForms
- **Organização:** Módulos com UserControls (arquivos Uc*)
- **Propósito:** Agilizar respostas, gerar relatórios, consolidar eventos e dados de clientes, faturamento, reparos e alarmes.

---

## Estrutura dos Arquivos

**Formulários & UserControls**
- `MainForm.cs`: Formulário principal
- `LoginUser.cs`: Interface de login/autenticação
- `Informes.cs`: Interface de relatórios
- `MassivaForm.cs` / `MassivaMenuConfigurations.cs`: Operações massivas
- Diversos arquivos a partir do prefixo `Uc*` (ex: `UcAberturaReparo`, `UcAlarmeDeLinkIndisponivel`, `UcDetalharFaturaDoCliente`, etc): Cada um representa um módulo de interface/ação específico

**Recursos (.resx)**
- Para cada módulo/UI há arquivos `.resx` equivalentes, centralizando textos, imagens e internacionalização.

**Projetos e Soluções**
- `NOC_Actions.csproj`, `NOCActions.sln`, `NOC_Actions.sln`: Arquivos padrão de configuração do projeto .NET.

**Diretórios**
- `bin/`, `obj/`: Diretórios de build.
- `.github/`: Workflows para automação CI/CD.
- `Properties/`: Configurações globais do projeto.

**Histórico**
- `registroDeAtt.txt`: Histórico de atualizações, bugs e melhorias.

---

## Funcionalidades Principais

- **Autenticação de usuário**
- **Abertura e detalhamento de reparos**
- **Alarmes operacionais de rede**
- **Gerenciamento de faturamento**
- **Relatórios e informes para clientes e equipe**
- **Gestão de pendências financeiras**
- **Operações de liberação de acesso (com e sem previsão)**
- **Gestão de eventos de energia e armazenamento de dados**

Cada funcionalidade conta com seus próprios formulários e módulos, facilitando a customização e evolução do código.

---

## Como Usar

1. **Clone o repositório:**  
   ```shell
   git clone https://github.com/devsantiag/NOC_Actions.git
   ```

2. **Abra a solução (.sln) no Visual Studio** (ou IDE de preferência que suporte WinForms/.NET).

3. **Configure dependências** caso necessário (verifique o arquivo `.csproj` para versões/referências).

4. **Compile e execute** o projeto.

---

## Histórico de Atualizações

Consulte o arquivo [registroDeAtt.txt](https://github.com/devsantiag/NOC_Actions/blob/main/registroDeAtt.txt) para ver logs de alterações, adições principais, correções e roadmap.

---

## Build & Execução

- É recomendado usar o Visual Studio 2019+ ou compatível com o target do projeto.
- Processo padrão via F5 ou `Build > Build Solution`.
- Projetos/diretórios auxiliares devem permanecer conforme a estrutura original.

---

## Colaboradores

- **devsantiag** (owner)
- Para contribuir, abra Issues ou Pull Requests com descrições claras.
- Sugestões podem ser discutidas via Issues e registro de atualizações.

---

> **Obs.:** Esta documentação cobre os principais módulos e estrutura com base nos arquivos visíveis. Para detalhes específicos de cada UserControl/módulo, consulte os respectivos arquivos ou faça uma busca direta no repository: [NOC_Actions Files](https://github.com/devsantiag/NOC_Actions).
