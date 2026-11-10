using System.Globalization;

namespace CSharpExercises.Comum;

/// <summary>Leituras de teclado com validação, para não repetir TryParse em cada exercício.</summary>
public static class Entrada
{
    public static int LerInteiro(string mensagem = "Digite um número inteiro: ")
    {
        while (true)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out var valor))
                return valor;
            Console.WriteLine("  Valor inválido, tente de novo.");
        }
    }

    public static long LerLong(string mensagem = "Digite um número inteiro: ")
    {
        while (true)
        {
            Console.Write(mensagem);
            if (long.TryParse(Console.ReadLine(), out var valor))
                return valor;
            Console.WriteLine("  Valor inválido, tente de novo.");
        }
    }

    public static double LerReal(string mensagem = "Digite um número real: ")
    {
        while (true)
        {
            Console.Write(mensagem);
            var texto = Console.ReadLine()?.Replace(',', '.');
            if (double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out var valor))
                return valor;
            Console.WriteLine("  Valor inválido, tente de novo.");
        }
    }

    public static string LerTexto(string mensagem = "Digite um texto: ")
    {
        Console.Write(mensagem);
        return Console.ReadLine() ?? string.Empty;
    }

    public static char LerCaractere(string mensagem = "Digite um caractere: ")
    {
        while (true)
        {
            Console.Write(mensagem);
            var texto = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(texto))
                return char.ToUpperInvariant(texto.Trim()[0]);
            Console.WriteLine("  Valor inválido, tente de novo.");
        }
    }

    /// <summary>Lê apenas 'S' ou 'N' e devolve true para sim.</summary>
    public static bool LerSimNao(string mensagem = "Deseja continuar (S/N)? ")
    {
        while (true)
        {
            var resposta = LerCaractere(mensagem);
            if (resposta == 'S') return true;
            if (resposta == 'N') return false;
            Console.WriteLine("  Responda S ou N.");
        }
    }

    public static void Pausar()
    {
        Console.WriteLine();
        Console.Write("Pressione Enter para continuar...");
        Console.ReadLine();
    }
}
