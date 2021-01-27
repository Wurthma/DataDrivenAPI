# Exemplo Data Driven API Dotnet C#

- Swagger para documentação da API (Adicionado por padrão no .Net 5)
- Autenticação com JWT
    - Site para inspecionar tokens: https://jwt.io/
- Exemplo de uso de Compression de JSON no startup.
- Exemplo de uso de cache no CategoryController.cs

## Packages:

- `dotnet add package Microsoft.EntityFrameworkCore.InMemory`
    - utilizado apenas para exemplo antes de conectar com o SQL Server.
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- `dotnet add package Microsoft.AspNetCore.Authentication`
- `dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer`
- `dotnet add package Swashbuckle.AspNetCore` (Adicionado por padrão no .Net 5)

## Azure

Realizado deploy da aplicação no azure para exemplo.
Grupo de recurso: GeorgeEstudos
