# First-CSharp-WebAPI

Este é um projeto de exemplo de uma API Web desenvolvida em ASP.NET Core. Ele contém dois controladores simples que demonstram como ler um arquivo e retornar informações sobre ele, bem como fornecer alguns exemplos de endpoints que retornam a data/hora atual e mensagens de saudação.

## Pré-requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download/dotnet/6.0)
- Visual Studio 2022 ou qualquer outro editor de código compatível (como [Visual Studio Code](https://code.visualstudio.com/))

## Estrutura do Projeto

O projeto está estruturado com os seguintes controladores principais:

### 1. ArquivoController

Esse controlador permite ler um arquivo específico no servidor e retornar o conteúdo dele junto com a quantidade de linhas.

#### Endpoints

- **GET /Arquivo/lerArquivo**:
  - **Descrição**: Lê o arquivo `resumoHobbit.txt` de um caminho especificado e retorna o número de linhas e o conteúdo do arquivo.
  - **Resposta de sucesso (200 OK)**:
    ```json
    {
      "Quantidade de linhas do arquivo": 5,
      "Arquivo": "Primeira linha\nSegunda linha\nTerceira linha..."
    }
    ```
  - **Resposta de erro (400 Bad Request)**:
    ```json
    {
      "message": "Erro ao ler o arquivo."
    }
    ```

### 2. UsuarioController

Este controlador oferece dois endpoints simples: um para retornar a data e a hora atual do sistema e outro para retornar uma mensagem de saudação com base no nome fornecido.

#### Endpoints

- **GET /Usuario/ObterDataHoraAtual**:
  - **Descrição**: Retorna a data e a hora atuais do servidor.
  - **Resposta de sucesso (200 OK)**:
    ```json
    {
      "Data": "Saturday, October 17, 2024",
      "Hora": "10:45 AM"
    }
    ```

- **GET /Usuario/Apresentar/{nome}**:
  - **Descrição**: Retorna uma saudação personalizada com o nome fornecido.
  - **Parâmetro**: `nome` - O nome da pessoa a ser saudada.
  - **Resposta de sucesso (200 OK)**:
    ```json
    {
      "message": "Olá Alisson, seja bem vindo!"
    }
    ```

## Como executar o projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/First-CSharp-WebAPI.git
