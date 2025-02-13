# Exemplo Camadas

Este projeto demonstra uma arquitetura em camadas utilizando .NET (net9.0) e ASP.NET Core. A solução está dividida nos seguintes projetos:

- **ExemploCurso.Application**: Camada de aplicação, contendo serviços de negócio.
- **ExemploCurso.Domain**: Camada de domínio, contendo entidades e interfaces do domínio.
- **ExemploCurso.IoC**: Configuração da injeção de dependências, registrando os serviços através do NativeInjectorBootStrapper.
- **ExemploCurso.Repository**: Implementação do padrão repositório e unit of work, utilizando um banco de dados em memória.
- **Presentation.ExamplosCurso**: Camada de apresentação, implementada com ASP.NET Core Web API, responsável pelos controllers e endpoints da aplicação.

## Como Executar

Para executar a aplicação, utilize o seguinte comando a partir da raiz do projeto:

  dotnet run --project Presentation.ExamplosCurso/Presentation.ExamplosCurso.Api.csproj

A aplicação estará disponível em http://localhost:51742 ou http://localhost:55035.

## Configurações Adicionais

- **Injeção de Dependências**: Configurada em `ExemploCurso.IoC/NativeInjectorBootStrapper.cs`.
- **Banco de Dados**: É utilizado um banco de dados em memória configurado em `NativeInjectorBootStrapper.cs`.
- **OpenAPI**: A aplicação está configurada para gerar documentação OpenAPI para os endpoints.

## Estrutura do Projeto

O repositório possui a seguinte estrutura:

- ExemploCurso.Application
- ExemploCurso.Domain
- ExemploCurso.IoC
- ExemploCurso.Repository
- Presentation.ExamplosCurso
- [Outros arquivos e configurações do Visual Studio]
