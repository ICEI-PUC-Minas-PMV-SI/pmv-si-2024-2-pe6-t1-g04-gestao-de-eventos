![image](https://github.com/user-attachments/assets/0a4cc8a0-89f9-410a-b8ad-1e037683da12)## APIs e Web Services

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
  <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2024-2-pe6-t1-g04-gestao-de-eventos/blob/main/docs/img/Fluxo.jpg">
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

#### Endpoint 1: Cadastro de Usuário (RF-02)
- **Método:** `POST`
- **URL:** `/api/Usuarios/register`
- **Parâmetros:**
  - Não possui parâmetros na URL.

- **Exemplo de Corpo da Requisição (JSON):**
  ```json
  {
    "nome": "Salo",
    "email": "salo@example.com",
    "senha": "pucminas",
    "perfil": 3
  }
  
  Resposta: Sucesso (200 OK)
  {
  "$id": "1",
  "nome": "Salo Lobato",
  "email": "salo@example.com",
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

#### Endpoint 2: Login de Usuário (RF-01)
- **Método:** `POST`
- **URL:** `/api/Usuarios/login`
- **Parâmetros:**
  - Não possui parâmetros na URL.

- **Exemplo de Corpo da Requisição (JSON):**
  ```json
    {
      "email": "salo@example.com",
      "senha": "pucminas"
    }
  ```

- **Exemplo de Respostas da Requisição (JSON):**
  ```json
    Resposta: Sucesso (200 OK)
    {
    "$id": "1",
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1IiwidW5pcXVlX25hbWUiOiJTYWxvbcOjbyIsImVtYWlsIjoic2Fsb21hb0Bob3RtYWlsLmNvbSIsInJvbGUiOiJGdW5jaW9uYXJpbyIsIm5iZiI6MTcyNzMwMjgwNCwiZXhwIjoxNzI3MzMxNjA0LCJpYXQiOjE3MjczMDI4MDR9.89BkrfOoH303rkfA-RzC9hZX2LXP5zSmmWDWuuyweqw"
    }
    Resposta: Erro (401 Unauthorized)
    E-mail e/ou Senha inválidos.
  ```

### API de Evento

#### Endpoint 1: Cadastro de Evento (RF-03,RF-04,RF-05,RF-06)
- **Método:** `POST`
- **URL:** `/api/Eventos/register`
- **Parâmetros:**
  - Não possui parâmetros na URL.

- **Exemplo de Corpo da Requisição (JSON):**
  ```json
    {
    "solicitanteId": 1,
    "titulo": "Evento 2024",
    "tipoEvento": 1,
    "localId": 1,
    "descricao": "Lorem ipsum",
    "dataInicio": "2024-09-30T01:01:56.539Z",
    "dataFim": "2024-10-02T01:01:56.539Z",
    "cursoId": 1,
    "outrosCursosParticipantes": false,
    "palestras": [
      {
        "horarioDeInicio": "2024-09-30T01:01:56.539Z",
        "horarioDeFim": "2024-09-30T01:01:56.539Z",
        "titulo": "Fluxos",
        "palestrante": "José Almeida",
        "vagas": 100
      }
    ],
    "atividadePratica": "Não",
    "materiais": "N/A",
    "infraestrutura": {
      "temAdaptadorHDMI": true,
      "qtdSuporteBanner": 2,
      "temAguaPalestrante": true,
      "temCoffeBreak": true,
      "qtdMesaPlastico": 3,
      "qtdForro": 3,
      "qtdCesto": 3,
      "temEstacionamentoPalestrante": true,
      "dadosPalestrante": "José Almeida, CPF 111.111.111-11. Placa do veículo XXX-9X99",
      "outrosEquipamentos": "Não"
    },
    "emissaoCertificadoSGA": true
    }
  ```

- **Exemplo de Respostas da Requisição (JSON):**
``` json
   Resposta: Sucesso (200 OK)
    {
      "$id": "1",
      "solicitanteId": 1,
      "solicitante": null,
      "titulo": "Evento 2024",
      "tipoEvento": 1,
      "localId": 1,
      "local": null,
      "descricao": "Lorem ipsum",
      "dataInicio": "2024-09-30T01:01:56.539Z",
      "dataFim": "2024-10-02T01:01:56.539Z",
      "setorId": null,
      "setor": null,
      "cursoId": 1,
      "curso": null,
      "outrosCursosParticipantes": false,
      "outrosCursos": null,
      "atividadePratica": "Não",
      "materiais": "N/A",
      "emissaoCertificadoSGA": true,
      "id": 7
    }
  ```

#### Endpoint 3: Evento por Usuário
- **Método:** `GET`
- **URL:** `/api/Eventos/Usuario/{usuario}`
- **Parâmetros:**
  - ID do Usuário.

- **Exemplo de Respostas da Requisição (JSON):**
  ```json
    Resposta: Sucesso (200 OK) // URL: /api/Eventos/Usuario/1
   {
      "$id": "1",
      "$values": [
          {
              "$id": "2",
              "solicitanteId": 1,
              "solicitante": {
                  "$id": "3",
                  "nome": "Administrator",
                  "email": "admin@email.com.br",
                  "senha": "$2a$11$VTD77/XVUCwFRPG55Nqfsu6tzC1pgPI0B4LrF.S3tD11y1/vqnt2O",
                  "perfil": 0,
                  "perfilDescricao": "Administrador",
                  "id": 1
              },
              "titulo": "Evento 2024",
              "tipoEvento": 1,
              "localId": 1,
              "local": {
                  "$id": "4",
                  "nome": "Auditório 1",
                  "prazoMinimo": 15,
                  "id": 1
              },
              "descricao": "Lorem ipsum",
              "dataInicio": "2024-09-30T01:01:56.539Z",
              "dataFim": "2024-10-02T01:01:56.539Z",
              "setorId": 0,
              "setor": null,
              "cursoId": 1,
              "curso": {
                  "$id": "5",
                  "nome": "Sistemas de Informação",
                  "id": 1
              },
              "outrosCursosParticipantes": false,
              "outrosCursos": null,
              "atividadePratica": "Não",
              "materiais": "N/A",
              "emissaoCertificadoSGA": true,
              "id": 4
          },
          {
              "$id": "6",
              "solicitanteId": 1,
              "solicitante": {
                  "$ref": "3"
              },
              "titulo": "Evento 2024",
              "tipoEvento": 1,
              "localId": 1,
              "local": {
                  "$ref": "4"
              },
              "descricao": "Lorem ipsum",
              "dataInicio": "2024-09-30T01:01:56.539Z",
              "dataFim": "2024-10-02T01:01:56.539Z",
              "setorId": null,
              "setor": null,
              "cursoId": 1,
              "curso": {
                  "$ref": "5"
              },
              "outrosCursosParticipantes": false,
              "outrosCursos": null,
              "atividadePratica": "Não",
              "materiais": "N/A",
              "emissaoCertificadoSGA": true,
              "id": 6
          },
          {
              "$id": "7",
              "solicitanteId": 1,
              "solicitante": {
                  "$ref": "3"
              },
              "titulo": "Evento 2024",
              "tipoEvento": 1,
              "localId": 1,
              "local": {
                  "$ref": "4"
              },
              "descricao": "Lorem ipsum",
              "dataInicio": "2024-09-30T01:01:56.539Z",
              "dataFim": "2024-10-02T01:01:56.539Z",
              "setorId": null,
              "setor": null,
              "cursoId": 1,
              "curso": {
                  "$ref": "5"
              },
              "outrosCursosParticipantes": false,
              "outrosCursos": null,
              "atividadePratica": "Não",
              "materiais": "N/A",
              "emissaoCertificadoSGA": true,
              "id": 7
          }
      ]
  }

  Resposta: Erro (400 Bad Request) // URL: /api/Eventos/Usuario/key
  {
    "$id": "1",
    "type": "https://tools.ietf.org/html/rfc9110#section-15.5.1",
    "title": "One or more validation errors occurred.",
    "status": 400,
    "errors": {
        "$id": "2",
        "usuario": [
            "The value 'key' is not valid."
        ]
    },
    "traceId": "00-9ca6839fb794effc67dc375c4026dd50-f943ed9ceb20a6ee-00"
  }
  ```

  #### Endpoint 2: Evento por ID
- **Método:** `GET`
- **URL:** `/api/Eventos/{evento}`
- **Parâmetros:**
  - ID do Evento.

- **Exemplo de Respostas da Requisição (JSON):**
  ```json
    Resposta: Sucesso (200 OK)
    {
      "solicitanteId": 1,
      "titulo": "Evento 2024",
      "tipoEvento": 1,
      "localId": 1,
      "descricao": "Lorem ipsum",
      "dataInicio": "2024-09-30T01:01:56.539Z",
      "dataFim": "2024-10-02T01:01:56.539Z",
      "cursoId": 1,
      "outrosCursosParticipantes": false,
      "palestras": [
        {
          "horarioDeInicio": "2024-09-30T01:01:56.539Z",
          "horarioDeFim": "2024-09-30T01:01:56.539Z",
          "titulo": "Fluxos",
          "palestrante": "José Almeida",
          "vagas": 100
        }
      ],
      "atividadePratica": "Não",
      "materiais": "N/A",
      "infraestrutura": {
        "temAdaptadorHDMI": true,
        "qtdSuporteBanner": 2,
        "temAguaPalestrante": true,
        "temCoffeBreak": true,
        "qtdMesaPlastico": 3,
        "qtdForro": 3,
        "qtdCesto": 3,
        "temEstacionamentoPalestrante": true,
        "dadosPalestrante": "José Almeida, CPF 111.111.111-11. Placa do veículo XXX-9X99",
        "outrosEquipamentos": "Não"
      },
      "emissaoCertificadoSGA": true
    }

  Resposta: Erro (404 Not Found)
  {
    "$id": "1",
    "message": "Entidade do tipo Evento com ID 2 não encontrada."
  }
  ```

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

![image](https://github.com/user-attachments/assets/9218de66-ad5b-415b-94d3-bab7ede2f75b)






### Servidor de Banco de Dados:

![image](https://github.com/user-attachments/assets/c49f92b4-963d-4af6-a862-b2d7dc3ee88b)





### Teste no Postman:

![image](https://github.com/user-attachments/assets/91c789d1-8a81-455e-863e-a10b16a0b0db)



## Testes

Para os testes da aplicação, utilizamos o software Postman para realizar requisições para as rotas configuradas. Abaixo, seguem exemplos de testes realizados para as principais rotas da aplicação, para o login e cadastro de usuários e para a solicitação de um novo evento:

### Usuário:

#### Cadastro:
![image](https://github.com/user-attachments/assets/997a8ce9-8141-4879-830d-b5e00085bcb1)


#### Login:
![image](https://github.com/user-attachments/assets/d877ffca-c6cd-4541-8500-45f7ac5611f8)


### Evento:

#### Cadastro:
![image](https://github.com/user-attachments/assets/daab2217-d68d-43f9-be14-586bd433cef9)


#### Listar por ID:
![image](https://github.com/user-attachments/assets/ee62c135-c2d3-413e-8ff4-3c85a77f902f)


#### Listar por Usuário:
![image](https://github.com/user-attachments/assets/cd1d1170-0f79-483d-9831-56facb138d1f)



# Referências

[Tutorial Web API ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio)

[Quickstart guide Azure PostgreSQL](https://learn.microsoft.com/en-us/azure/postgresql/flexible-server/quickstart-create-connect-server-vnet)

[Documentação Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
