using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F25 — Saldo bancário (positivo/negativo)</summary>
public sealed class F25 : Exercicio
{
    public override string Codigo => "F25";
    public override string Titulo => "Saldo bancário (positivo/negativo)";

    public override string Enunciado => """
        Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular
        e escrever o saldo atual (saldo atual = saldo - débito + crédito). Também testar se saldo atual
        for maior ou igual a zero escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo
        Negativo'.

        Faccat — p. 6.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
