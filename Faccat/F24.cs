using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F24 — Comissão sobre vendas (3% + 5%)</summary>
public sealed class F24 : Exercicio
{
    public override string Codigo => "F24";
    public override string Titulo => "Comissão sobre vendas (3% + 5%)";

    public override string Enunciado => """
        Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que
        ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que
        ultrapassar este valor, calcular e escrever o seu salário total.

        Faccat — p. 6.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
