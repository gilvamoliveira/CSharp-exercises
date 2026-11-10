# Exercícios — Manzano + Faccat

Projeto único de Console com **os exercícios que você tem para fazer**, um arquivo `.cs` por exercício,
com o enunciado já transcrito e o método `Executar()` esperando a sua solução.

**Total: 84 exercícios** — 49 do livro do Manzano + 35 da apostila do Faccat.

Não existe `Main` espalhado nem `.csproj` para editar: você entra, escolhe a lista, escolhe o exercício
e só escreve o código.

## Como usar

```powershell
dotnet run                  # menu: escolhe a lista e o exercício
dotnet run -- L01A          # executa um exercício direto pelo código
dotnet run -- status        # quanto já foi feito
```

No menu:

- digite o número da lista para abrir;
- dentro da lista, digite o código (`L01A`, `F05`) para executar;
- `?F05` mostra o enunciado sem executar;
- Enter volta, `sair` encerra.

## Onde escrever a solução

Cada arquivo tem esta cara:

```csharp
public sealed class F05 : Exercicio
{
    public override string Codigo => "F05";
    public override string Titulo => "Antecessor de um valor lido";
    public override string Enunciado => """ ... """;   // texto da apostila

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
```

Você só mexe no `Executar()`. O progresso é contado pelos arquivos que **ainda contêm `TODO`**:
quando você apagar essa linha, o exercício aparece como concluído no menu e no `status`.

Ajuda pronta em `Comum/Entrada.cs`:

```csharp
int qtd = Entrada.LerInteiro("Quantos valores? ");
double nota = Entrada.LerReal("Nota: ");
string nome = Entrada.LerTexto("Nome: ");
bool continuar = Entrada.LerSimNao("Continuar (S/N)? ");
Entrada.Pausar();
```

## Escopo (só o que foi pedido)

### Manzano — *Estudo Dirigido: Algoritmos* (Érica, 2000)

| Pasta | Seção / página | Conteúdo | Exercícios |
|---|---|---|---|
| `Lista01_EstruturaSequencial` | 3.9, p. 25–26 | seqüencial: leitura, fórmulas, escrita (ex. 7 **A–M** + os 3 extras) | 16 |
| `Lista03_Enquanto` | 5.1.1, p. 46–47 | repetição com teste no início (**ENQUANTO**), **A–L** | 12 |
| `Lista04_Repita` | 5.2.1, p. 50 | repetição com teste no final (**REPITA … ATÉ**), **A–J** | 10 |
| `Lista05_Para` | 5.6.1, p. 66 | repetição com contagem (**PARA**), **A–K** | 11 |

13 + 3 + 12 + 10 + 11 = **49**.

Códigos: `L01A` … `L01M` são os itens A–M da p. 25; `E03A`, `E03B`, `E03C` são os 3 extras
seguintes; `L03A` … `L03L`, `L04A` … `L04J`, `L05A` … `L05K`.

### Faccat — *Exercícios de Lógica de Programação* (Profa. Flávia Pereira de Carvalho)

Pasta `Faccat`, códigos `F05` … `F39`.

| Página | Exercícios | Conteúdo | Total |
|---|---|---|---|
| 4 | 5–11 | operadores aritméticos | 7 |
| 5 | 12–13 | horizontalização | 2 |
| 5–6 | 14–26 | seleção e operadores relacionais | 13 |
| 6–8 | 27–38 | seleção aninhada / concatenada | 12 |
| 8 | 39 | operadores lógicos | 1 |

7 + 2 + 13 + 12 + 1 = **35**.

## Duas observações sobre a numeração

- O seu roteiro chama a p. 46 (5.1.1) de “estrutura de decisão (SE/ENTÃO/SENÃO)”, mas no livro essa
  seção é **repetição com teste no início (ENQUANTO)**. Os 12 exercícios (A–L) são os mesmos que você
  listou; o que muda é só o nome da pasta: `Lista03_Enquanto`.
- A lista de **decisão** do Manzano é a 4.7 (p. 39–42). Ela **não** está no projeto porque não aparece
  no seu recorte; se precisar dela depois, é só pedir que eu gero (12 exercícios A–L).

## Estrutura

```
CSharp-exercises/
├─ CSharpExercises.sln            solução para abrir no Visual Studio
├─ CSharpExercises.csproj         projeto Console (net9.0)
├─ Program.cs                     menu, execução direta e status
├─ Comum/
│  ├─ Exercicio.cs                classe base de todo exercício
│  ├─ Catalogo.cs                 descobre os exercícios por reflexão
│  ├─ Entrada.cs                  leitura de teclado com validação
│  └─ Progresso.cs                conta os "TODO" e mostra o andamento
├─ Modelo/ExercicioNovo.cs.txt    modelo para criar exercício novo
├─ Lista01_EstruturaSequencial/   L01A…L01M, E03A…E03C
├─ Lista03_Enquanto/              L03A…L03L
├─ Lista04_Repita/                L04A…L04J
├─ Lista05_Para/                  L05A…L05K
└─ Faccat/                        F05…F39
```

## Ordem sugerida

Manzano 01 → 03 → 04 → 05, depois Faccat 5 → 39 (a apostila é cumulativa: aritmética, seleção,
seleção aninhada, lógica). Se travar em um exercício por mais de ~30 minutos, anote a dúvida e siga.

## Observações

- Os enunciados foram extraídos dos PDFs. Onde a extração embaralhou fórmulas ou tabelas
  (ex.: `F23`, `F34`, `F35`, `F37`), o texto foi reescrito à mão no arquivo.
- Cada enunciado termina com a página de origem (`Livro: p. 25.` / `Faccat — p. 6.`) para conferir
  no PDF original.
- Três exercícios do Faccat não são “programar”: `F23` (achar erros), `F34` (teste de mesa) e
  `F39` (avaliar expressões). Ficaram como classes também — o enunciado está lá e a dica de como
  resolver aparece no próprio texto.
- O `.gitignore` já ignora `bin/`, `obj/` e `.vs/`.
