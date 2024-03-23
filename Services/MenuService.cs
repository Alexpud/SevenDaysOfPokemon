namespace SevenDaysOfPokemon.Services;

public static class MenuService
{
    public static string ExibirBoasVindas()
    {
        Console.WriteLine("Qual o seu nome?");
        return Console.ReadLine();
    }

    public static void ExibirOpcoesComPokemonEscolhido(string escolhaPokemon)
    {
        Console.WriteLine($"1 - Saber mais sobre {escolhaPokemon.ToUpper()}");
        Console.WriteLine($"2 - Adotar {escolhaPokemon.ToUpper()}");
        Console.WriteLine("3 - Voltar");
    }

    public static void ExibirOpcoesSemPokemonEscolhido()
    {
        Console.WriteLine("1 - Adotar um mascote virtual");
        Console.WriteLine("2 - Ver seus mascotes");
        Console.WriteLine("3 - Sair");
    }

    public static void ExibirMenuSuperior(string NomePlayer)
    {
        Console.WriteLine("-----------------------------------Menu-----------------------------------");
        Console.WriteLine($"{NomePlayer} Voce deseja:");
    }

    public static void ExibirOpcaoInvalida()
        => Console.WriteLine("Opção invalida");
}