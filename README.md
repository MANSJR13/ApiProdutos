# 🛒 ApiProdutos

API REST desenvolvida com ASP.NET Core 8 para gerenciamento de produtos.

## 📋 Sobre o projeto

Este projeto foi criado com fins de estudo e tem como objetivo aplicar conceitos de desenvolvimento backend utilizando:

- ASP.NET Core 8
- Entity Framework Core
- SQLite
- Migrations
- Swagger/OpenAPI
- CRUD de produtos

---

## 🚀 Tecnologias utilizadas

- C#
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger

---

## 📁 Estrutura do projeto

```
ApiProdutos
│
├── Controllers
│     └── ProdutosController.cs
│
├── Data
│     └── AppDbContext.cs
│
├── Models
│     └── Produto.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
├── produtos.db
└── ApiProdutos.csproj
```

---

## 🧱 Modelo Produto

```csharp
public class Produto
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
}
```

---

## ⚙️ Configuração do banco

O projeto utiliza SQLite.

String de conexão:

```csharp
options.UseSqlite("Data Source=produtos.db");
```

---

## 📦 Entity Framework Core

### Criar migration

```bash
dotnet ef migrations add InitialCreate
```

### Atualizar banco

```bash
dotnet ef database update
```

---

## ▶️ Executando o projeto

Restaurar dependências:

```bash
dotnet restore
```

Executar a aplicação:

```bash
dotnet run
```

---

## 📚 Swagger

Após iniciar a aplicação, acesse:

```
https://localhost:{porta}/swagger
```

O Swagger permite testar todos os endpoints da API.

---

## 🔗 Endpoints

### Buscar todos os produtos

```http
GET /api/produtos
```

Resposta:

```json
[
  {
    "id": 1,
    "nome": "Mouse Gamer",
    "preco": 120.50,
    "estoque": 10
  }
]
```

---

### Cadastrar produto

```http
POST /api/produtos
```

Body:

```json
{
  "nome": "Teclado Mecânico",
  "preco": 299.90,
  "estoque": 5
}
```

---

## 📌 Funcionalidades implementadas

- [x] API REST com ASP.NET Core
- [x] Modelo Produto
- [x] Controller de Produtos
- [x] Entity Framework Core
- [x] SQLite
- [x] Migrations
- [x] Persistência de dados
- [x] Swagger

---

## 🚧 Próximas implementações

- [ ] PUT (Atualizar produto)
- [ ] DELETE (Remover produto)
- [ ] Validação dos dados
- [ ] DTOs
- [ ] Service Layer
- [ ] Repository Pattern
- [ ] Tratamento global de exceções
- [ ] Autenticação JWT
- [ ] Testes unitários

---

## 🎯 Objetivo

Projeto desenvolvido para fins de aprendizado e construção de portfólio em desenvolvimento backend com .NET.

---

## 👨‍💻 Autor

Marco Aurelio Silva

GitHub:
https://github.com/MANSJR13