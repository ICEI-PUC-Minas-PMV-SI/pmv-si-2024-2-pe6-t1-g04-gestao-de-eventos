# APIs e Web Services

<p align="justify"> Este projeto visa desenvolver um sistema web para gerenciar eventos realizados na PUC Minas Betim, utilizando uma arquitetura de microsserviços e o banco de dados PostgreSQL. Cada funcionalidade do sistema como cadastro de usuários, reserva de espaços, escolha de cursos responsáveis, solicitação de infraestrutura e outros será implementada como um serviço separado. Essa abordagem permite que cada microserviço seja escalado de forma autônoma e se comunique com os demais por meio de APIs.</p>


## Objetivos da API

Possibilitar a troca de informações e funcionalidades entre as aplicações Web, Mobile com o Banco de Dados para a gestão de eventos da PUC Minas Betim; 

Utilização por usuários que podem ser administradores ou professores, alunos e funcionários; 

Usuários (alunos, professores, funcionários e administradores) - permitir cadastro, alteração, exclusão de dados para utilização e acesso aos sistemas; 

Administradores - permitir cadastro, alteração, exclusão, pesquisa e visualização de dados. 


## Arquitetura

[Descrição da arquitetura das APIs, incluindo os componentes e suas interações.]

## Modelagem da Aplicação

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/Gest%C3%A3o%20de%20eventos.drawio.png" alt="Diagrama de Entidade de Relacionamento">
</p>

<p align="center">Figura 1 - Aplicação WEB</p>

## Fluxo de Dados

[Diagrama ou descrição do fluxo de dados na aplicação.]

## Requisitos Funcionais

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
