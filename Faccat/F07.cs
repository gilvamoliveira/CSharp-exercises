using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F07 — Idade em dias (anos, meses e dias)</summary>
public sealed class F07 : Exercicio
{
    public override string Codigo => "F07";
    public override string Titulo => "Idade em dias (anos, meses e dias)";

    public override string Enunciado => """
        Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a
        idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.

        Faccat — p. 4.
        """;

    public override void Executar()
    {
        Console.Write("Digite a idade em anos: ");
        int anos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite a idade em meses: ");
        int meses = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite a idade em dias: ");
        int dias = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        int idadeEmDias = (anos * 365) + (meses * 30) + dias;

        Console.WriteLine($"Dias desde o seu nascimento: {idadeEmDias}");
    }
}
