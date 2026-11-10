using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F13 — Média ponderada (pesos 2, 3 e 5)</summary>
public sealed class F13 : Exercicio
{
    public override string Codigo => "F13";
    public override string Titulo => "Média ponderada (pesos 2, 3 e 5)";

    public override string Enunciado => """
        Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno.
        Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula: mediafinal = (n1
        * 2 + n2 * 3 + n3 * 5) / 10.

        Faccat — p. 5.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
