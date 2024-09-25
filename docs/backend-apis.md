## APIs e Web Services

<p align="justify"> Este projeto visa desenvolver um sistema web para gerenciar eventos realizados na PUC Minas Betim, utilizando uma arquitetura monolítica e o banco de dados PostgreSQL. Cada funcionalidade do sistema como cadastro de usuários, reserva de espaços, escolha de cursos, solicitação de infraestrutura e outros será implementada como um serviço. </p>

## Objetivos da API

#### API Gestão de Eventos:
**Objetivo:** Prover funcionalidades para gerenciar eventos, voltado ao público interno da PUC Minas Betim. 

- **Cadastro de Eventos:**
  Inclusão, alteração e exclusão de nome, descrição e demais informações do evento.
- **Cadastro de usuário:**
  Inclusão, alteração, exclusão e autenticação de usuários internos.
- **Cadastro de cursos:**
 Inclusão, alteração e exclusão de cursos relacionados ao evento. 
- **Cadastro de setor:**
  Inclusão, alteração e exclusão de setores responsáveis pelo evento.
- **Cadastro de infraestrutura:**
  Inclusão, alteração e exclusão de materiais e recursos solicitados para os eventos.
- **Cadastro de palestra:**
  Inclusão, alteração e exclusão de palestras, com informações como título, horário e local.

## Arquitetura

<p align="justify"> A arquitetura monolítica do sistema de Gestão de Eventos da PUC Minas Betim centraliza todas as funcionalidades, como o cadastro de usuários, reserva de espaços, escolha de cursos, solicitação de infraestrutura e outros, em uma única aplicação. Todas as funcionalidades e componentes são integrados em um único bloco de código e compartilham o mesmo ambiente de execução. </p>

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/Arquitetura%20do%20API.jpg" alt="Arquitetura da API">
</p>

<p align="center">Figura 1 - Arquitetura da API </p>

### Modelagem da Aplicação

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/Gest%C3%A3o%20de%20eventos%20v2.jpg" alt="Diagrama de Entidade de Relacionamento">
</p>

<p align="center">Figura 2 - Diagrama de Entidade de Relacionamento </p>

## Fluxo de Dados

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/Fluxo%20API.jpg" alt="Fluxo de dados da API">
</p>

<p align="center">Figura 3 - Fluxo de dados da API </p>

## Requisitos Funcionais do Setor de Eventos

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

| Identificador | Requisitos                                                                | Classificação  | Prioridade |
|---------------|---------------------------------------------------------------------------|----------------|------------|
| RNF01         | A aplicação deve ser escalável, mesmo com 50 usuários simultâneos. | Desempenho     | Alta       |
| RNF02         | Garantir a proteção dos dados dos usuários e a integridade das informações dos eventos. | Segurança      | Alta       |
| RNF03         | O sistema deve ser responsivo e funcional em diferentes dispositivos e sistemas operacionais. | Usabilidade    | Média      |
| RNF04         | A aplicação deve responder bem até 50 usuários simultâneos e suportar um aumento de até 100 usuários simultâneos sem perda de desempenho. | Escalabilidade | Média      |
| RNF05         | O código deve ser bem documentado e estruturado para facilitar futuras manutenções e atualizações. | Manutenibilidade | Média      |
| RNF06         | A aplicação deve estar disponível e acessível 24/7, com um tempo de inatividade mínimo. | Disponibilidade | Alta       |

[Liste os principais requisitos não funcionais da aplicação, como desempenho, segurança, escalabilidade, etc.]

## Tecnologias Utilizadas

- **Linguagem de Programação**: C# (.NET)
- **Framework**: .NET 8/9
- **Banco de Dados**: PostgreSQL
- **API**: ASP.NET Core Web API
- **Documentação de API**: Swagger para documentação automática e interface de teste de APIs
- **IDE de Desenvolvimento**: Visual Studio 2022
- **Ferramentas de Versionamento**: Git, usando GitHub
- **Deploy/ hospedagem da API**: AWS
- **Ferramentas de Teste**: Postman


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
