using CSharpExercises.Comum;

// dotnet run              -> menu
// dotnet run -- L01A      -> executa um exercício direto
// dotnet run -- status    -> mostra o progresso
if (args.Length > 0)
{
    if (args[0] is "status" or "--status" or "-s")
    {
        Progresso.Mostrar();
        return;
    }

    var escolhido = Catalogo.PorCodigo(args[0]);
    if (escolhido is null)
    {
        Console.WriteLine($"Exercício '{args[0]}' não encontrado. Rode 'dotnet run' para ver o menu.");
        return;
    }

    Rodar(escolhido);
    return;
}

Menu();

static void Limpar()
{
    try
    {
        Console.Clear();
    }
    catch (IOException)
    {
        // saída redirecionada (pipe/arquivo): não há tela para limpar
        Console.WriteLine();
    }
}

static void Menu()
{
    var grupos = Catalogo.PorLista().ToList();

    while (true)
    {
        Limpar();
        var feitos = Catalogo.Todos.Count(e => !Progresso.Pendente(e));

        Console.WriteLine("=== Exercícios ===");
        Console.WriteLine($"Concluídos: {feitos}/{Catalogo.Todos.Count}");
        Console.WriteLine();

        for (var i = 0; i < grupos.Count; i++)
        {
            var grupo = grupos[i];
            var feitosLista = grupo.Count(e => !Progresso.Pendente(e));
            Console.WriteLine($"{i + 1,2}. {grupo.Key,-32} {feitosLista,3}/{grupo.Count(),-3}");
        }

        Console.WriteLine();
        Console.Write("Número da lista, código do exercício (ex.: L01A) ou 'sair': ");
        var entrada = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(entrada) || entrada.Equals("sair", StringComparison.OrdinalIgnoreCase))
            return;

        if (int.TryParse(entrada, out var indice) && indice >= 1 && indice <= grupos.Count)
        {
            EscolherNaLista(grupos[indice - 1].ToList());
            continue;
        }

        var exercicio = Catalogo.PorCodigo(entrada);
        if (exercicio is null)
        {
            Console.WriteLine($"  '{entrada}' não existe.");
            Entrada.Pausar();
            continue;
        }

        Rodar(exercicio);
    }
}

static void EscolherNaLista(List<Exercicio> lista)
{
    while (true)
    {
        Limpar();
        Console.WriteLine($"=== {lista[0].Lista} ===");
        Console.WriteLine();

        foreach (var exercicio in lista)
        {
            var marca = Progresso.Pendente(exercicio) ? "[ ]" : "[x]";
            Console.WriteLine($"{marca} {exercicio.Codigo,-7} {exercicio.Titulo}");
        }

        Console.WriteLine();
        Console.Write("Código ('?' antes = ver enunciado) ou Enter para voltar: ");
        var entrada = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(entrada))
            return;

        var verEnunciado = entrada.StartsWith('?');
        var codigo = verEnunciado ? entrada[1..].Trim() : entrada;
        var alvo = lista.FirstOrDefault(e => e.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));

        if (alvo is null)
        {
            Console.WriteLine($"  '{codigo}' não existe nesta lista.");
            Entrada.Pausar();
            continue;
        }

        if (verEnunciado)
        {
            Limpar();
            Console.WriteLine($"=== {alvo.Codigo} — {alvo.Titulo} ===");
            Console.WriteLine();
            Console.WriteLine(alvo.Enunciado);
            Entrada.Pausar();
            continue;
        }

        Rodar(alvo);
    }
}

static void Rodar(Exercicio exercicio)
{
    Limpar();
    Console.WriteLine($"=== {exercicio.Codigo} — {exercicio.Titulo} ===");
    Console.WriteLine();
    Console.WriteLine(exercicio.Enunciado);
    Console.WriteLine();

    try
    {
        exercicio.Executar();
    }
    catch (NotImplementedException)
    {
        Console.WriteLine($">>> Ainda não implementado. Abra {exercicio.Lista}\\{exercicio.Codigo}.cs e escreva sua solução.");
    }
    catch (Exception erro)
    {
        Console.WriteLine($">>> Erro: {erro.Message}");
    }

    Entrada.Pausar();
}
