using CSharpExercises.Comum;

namespace CSharpExercises.Lista01_EstruturaSequencial;

/// <summary>L01D — Efetuar o cálculo da quantidade de litros de combustível...</summary>
public sealed class L01D : Exercicio
{
    public override string Codigo => "L01D";
    public override string Titulo => "Efetuar o cálculo da quantidade de litros de combustível...";

    public override string Enunciado => """
        Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um
        automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto
        (TEMPO) e a velocidade média (VELOCIDADE) durante a viagem. Desta forma, será possível obter a
        distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Possuindo o valor da
        distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
        fórmula LITROS_USADOS = DISTANCIA / 12. Ao final, o programa deve apresentar os valores da
        velocidade média (VELOCIDADE), tempo gasto na viagem (TEMPO), a distancia percorrida (DISTANCIA)
        e a quantidade de litros (LITROS_USADOS) utilizada na viagem.

        Livro: p. 25.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
