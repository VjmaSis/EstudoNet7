# Sistema de Cadastro de Pessoas

## Descrição

Sistema desenvolvido em Blazor WebAssembly para cadastro de pessoas, implementando operações básicas de CRUD (Create, Read, Update, Delete) com interface moderna usando MudBlazor.

## Funcionalidades

- ✅ **Cadastrar nova pessoa**
- ✅ **Listar pessoas cadastradas**
- ✅ **Editar dados de uma pessoa**
- ✅ **Remover pessoa cadastrada**
- ✅ **Validação de formulários**
- ✅ **Interface responsiva e moderna**

## Requisitos Técnicos Implementados

### ✅ Persistência em Memória
- Dados armazenados em memória (sem banco de dados)
- Implementação thread-safe com locks

### ✅ Interface MudBlazor
- Componentes modernos e responsivos
- Tema consistente e profissional
- Navegação intuitiva

### ✅ Princípios SOLID
- **S** - Single Responsibility: Cada classe tem uma responsabilidade específica
- **O** - Open/Closed: Extensível sem modificação
- **L** - Liskov Substitution: Interfaces bem definidas
- **I** - Interface Segregation: Interfaces específicas
- **D** - Dependency Inversion: Inversão de dependências

### ✅ Padrão Adapter
- Abstração do repositório através de interface
- Separação entre lógica de domínio e persistência
- Facilita futuras mudanças de implementação

### ✅ Arquitetura em Camadas
- **Apresentação**: Componentes Blazor e páginas
- **Aplicação**: Serviços de aplicação
- **Domínio**: Entidades e interfaces
- **Infraestrutura**: Implementações concretas

## Estrutura do Projeto

```
EstudoCursor.Client/
├── Application/
│   └── Services/
│       └── PessoaService.cs
├── Components/
│   ├── NavMenu.razor
│   └── PessoaDialogo.razor
├── Domain/
│   ├── Entities/
│   │   └── Pessoa.cs
│   └── Interfaces/
│       └── IPessoaRepository.cs
├── Infrastructure/
│   └── Repositories/
│       └── PessoaRepositoryInMemory.cs
├── Layout/
│   └── MainLayout.razor
├── Pages/
│   ├── Home.razor
│   └── Pessoas.razor
└── wwwroot/
    ├── css/
    │   └── app.css
    └── index.html
```

## Campos Obrigatórios

### Nome
- Obrigatório
- Máximo 100 caracteres

### Data de Nascimento
- Obrigatória
- Mínimo 18 anos de idade

### E-mail
- Obrigatório
- Formato válido de e-mail
- Único no sistema

### CPF
- Obrigatório
- Formato: 000.000.000-00
- Único no sistema

## Regras de Negócio

1. **Idade mínima**: 18 anos
2. **CPF único**: Não permite duplicatas
3. **E-mail único**: Não permite duplicatas
4. **Validação de formato**: CPF e e-mail com formatos específicos

## Como Executar

### Pré-requisitos
- .NET 9.0 SDK
- Visual Studio 2022 ou VS Code

### Passos
1. Clone o repositório
2. Navegue até a pasta do projeto:
   ```bash
   cd EstudoCursor
   ```
3. Restaure as dependências:
   ```bash
   dotnet restore
   ```
4. Execute o projeto:
   ```bash
   dotnet run
   ```
5. Acesse no navegador: `https://localhost:5001`

## Tecnologias Utilizadas

- **.NET 9.0**
- **Blazor WebAssembly**
- **MudBlazor 6.17.0**
- **C# 12**

## Funcionalidades da Interface

### Página Inicial
- Apresentação do sistema
- Lista de funcionalidades
- Navegação para cadastro

### Listagem de Pessoas
- Tabela responsiva
- Botões de ação (editar/excluir)
- Indicador de carregamento
- Mensagem quando não há dados

### Formulário de Cadastro/Edição
- Validação em tempo real
- Máscara para CPF
- Seletor de data com limite
- Validação de e-mail
- Botões de ação

### Confirmações
- Diálogo de confirmação para exclusão
- Notificações de sucesso/erro
- Feedback visual para o usuário

## Extensibilidade

O projeto foi estruturado para facilitar futuras extensões:

- **Banco de dados**: Basta implementar `IPessoaRepository` com Entity Framework
- **Novos campos**: Adicionar propriedades na entidade `Pessoa`
- **Novas validações**: Implementar no `PessoaService`
- **Novas funcionalidades**: Criar novos serviços e componentes

## Contribuição

1. Fork o projeto
2. Crie uma branch para sua feature
3. Commit suas mudanças
4. Push para a branch
5. Abra um Pull Request

## Licença

Este projeto está sob a licença MIT. 