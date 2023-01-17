
# Teste - CRUD agenda

Um CRUD de uma agenda realizado como parte do processo seletivo para a empresa Blue Technology. A agenda conta com as quatro operações básicas de um CRUD.

A aplicação foi feita em:
  * Vue.js 3
  * .NET 6
  * Entity Framework (InMemoryDatabase)

  O banco de dados é em memória, logo, ao reiniciar o servidor back-end, todos os dados serão perdidos. Decidi usar o banco de dados em memória para não precisar configurar o banco de dados na hora de rodar a aplicação, tornando o processo mais simples.
## Rodando a aplicação

Para rodar, além do .NET 6 e o Vue.js 3 + npm instalados, são necessários os comandos:

Vue.js:
```bash
  npm run serve
```
.NET
```bash
  dotnet watch run
```

Por padrão, a aplicação Vue.js rodará no endereço

```bash
http://localhost:8080
```
E a .NET rodará no endereço (também possui a rota /swagger)
```bash
https://localhost:7296
```

## API Reference

#### Retorna todos os contatos salvos

```http
  GET /Contato
```

| Descrição                       | Retorno
| :-------------------------------- | :-----------
|  Sem parâmetros.| Objeto JSON com todos os contatos salvos.

#### Retorna um contato específico

```http
  GET /Contato/${id}
```

| Parâmetro | Tipo     | Descrição                       | Retorno
| :-------- | :------- | :-------------------------------- | :-----------
| `id`      | `int` | **Required**. | Objeto JSON com o contato específico.

#### Recebe os dados para salvar o contato e retorna o contato

```http
  POST /Contato
```

| Parâmetro | Tipo     | Descrição                         |       
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **NOT Required: AutoIncrement**.|
| `nome` | `string `| **Required**.| 
| `email`| `string `| **Required**.| 
| `telefone` | `string `| **Required**.|

#### Atualiza os dados de um contato através do ID
```http
  PUT /Contato/update/${id}
```

| Parâmetro | Tipo     | Descrição                         | 
| :-------- | :------- | :-------------------------------- | 
| `id`      | `int` | **Required**. | 
| `nome`      | `string` | **Required**. | 
| `email`      | `string` | **Required**. | 
| `telefone`      | `string` | **Required**. |

#### Deleta um contato através do ID
```http
  PUT /Contato/delete/${id}
```

| Parâmetro | Tipo     | Descrição                       | 
| :-------- | :------- | :-------------------------------- | 
| `id`      | `int` | **Required**. | 
