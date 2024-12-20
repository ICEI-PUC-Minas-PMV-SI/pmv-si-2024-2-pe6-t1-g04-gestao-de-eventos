# Front-end Móvel

<p align="justify"> Este projeto dá continuidade à aplicação web, com o objetivo de ampliar e otimizar a plataforma de gerenciamento de eventos da PUC Minas Betim. O foco será no desenvolvimento de um front-end voltado para dispositivos móveis, garantindo uma interface intuitiva, de fácil navegação e alta eficiência. A aplicação será projetada para atender às necessidades de diferentes perfis de usuários, incluindo administradores, alunos, professores e funcionários, oferecendo uma experiência otimizada para smartphones e tablets.</p>

## Tecnologias Utilizadas
<p align="justify"> As seguintes tecnologias foram utilizadas no desenvolvimento deste projeto: </p>

- **HTML;**
- **CSS;**
- **JavaScript;**
- **React Native;**
- **React Navigation;**
- **Axios;**
- **TypeScript;**
- **Expo.dev;**



## Arquitetura

<p align="justify"> A arquitetura do sistema de gestão de eventos da PUC Minas foi projetada para ser modular e escalável, reutilizando o código desenvolvido anteriormente no framework React e adaptando-o para o React Native, com integração à Web API implementada em C#. A aplicação segue uma estrutura em camadas fechadas e componentes bem definidos, que se comunicam de forma eficiente para proporcionar uma experiência de usuário dinâmica e otimizada para dispositivos móveis.</p>

### Descrição da Arquitetura

#### 1. Camada de Apresentação (UI Layer)
- **React Native**: a interface do usuário é construída com componentes reutilizáveis ​​e projetada para dispositivos móveis.
- **Expo**: Ferramenta para gerenciar a execução, testes e estilização adicional da aplicação.
- **CSS-in-JS**: Para a estilização modular de componentes, garantindo consistência visual e adaptabilidade.

#### 2. Componente de Navegação e Rotas 
- **React Navigation:** Utilizado para gerenciar a navegação dentro do aplicativo.
- **Expo Router:** Simplifica a configuração de rotas, permitindo uma abordagem baseada em arquivos, similar ao Next.js, mas otimizada para React Native.

#### 3. Componentes da Interface (React Native)
A aplicação é dividida em pequenos componentes reutilizáveis em React Native. Estes são alguns exemplos:

- **Formulários de Cadastro e Login**:  Componentes que gerenciam autenticação e registro de usuários.
- **Página de Solicitação de Evento:** : Um formulário interativo onde usuários podem registrar eventos com informações detalhadas, como nome, data, local, palestrantes e infraestrutura necessária.


#### 4. Interações Dinâmicas (JavaScript)
- **JavaScript**: Gerencia ações dinâmicas, como validação de formulários, navegação condicional e controle de estados (por exemplo, autenticação).
- **Axios:** Para comunicação com a API, enviando e recebendo dados de forma eficiente.
- **React Hook Form e Zod:** Para a criação e validação de formulários.


## Modelagem da Aplicação


Abaixo, apresentamos o Diagrama de Sequência para Cadastro de Usuário, Login, Alteração de Senha e Solicitação de Eventos.

Este diagrama ilustra as interações entre os usuários e o sistema durante esses processos. A sequência inicia com o cadastro do usuário, que insere o e-mail e a senha. Em seguida, o sistema verifica os dados e confirma o registro. Após o cadastro, o usuário realiza o login para acessar as funcionalidades do sistema.

A alteração de senha é realizada quando o usuário solicita essa ação, e o sistema valida a identidade do usuário antes de permitir a alteração.

Em relação à solicitação de eventos, o usuário preenche um formulário com os detalhes do evento desejado. O Setor de Eventos verifica a disponibilidade do local e processa a solicitação.

Esses fluxos de interação são fundamentais para garantir que os usuários tenham uma experiência organizada e eficiente ao utilizar o sistema.


### Interações dos Componentes


<p align="center">
  <img src="https://github.com/user-attachments/assets/efa9bd1c-bf0b-40e4-84ff-0d096d7e73c8" alt="image" />
</p>



## Projeto da Interface
### Wireframes
Uma visão preliminar das telas principais  em dispositivos móveis que compõem a plataforma de eventos da PUC Minas Betim, destacando o fluxo e as principais funcionalidades para os usuários.

#### Tela Inicial
A página inicial dá aos usuários o primeiro acesso à plataforma de eventos da PUC Minas Betim.
<p align="center">
  <img src="https://github.com/user-attachments/assets/28ce7a19-ef3f-4add-a391-92a486b83c76" />
</p>

#### Tela Entrar
Aqui, os usuários podem inserir suas credenciais para acessar a plataforma. Em caso de esquecimento, é possível acessar a opção de recuperação de senha. Serve também como tela de retorno após o logout (Sair).
<p align="center">
  <img src="https://github.com/user-attachments/assets/d912ba33-89bd-49f6-a793-1fd63617d3d4" />
</p>

#### Tela Cadastrar
Para novos usuários registrarem suas credenciais e criarem uma conta.  
<p align="center">
  <img src="https://github.com/user-attachments/assets/86773829-af51-448e-b87e-9667405b48bc" />
</p>

#### Tela Alterar Senha
Uma tela dedicada para atualização de credenciais e redefinição de senha.  
<p align="center">
  <img src="https://github.com/user-attachments/assets/3a742361-f13c-430d-9e43-37e548ce678e" />
</p>

#### Tela Solicitação de Eventos
Nesta seção, o usuário pode solicitar a criação de novos eventos e palestras, fornecendo todas as informações relevantes.  
<p align="center">
  <img src="https://github.com/user-attachments/assets/53b71ada-1bf7-4aab-a8c0-4101b1ce4a10" />
</p>

#### Tela Eventos
Esta tela exibe a lista de eventos criados pelo usuário, com a opção de adicionar novos eventos por meio do botão "Novo Evento". 
<p align="center">
  <img src="https://github.com/user-attachments/assets/feced6cb-a9ab-41eb-8a3b-7e38c822edee" />
</p>


### Design Visual
A identidade visual da aplicação mobile será construída em torno das cores **branca** e **azul**, seguindo a paleta de cores do logo da **PUC Minas**, para garantir consistência com a identidade visual da universidade e a página web previamente criada. Incluímos o uso da cor **laranja** nos botões de ação **Cadastrar**, **Entrar**, **Alterar Senha** e **Solicitar Evento**. O uso do **branco** proporcionará uma base limpa e minimalista, enquanto o **azul** será aplicado em elementos chave para transmitir seriedade, confiança e profissionalismo, alinhando-se ao padrão visual da instituição. Já o uso do **laranja** transmite energia, criatividade, entusiasmo e dinamismo.

#### Estrutura e Paleta de Cores:
- **Fundo Principal**: A cor **branca** será predominantemente utilizada no fundo, proporcionando uma aparência leve e moderna. Esse fundo claro facilitará a leitura e criará um contraste elegante com outros elementos da interface.
- **Elementos em Azul**: O **azul** será aplicado nos componentes principais da interface, como cabeçalhos e links. Essa cor remete à confiabilidade e à excelência, além de reforçar a identidade visual da PUC Minas.
- **Destaques em Vermelho**: Itens que exigem uma ação negativa ou "não" serão destacados em **vermelho**. Esta cor forte e vibrante chamará a atenção do usuário, indicando claramente opções ou respostas que devem ser evitadas. O vermelho será utilizado em botões de cancelamento, alertas e mensagens de erro.
- **Botões em Laranja**: A cor laranja em layouts de aplicativos costuma transmitir energia, criatividade, entusiasmo e dinamismo. É uma cor quente e vibrante que pode estimular a ação e a interação. Será aplicado em botões de ação.

#### Componentes de UI:
- **Botões e Links**: Os botões de ação terão o laranja como cor de fundo, com texto branco, garantindo contraste e legibilidade. Já os botões de cancelamento ou respostas negativas terão um fundo vermelho, para uma clara diferenciação visual.
- **Textos e Títulos**: Os textos seguirão um estilo simples e direto, com títulos em azul para dar ênfase e hierarquia às informações, enquanto o corpo do texto será em cinza escuro ou preto para garantir uma boa legibilidade.
- **Ícones e Formulários**: Ícones e campos de formulário seguirão a mesma paleta de cores. Ícones de ação importante terão destaque azul, enquanto mensagens de erro ou alertas usarão ícones vermelhos.

Este design equilibrado entre o uso de cores claras e vibrantes não só representa a identidade visual da PUC Minas, mas também proporciona uma experiência de usuário intuitiva, clara e agradável, refletindo a seriedade e a qualidade da universidade.

### Layout Responsivo

A interface do aplicatico mobile será projetada para se adaptar de forma eficiente a diferentes tamanhos de tela e dispositivos, garantindo uma experiência de usuário otimizada em desktops e smartphones. Isso será alcançado por meio de práticas de **layout responsivo** usando as tecnologias **CSS**, **React Native** e **Javascript**, que permitirão uma transição suave entre os diferentes formatos de dispositivos.

#### Estrutura Responsiva:
- **CSS para Responsividade**: A abordagem responsiva envolve o uso de unidades proporcionais, como `%` para tamanhos relativos e `vh/vw` para dimensões baseadas na altura ou largura da tela.
#### Estratégias de Layout:
- **Smartphones (Telas Pequenas)**: Em dispositivos móveis, como smartphones, o layout será reestruturado para uma **estrutura em coluna única**. A navegação será simplificada, com menus em **hamburguer menus** ou botões de ação que se expandem, oferecendo uma navegação intuitiva em telas menores.

#### Imagens e Conteúdos Responsivos
- **Imagens Otimizadas**: Em React Native, as imagens foram ajustadas automaticamente com o estilo `resizeMode: "contain"` ou `resizeMode: "cover"`, garantindo que sejam exibidas corretamente em diferentes resoluções e tamanhos de tela.
- **Fontes e Tamanhos**: O tamanho das fontes será ajustado dinamicamente usando JavaScript e estilos proporcionais, com base na densidade de pixels (DPI) ou no tamanho da tela. A API `PixelRatio` do React Native foi usada para escalonar os tamanhos de texto, garantindo legibilidade em dispositivos pequenos:


#### Flexibilidade e Acessibilidade:
- O layout será **flexível e adaptável**, ajustando-se automaticamente à orientação da tela (retrato ou paisagem).
- Os elementos da interface, como botões e campos de formulário, terão tamanhos apropriados para toque em dispositivos móveis, assegurando uma **experiência de usuário acessível** e sem complicações.

Dessa forma, o layout responsivo garantirá que a aplicação ofereça uma interface adaptável, de fácil navegação e uso, independentemente do dispositivo ou tamanho da tela.

### Interações do Usuário
No sistema de gestão de eventos, existem **quatro tipos de usuários**, cada um com diferentes níveis de acesso e permissões. Esses usuários são: **administrador**, **aluno**, **funcionário** e **professor**.

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

#### Interações dos Componentes

1. **Tela Inicial**
   - O usuário pode:
     - Fazer login (direciona para a **Tela de Eventos**).
     - Cadastrar-se (cria o usuário e retorna para a **Tela Inicial**).

2. **Tela de Eventos**
   - Exibe uma lista de eventos cadastrados. 
   - Botões disponíveis:
     - **Solicitar Novo Evento**: Redireciona para a **Tela de Cadastro de Evento**.
     - **Alterar Senha**: Redireciona para a **Tela de Alteração de Senha**.

3. **Tela de Cadastro de Evento**
   - Formulário para cadastrar um novo evento:
     - Campos obrigatórios: nome, data, hora, local, descrição e categoria.
   - Ao clicar em **Enviar**:
     - Valida os dados no frontend.
     - Envia os dados ao backend.
     - Exibe mensagem de sucesso ou erro.
     - Redireciona para a **Tela de Eventos** com a lista atualizada.

4. **Tela de Alteração de Senha**
   - Exibe informações do usuário logado: nome, e-mail e perfil.
   - Campo para digitar a nova senha.
   - Ao clicar em **Alterar**:
     - Envia a solicitação ao backend.
     - Exibe mensagem de sucesso.
     - Redireciona para a **Tela de Eventos**.
    
<p align="center">
  <img src="https://github.com/user-attachments/assets/a7c41fc0-1005-43ea-a10a-920cc71f8d3d" alt="image" />
</p>


## Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                         | Prioridade |
|--------|---------------------------------------------------------------------------------------------------------------|------------|
| RF-01  | O aplicativo deve permitir que usuários dos tipos **administrador**, **aluno**, **funcionário** e **professor** possam cadastrar novos eventos. | Alta       |
| RF-02  | O formulário de cadastro de evento deve incluir campos obrigatórios como nome do evento, data, hora, local, descrição e categoria. | Alta       |
| RF-03  | O aplicativo deve permitir que todos os usuários visualizem a lista de eventos cadastrados por eles. | Alta       |
| RF-04  | A lista de eventos deve exibir informações básicas como nome, data, local e status do evento. | Alta       |
| RF-05  | A listagem deve permitir rolagem infinita (infinite scroll) caso haja mais eventos do que o espaço disponível na tela. | Alta       |
| RF-06  | O **administrador** deve ter a capacidade de excluir eventos. | Alta       |
| RF-07  | A exclusão de eventos deve ser feita através de um botão "Excluir" exibido ao lado ou em um menu de opções do evento listado. | Alta       |
| RF-08  | Após a exclusão, a lista de eventos deve ser atualizada imediatamente, sem a necessidade de recarregar o aplicativo. | Alta       |
| RF-09  | A navegação entre as telas do aplicativo deve ser clara e intuitiva, permitindo que os usuários acessem as telas de cadastro e listagem de eventos facilmente. | Alta       |
| RF-10  | A interface deve ser responsiva e se adaptar bem a diferentes tamanhos de tela, como smartphones e tablets. | Alta       |
| RF-11  | O aplicativo deve permitir que o usuário faça login com seu e-mail e senha. | Alta       |
| RF-12  | O usuário deve poder realizar logout, retornando à tela de login. | Alta       |
| RF-13  | O aplicativo deve exibir mensagens de erro caso o formulário de cadastro seja preenchido de maneira inadequada. | Alta       |
| RF-14  | O aplicativo deve exibir mensagens de sucesso quando o evento for cadastrado ou excluído com sucesso. | Alta       |


## Requisitos Não Funcionais

| Identificador | Requisitos                                                                | Classificação  | Prioridade |
|---------------|---------------------------------------------------------------------------|----------------|------------|
| RNF01         | A interface deve ser intuitiva e fácil de usar, com botões e elementos bem visíveis e organizados. | Usabilidade    | Alta       |
| RNF02         | A navegação entre telas deve ser clara, com uma barra de navegação ou menu acessível em todas as telas. | Usabilidade    | Alta       |
| RNF03         | O aplicativo deve garantir que as informações de login e cadastro sejam tratadas com segurança, utilizando criptografia para senhas e autenticação segura (ex.: OAuth2). | Segurança      | Alta       |
| RNF04         | Os dados dos eventos e do usuário devem ser validados no frontend antes de serem enviados ao backend. | Segurança      | Alta       |
| RNF05         | O aplicativo deve ser compatível com as plataformas iOS e Android. | Compatibilidade | Alta       |
| RNF06         | A interface deve se adaptar bem a diferentes resoluções de tela e dispositivos (smartphones e tablets). | Compatibilidade | Alta       |
| RNF07         | O código deve ser modular e reutilizável, facilitando futuras alterações e manutenções. | Manutenibilidade | Alta       |
| RNF08         | O uso de frameworks como **React Native** e bibliotecas como **Redux** ou **Context API** deve seguir boas práticas de desenvolvimento para garantir escalabilidade e fácil manutenção. | Manutenibilidade | Alta       |
| RNF09         | O aplicativo deve ser acessível para pessoas com deficiência visual e motora, garantindo que leitores de tela possam interpretar o conteúdo corretamente. | Acessibilidade | Alta       |
| RNF10         | Elementos interativos como botões devem ser navegáveis via teclado ou gestos. | Acessibilidade | Alta       |
| RNF11         | O aplicativo deve permitir a futura expansão para suportar diferentes idiomas, com textos e mensagens traduzíveis. | Internacionalização | Média      |



## Considerações de Segurança

Para garantir a segurança da aplicação de gestão de eventos, utilizaremos o **JSON Web Token (JWT)** para autenticar a sessão dos usuários. O JWT é uma maneira segura de garantir que as informações de autenticação sejam transmitidas de forma confiável entre o cliente e o servidor, sem a necessidade de armazenar dados de sessão no servidor.

#### Autenticação com JWT no React Native

- O usuário se autentica utilizando seu e-mail e senha na aplicação.
- Após a autenticação, o backend gera um **token JWT**, que é enviado para o cliente.
- O **token JWT** contém informações relevantes, como o ID do usuário e seu tipo (administrador, aluno, funcionário, professor), além de uma data de expiração definida para aumentar a segurança.
- O token é armazenado localmente no dispositivo do usuário, utilizando ferramentas como `AsyncStorage` (ou alternativas mais seguras, como `react-native-secure-storage`).
- Em cada requisição subsequente, o token é enviado no **header Authorization**, permitindo que o backend valide a autenticidade do usuário.
- O backend valida o token em cada requisição para garantir que o usuário tenha permissão para acessar o recurso solicitado.

## Implantação
Abaixo estão listadas as etapas e os requisitos para implantar a aplicação frontend em um ambiente de produção.

#### Requisitos de Software:
- **Plataforma de Hospedagem**: Vercel
- **Ambiente de Desenvolvimento**: React Native, `npm´ ou `yarn´ para gerenciar dependências.
- **Sistema Operacional Focado em**: Inicialmente voltada para dispositivos Android, com a possibilidade de expansão para outras plataformas, como iOS.

#### Requisitos de Hardware:
- **CPU**: um processador de alto desempenho, de preferência com vários núcleos (pelo menos 4 núcleos), para garantir que o processamento de solicitações e as operações do aplicativo ocorram rapidamente.
- **Memória RAM**:  Pelo menos 4 GB de memória RAM, o que garantirá que a aplicação consiga lidar com múltiplos processos simultâneos e o tráfego esperado de usuários.
- **Armazenamento**:  Espaço de armazenamento Baseado em tecnologia SSD (ou equivalente) com capacidade mínima de 32 GB, suficiente para rodar a aplicação de forma eficiente em dispositivos móveis.
- **Conexão de rede**: Conexões de alta velocidade, essenciais para o bom funcionamento da aplicação, evitando atrasos e garantindo que as interações API sejam realizadas de forma eficiente.
  
#### Passos para Implantação:

1. **Escolha da Plataforma de Hospedagem**:
   - Selecionamos a plataforma de hospedagem Vercel com base nas necessidades de escalabilidade e desempenho.
   
2. **Configuração do Ambiente de Implantação**:
   - Configuração do ambiente de implantação, que inclui a instalação do **React Native** e **npm**
   - Para uso do React Native e npm, instalação das dependências com o seguinte comando:
     ```bash
     npm install
     ```
3. **Deploy da Aplicação**:
   - Realize o build de produção da aplicação com o comando:
     ```bash
      npx expo start
     ```
   - Deploy da aplicação na plataforma **Vercel**

#### Considerações Finais:
- Certifique-se de que a aplicação esteja otimizada e responsiva em diferentes dispositivos, como desktops e smartphones.
- Verifique se as boas práticas de segurança estão implementadas, como HTTPS (SSL/TLS).

## Testes
Para demonstrar os testes feitos na plataforma, os mesmos foram separados por categorias explicativo para cada, demonstrando a eficácia das funcionalidades do sistema resultados esperados e obtidos. 

### **1.0 - Caso de Teste: Login com autenticação utilizando token JWT**

#### **Passos**
| **Passo** | **Descrição**                                                                 |
|-----------|-------------------------------------------------------------------------------|
| 1         | Acessar a página de login.                                                   |
| 2         | Inserir as credenciais (e-mail e senha) nos campos exibidos.                 |
| 3         | Clicar no botão "Continuar" para autenticar. O usuário será redirecionado para a página de listagem de evento já solicitados. |

#### **Resultados**
| **Resultado Esperado**                                     | **Resultado Alcançado**                                                                      |
|------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| Login bem-sucedido  **Request: 200 OK**                   | Usuário autenticado com sucesso. O token JWT foi gerado e armazenado no Async Storage.    |

<p align="center">
<img src="https://github.com/user-attachments/assets/da2abca2-cc7f-45c7-9d02-d426c84df222"    
</p>


<p align="center">
<img src="https://github.com/user-attachments/assets/c681d86f-73d0-4897-a64b-a39e443174ea"    
</p>


### **1.1 - Caso de Teste: Tentativa de Login**

#### **Passos**
| **Passo** | **Descrição**                                                                 |
|-----------|-------------------------------------------------------------------------------|
| 1         | Acessar a página de login.                                                   |
| 2         | Inserir um e-mail e/ou senha incorreta nos campos exibidos.          |
| 3         | Clicar no botão "Continuar" para tentar autenticar.                             |
| 4         | Caso a senha esteja incorreta, será exibido um pop-up com a mensagem "Usuário e/ou senha incorretos!". O usuário deve clicar no botão de fechar para tentar realizar o login novamente. |
| 5         | Inserir as credenciais corretas e clicar no botão "Continuar". O usuário será redirecionado para a página de listagem de evento já solicitados. |


#### **Resultados**
| **Cenário**                                              | **Resultado Esperado**                              | **Resultado Alcançado**                          |
|----------------------------------------------------------|----------------------------------------------------|-------------------------------------------------|
| Login com senha correta                                  | **Request: 200 OK** - Login bem-sucedido.          | Usuário autenticado com sucesso. O token JWT foi gerado e armazenado no Async Storage. O usuário foi redirecionado para a página de listagem de evento já solicitados. |
| Login com senha incorreta                                | **Request: 401 Unauthorized** - Login não-sucedido. | Um pop-up exibiu a mensagem "Usuário e/ou senha incorretos!". O usuário não foi autenticado, e o token JWT não foi gerado. O usuário permaneceu na página de login. |


Essa organização facilita a visualização do que é esperado e o que foi realmente alcançado durante o teste.

<p align="center">
<img src="https://github.com/user-attachments/assets/0422d037-9fbc-4fa7-97d8-0922cdf88b5d"    
</p>
  

<p align="center">
<img src="https://github.com/user-attachments/assets/9d269ffe-a763-4b22-9e31-b0ed80f33ffd"    
</p>



### **2.0 -Caso de teste de Cadastro de Usuários**

#### **Passos**
| **Passo** | **Descrição**                                                                 |
|-----------|-------------------------------------------------------------------------------|
| 1         | Acessar a página de cadastro.                                                |
| 2         | Inserir as credenciais (nome, e-mail, senha, confirmar senha e tipo de usuário) nos campos exibidos. |
| 3         | O campo `e-mail` possui validação, sendo obrigatório inserir um e-mail institucional. |
| 4         | No campo `tipo de usuário`, o usuário deve selecionar entre as opções: aluno, professor ou funcionário. |
| 5         | Clicar no botão "Cadastrar" para concluir o cadastro.                        |
| 6         | Um modal será exibido com a mensagem "Cadastro realizado com sucesso!" e o usuário será redirecionado para a página de login. |

#### **Resultados**
| **Cenário**                                              | **Resultado Esperado**                              | **Resultado Alcançado**                          |
|----------------------------------------------------------|----------------------------------------------------|-------------------------------------------------|
| Cadastro com e-mail válido                               | **Request: 200 OK**                                | Cadastro realizado com sucesso. Modal exibido com a mensagem "Cadastro realizado com sucesso!" e o usuário será redirecionado para a página de login. |
| Cadastro com e-mail inválido (não institucional)         | **Mensagem de alerta**                             | Exibição de mensagem indicando que o e-mail deve ser institucional e impedindo o cadastro. |

<p align="center">
<img src="https://github.com/user-attachments/assets/e77ecef9-3146-4e1d-8587-1f20523148d3"    
</p>
  
<p align="center">
<img src="https://github.com/user-attachments/assets/5b2a9b93-449b-4d4f-b811-ef4f383bcd63"    
</p>


<p align="center">
<img src="https://github.com/user-attachments/assets/d3bea4c7-508b-4776-ae46-db1160a67201"    
</p>




# Referências

ALVES, P. Desenvolvimento de Interfaces com React. São Paulo: Editora Dev, 2022.

COSTA, L. Fundamentos de CSS e JavaScript. Rio de Janeiro: Editora Code, 2021.

KRAUSE, M. Tutorial de Diagrama de Sequência UML | Passo a Passo para Desenvolver Aplicações Modernas. YouTube, 2023. Disponível em: https://www.youtube.com/watch?v=qaWShGkUiBo. Acesso em: 1 nov. 2024.

MDN WEB DOCS (Mozilla Developer Network). Documentação de HTML, CSS e JavaScript. Disponível em: https://developer.mozilla.org/. Acesso em: 1 nov. 2024.

W3SCHOOLS. CSS, JavaScript, React, e mais. Disponível em: https://www.w3schools.com/. Acesso em: 1 nov. 2024.

CSS-TRICKS. Artigos, tutoriais e dicas sobre CSS e front-end. Disponível em: https://css-tricks.com/. Acesso em: 1 nov. 2024.

REACT DOCUMENTATION. Introdução e guia oficial do React. Disponível em: https://react.dev/. Acesso em: 1 nov. 2024.

ALURA. Configurando o ambiente React Native. Disponível em: https://www.alura.com.br/artigos/configurando-o-ambiente-react-native. Acesso em: 19 nov. 2024.

REACT NATIVE. Documentação de React Native. Disponível em: https://reactnative.dev/. Acesso em : 21 nov.2024

