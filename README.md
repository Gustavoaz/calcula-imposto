# Calcula Juros
A solução está usando docker e publicando a imagem em um Container Registry do Google Cloud e tem um webapp apontando para a imagem.

## Server

Está publicado no servidor do caminho: https://calcula-juros.appspot.com

**Swagger**: https://calcula-juros.appspot.com/api-docs

## Local

Navegue até a pasta **CalculaJuros.api** e execute o comando **dotnet run**

## Tests

### Unit Test

Navegue até a pasta **CalculaJuros.Domain.Test** e execute o comando **dotnet test**

### Integration Test

É necessário importar na ferramenta **Postman** o arquivo dentro da pasta **Integration Test**