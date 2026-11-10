namespace CSharpExercises.Comum;

/// <summary>
/// Base de todo exercício do livro. Cada exercício é uma classe que herda de
/// <see cref="Exercicio"/>; o menu descobre as classes por reflexão, portanto
/// não existe nenhuma lista de exercícios para manter à mão.
/// </summary>
public abstract class Exercicio
{
    /// <summary>Código usado no livro (L01A, E03C, L09_1...).</summary>
    public abstract string Codigo { get; }

    /// <summary>Título curto mostrado no menu.</summary>
    public abstract string Titulo { get; }

    /// <summary>Enunciado do exercício, transcrito do livro.</summary>
    public abstract string Enunciado { get; }

    /// <summary>Lista/pasta a que o exercício pertence.</summary>
    public string Lista => GetType().Namespace?.Split('.').LastOrDefault() ?? "SemLista";

    /// <summary>Implemente aqui a solução.</summary>
    public abstract void Executar();
}
