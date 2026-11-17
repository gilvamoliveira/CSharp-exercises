using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F08 — Percentual de votos brancos, nulos e válidos</summary>
public sealed class F08 : Exercicio
{
    public override string Codigo => "F08";
    public override string Titulo => "Percentual de votos brancos, nulos e válidos";

    public override string Enunciado => """
        Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
        brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao
        total de eleitores.

        Faccat — p. 4.
        """;

    public override void Executar()
    {
        Console.Write("Digite o número total de eleitores: ");
        int totalEleitores = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o número de votos brancos: ");
        int votosBrancos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o número de votos nulos: ");
        int votosNulos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Digite o número de votos válidos: ");
        int votosValidos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (totalEleitores <= 0)
        {
            Console.WriteLine("O número total de eleitores deve ser maior que zero.");
        }
        else
        {
            double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
            double percentualNulos = (double)votosNulos / totalEleitores * 100;
            double percentualValidos = (double)votosValidos / totalEleitores * 100;

            Console.WriteLine($"Percentual de votos brancos: {percentualBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");
        }


    }
}
