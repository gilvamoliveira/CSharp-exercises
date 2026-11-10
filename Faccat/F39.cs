using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F39 — Expressões lógicas com A=V, B=V, C=F</summary>
public sealed class F39 : Exercicio
{
    public override string Codigo => "F39";
    public override string Titulo => "Expressões lógicas com A=V, B=V, C=F";

    public override string Enunciado => """
        Para A = V, B = V e C = F, qual o resultado da avaliação das seguintes expressões:
        a) (A e B) ou (A xou B)
        b) (A ou B) e (A e C)
        c) A ou C e B xou A e não B

        Faccat — p. 8.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
