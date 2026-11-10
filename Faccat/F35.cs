using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F35 — Combustível: álcool ou gasolina</summary>
public sealed class F35 : Exercicio
{
    public override string Codigo => "F35";
    public override string Titulo => "Combustível: álcool ou gasolina";

    public override string Enunciado => """
        Um posto está vendendo combustíveis com a seguinte tabela de descontos:
        Álcool:
        - até 20 litros: desconto de 3% por litro
        - acima de 20 litros: desconto de 5% por litro
        Gasolina:
        - até 20 litros: desconto de 4% por litro
        - acima de 20 litros: desconto de 6% por litro
        Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da
        seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
        sabendo-se que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90.

        Faccat — p. 8.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
