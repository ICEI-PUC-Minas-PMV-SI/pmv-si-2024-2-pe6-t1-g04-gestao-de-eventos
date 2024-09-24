## APIs e Web Services

<p align="justify"> Este projeto visa desenvolver um sistema web para gerenciar eventos realizados na PUC Minas Betim, utilizando uma arquitetura de microsserviços e o banco de dados PostgreSQL. Cada funcionalidade do sistema como cadastro de usuários, reserva de espaços, escolha de cursos responsáveis, solicitação de infraestrutura e outros será implementada como um serviço separado. Essa abordagem permite que cada microserviço seja escalado de forma autônoma e se comunique com os demais por meio de APIs.</p>

## Objetivos da API

### API Cadastro de Evento
**Objetivo:** Fornecer funcionalidades para o cadastro de eventos, destinado ao público interno da PUC Minas Betim. 
#### Recursos esperados:
- **Cadastro de Eventos por Curso:**
  Inclusão, alteração e exclusão do nome do evento, descrição, prazos, curso responsável, público-alvo, e informações sobre o local.
- **Cadastro de Eventos Institucionais:**
  Inclusão, alteração e exclusão do nome do evento, descrição, prazos, setor responsável, público-alvo, e informações sobre o local.

### API Usuário
**Objetivo:** Fornecer funcionalidades para a gestão do cadastro de usuários, destinado ao uso interno da PUC Minas.  
#### Recursos esperados:
- **Inclusão de Usuários:**
  Possibilitar o cadastro de usuários internos da PUC Minas, incluindo nome e e-mail com os domínios `@pucminas.br` e `@sga.pucminas.br`.

### API de Login
**Objetivo:** Realizar a autenticação e autorização de usuários do sistema.  
#### Recursos esperados:
- **Autenticação de Usuários:**
  Verificar as credenciais de login (usuário/senha).
- **Autorização de Acesso:**
  Controlar o acesso a recursos específicos com base nas permissões atribuídas aos usuários (alunos, funcionários, professores e administradores).

### API de Infraestrutura do Evento
**Objetivo:** Fornecer funcionalidades para solicitação de infraestrutura necessária para eventos.  
#### Recursos esperados:
- **Solicitação de Infraestrutura:**
  Inclusão de opções para solicitação de itens como café, água, forro, copos, mesas, cestos, estacionamento, entre outros.

### API de Setores
**Objetivo:** Fornecer funcionalidades para o cadastro do setor responsável pelo evento.  
#### Recursos esperados:
- **Cadastro de Setores:**
  Inclusão de opções dos setores da PUC Minas Betim para a seleção do setor responsável pelo evento.

### API de Cursos
**Objetivo:** Fornecer funcionalidades para o cadastro do curso responsável pelo evento.  
#### Recursos esperados:
- **Cadastro de Cursos:**
  Inclusão de opções dos cursos da PUC Minas Betim para a seleção do curso responsável pelo evento.

### API de Palestras
**Objetivo:** Fornecer funcionalidades para o cadastro de palestras em eventos.  
#### Recursos esperados:
- **Cadastro de Palestras:**
  Inclusão de campos como título, horário, local e número de vagas disponíveis para a palestra.

## Arquitetura

<p align="justify"> </p>

[Descrição da arquitetura das APIs, incluindo os componentes e suas interações.]

### Modelagem da Aplicação

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/Gest%C3%A3o%20de%20eventos.drawio.png" alt="Diagrama de Entidade de Relacionamento">
</p>

<p align="center">Figura 1 - Diagrama de Entidade de Relacionamento </p>

## Fluxo de Dados

[Diagrama ou descrição do fluxo de dados na aplicação.]

## Requisitos Funcionais

# Requisitos Funcionais do Setor de Eventos

| ID     | Descrição do Requisito                                                                                  | Prioridade |
|--------|---------------------------------------------------------------------------------------------------------|------------|
| RF-01  | Permitir que o usuário faça login utilizando um e-mail com domínio `@pucminas.br`.                       | Alta       |
| RF-02  | Permitir que o usuário registre seus dados pessoais, incluindo: Nome, Código de pessoa, E-mail, Telefone. | Alta       |
| RF-03  | Permitir que o usuário cadastre eventos institucionais, inserindo: Nome do evento, Descrição do evento.   | Alta       |
| RF-04  | Permitir que o usuário cadastre eventos de graduação, inserindo: Nome do evento, Descrição do evento.     | Alta       |
| RF-05  | Permitir que o usuário registre palestras relacionadas aos eventos.                                       | Alta       |
| RF-06  | Permitir que o usuário solicite materiais e recursos de infraestrutura para os eventos.                   | Alta       |
| RF-07  | Permitir que o usuário edite as informações da solicitação do evento previamente cadastradas.             | Alta       |
| RF-08  | Exibir notificações detalhadas sobre o status e atualizações do evento.                                   | Média      |


[Liste os principais requisitos funcionais da aplicação.]

## Requisitos Não Funcionais

[Liste os principais requisitos não funcionais da aplicação, como desempenho, segurança, escalabilidade, etc.]

## Tecnologias Utilizadas

- **Linguagem de Programação**: C# (.NET)
- **Framework**: .NET 8/9
- **Banco de Dados**: PostgreSQL
- **API**: ASP.NET Core Web API
- **Documentação de API**: Swagger para documentação automática e interface de teste de APIs
- **IDE de Desenvolvimento**: Visual Studio 2022
- **Ferramentas de Versionamento**: Git, usando GitHub


## API Endpoints

[Liste os principais endpoints da API, incluindo as operações disponíveis, os parâmetros esperados e as respostas retornadas.]

### Endpoint 1
- Método: GET
- URL: /endpoint1
- Parâmetros:
  - param1: [descrição]
- Resposta:
  - Sucesso (200 OK)
    ```
    {
      "message": "Success",
      "data": {
        ...
      }
    }
    ```
  - Erro (4XX, 5XX)
    ```
    {
      "message": "Error",
      "error": {
        ...
      }
    }
    ```


## Considerações de Segurança

[Discuta as considerações de segurança relevantes para a aplicação distribuída, como autenticação, autorização, proteção contra ataques, etc.]

## Implantação

[Instruções para implantar a aplicação distribuída em um ambiente de produção.]

1. Defina os requisitos de hardware e software necessários para implantar a aplicação em um ambiente de produção.
2. Escolha uma plataforma de hospedagem adequada, como um provedor de nuvem ou um servidor dedicado.
3. Configure o ambiente de implantação, incluindo a instalação de dependências e configuração de variáveis de ambiente.
4. Faça o deploy da aplicação no ambiente escolhido, seguindo as instruções específicas da plataforma de hospedagem.
5. Realize testes para garantir que a aplicação esteja funcionando corretamente no ambiente de produção.

## Testes

[Descreva a estratégia de teste, incluindo os tipos de teste a serem realizados (unitários, integração, carga, etc.) e as ferramentas a serem utilizadas.]

1. Crie casos de teste para cobrir todos os requisitos funcionais e não funcionais da aplicação.
2. Implemente testes unitários para testar unidades individuais de código, como funções e classes.
3. Realize testes de integração para verificar a interação correta entre os componentes da aplicação.
4. Execute testes de carga para avaliar o desempenho da aplicação sob carga significativa.
5. Utilize ferramentas de teste adequadas, como frameworks de teste e ferramentas de automação de teste, para agilizar o processo de teste.

# Referências

Inclua todas as referências (livros, artigos, sites, etc) utilizados no desenvolvimento do trabalho.
