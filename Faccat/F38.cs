using CSharpExercises.Comum;

namespace CSharpExercises.Faccat;

/// <summary>F38 — Código de usuário e senha</summary>
public sealed class F38 : Exercicio
{
    public override string Codigo => "F38";
    public override string Titulo => "Código de usuário e senha";

    public override string Enunciado => """
        Faça um algoritmo para ler um número que é um código de usuário. Caso este código seja diferente
        de um código armazenado internamente no algoritmo (igual a 1234) deve ser apresentada a mensagem
        ‘Usuário inválido!’. Caso o Código seja correto, deve ser lido outro valor que é a senha. Se
        esta senha estiver incorreta (a certa é 9999) deve ser mostrada a mensagem ‘senha incorreta’.
        Caso a senha esteja correta, deve ser mostrada a mensagem ‘Acesso permitido’.

        Faccat — p. 8.
        """;

    public override void Executar()
    {
        // TODO: implemente o exercício aqui.
        throw new NotImplementedException();
    }
}
