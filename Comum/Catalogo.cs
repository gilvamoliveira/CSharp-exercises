using System.Reflection;

namespace CSharpExercises.Comum;

/// <summary>Descobre automaticamente todos os exercícios do projeto.</summary>
public static class Catalogo
{
    public static IReadOnlyList<Exercicio> Todos { get; } = Descobrir();

    private static List<Exercicio> Descobrir()
    {
        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(Exercicio).IsAssignableFrom(t) && t is { IsAbstract: false, IsInterface: false })
            .Select(t => (Exercicio)Activator.CreateInstance(t)!)
            .OrderBy(e => ChaveLista(e.Lista), StringComparer.Ordinal)
            .ThenBy(Ordem, StringComparer.Ordinal)
            .ToList();
    }

    /// <summary>Mantém a ordem do livro: L01A, L01B... L01M e depois E03A, E03B...</summary>
    private static string Ordem(Exercicio exercicio)
    {
        var codigo = exercicio.Codigo;
        var tipo = codigo[0] == 'L' ? "0" : "1";
        return codigo.Length >= 4 ? $"{tipo}:{codigo[1..3]}:{codigo[3..]}" : codigo;
    }

    public static IEnumerable<IGrouping<string, Exercicio>> PorLista()
    {
        return Todos.GroupBy(e => e.Lista).OrderBy(g => ChaveLista(g.Key), StringComparer.Ordinal);
    }

    /// <summary>
    /// Ordem das listas no menu: Lista01, Lista03... (Manzano) primeiro, depois o Faccat.
    /// </summary>
    private static string ChaveLista(string lista)
    {
        return lista.StartsWith("Lista", StringComparison.Ordinal) ? "0:" + lista : "1:" + lista;
    }

    public static Exercicio? PorCodigo(string codigo)
    {
        return Todos.FirstOrDefault(e => string.Equals(e.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
    }
}
