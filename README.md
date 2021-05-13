# Blazor_Course

## Projetos desenvolvidos com:
- .NET core 3.1
- Visual Studio 2019
- SQL Server

## Pasta documentação
Contém a apresentação realizada e ainda um ebook com informações adicionais.

## Descrição dos projetos:

1. DemoUI: Exemplo de projeto com Blazor Server que demonstra um website simplificado (tendo por base o website de exemplo do Blazor) que através de um item específico (People) suporta a ligação à base de dados (SQL - DDL disponível na pasta Database que recria a tabela people sem dados), permitindo listar a adicionar novos elemenentos na página (que surgem de imediato na listagem). 
- Contém ainda um projeto: DataAccessLibrary que é uma biblioteca que encapsula a lógica necessária de acesso à base e dados utilizando a biblioteca Dapper.

- Passos para execução: 1. Abrir o projeto, 2. criar uma base de dados e recriar a tabela, 3. No visual studio, em particular na tab: "SQL Server Object Explorer", estabelecer a ligação, em propriedades copiar a connection string e substituir a string de conexão no ficheiro appsetting.json. 

2. HelpDesk: Exemplo com base de dados (backup na pasta Database) utilizando a Entity Framework. Inclui um exemplo de autenticação utilizador comum e administrador) e um formulário que utiliza componentes third party (neste caso da syncfusion). Na pasta documentação está incluído um ebook que explica o processo.

3. TodoList: Exemplo simples que demonstra um pequena lista de tarefas (sem base de dados) e que permite visualizar como uma tarefa tipicamente implementada recorrendo a javascript pode ser implementada com blazor.

4. Exemplo de Session Storage com um componente Blazored: https://github.com/Blazored
    
