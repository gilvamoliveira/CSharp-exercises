using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F37 — Fruteira: morangos e maçãs</summary>
public sealed class F37 : Exercicio
{
    public override string Codigo => "F37";
    public override string Titulo => "Fruteira: morangos e maçãs";

    public override string Enunciado => """
        Uma fruteira está vendendo frutas com a seguinte tabela de preços:
          Produto Até 5 Kg Acima de 5 Kg
          Morango R$ 2,50 por Kg R$ 2,20 por Kg
          Maçã R$ 1,80 por Kg R$ 1,50 por Kg
        Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 25,00,
        receberá ainda um desconto de 10% sobre este total. Escreva um algoritmo para ler a quantidade
        (em Kg) de morangos e a quantidade (em Kg) de maçãs adquiridas e escreva o valor a ser pago pelo
        cliente.

        Faccat — p. 8.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
