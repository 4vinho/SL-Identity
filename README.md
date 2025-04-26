SL-Identity

SL-Identity é um sistema de autenticação desenvolvido em C# utilizando o ASP.NET Core Identity. Este projeto fornece uma base sólida para implementar funcionalidades de login, registro e gerenciamento de usuários em aplicações web.

🔧 Tecnologias Utilizadas

ASP.NET Core 9.0

Entity Framework Core

ASP.NET Core Identity

C#

📁 Estrutura do Projeto

O projeto está organizado nos seguintes diretórios:

App/Controller: Contém os controladores responsáveis por lidar com as requisições HTTP e coordenar as respostas apropriadas.

Core: Inclui as classes centrais do domínio, como modelos e interfaces.

Infra: Responsável pela implementação da camada de acesso a dados e outras infraestruturas necessárias.

Migrations: Armazena as migrações do Entity Framework Core para o banco de dados.

🚀 Como Executar

Clone o repositório:

git clone https://github.com/4vinho/SL-Identity.git

Navegue até o diretório do projeto:

cd SL-Identity

Restaure as dependências:

dotnet restore

Aplique as migrações e atualize o banco de dados:

dotnet ef database update

Execute a aplicação:

dotnet run

A aplicação estará disponível em https://localhost:5001 por padrão.

📌 Funcionalidades

Registro de usuários com validação de dados.

Login seguro com autenticação baseada em cookies.

Gerenciamento de sessões de usuários autenticados.

Implementação de políticas de autorização para proteger rotas específicas.
