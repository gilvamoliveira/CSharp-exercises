using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F16 — Custo de maçãs (preço por dúzia)</summary>
public sealed class F16 : Exercicio
{
    public override string Codigo => "F16";
    public override string Titulo => "Custo de maçãs (preço por dúzia)";

    public override string Enunciado => """
        As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas
        pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o
        custo total da compra.

        Faccat — p. 5.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
