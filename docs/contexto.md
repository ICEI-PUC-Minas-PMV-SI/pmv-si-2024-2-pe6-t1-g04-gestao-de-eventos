# Introdução

A proposta deste projeto é desenvolver uma aplicação web e mobile com foco na criação de uma página para gerenciar os eventos da PUC Minas Betim, que servirá como modelo para as demais unidades da Universidade. A página será projetada com princípios de design responsivo, garantindo um funcionamento eficaz tanto em desktops quanto em dispositivos móveis. O projeto incluirá a definição de personas, histórias de usuários, requisitos funcionais e não funcionais, bem como a documentação da arquitetura distribuída e do catálogo de serviços, além da análise de custos.


## Problema
Atualmente, a PUC Minas Betim utiliza um documento em Word intitulado "CHECK LIST Eventos" para a solicitação de eventos, o qual pode ser preenchido por professores, funcionários e alunos e enviado ao Setor de Eventos para aprovação e organização. No entanto, esse processo é ultrapassado e resulta em dados desorganizados e incompletos. A unidade oferece 9 cursos de graduação, incluindo o curso de Medicina, que gera um número elevado de solicitações de eventos. Devido à forma como o processo é conduzido, frequentemente ocorrem erros, tornando a organização dos mesmos um desafio.
Após o envio da solicitação do evento ao setor, o documento: "CHECK LIST Eventos"  é encaminhado para aprovação da Coordenação do curso e/ou da Diretoria de Graduação. Eventos realizados dentro da Unidade precisam apenas do parecer da Coordenação, enquanto eventos fora da Unidade requerem a aprovação tanto da Coordenação quanto da Diretoria de Graduação. O Setor de Eventos, ao receber o parecer, seja ele favorável ou contrário, comunica a decisão ao solicitante.
Quando aprovado, o evento é cadastrado no Sistema de Gestão Acadêmica (SGA) para que os alunos possam se inscrever, desde que o responsável marque essa opção. Além disso, são enviados os detalhes para a infraestrutura, como reserva de espaço, necessidade de café, água e outros requisitos. No caso de eventos online, a solicitação é encaminhada ao setor técnico (CRC), e, se necessário, à Assessoria de Comunicação para divulgação.
O Setor de Eventos enfrenta desafios significativos devido à falta de uma plataforma centralizada e eficiente. A ausência de uma solução integrada dificulta a organização, divulgação e acompanhamento dos eventos, tornando o processo menos ágil e mais propenso a erros. Portanto, a implementação de uma plataforma dedicada é crucial para melhorar a eficiência para o gerenciamento dos eventos acadêmicos e administrativos da PUC Minas Betim.


> **Links Úteis**:
> - [Objetivos, Problema de pesquisa e Justificativa](https://medium.com/@versioparole/objetivos-problema-de-pesquisa-e-justificativa-c98c8233b9c3)
> - [Matriz Certezas, Suposições e Dúvidas](https://medium.com/educa%C3%A7%C3%A3o-fora-da-caixa/matriz-certezas-suposi%C3%A7%C3%B5es-e-d%C3%BAvidas-fa2263633655)
> - [Brainstorming](https://www.euax.com.br/2018/09/brainstorming/)

## Objetivos

O principal objetivo desta proposta é desenvolver uma solução centralizada e eficiente para o gerenciamento de eventos na PUC Minas Betim, que possa ser expandida para outras unidades da universidade. A proposta visa criar uma plataforma web e mobile que permita a organização e acompanhamento de eventos de maneira integrada e simplificada. Com isso, busca-se:
- Otimizar o Processo de Solicitação: Automatizar e padronizar a solicitação de eventos, garantindo que todos os requisitos sejam atendidos dentro dos prazos estabelecidos, evitando assim os transtornos causados por pedidos tardios ou incompletos.
- Facilitar a Gestão de Infraestrutura: Permitir a especificação clara e antecipada das demandas de infraestrutura, reduzindo as solicitações emergenciais e melhorando a coordenação entre os setores envolvidos.
- Melhorar a Comunicação e Transparência: Centralizar a comunicação entre solicitantes e o Setor de Eventos, proporcionando um fluxo de informações mais claro e acessível, o que facilitará o acompanhamento de aprovações, ajustes e necessidades específicas.
- Aumentar a Eficiência Organizacional: Reduzir a sobrecarga de trabalho do Setor de Eventos e demais áreas envolvidas, permitindo que os eventos sejam organizados de forma mais eficiente e com menos margem para erros.

## Justificativa:
Atualmente, a PUC Minas Betim utiliza um documento em Word intitulado "CHECK LIST Eventos" para a solicitação de eventos, o qual pode ser preenchido por professores, funcionários e alunos e enviado ao Setor de Eventos para aprovação e organização. No entanto, esse processo é ultrapassado e resulta em dados desorganizados e incompletos. A unidade oferece 9 cursos de graduação, incluindo o curso de Medicina, que gera um número elevado de solicitações de eventos. Devido à forma como o processo é conduzido, frequentemente ocorrem erros, tornando a organização dos mesmos um desafio.
Após o envio da solicitação do evento ao setor, o documento: "CHECK LIST Eventos"  é encaminhado para aprovação da Coordenação do curso e/ou da Diretoria de Graduação. Eventos realizados dentro da Unidade precisam apenas do parecer da Coordenação, enquanto eventos fora da Unidade requerem a aprovação tanto da Coordenação quanto da Diretoria de Graduação. O Setor de Eventos, ao receber o parecer, seja ele favorável ou contrário, comunica a decisão ao solicitante.
Quando aprovado, o evento é cadastrado no Sistema de Gestão Acadêmica (SGA) para que os alunos possam se inscrever, desde que o responsável marque essa opção. Além disso, são enviados os detalhes para a infraestrutura, como reserva de espaço, necessidade de café, água e outros requisitos. No caso de eventos online, a solicitação é encaminhada ao setor técnico (CRC), e, se necessário, à Assessoria de Comunicação para divulgação.
O Setor de Eventos enfrenta desafios significativos devido à falta de uma plataforma centralizada e eficiente. A ausência de uma solução integrada dificulta a organização, divulgação e acompanhamento dos eventos, tornando o processo menos ágil e mais propenso a erros. Portanto, a implementação de uma plataforma dedicada é crucial para melhorar a eficiência para o gerenciamento dos eventos acadêmicos e administrativos da PUC Minas Betim.


Aqui você deve descrever os objetivos do trabalho indicando que o objetivo geral é desenvolver um software para solucionar o problema apresentado acima. 

Apresente também alguns (pelo menos 2) objetivos específicos dependendo de onde você vai querer concentrar a sua prática investigativa, ou como você vai aprofundar no seu trabalho.
 
> **Links Úteis**:
> - [Objetivo geral e objetivo específico: como fazer e quais verbos utilizar](https://blog.mettzer.com/diferenca-entre-objetivo-geral-e-objetivo-especifico/)

## Justificativa

A proposta de um sistema centralizado para o gerenciamento de eventos surge como resposta aos problemas recorrentes que têm tornado o processo atual moroso e desorganizado. Os erros constantes, como a demanda de última hora e o fornecimento de informações incompletas, têm prejudicado a organização dos eventos e causado sérios transtornos ao Setor de Eventos e aos funcionários envolvidos.
A ausência de uma ferramenta eficaz dificulta o controle das solicitações, resultando em uma falta de organização e supervisão adequada. Isso leva a uma sobrecarga de trabalho para os funcionários, que se veem obrigados a lidar com demandas urgentes, revisões de última hora e correções constantes, comprometendo a qualidade do trabalho e gerando estresse desnecessário.
Com a implementação de um sistema automatizado, será possível gerenciar os pedidos de eventos de maneira eficaz, com prazos estabelecidos e regras claras. A obrigatoriedade de confirmar a leitura e o entendimento das diretrizes antes do envio da solicitação garantirá que todos os envolvidos sigam um processo padronizado, reduzindo significativamente os erros e garantindo que os eventos sejam organizados conforme planejado.
Essa proposta visa, portanto, não apenas melhorar a eficiência e a organização do Setor de Eventos, mas também proporcionar um ambiente de trabalho mais tranquilo e controlado, onde as solicitações são tratadas com a devida atenção e dentro dos parâmetros estabelecidos.


Descreva a importância ou a motivação para trabalhar com esta aplicação que você escolheu. Indique as razões pelas quais você escolheu seus objetivos específicos ou as razões para aprofundar em certos aspectos do software.

O grupo de trabalho pode fazer uso de questionários, entrevistas e dados estatísticos, que podem ser apresentados, com o objetivo de esclarecer detalhes do problema que será abordado pelo grupo.

> **Links Úteis**:
> - [Como montar a justificativa](https://guiadamonografia.com.br/como-montar-justificativa-do-tcc/)

## Público-Alvo

Alunos, Professores e Funcionários da PUC Minas Betim.

# Definição de personas
Persona 1: Administrador de Eventos
Nome: João da Silva
Idade: 45 anos
Ocupação: Funcionário do setor de Eventos da PUC Minas Betim.
Objetivos:
Gerenciar a solicitação de eventos presenciais e virtuais;
Gerenciar uso de espaços físicos;
Gerenciar Certificado de Palestrantes;
Solicitação de equipamentos e Coffee Break (enviar solicitação para a Infra estrutura);
Solicitação de transmissão ao vivo (enviar solicitação para a CRC);
Monitorar deferimento de eventos (entre a Coordenação e Diretoria de Graduação);
Divulgação dos Eventos (enviar solicitação para Assessoria de Comunicação).
Desafios:
Necessidade de uma interface intuitiva para gerenciar múltiplos eventos.
Garantir que a solicitação seja completa para que não surjam contratempos no decorrer do evento.
Tecnologia: Utiliza tanto desktop quanto dispositivos móveis para acessar a aplicação.

Persona 2: Estudante Participante
Nome: Maria Eduarda
Idade: 21 anos
Ocupação: Estudante de Direito da PUC Minas Betim.
Objetivos:
Solicitar eventos acadêmicos e serviços necessários.
Receber o parecer do setor de eventos.
Desafios:
Necessidade de uma plataforma que facilite a comunicação com os participantes (alunos, setor de eventos, Coordenação e Diretoria de Graduação). 	
Garantir que os eventos sejam bem organizados.
Tecnologia: Principalmente dispositivos móveis, mas também acessa via desktop.

Persona 3: Professor Palestrante
Nome: Dr. Carlos Henrique
Idade: 48 anos
Ocupação: Professor da PUC Minas Betim e palestrante.
Objetivos:
Solicitar eventos acadêmicos e serviços necessários.
Receber o parecer do setor de eventos.
Desafios:
Necessidade de uma plataforma que facilite a comunicação com os participantes (setor de eventos, professores). 	
Garantir que os eventos sejam bem organizados.
Tecnologia: Utiliza tanto desktop quanto dispositivos móveis.

# Histórias de usuário

 est001 - como [afiliado da PUC Minas] eu quero poder abrir uma solicitação para realizar um evento nas dependências da universidade

est002 - como [analista/secretaria] quero receber solicitações de eventos padronizadas para facilitar a conferência de viabilidade

est003 - como [analista/secretaria] quero ter uma lista das solicitações  de eventos em aberto para realizar a análise

est004 - como [analista/secretaria] quero verificar a viabilidade de cada solicitação para classificar em viável ou não viável

est005 - como [analista/secretaria] quero listar todas as solicitações em aberto para acompanhar o andamento de cada uma

est006 - como [analista/secretaria] quero poder pedir mais informações para o solicitante para eventual análise de dados faltantes

est007 - como [afiliado da PUC Minas] quero encaminhar informações adicionais para atender a solicitação de uma análise

est008 - como [analista/secretaria] quero encaminhar uma solicitação viável para a aprovação e assinatura do documento

· est009 - como [analista/secretaria] quero encaminhar a solicitação aprovada para o solicitante afiliado da PUC Minas para que ele possa iniciar os preparativos do evento

· est010 - como [analista/secretaria] quero encaminhar a solicitação aprovada para o setores envolvidos PUC Minas para ciência e deferimento do documento

est011 - como [afiliado da PUC Minas] quero poder verificar o status da solicitação para conseguir acompanhar o andamento do meu pedido

est012 - como [afiliado da PUC Minas] quero receber notificação sobre o status da solicitação para ficar atualizado sobre o andamento do meu pedido


Descreva quem serão as pessoas que usarão a sua aplicação indicando os diferentes perfis. O objetivo aqui não é definir quem serão os clientes ou quais serão os papéis dos usuários na aplicação. A ideia é, dentro do possível, conhecer um pouco mais sobre o perfil dos usuários: conhecimentos prévios, relação com a tecnologia, relações
hierárquicas, etc.

Adicione informações sobre o público-alvo por meio de uma descrição textual, diagramas de personas e mapa de stakeholders.

> **Links Úteis**:
> - [Público-alvo](https://blog.hotmart.com/pt-br/publico-alvo/)
> - [Como definir o público alvo](https://exame.com/pme/5-dicas-essenciais-para-definir-o-publico-alvo-do-seu-negocio/)
> - [Público-alvo: o que é, tipos, como definir seu público e exemplos](https://klickpages.com.br/blog/publico-alvo-o-que-e/)
> - [Qual a diferença entre público-alvo e persona?](https://rockcontent.com/blog/diferenca-publico-alvo-e-persona/)

# Especificações do Projeto

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

| Identificador | Requisitos                                                                                  | Classificação        | Prioridade |
|---------------|----------------------------------------------------------------------------|----------------------------|------------|
| RF01          | Permitir que os usuários possam criar eventos online com prazo de 5 dias úteis de antecedência. | Criação de Eventos         | Alta       |
| RF02          | Permitir que os usuários possam criar eventos para sala de aula campus Betim com prazo de 10 dias úteis de antecedência no máximo 60 pessoas. | Criação de Eventos         | Alta       |
| RF03          | Permitir que os usuários possam criar eventos para Auditório campus Betim com prazo de 15 dias úteis de antecedência e mínimo de 100 pessoas. | Criação de Eventos         | Alta       |
| RF04          | Permitir que os usuários possam criar eventos para Multimeios campus Betim com prazo de 15 dias úteis de antecedência e mínimo 70 pessoas. | Criação de Eventos         | Alta       |
| RF05          | Permitir que os usuários possam criar eventos para Laboratórios campus Betim com prazo de 15 dias úteis de antecedência. | Criação de Eventos         | Alta       |
| RF06          | Permitir que os usuários possam criar eventos para Hall campus Betim com prazo de 15 dias úteis de antecedência. | Criação de Eventos         | Alta       |
| RF07          | Permitir que os usuários possam criar eventos para outra unidade, campus ou outros locais solicitação deve ser feita com prazo de 20 dias úteis de antecedência. | Criação de Eventos         | Média      |
| RF08          | Permitir que os usuários possam editar eventos, antes de enviar a solicitação. | Edição e Exclusão de Eventos | Alta       |
| RF09          | Permitir que os usuários possam excluir eventos, antes de enviar a solicitação. | Edição e Exclusão de Eventos | Alta       |
| RF10          | Permitir que o usuário realize a descrição do Evento para análise da Coordenação e/ou Diretoria de Graduação. | Descrição do Evento        | Alta       |
| RF11          | Permitir que a Coordenação defira ou indefira a solicitação de eventos realizados na Unidade Betim. | Aprovação de Eventos       | Alta       |
| RF12          | Permitir que a Coordenação e a Diretoria de Graduação defiram ou indefiram a solicitação do Evento solicitados em outros locais fora da Unidade Betim. | Aprovação de Eventos       | Alta       |
| RF13          | Enviar notificações ao solicitante sobre deferimento ou indeferimento do evento. | Notificações               | Alta       |
| RF14          | Enviar notificações aos solicitantes sobre alterações do evento. | Notificações               | Média      |
| RF15          | Permitir encaminhar ao solicitante mais informações sobre o evento. | Notificações               | Média      |
| RF16          | Permitir o solicitante retornar alterações sobre o evento. | Notificações               | Média      |
| RF17          | Implementar login e registro de usuários, com diferentes níveis de acesso (administradores e participantes). | Login e Registro de Usuários | Alta       |
| RF18          | Sincronizar eventos com calendários da PUC Minas. | Sincronização com Calendários | Média      |
| RF19          | Oferecer funcionalidades de busca do evento por data, curso, setor ou funcionário, com filtros para encontrar eventos específicos. (setor) | Funcionalidades de Busca   | Alta       |
| RF20          | Oferecer funcionalidades de busca dos eventos em andamento, finalizados e indeferidos. (setor) | Funcionalidades de Busca   | Alta       |
| RF21          | Implementar as opções de serviços necessários para encaminhamento ao setor de Infraestrutura, visando a organização do evento. | Serviços de Infraestrutura | Alta       |
| RF22          | Implementar as opções de serviços necessários para encaminhamento ao setor de Laboratórios, visando a organização do evento. | Serviços de Laboratórios   | Alta       |
| RF23          | Permitir que o sistema emita um resumo do evento em formatos como PDF e DOCX. | Emissão de Resumo do Evento | Média      |



### Requisitos Não Funcionais

| Identificador | Requisitos                                                                 | Classificação  | Prioridade |
|---------------|---------------------------------------------------------------------------|----------------|------------|
| RNF01         | A aplicação deve carregar rapidamente e ser responsiva, mesmo com um grande número de usuários simultâneos. | Desempenho     | Alta       |
| RNF02         | Garantir a proteção dos dados dos usuários e a integridade das informações dos eventos. | Segurança      | Alta       |
| RNF03         | A interface deve ser intuitiva e fácil de usar, com um design responsivo que funcione bem em diferentes dispositivos. | Usabilidade    | Média      |
| RNF04         | A aplicação deve ser capaz de crescer e suportar um aumento no número de eventos e usuários sem perda de desempenho. | Escalabilidade | Média      |
| RNF05         | Deve funcionar em diversos navegadores e sistemas operacionais, tanto em desktops quanto em dispositivos móveis. | Compatibilidade | Média      |
| RNF06         | O código deve ser bem documentado e estruturado para facilitar futuras manutenções e atualizações. | Manutenibilidade | Média      |
| RNF07         | A aplicação deve estar disponível e acessível 24/7, com um tempo de inatividade mínimo. | Disponibilidade | Alta       |



Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

1. Orçamento Limitado: Como é um projeto acadêmico, o orçamento pode ser restrito, limitando as escolhas tecnológicas e de hospedagem.
2. Prazo de Entrega: O sistema deve estar finalizado até dezembro, exigindo uma gestão eficiente do tempo.
3. Complexidade da Integração: A integração com sistemas já existentes, como o Sistema de Gestão Acadêmica (SGA), pode ser desafiadora.
4. Escalabilidade: Embora o foco inicial seja na unidade Betim, o sistema precisa ser escalável para outras unidades da PUC Minas.
5. Segurança de Dados: A proteção de informações pessoais e sensíveis dos usuários é crucial.
6. Conformidade com Políticas Institucionais: O sistema deve seguir as políticas de TI e governança da PUC Minas.
7. Acessibilidade: A aplicação deve ser acessível para pessoas com diferentes necessidades.
8. Complexidade com calendário acadêmico da PUC Minas: Apresentar no software datas em que a PUC segue mediante feriados e férias.


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

# Catálogo de Serviços

1. Cadastro de Solicitações de Eventos:
   Criação, edição e exclusão de solicitações de eventos.
   Aprovação e acompanhamento das solicitações.
2. Notificações Automáticas:
Notificações sobre o status das solicitações (deferido, indeferido, em análise).
Lembretes de prazos e atualizações de eventos.
3. Cadastro de Solicitação de Infraestrutura:
   Solicitação de espaços físicos e equipamentos.
   Coordenação com setores de infraestrutura e técnico.
4. Integração com Calendário:
   Sincronização dos eventos com o calendário institucional.
5. Acompanhamento de solicitações de eventos:
   Lista de eventos com detalhes e opções de filtro.
6. Autenticação e Níveis de Acesso:
   Diferentes níveis de acesso para administradores, professores, funcionários e alunos.


# Arquitetura da Solução

1. Frontend:
   Web Application: Desenvolvida com React.js para a interface web.
   Mobile Application: Desenvolvida com React Native ou Flutter para garantir a responsividade em dispositivos móveis.
2. Backend:
   API RESTful: Desenvolvida em Go para fornecer os serviços da aplicação.
Banco de Dados: MySQL para armazenar os dados dos eventos e usuários.
3. Integrações:
   Integração com calendário.
4. Hospedagem:
   Hospedagem na nuvem utilizando serviços como AWS.
Uso de Docker para containerização das aplicações.
5. Segurança:
   Implementação de HTTPS para comunicação segura.


Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![arq](https://github.com/user-attachments/assets/b9402e05-8445-47c3-9d47-f11696e38a3d)


## Tecnologias Utilizadas

1. Frontend: React.js
2. Backend: Go
3. Banco de Dados: MySQL
4. Hospedagem: AWS


Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

1. Ambiente de Desenvolvimento: Local com uso de Docker para garantir a consistência entre ambientes.
2. Ambiente de Produção: Hospedagem na nuvem, com AWS utilizando instâncias EC2, banco de dados gerenciado (RDS), e armazenamento de arquivos no S3.
3. Monitoramento e Logs: Ferramentas como AWS CloudWatch para monitorar a performance e logs da aplicação.


Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
