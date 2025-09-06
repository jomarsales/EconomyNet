EconomyNet
==========

Projeto para controle financeiro pessoal, desenvolvido com o objetivo de estudar e aplicar conceitos de arquitetura limpa e boas práticas de desenvolvimento.

---

Tecnologias Utilizadas
-----------------------
- .NET Core
- ASP.NET Core
- Entity Framework Core
- Banco de Dados: SQL Server / SQLite
- Arquitetura Limpa (Clean Architecture)
- Domain-Driven Design (DDD)

---

Estrutura do Projeto
--------------------
```
EconomyNet/
├── src/
│   ├── Domain/           # Entidades, Agregados, Value Objects
│   ├── Application/      # Casos de uso, DTOs, Interfaces
│   ├── Infrastructure/   # Implementações técnicas, Repositórios, DbContext
│   ├── API/              # Controllers, Middlewares, Configurações de API
├── EconomyNet.sln        # Solução do Visual Studio
└── README.md             # Este arquivo de descrição
```

---

Como Executar o Projeto
-----------------------
1. Clone o repositório:
   ```bash
   git clone https://github.com/jomarsales/EconomyNet.git
   ```
2. Abra a solução no Visual Studio ou utilizando a CLI do .NET:
   ```bash
   cd EconomyNet
   dotnet restore
   ```
3. Execute a API:
   ```bash
   cd src/API
   dotnet run
   ```
4. A API estará disponível em:
   ```
   https://localhost:5001
   ```

---

Próximos Passos
---------------
- [ ] Implementar autenticação e autorização (JWT)
- [ ] Conectar a um banco de dados real (configurar migrations com EF Core)
- [ ] Criar testes unitários e de integração
- [ ] Adicionar funcionalidades como categorias de despesas, relatórios financeiros, etc.
- [ ] Fazer deploy (Docker, Azure, etc.)

---

Licença
--------
Este projeto está licenciado sob a Licença GPL-3.0. Consulte o arquivo LICENSE para mais detalhes.
