using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F23 — Achar os erros do algoritmo de peso ideal</summary>
public sealed class F23 : Exercicio
{
    public override string Codigo => "F23";
    public override string Titulo => "Achar os erros do algoritmo de peso ideal";

    public override string Enunciado => """
        Para o enunciado a seguir foi elaborado um algoritmo em Português Estruturado que contém erros.
        Identifique os erros no algoritmo apresentado abaixo.
        Enunciado: tendo como dados de entrada o nome, a altura e o sexo (M ou F) de uma pessoa, calcule
        e mostre seu peso ideal, utilizando as seguintes fórmulas:
        - para sexo masculino: peso ideal = (72.7 * altura) - 58
        - para sexo feminino: peso ideal = (62.1 * altura) - 44.7
        algoritmo "peso_ideal"
        var
          nome: literal
          sexo: literal
          altura, peso_ideal: real
        inicio
          leia(nome)
          leia(sexo)
          se (sexo = "M") entao
            peso_ideal <- (72.7 * altura) - 58
          senao
            peso_ideal <- (62.1 * altura) - 44.7
          fimse
          escreva(peso_ideal)
        fimalgoritmo
        Dica do projeto: além de apontar os erros, implemente a versão correta em Executar().

        Faccat — p. 6.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
