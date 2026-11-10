using CSharpExercises.Comum;

namespace CSharpExercises.Lista04_Repita;

/// <summary>L04D — Elaborar um programa que efetue o cálculo e no final...</summary>
public sealed class L04D : Exercicio
{
    public override string Codigo => "L04D";
    public override string Titulo => "Elaborar um programa que efetue o cálculo e no final...";

    public override string Enunciado => """
        Elaborar um programa que efetue o cálculo e no final apresente o somatório do número de grãos de
        trigo que se pode obter num tabuleiro de xadrez, obedecendo à seguinte regra: colocar um grão de
        trigo no primeiro quadro e nos quadros seguintes o dobro do quadro anterior. Ou seja, no
        primeiro quadro coloca-se 1 grão, no segundo quadro colocam-se 2 grãos (neste momento têm-se 3
        grãos), no terceiro quadro colocam-se 4 grãos (tendo neste momento 7 grãos), no quarto
        colocam-se 8 grãos (tendo-se então 15 grãos) até atingir o sexagésimo quarto (64o) quadro.
        Utilize variáveis do tipo real como acumuladores.

        Livro: p. 50.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
