using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F06 — Área de um retângulo</summary>
public sealed class F06 : Exercicio
{
    public override string Codigo => "F06";
    public override string Titulo => "Área de um retângulo";

    public override string Enunciado => """
        Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever
        a área do retângulo.

        Faccat — p. 4.
        """;

    public override void Executar()
    {
        Console.Write("Digite o valor da base: ");
        double baseRetangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o valor da altura: ");
        double alturaRetangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        double areaRetangulo = baseRetangulo * alturaRetangulo;

        Console.WriteLine($"A área do retângulo é: {areaRetangulo}");
    }
}
