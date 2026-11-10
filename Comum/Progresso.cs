namespace CSharpExercises.Comum;

/// <summary>
/// Progresso do curso: um exercício conta como pendente enquanto o arquivo dele
/// ainda tiver a marca "TODO". Assim não há planilha para manter em dia.
/// </summary>
public static class Progresso
{
    public static string? RaizProjeto { get; } = LocalizarRaiz();

    private static string? LocalizarRaiz()
    {
        var pasta = new DirectoryInfo(AppContext.BaseDirectory);
        while (pasta is not null)
        {
            if (pasta.GetFiles("*.csproj").Length > 0)
                return pasta.FullName;
            pasta = pasta.Parent;
        }
        return null;
    }

    public static bool Pendente(Exercicio exercicio)
    {
        if (RaizProjeto is null)
            return true;

        var arquivo = Path.Combine(RaizProjeto, exercicio.Lista, exercicio.Codigo + ".cs");
        return !File.Exists(arquivo) || File.ReadAllText(arquivo).Contains("TODO");
    }

    public static void Mostrar()
    {
        var grupos = Catalogo.PorLista().ToList();
        var largura = grupos.Count == 0 ? 20 : grupos.Max(g => g.Key.Length);

        Console.WriteLine();
        Console.WriteLine($"{"LISTA".PadRight(largura)}  {"FEITOS",6}  {"TOTAL",5}  {"%",5}");
        Console.WriteLine(new string('-', largura + 22));

        foreach (var grupo in grupos)
        {
            var total = grupo.Count();
            var feitos = grupo.Count(e => !Pendente(e));
            Console.WriteLine($"{grupo.Key.PadRight(largura)}  {feitos,6}  {total,5}  {(total == 0 ? 0 : feitos * 100 / total),4}%");
        }

        var todos = Catalogo.Todos;
        var feitosTotal = todos.Count(e => !Pendente(e));
        Console.WriteLine(new string('-', largura + 22));
        Console.WriteLine($"{"TOTAL".PadRight(largura)}  {feitosTotal,6}  {todos.Count,5}  " +
                          $"{(todos.Count == 0 ? 0 : feitosTotal * 100 / todos.Count),4}%");
        Console.WriteLine();

        if (feitosTotal < todos.Count && todos.Count > 0)
        {
            var proximo = todos.First(e => Pendente(e));
            Console.WriteLine($"Próximo pendente: {proximo.Codigo} — {proximo.Titulo}");
        }
    }
}
