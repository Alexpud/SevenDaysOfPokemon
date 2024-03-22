using RestSharp;
using SevenDaysOfPokemon.Models;

var pokemonsEscolhidos = new List<string>()
{
    "vulpix",
    "steelix",
    "abra"
};

Console.WriteLine("Qual o seu nome?");
var nome = Console.ReadLine();
var escolhaPokemon = string.Empty;
while (true)
{
    Console.WriteLine("-----------------------------------Menu-----------------------------------");

    Console.WriteLine($"{nome} Voce deseja:");
    if (!string.IsNullOrEmpty(escolhaPokemon))
    {
        Console.WriteLine($"1 - Saber mais sobre {escolhaPokemon.ToUpper()}");
        Console.WriteLine($"2 - Adotar {escolhaPokemon.ToUpper()}");
        Console.WriteLine("3 - Voltar");
        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                await ExibirInformacoesPokemons(new List<string>() { escolhaPokemon });
                break;
            case '2':
                Console.WriteLine("Adotado!");
                return 0;
            case '3':
                escolhaPokemon = string.Empty;
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }
    else
    {
        Console.WriteLine("1 - Adotar um mascote virtual");
        Console.WriteLine("2 - Ver seus mascotes");
        Console.WriteLine("3 - Sair");

        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                escolhaPokemon = AdotarUmMascote(pokemonsEscolhidos);
                break;
            case '2':
                await ExibirInformacoesPokemons(pokemonsEscolhidos);
                break;
            case '3':
                return 0;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }
}

async Task ExibirInformacoesPokemons(List<string> pokemonsEscolhidos)
{
    var pokemonClient = new PokemonClient();
    foreach(var pokemon in pokemonsEscolhidos)
    {
        var infoPokemon = await pokemonClient.ObterInformacaoPokemon(pokemon);
        ImprimirDadosPokemon(infoPokemon);
    }
}

static void ImprimirDadosPokemon(Pokemon? pokemon)
{
    Console.WriteLine($"Nome: {pokemon?.Nome}");
    Console.WriteLine($"Nome Pokemon: {pokemon.Nome}");
    Console.WriteLine($"Altura: {pokemon.Altura}");
    Console.WriteLine($"Peso: {pokemon.Peso}");
    Console.WriteLine("Habilidades:");
    foreach (var habilidade in pokemon.Habilidades)
        Console.WriteLine(habilidade.Habilidade.Nome);
    Console.WriteLine("--------------------------------------------------------------------------");
}


static string AdotarUmMascote(List<string> nomesPokemon)
{
    Console.WriteLine("-------------------------------ADOTAR UM MASCOTE--------------------------");
    for (int i = 0; i < nomesPokemon.Count; i++)
    {
        Console.WriteLine($"{i} - {nomesPokemon[i].ToUpper()}");
    }
    var posicao = Console.ReadLine();
    return nomesPokemon[Int32.Parse(posicao)];
}