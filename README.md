# Sistema de Cadastro de Clientes

Este projeto é um sistema de cadastro de clientes desenvolvido em C# para armazenar informações de clientes em um banco de dados.

## Funcionalidades

* Cadastro de clientes com nome, sobrenome, documento, data de nascimento e idade (de acordo com a data informada.)
* Listagem de clientes cadastrados.
* Edição de informações de clientes existentes.
* Exclusão de clientes cadastrados.

## Pré-requisitos

* [.NET SDK 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

## Instalação

1.  Clone o repositório: `git clone https://github.com/JuniorErnesto/MestreGafanhoto`
2.  Navegue até o diretório do projeto: `cd cadastro-clientes`
3.  Restaure os pacotes NuGet: `dotnet restore`
4.  Crie um banco de dados SQL Server com o nome "CadastroClientes".
5.  Atualize a string de conexão no arquivo `appsettings.json`.
6.  Aplique as migrações do Entity Framework Core: `dotnet ef database update`
7.  Compile o projeto: `dotnet build`

## Como Usar

1.  Execute o projeto: `dotnet run`
2.  Acesse a interface do sistema através do navegador em `http://localhost:5000`.
3.  Utilize as funcionalidades de cadastro, listagem, edição e exclusão de clientes.

## Contribuição

1.  Fork o repositório.
2.  Crie uma branch para sua funcionalidade (`git checkout -b feature/relatorio-clientes`).
3.  Faça commit das suas mudanças (`git commit -m 'Adiciona relatório de clientes cadastrados'`).
4.  Faça push para a branch (`git push origin feature/relatorio-clientes`).
5.  Abra um Pull Request.

## Licença

Este projeto é distribuído sob a licença [MIT](https://opensource.org/licenses/MIT).

## Autor

[Ernesto Junior](https://github.com/JuniorErnesto)