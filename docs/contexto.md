# Introdução

A proposta deste projeto é desenvolver uma aplicação web e mobile para gerenciar os eventos da PUC Minas Betim, localizada na cidade de Betim, Minas Gerais, que integra a Região Metropolitana de Belo Horizonte. A PUC Minas conta com seu campus principal no Coração Eucarístico e nove unidades adicionais: Barreiro, Betim, Contagem, Lourdes, Poços de Caldas, Virtual e São Gabriel. O desenvolvimento será realizado por um grupo de alunos do 6º período do curso de Sistemas de Informação da PUC Minas Virtual, utilizando a unidade Betim como exemplo.

Atualmente, a PUC Minas Betim utiliza um documento em Word, denominado "CHECK LIST Eventos", para a solicitação de eventos. Este documento pode ser preenchido por professores, funcionários e alunos, e enviado ao Setor de Eventos para aprovação e organização. Com uma média de 20 solicitações de eventos por mês, esse processo é antiquado, resultando em dados desorganizados e incompletos. A forma como os eventos são solicitados frequentemente gera erros, tornando a organização dos mesmos um desafio significativo.

Além disso, o processo atual enfrenta diversos problemas, como a falta de adesão aos prazos por parte dos solicitantes, o que gera transtornos na organização. Muitas vezes, as demandas de infraestrutura não são especificadas claramente, resultando em pedidos emergenciais durante os eventos. Informações essenciais para a organização também são frequentemente omitidas, obrigando o Setor de Eventos a buscar esses dados de última hora, complicando ainda mais o processo de preparação.

Esses desafios tornam evidente a necessidade de uma plataforma para o gerenciamento dos eventos acadêmicos e administrativos da PUC Minas Betim. A nova aplicação será projetada com princípios de design responsivo, buscando um funcionamento adequado tanto em página web quanto em dispositivos móveis. O projeto inclui requisitos funcionais e não funcionais, além da documentação da arquitetura distribuída, catálogo de serviços e análise de custos.

## Objetivos

O principal objetivo deste projeto é desenvolver uma aplicação distribuída para o gerenciamento de eventos na PUC Minas Betim, projetada para suportar até 50 usuários simultâneos e com uma arquitetura escalável para até 100 usuários simultâneos que permita sua adaptação e expansão para as demais unidades da universidade.

## Objetivos específicos:

Preparar a Aplicação para Escalabilidade: Projetar a arquitetura da aplicação com a capacidade de escalonamento horizontal e vertical, permitindo que a aplicação seja facilmente expandida para suportar até 100 usuários simultâneos, conforme necessário.

Desenvolver Mecanismos de Controle de Acesso: Implementar um sistema de autenticação e autorização que assegure que diferentes níveis de acesso sejam atribuídos de acordo com os perfis de usuários (alunos, professores, funcionários).

Facilitar a Expansão para Outras Unidades: Estruturar o sistema de forma modular, com configurações e dados que possam ser personalizados para atender às necessidades específicas de diferentes unidades da PUC Minas, permitindo uma implementação ágil em novas localidades.

Integrar Ferramentas de Monitoramento e Relatórios: Desenvolver funcionalidades que permitam o monitoramento em tempo real da utilização da aplicação e a geração de relatórios sobre eventos, participação e recursos, para apoiar a tomada de decisões administrativas.

Conduzir Testes de Usabilidade e Ajustes Finais: Realizar testes de usabilidade com usuários reais para identificar e corrigir problemas, garantindo que a aplicação atenda às expectativas de funcionalidade e facilidade de uso.

## Justificativa

A proposta de um sistema distribuído para o gerenciamento de eventos surge como resposta aos problemas recorrentes que têm tornado o processo atual moroso e desorganizado. Os erros constantes, como a demanda de última hora e o fornecimento de informações incompletas, têm prejudicado a organização dos eventos e causado sérios transtornos ao Setor de Eventos e também aos outros setores envolvidos.

Com a implementação desse sistema, será possível gerenciar os pedidos de eventos de maneira mais organizada, com prazos estabelecidos e regras claras, evitando surpresas e contratempos.

Essa proposta, portanto, não visa apenas aprimorar a organização do Setor de Eventos, mas também proporcionar um ambiente de trabalho mais tranquilo e controlado, onde as solicitações são tratadas com a devida atenção e dentro dos parâmetros estabelecidos.

## Público-Alvo

O público-alvo desta aplicação inclui alunos, professores e funcionários da PUC Minas Betim, abrangendo indivíduos com idades entre 17 e 70 anos. Este grupo é composto por usuários com diferentes níveis de familiaridade com tecnologia, desde aqueles com conhecimentos básicos até avançados em informática. Além disso, inclui o gestor do sistema, que atuará como administrador, gerenciando o sistema, emitindo relatórios e encaminhando as solicitações para avaliação pela coordenação, Diretoria de Graduação e setores envolvidos.

## Especificações do Projeto

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

| Identificador | Requisitos                                                                                  | Classificação        | Prioridade |
|---------------|----------------------------------------------------------------------------|----------------------------|------------|
| RF01          | O sistema deve permitir o cadastro de locais físicos, especificando prazos mínimos de antecedência para as reservas. Além disso, deve oferecer funcionalidades para editar, visualizar e excluir esses cadastros conforme necessário. | Gestão do evento         | Alta       |
| RF02          | O sistema deve permitir o cadastro de outras unidades, especificando prazos mínimos de antecedência para as reservas. Além disso, deve oferecer funcionalidades para editar, visualizar e excluir esses cadastros conforme necessário. | Gestão das unidades         | Alta       |
| RF03          | Permitir a criação de eventos, validando a data de início e fim do evento, informando o usuário caso a data escolhida não atenda ao prazo mínimo de antecedência. | Gestão de Eventos         | Alta       |
| RF04          | Permitir a criação de eventos fora do prazo mínimo de antecedência em casos excepcionais. | Gestão de eventos         | Alta       |
| RF05          | Permitir que o sistema envie uma notificação para a Coordenação e/ou a Diretoria de Graduação visualizar a solicitação do evento para ser deferido ou indeferido com prazo pré estabelecido. | Ciclo de eventos         | Alta       |
| RF06          | Permitir que o sistema envie notificações ao solicitante sobre deferimento ou indeferimento do evento. | Ciclo de eventos         | Alta       |
| RF07          | Permitir que o sistema envie notificações aos solicitantes caso o local do evento seja alterado ou esteja indisponível na data solicitada. | Ciclo de eventos         | Alta      |
| RF08          | Permitir que o solicitante envie alterações sobre o evento dentro do prazo estabelecido. | Ciclo de eventos | Alta       |
| RF09          | Implementar login e registro de usuários, com diferentes níveis de acesso (administradores e participantes). | Gestão do usuário | Alta       |
| RF10          | Oferecer funcionalidades de busca do evento por data, curso, setor ou funcionário, com filtros para encontrar eventos específicos. (setor) | Gestão de eventos        | Alta       |
| RF11          | Permitir que o sistema emita um resumo do evento em formatos como PDF e DOCX. | Relatório final       | Média       |




### Requisitos Não Funcionais

| Identificador | Requisitos                                                                | Classificação  | Prioridade |
|---------------|---------------------------------------------------------------------------|----------------|------------|
| RNF01         | A aplicação deve ser responsiva, mesmo com 50 usuários simultâneos. | Desempenho     | Alta       |
| RNF02         | Garantir a proteção dos dados dos usuários e a integridade das informações dos eventos. | Segurança      | Alta       |
| RNF03         | O sistema deve ser funcional em diferentes dispositivos. | Usabilidade    | Média      |
| RNF04         | A aplicação deve responder bem até 50 usuários simultâneos e suportar um aumento de até 100 usuários simultâneos sem perda de desempenho. | Escalabilidade | Média      |
| RNF05         | Deve funcionar em diversos navegadores e sistemas operacionais, tanto em web client e mobile. | Compatibilidade | Média      |
| RNF06         | O código deve ser bem documentado e estruturado para facilitar futuras manutenções e atualizações. | Manutenibilidade | Média      |
| RNF07         | A aplicação deve estar disponível e acessível 24/7, com um tempo de inatividade mínimo. | Disponibilidade | Alta       |

## Restrições

A princício, foram identificadas duas restrições, que estão descritas abaixo:

1. Orçamento Limitado: Como é um projeto acadêmico, o orçamento pode ser restrito, limitando as escolhas tecnológicas e de hospedagem;
2. Prazo de Entrega: O sistema deve estar finalizado até dezembro, exigindo uma gestão eficiente do tempo.

## Catálogo de Serviços

Abaixo, enumeramos os principais serviços que serão oferecidos em nossa aplicação web/mobile:

1. Cadastro de Solicitações de Eventos:
   Criação, edição e exclusão de solicitações de eventos.
   Aprovação e acompanhamento das solicitações.

2. Notificações Automáticas:
   Notificações sobre o status das solicitações (deferido, indeferido, em análise).
   Lembretes de prazos e atualizações de eventos.

3. Cadastro de Solicitação de Infraestrutura:
   Solicitação de espaços físicos e equipamentos.
   Coordenação com setores de infraestrutura e técnico.
   
4. Acompanhamento de solicitações de eventos:
   Lista de eventos com detalhes e opções de filtro.
   
5. Autenticação e Níveis de Acesso:
   Diferentes níveis de acesso para administradores, professores, funcionários e alunos.

## Arquitetura da Solução

A aplicação web/mobile foi idealizada em sua arquitetura como sendo cliente-servidor. Tal arquitetura se dá como uma rede em que um programa de computador (cliente), solicita um serviço ou recurso de outro programa de computador (servidor), recebendo uma resposta com as informações solicitadas por meio de protocolos de rede em infraestruturas de TI.
A API se dará em estrutura monolítica, onde todos os componentes são integrados em uma única aplicação.

## Tecnologias Utilizadas

1. Frontend: React native
2. Backend: Dot Net
3. Banco de Dados: MySQL
4. Hospedagem: AWS

## Hospedagem

1. Ambiente de Desenvolvimento: Local com uso de Docker para garantir a consistência entre ambientes.
2. Ambiente de Produção: Hospedagem na nuvem, com AWS utilizando instâncias EC2, banco de dados gerenciado (RDS), e armazenamento de arquivos no S3.
3. Monitoramento e Logs: Ferramentas como AWS CloudWatch para monitorar a performance e logs da aplicação.

