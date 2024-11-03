# Front-end Web

<p align="justify"> Este projeto de front-end visa desenvolver uma plataforma para gerenciar eventos realizados na PUC Minas Betim. O objetivo é criar uma interface de fácil visualização e eficiente para usuários com diferentes perfis (administradores, alunos, professores e funcionários).</p>

## Tecnologias Utilizadas
<p align="justify"> Para o desenvolvimento do front-end deste projeto de gestão de eventos, foram utilizadas as seguintes tecnologias: 

  - *React;*
  - *HTML;*
  - *CSS;*
  - *JavaScript;*
  - *Next.js;*
  - *Frameworks de CSS: Tailwind.
 

## Arquitetura

<p align="justify"> A arquitetura frontend do sistema de gestão de eventos da PUC Minas é projetada para ser modular, reutilizável e escalável, utilizando os frameworks e bibliotecas como React, Next.js e Tailwind. A aplicação é dividida em diferentes camadas e componentes que interagem entre si para proporcionar uma experiência de usuário dinâmica e eficiente. </p>

### Descrição da Arquitetura

### 1. Camada de Apresentação (UI Layer)
- **HTML**: A estrutura das páginas é definida em HTML, que descreve os elementos visuais de cada página, como formulários, botões e tabelas.

- **CSS (Tailwind)**:
  - **Tailwind**: Um framework utilitário que permite um design rápido e customizável. É usado para estilização modular de componentes, aplicando classes diretamente nos elementos HTML.

A camada de apresentação é responsável por renderizar o conteúdo das páginas de forma que seja visualmente agradável e adaptável.

### 2. Componente de Navegação e Rotas
- **Next.js**: É utilizado para gerenciar as rotas e a navegação do sistema. Com sua funcionalidade de roteamento baseado em páginas, o Next.js permite a renderização do lado do servidor.

### 3. Componentes da Interface (React)
A aplicação é dividida em pequenos componentes reutilizáveis em React. Estes são alguns exemplos:
- **Header**: Um componente que contém a barra de navegação, com links para páginas principais como “Página Inicial”, “Login”, "Cadastro", “Solicitação de Evento”.
- **Formulários de Cadastro e Login**: Componentes responsáveis pela autenticação dos usuários. O formulário de cadastro coleta dados básicos do usuário (nome, e-mail, senha), enquanto o de login valida as credenciais.
- **Página de Solicitação de Evento**: Um formulário que permite aos usuários solicitarem a criação de novos eventos, preenchendo informações como nome do evento, data, local, infraestrutura, palestrante e descrição.

### 4. Interações Dinâmicas (JavaScript)
A interação entre os componentes da interface é controlada por JavaScript. Aqui são gerenciadas as ações, como a submissão de formulários, validação de dados, controle de modais, navegação condicional baseada em estados de autenticação, entre outras funcionalidades dinâmicas.

## Modelagem da Aplicação

Abaixo apresentamos o Diagrama de Sequência para o Cadastro de Usuário, Login, Alteração de Senha e Solicitação de Eventos.

Este diagrama ilustra as interações entre os usuários e o sistema durante esses processos. A sequência inicia com o cadastro do usuário, que insere e-mail e senha. Em seguida, o sistema verifica os dados e confirma o registro. Após o cadastro, o usuário realiza o login para acessar as funcionalidades do sistema.

A alteração de senha é realizada quando o usuário solicita essa ação, e o sistema valida a identidade do usuário antes de permitir a alteração.

No que se refere à solicitação de eventos, o usuário preenche um formulário com os detalhes do evento desejado. O Setor de Eventos verifica a disponibilidade do local e processa a solicitação.

Esses fluxos de interação são fundamentais para garantir que os usuários tenham uma experiência organizada e eficiente ao utilizar o sistema. 

### Interações dos Componentes


<p align="center">
  <img src="https://github.com/user-attachments/assets/efa9bd1c-bf0b-40e4-84ff-0d096d7e73c8" alt="image" />
</p>


## Projeto da Interface Web
[Descreva o projeto da interface Web da aplicação, incluindo o design visual, layout das páginas, interações do usuário e outros aspectos relevantes.]

### Wireframes
[Inclua os wireframes das páginas principais da interface, mostrando a disposição dos elementos na página.]

#### Tela Home
![Tela inicial projetada no Figma](https://github.com/user-attachments/assets/cf683d4b-c88f-4ecb-ac87-b1e7ff85bf3a)

#### Tela Entrar
![image](https://github.com/user-attachments/assets/0abb399e-4e6f-4bba-bb62-61d33b95279e)


#### Tela Cadastrar 
![image](https://github.com/user-attachments/assets/0d50c03b-d1cf-4124-acfd-5da2136abc97)


#### Tela Sobre
![image](https://github.com/user-attachments/assets/a8fa7da2-00e7-4736-b523-bf877444a361)

#### Tela Evento

#### Tela Painel do Administrador

#### Tela Painel do Usuário 




### Design Visual

A identidade visual da página web será construída em torno das cores **branca** e **azul**, seguindo a paleta de cores do logo da **PUC Minas**, garantindo consistência com a imagem da universidade. O uso do **branco** proporcionará uma base limpa e minimalista, enquanto o **azul** será aplicado em elementos chave para transmitir seriedade, confiança e profissionalismo, alinhando-se ao padrão visual da instituição.

#### Estrutura e Paleta de Cores:
- **Fundo Principal**: A cor **branca** será predominantemente utilizada no fundo, proporcionando uma aparência leve e moderna. Esse fundo claro facilitará a leitura e criará um contraste elegante com outros elementos da interface.
- **Elementos em Azul**: O **azul** será aplicado nos componentes principais da interface, como cabeçalhos, botões de ação e links. Essa cor remete à confiabilidade e à excelência, além de reforçar a identidade visual da PUC Minas.
- **Destaques em Vermelho**: Itens que exigem uma ação negativa ou "não" serão destacados em **vermelho**. Esta cor forte e vibrante chamará a atenção do usuário, indicando claramente opções ou respostas que devem ser evitadas. O vermelho será utilizado em botões de cancelamento, alertas e mensagens de erro.

#### Componentes de UI:
- **Botões e Links**: Os botões de ação terão o azul como cor de fundo, com texto branco, garantindo contraste e legibilidade. Já os botões de cancelamento ou respostas negativas terão um fundo vermelho, para uma clara diferenciação visual.
- **Textos e Títulos**: Os textos seguirão um estilo simples e direto, com títulos em azul para dar ênfase e hierarquia às informações, enquanto o corpo do texto será em cinza escuro ou preto para garantir uma boa legibilidade.
- **Ícones e Formulários**: Ícones e campos de formulário seguirão a mesma paleta de cores. Ícones de ação importante terão destaque azul, enquanto mensagens de erro ou alertas usarão ícones vermelhos.

Este design equilibrado entre o uso de cores claras e vibrantes não só representa a identidade visual da PUC Minas, mas também proporciona uma experiência de usuário intuitiva, clara e agradável, refletindo a seriedade e a qualidade da universidade.

### Layout Responsivo

A interface da página web será projetada para se adaptar de forma eficiente a diferentes tamanhos de tela e dispositivos, garantindo uma experiência de usuário otimizada em desktops e smartphones. Isso será alcançado por meio de práticas de **layout responsivo** usando as tecnologias **CSS** e **Tailwind**, que permitirão uma transição suave entre os diferentes formatos de dispositivos.

#### Estrutura Responsiva com Tailwind:
- **Tailwind CSS**: Utilizando classes utilitárias do Tailwind, os componentes da interface serão estilizados para se ajustar automaticamente ao tamanho da tela.
#### Estratégias de Layout:
1. **Desktops (Telas Grandes)**: Em telas grandes, como monitores de desktop, a interface será exibida com uma estrutura de **layout em colunas**. As seções de conteúdo e navegação serão organizadas em colunas lado a lado, aproveitando ao máximo o espaço disponível.
2. **Smartphones (Telas Pequenas)**: Em dispositivos móveis, como smartphones, o layout será reestruturado para uma **estrutura em coluna única**. A navegação será simplificada, com menus em **hamburguer menus** ou botões de ação que se expandem, oferecendo uma navegação intuitiva em telas menores.

#### Imagens e Conteúdos Responsivos:
- **Imagens Otimizadas**: O uso do **Next.js** garantirá que as imagens sejam automaticamente otimizadas para diferentes resoluções e tamanhos de tela. 
- **Fontes e Tamanhos**: O tamanho das fontes será ajustado com as classes de responsividade do Tailwind e Bootstrap, garantindo que o texto permaneça legível em qualquer dispositivo, evitando textos muito pequenos em telas menores.

#### Flexibilidade e Acessibilidade:
- O layout será **flexível e adaptável**, ajustando-se automaticamente à orientação da tela (retrato ou paisagem).
- Os elementos da interface, como botões e campos de formulário, terão tamanhos apropriados para toque em dispositivos móveis, assegurando uma **experiência de usuário acessível** e sem complicações.

Dessa forma, o layout responsivo garantirá que a aplicação ofereça uma interface adaptável, de fácil navegação e uso, independentemente do dispositivo ou tamanho da tela.


### Interações do Usuário

No sistema de gestão de eventos, existem **4 tipos de usuários**, cada um com diferentes níveis de acesso e permissões. Esses usuários são: **administrador**, **aluno**, **funcionário** e **professor**.

#### 1. Administrador
- **Permissões**: O administrador terá acesso total a todas as funcionalidades do sistema, incluindo:
  - **Cadastrar eventos**: O administrador pode criar novos eventos.
  - **Listar eventos**: O administrador pode visualizar todos os eventos cadastrados.
  - **Deletar eventos**: O administrador pode excluir eventos já cadastrados.
  - **Acesso a todas as telas**: O administrador pode acessar todas as páginas e funcionalidades do sistema, sem restrições.

#### 2. Aluno, Funcionário e Professor
- **Permissões**: Os usuários com o perfil de **aluno**, **funcionário** e **professor** têm acesso limitado, permitindo apenas:
  - **Cadastrar eventos**: Eles podem criar novos eventos no sistema.
  - **Listar eventos**: Eles podem visualizar eventos já cadastrados.
  - **Sem permissão para deletar eventos**: Eles não têm permissão para excluir eventos, apenas para visualizá-los e cadastrá-los.
  - **Acesso restrito às telas de cadastro, login listagem**: Eles não terão acesso às funcionalidades administrativas, como a exclusão de eventos, nem às páginas que só o administrador pode acessar.

#### Resumo de Acesso:
| Tipo de Usuário   | Cadastrar Eventos | Listar Eventos | Deletar Eventos | Acesso a todas as telas |
|-------------------|--------------------|----------------|-----------------|-------------------------|
| Administrador     | Sim                | Sim            | Sim             | Sim                     |
| Aluno             | Sim                | Sim            | Não             | Não                     |
| Funcionário       | Sim                | Sim            | Não             | Não                     |
| Professor         | Sim                | Sim            | Não             | Não                     |

Esse controle de acesso garante que apenas o **administrador** possa realizar ações críticas como a exclusão de eventos, enquanto os outros usuários podem apenas interagir com os eventos que foram criados ou listados.


## Fluxo de Dados

### Interações dos Componentes
1. O usuário acessa a página inicial onde pode se cadastrar ou fazer login.
2. **Header** controla a navegação para páginas internas, como a página de solicitação de evento, alteração de senha e cadastro de usuário.
3. Após o login, o usuário é redirecionado para a **Página de Eventos**. Nesta página, inicialmente, são listados os eventos solicitados anteriormente, caso eles existam. Também são disponibilizados dois botões: o de **Solicitar novo evento** e de **Alterar Senha**.
4. Ao clicar no botão de **Solicitar novo evento**, o usuário é direcionado para a página onde consta o formulário que deve ser preenchido para fazer a solicitação do evento. Ao clicar no botão de Encaminhar Solicitação, a resposta do backend é exibida dinamicamente no frontend, mostrando uma confirmação da solicitação ou erros no formulário. Logo após, o usuário é direcionado devolta para a **Página de Eventos**
5. Ao clicar no botão de **Alterar Senha**, o usuário é direcionado para a tela de alterar senha e lá, são renderizados na tela o nome, e-mail e perfil do cliente logado, e também um campo onde o usuário deve digitar a nova senha. Ao clicar no botão de alterar senha, é mostrada uma confirmação de que a senha foi alterada com sucesso e o usuário é direcionado devolta para a **Página de Eventos**.

<p align="center">
  <img src="https://github.com/user-attachments/assets/a7c41fc0-1005-43ea-a10a-920cc71f8d3d" alt="image" />
</p>

## Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                         | Prioridade |
|--------|---------------------------------------------------------------------------------------------------------------|------------|
| RF-01  | O sistema deve permitir que usuários do tipo **administrador**, **aluno**, **funcionário** e **professor** possam cadastrar novos eventos. | Alta       |
| RF-02  | O formulário de cadastro de evento deve incluir campos obrigatórios como nome do evento, data, hora, local, descrição e categoria. | Alta       |
| RF-03  | O sistema deve permitir que todos os usuários possam visualizar a lista de eventos já cadastrados por eles. | Alta       |
| RF-04  | A lista de eventos deve exibir informações básicas como nome, data, local e status do evento. | Alta       |
| RF-05  | A listagem deve permitir a navegação entre diferentes páginas de eventos, caso haja mais eventos do que o espaço disponível em uma única página. | Alta       |
| RF-06  | O **administrador** deve ter a capacidade de excluir eventos. | Alta       |
| RF-07  | A exclusão de eventos deve ser feita através de um botão "Excluir" ao lado do evento listado. | Alta       |
| RF-08  | Após a exclusão, a lista de eventos deve ser atualizada imediatamente, sem a necessidade de recarregar a página. | Alta       |
| RF-09  | O sistema deve ter uma navegação clara e intuitiva, permitindo que os usuários acessem as páginas de cadastro e listagem de eventos facilmente. | Alta       |
| RF-10  | A interface deve ser responsiva e se adaptar a diferentes dispositivos, como desktops e smartphones. | Alta       |
| RF-11  | O sistema deve permitir que o usuário faça login com seu e-mail e senha. | Alta       |
| RF-12  | O usuário deve poder realizar logout, retornando à página de login. | Alta       |
| RF-13  | O sistema deve exibir mensagens de erro caso o formulário de cadastro seja preenchido de maneira inadequada. | Alta       |
| RF-14  | O sistema deve exibir mensagens de sucesso quando o evento for cadastrado ou excluído com sucesso. | Alta       |

## Requisitos Não Funcionais

| Identificador | Requisitos                                                                | Classificação  | Prioridade |
|---------------|---------------------------------------------------------------------------|----------------|------------|
| RNF01         | A interface deve ser intuitiva e fácil de usar, com botões e links bem visíveis e organizados. | Usabilidade    | Alta       |
| RNF02         | A navegação deve ser clara, com um menu principal acessível em todas as páginas. | Usabilidade    | Alta       |
| RNF03         | O sistema deve garantir que as informações de login e cadastro sejam tratadas com segurança, utilizando criptografia para senhas e autenticação segura. | Segurança      | Alta       |
| RNF04         | Os dados dos eventos e do usuário devem ser validados no frontend antes de serem enviados ao backend. | Segurança      | Alta       |
| RNF05         | O sistema deve ser compatível com os principais navegadores, incluindo Google Chrome, Mozilla Firefox, Microsoft Edge e Safari. | Compatibilidade | Alta       |
| RNF06         | A interface deve se adaptar bem a diferentes resoluções de tela e dispositivos (desktops e smartphones). | Compatibilidade | Alta       |
| RNF07         | O código front-end deve ser modular e reutilizável, facilitando futuras alterações e manutenções. | Manutenibilidade | Alta       |
| RNF08         | O uso de frameworks como **React** e **Next.js** deve seguir boas práticas de desenvolvimento para garantir escalabilidade e fácil manutenção. | Manutenibilidade | Alta       |
| RNF09         | A aplicação deve ser acessível para pessoas com deficiência visual e motora, garantindo que leitores de tela possam interpretar o conteúdo da página corretamente. | Acessibilidade | Alta       |
| RNF10         | Elementos interativos como botões e links devem ser navegáveis via teclado. | Acessibilidade | Alta       |
| RNF11         | O sistema deve permitir a futura expansão para suportar diferentes idiomas, com textos e mensagens prontamente traduzíveis. | Internacionalização | Média      |

## Considerações de Segurança

Para garantir a segurança da aplicação de gestão de eventos, utilizaremos o **JSON Web Token (JWT)** para autenticar a sessão dos usuários. O JWT é uma maneira segura de garantir que as informações de autenticação sejam transmitidas de forma confiável entre o cliente e o servidor, sem a necessidade de armazenar dados de sessão no servidor.

#### Autenticação com JWT

- O usuário se autentica utilizando seu e-mail e senha na aplicação.
- Após a autenticação, o backend gera um **token JWT**, que é enviado para o cliente.
- O **token JWT** contém informações relevantes como o ID do usuário e seu tipo (administrador, aluno, funcionário, professor) e tem uma data de expiração definida para aumentar a segurança.
- Este token é armazenado no lado do cliente e é enviado em cada requisição subsequente, no **header Authorization**.
- O backend valida o token em cada requisição para garantir que o usuário tenha permissão para acessar o recurso.

#### Outras Medidas de Segurança

Além da autenticação JWT, a aplicação adotará as seguintes práticas para garantir a segurança dos dados e das interações:

1. **Criptografia de Senhas**:
   - As senhas dos usuários serão criptografadas, garantindo que as informações sensíveis sejam protegidas de forma robusta.
   
2. **Validação de Dados no Frontend**:
   - O sistema validará todos os dados no frontend antes de enviá-los ao backend. Isso ajuda a prevenir ataques como **SQL Injection** e **Cross-site Scripting (XSS)**.
   
3. **Controle de Acesso com Roles e Permissões**:
   - Utilizaremos **roles** para garantir que cada tipo de usuário tenha acesso somente às funcionalidades permitidas. Apenas o **administrador** poderá excluir eventos, enquanto **alunos**, **funcionários** e **professores** terão permissões restritas.
   
4. **Sessão Expirável e Renovações de Token**:
   - Os tokens JWT terão uma expiração limitada, que pode ser renovada com um novo token se o usuário continuar utilizando a aplicação de forma legítima. Caso o token expire ou seja invalidado, o usuário precisará se autenticar novamente.
   
5. **HTTPS**:
   - A aplicação estará disponível apenas via **HTTPS**, garantindo a segurança na comunicação entre cliente e servidor.
   
Essas medidas garantem que a aplicação não apenas forneça um acesso seguro aos usuários, mas também proteja as informações sensíveis e garanta a integridade e confidencialidade dos dados trocados entre o frontend e o backend.


## Implantação

1. Defina os requisitos de hardware e software necessários para implantar a aplicação em um ambiente de produção.
2. Escolha uma plataforma de hospedagem adequada, como um provedor de nuvem ou um servidor dedicado.
3. Configure o ambiente de implantação, incluindo a instalação de dependências e configuração de variáveis de ambiente.
4. Faça o deploy da aplicação no ambiente escolhido, seguindo as instruções específicas da plataforma de hospedagem.
5. Realize testes para garantir que a aplicação esteja funcionando corretamente no ambiente de produção.

Abaixo estão listadas as etapas e os requisitos para implantar a aplicação frontend em um ambiente de produção.

#### Requisitos de Software:
- **Plataforma de Hospedagem**: Vercel
- **Ambiente de Desenvolvimento**: Node.js e npm para gerenciar dependências.
- **Sistema Operacional**: Linux, macOS ou Windows (dependendo do servidor)

#### Requisitos de Hardware:
- **CPU**: CPU de alto desempenho
- **Memória RAM**: Pelo menos 16 GB para gerenciar o tráfego e garantir a performance da aplicação.
- **Armazenamento**: SSD de no mínimo 500 GB, com base no tamanho do projeto e no tráfego esperado.
- **Conexão de rede**: Conexão de rede de alta velocidade

#### Passos para Implantação:

1. **Escolha da Plataforma de Hospedagem**:
   - Selecionamos a plataforma de hospedagem Vercel com base nas necessidades de escalabilidade e desempenho.
   
2. **Configuração do Ambiente de Implantação**:
   - Configuração do ambiente de implantação, que inclui a instalação do **Node.js** e **npm**
   - Para uso do Next.js, instalação das dependências com o seguinte comando:
     ```bash
     npm install
     ```
3. **Deploy da Aplicação**:
   - Realize o build de produção da aplicação com o comando:
     ```bash
     npm run build
     ```
   - Deploy da aplicação na plataforma **Vercel**

#### Considerações Finais:
- Certifique-se de que a aplicação esteja otimizada e responsiva em diferentes dispositivos, como desktops e smartphones.
- Verifique se as boas práticas de segurança estão implementadas, como HTTPS (SSL/TLS).


## Testes

Para demontrar os testes feitos na plataforma, os mesmos foram separados por categorias e foi criado um vídeo explicativo para cada, demonstrando a eficácia das funcionalidades do sistema.

- **Teste Login e Logout com autenticação utilizando token JWT**:


1) 

https://github.com/user-attachments/assets/a61197c7-2448-4004-a848-af5d697197cf


2) 

https://github.com/user-attachments/assets/bfb563be-b8a0-473a-bc09-8d6b14717cf1



- **Teste Cadastro de usuário**:



https://github.com/user-attachments/assets/595c5573-5be7-4851-b99b-3feb37ed38cc



- **Teste Alteração de Senha**:




https://github.com/user-attachments/assets/9e4c13e8-c5db-474f-8b1c-e85ac25965e9



[Descreva a estratégia de teste, incluindo os tipos de teste a serem realizados (unitários, integração, carga, etc.) e as ferramentas a serem utilizadas.]

1. Crie casos de teste para cobrir todos os requisitos funcionais e não funcionais da aplicação.
2. Implemente testes unitários para testar unidades individuais de código, como funções e classes.
3. Realize testes de integração para verificar a interação correta entre os componentes da aplicação.
4. Execute testes de carga para avaliar o desempenho da aplicação sob carga significativa.
5. Utilize ferramentas de teste adequadas, como frameworks de teste e ferramentas de automação de teste, para agilizar o processo de teste.

**Testes Pós-Deploy**:
   - Após o deploy na AWS, execute testes para garantir que a aplicação está funcionando corretamente no ambiente de produção:
     - Verifique a navegação entre páginas.
     - Teste a funcionalidade de cadastro, login e listagem de eventos.
     - Realize testes de performance, simulando múltiplos acessos simultâneos.
     - Certifique-se de que todas as variáveis de ambiente estão corretas e funcionando conforme esperado.

# Referências

ALVES, P. *Desenvolvimento de Interfaces com React*. São Paulo: Editora Dev, 2022.

COSTA, L. *Fundamentos de CSS e JavaScript*. Rio de Janeiro: Editora Code, 2021.

FONTES, A. *Arquitetura de Sistemas com Next.js e Tailwind*. Recife: Editora WebTech, 2023.

KRAUSE, M. *Tutorial de Diagrama de Sequência UML | Passo a Passo para Desenvolver Aplicações Modernas*. YouTube, 2023. Disponível em: [https://www.youtube.com/watch?v=qaWShGkUiBo](https://www.youtube.com/watch?v=qaWShGkUiBo). Acesso em: 1 nov. 2024.

SANTOS, G. *O que é Next.js, na prática, em 15 minutos!*. YouTube, 2023. Disponível em: [https://www.youtube.com/watch?v=QsSUbuYeEFk](https://www.youtube.com/watch?v=QsSUbuYeEFk). Acesso em: 1 nov. 2024.

SILVA, L. *Next.js para Iniciantes na prática!*. YouTube, 2023. Disponível em: [https://www.youtube.com/watch?v=k7eDn1qdj-E](https://www.youtube.com/watch?v=k7eDn1qdj-E). Acesso em: 1 nov. 2024.

MDN WEB DOCS (Mozilla Developer Network). Documentação de HTML, CSS e JavaScript. Disponível em: [https://developer.mozilla.org/](https://developer.mozilla.org/). Acesso em: 1 nov. 2024.

W3SCHOOLS. CSS, JavaScript, React, e mais. Disponível em: [https://www.w3schools.com/](https://www.w3schools.com/). Acesso em: 1 nov. 2024.

CSS-TRICKS. Artigos, tutoriais e dicas sobre CSS e front-end. Disponível em: [https://css-tricks.com/](https://css-tricks.com/). Acesso em: 1 nov. 2024.

TAILWIND CSS DOCUMENTATION. Guia oficial sobre Tailwind CSS. Disponível em: [https://tailwindcss.com/](https://tailwindcss.com/). Acesso em: 1 nov. 2024.

REACT DOCUMENTATION. Introdução e guia oficial do React. Disponível em: [https://react.dev/](https://react.dev/). Acesso em: 1 nov. 2024.

NEXT.JS DOCUMENTATION. Documentação oficial do Next.js. Disponível em: [https://nextjs.org/docs](https://nextjs.org/docs). Acesso em: 1 nov. 2024.


