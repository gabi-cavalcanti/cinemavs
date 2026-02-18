# Sistema de Catálogo: Filmes e Artistas

Este projeto é uma aplicação de console em .NET desenvolvida para gerenciar o relacionamento entre filmes e seus elencos. O foco principal foi aplicar conceitos avançados de **Orientação a Objetos**, como encapsulamento e associações bidirecionais.

---

## Funcionalidades

- **Relacionamento Bidirecional:** Ao adicionar um artista a um filme, o sistema automaticamente vincula o filme à lista de filmografia do artista e vice-versa.
- **Prevenção de Duplicidade:** Implementação de lógica de negação lógica (`!`) e o método `.Contains()` para garantir que um artista não seja adicionado mais de uma vez ao mesmo filme (e vice-versa).
- **Fichas Técnicas Detalhadas:** Métodos que percorrem as listas internas para exibir informações cruzadas de forma organizada no console.
- **Flexibilidade com `params`:** Métodos de adição que permitem passar múltiplos objetos de uma só vez, tornando o código no `Program.cs` mais limpo.

---

## Tecnologias e Conceitos Aplicados

| Categoria | Detalhes |
|---|---|
| **Linguagem** | C# |
| **IDE Preferencial** | Visual Studio |
| **Encapsulamento** | Propriedades `{ get; }` e modificadores `private` |
| **Segurança de Referência** | Inicialização rigorosa de listas nos construtores |
| **Engenharia de Software** | Travas contra recursão infinita em associações bidirecionais |

---

## Exemplo de Uso

```csharp
// Criando instâncias
var f1 = new filme("De volta pro futuro", 116);
var a1 = new artistas("Michael J. Fox", 62);

// O vínculo acontece nos dois sentidos automaticamente
f1.adicionarartista(a1);

// Ambos os métodos exibirão os dados cruzados
f1.Exibirfichatecnica();
a1.exibirfichatecnicaartistaI();
```

---

## Como Executar

1. Clone o repositório.
2. Certifique-se de ter o [SDK do .NET](https://dotnet.microsoft.com/download) instalado.
3. Abra o projeto no seu IDE (**JetBrains Rider** ou **Visual Studio**).
4. No terminal, execute:

```bash
dotnet run
```
