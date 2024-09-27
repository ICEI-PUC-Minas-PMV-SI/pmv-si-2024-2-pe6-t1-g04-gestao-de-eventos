## APIs e Web Services

<p align="justify"> Este projeto visa desenvolver um sistema web para gerenciar eventos realizados na PUC Minas Betim, utilizando uma arquitetura monolítica e o banco de dados PostgreSQL. Cada funcionalidade do sistema, como cadastro de usuários, reserva de espaços, escolha de cursos, solicitação de infraestrutura e outros, será implementada como um serviço. </p>

## Objetivos da API

#### API Gestão de Eventos:
**Objetivo:** Prover funcionalidades para gerenciar eventos, voltado ao público interno da PUC Minas Betim.

**Recursos:** 

- **API de evento:**
  Inclusão, alteração e exclusão de nome, descrição e demais informações do evento.
- **API de usuário:**
  Inclusão, alteração, exclusão e autenticação de usuários internos.
- **API de curso:**
 Inclusão, alteração e exclusão de cursos relacionados ao evento. 
- **API de setor:**
  Inclusão, alteração e exclusão de setores responsáveis pelo evento.
- **API de infraestrutura:**
  Inclusão, alteração e exclusão de materiais e recursos solicitados para os eventos.
- **API de palestra:**
  Inclusão, alteração e exclusão de palestras, com informações como título, horário e local.

## Arquitetura

<p align="justify"> A arquitetura monolítica do sistema de Gestão de Eventos da PUC Minas Betim centraliza todas as funcionalidades, como o cadastro de usuários, reserva de espaços, escolha de cursos, solicitação de infraestrutura e outros, em uma única aplicação. Todas as funcionalidades e componentes são integrados em um único bloco de código e compartilham o mesmo ambiente de execução. </p>

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/ArquiteturaAPI.jpg" alt="Arquitetura da API">
</p>

<p align="center">Figura 1 - Arquitetura da API </p>

### Modelagem da Aplicação

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/DiagramaER.jpeg" alt="Diagrama de Entidade de Relacionamento">
</p>

<p align="center">Figura 2 - Diagrama de Entidade de Relacionamento </p>

## Fluxo de Dados

<p align="center">
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/FluxoAPI.jpg" alt="Fluxo de dados da API">
</p>

<p align="center">Figura 3 - Fluxo de dados da API </p>

## Requisitos Funcionais do Setor de Eventos

| ID     | Descrição do Requisito                                                                                  | Prioridade |
|--------|---------------------------------------------------------------------------------------------------------|------------|
| RF-01  | Permitir que o usuário faça login utilizando um e-mail.                                                   | Alta       |
| RF-02  | Permitir que o usuário registre seus dados pessoais, incluindo: Nome, E-mail, Telefone.                   | Alta       |
| RF-03  | Permitir que o usuário cadastre eventos institucionais, inserindo: Nome do evento, Descrição do evento.   | Alta       |
| RF-04  | Permitir que o usuário cadastre eventos de graduação, inserindo: Nome do evento, Descrição do evento.     | Alta       |
| RF-05  | Permitir que o usuário registre palestras relacionadas aos eventos.                                       | Alta       |
| RF-06  | Permitir que o usuário solicite materiais e recursos de infraestrutura para os eventos.                   | Alta       |
| RF-07  | Permitir que o usuário edite as informações da solicitação do evento previamente cadastradas.             | Alta       |

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
- **Deploy/ hospedagem da API**: Azure
- **Ferramentas de Teste**: Postman


## API Endpoints
### API de Usuários

#### Endpoint 1: Cadastro de Usuário
- **Método:** `POST`
- **URL:** `/api/usuarios/register`
- **Parâmetros:**
  - Não possui parâmetros na URL.

- **Exemplo de Corpo da Requisição (JSON):**
  ```json
  {
    "nome": "Salomão",
    "email": "salomao@hotmail.com",
    "senha": "senhaSegura123",
    "perfil": 3
  }
  Resposta: Sucesso (200 OK)
  {
  "$id": "1",
  "nome": "Salomão",
  "email": "salomao@hotmail.com",
  "senha": "$2a$11$CY3ahpQwI/5lJMm5CB7vOeQRQQAUaQr1kaW1bj12aW9ukCz2u2oJi",
  "perfil": 3,
  "perfilDescricao": "Funcionario",
  "id": 5
  }

  Erro (4XX, 5XX):
  {
  "$id": "1",
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "errors": {
      "$id": "2",
      "Senha": [
          "A senha deve ter pelo menos 8 caracteres."
      ]
  },
  "traceId": "00-e571816b6ec2621e4185cffadd62f3d9-dba082aa772daa05-00"
  }



### API de Login

#### Endpoint 2: Login de Usuário
- **Método:** `POST`
- **URL:** `/api/usuarios/login`
- **Parâmetros:**
  - Não possui parâmetros na URL.

- **Exemplo de Corpo da Requisição (JSON):**
  ```json
  {
    "email": "salomao@hotmail.com",
    "senha": "senhaSegura123"
  }

  Resposta: Sucesso (200 OK)
  {
  "$id": "1",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1IiwidW5pcXVlX25hbWUiOiJTYWxvbcOjbyIsImVtYWlsIjoic2Fsb21hb0Bob3RtYWlsLmNvbSIsInJvbGUiOiJGdW5jaW9uYXJpbyIsIm5iZiI6MTcyNzMwMjgwNCwiZXhwIjoxNzI3MzMxNjA0LCJpYXQiOjE3MjczMDI4MDR9.89BkrfOoH303rkfA-RzC9hZX2LXP5zSmmWDWuuyweqw"
  }

## Considerações de Segurança

<p align="justify"> A API utiliza tokens JWT (JSON Web Tokens) para autenticar e autorizar usuários. Cada token deve conter informações sobre o usuário e suas permissões. Também é utilizada a Proteção de Rotas por Tipo de Perfil de Usuário (RBAC), assim garantindo que apenas usuários com as permissões adequadas possam acessar determinadas rotas. Cada rota deve ser protegida de acordo com o perfil do usuário (aluno, professor, funcionário e administrador). </p>

Com essas considerações de segurança implementadas, a API terá: 
- **Autenticação e Autorização Seguras:** Apenas usuários autenticados e autorizados poderão acessar os recursos da API.
- **Integridade e Autenticidade dos Dados:** Os tokens JWT assinados digitalmente garantem que os dados não foram alterados e que a identidade do usuário é verificada.
- **Proteção Contra Uso Indevido:** A expiração dos tokens e a renovação segura ajudam a minimizar o risco de uso indevido em caso de comprometimento.
- **Acesso Controlado:** A implementação de RBAC assegura que apenas usuários com as permissões adequadas possam acessar determinadas rotas, protegendo informações sensíveis.</p>

## Implantação

Abaixo listamos os requisitos de hardware e software necessários para implantar a aplicação em um ambiente de produção.
 ### Requisitos de Software:
- Servidor de banco de dados PostgreSQL
- Servidor web
- Ambiente de execução: C# e .NET Core
- Linux

### Requisitos de Hardware:
- CPU de alto desempenho
- Memória RAM de pelo menos 16 GB
- Armazenamento SSD de no mínimo 500 GB
- Conexão de rede de alta velocidade
  
### Plataforma de Hopedagem:

<p style="text-align: justify;">
A aplicação será implementada no ambiente de nuvem da Microsoft Azure e estará pronta para oferecer uma solução para a gestão de eventos, preparada para escalar e se adaptar a diferentes cenários de uso, enquanto mantém segurança e conformidade exigidos pelas melhores práticas do mercado.
</p>


###  Servidor Web:

![image](https://github.com/user-attachments/assets/52b3d6b4-c021-4df4-86e3-91d83a28a0cd)





### Servidor de Banco de Dados:

![image](https://github.com/user-attachments/assets/7e573934-9ad3-43a1-8442-d9d447f21c31)




### Teste no Postman:

![image](https://github.com/user-attachments/assets/91c789d1-8a81-455e-863e-a10b16a0b0db)



## Testes

### Usuário:

#### Cadastro:
![image](https://github.com/user-attachments/assets/997a8ce9-8141-4879-830d-b5e00085bcb1)

# Referências

[Tutorial Web API ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio)

[Quickstart guide Azure PostgreSQL](https://learn.microsoft.com/en-us/azure/postgresql/flexible-server/quickstart-create-connect-server-vnet)

[Documentação Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
