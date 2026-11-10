using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F34 — Teste de mesa do algoritmo A/B/C</summary>
public sealed class F34 : Exercicio
{
    public override string Codigo => "F34";
    public override string Titulo => "Teste de mesa do algoritmo A/B/C";

    public override string Enunciado => """
        Seja o seguinte algoritmo:
        inicio
          leia(x)
          leia(y)
          z <- (x * y) + 5
          se (z <= 0) entao
            resposta <- "A"
          senao
            se (z <= 100) entao
              resposta <- "B"
            senao
              resposta <- "C"
            fimse
          fimse
          escreva(z, resposta)
        fimalgoritmo
        Faça um teste de mesa e complete o quadro a seguir para os seguintes valores:
          X Y
          3 2
          150 3
          7 -1
          -2 5
          50 3
        Dica do projeto: implemente o algoritmo e mostre, para cada par (X, Y) da tabela, os valores de
        Z e Resposta.

        Faccat — p. 7.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
