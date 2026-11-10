using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F26 — Estoque: efetuar compra ou não</summary>
public sealed class F26 : Exercicio
{
    public override string Codigo => "F26";
    public override string Titulo => "Estoque: efetuar compra ou não";

    public override string Enunciado => """
        Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e
        quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade
        média = quantidade máxima + quantidade mínima)/2). Se a quantidade em estoque for maior ou igual
        a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar
        compra'.

        Faccat — p. 6.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
