using SevenDaysOfPokemon.Clients;

namespace SevenDaysOfPokemon.Services;

public class PokemonService
{
    private readonly PokemonClient _pokemonClient;
    public PokemonService()
    {
        _pokemonClient = new PokemonClient();
    }

    public string AdotarUmMascote(List<string> nomesPokemon)
    {
        Console.WriteLine("-------------------------------ADOTAR UM MASCOTE--------------------------");
        for (int i = 0; i < nomesPokemon.Count; i++)
        {
            Console.WriteLine($"{i} - {nomesPokemon[i].ToUpper()}");
        }
        var posicao = Console.ReadLine();
        return nomesPokemon[Int32.Parse(posicao)];
    }


    public async Task ExibirInformacoesPokemons(List<string> pokemonsEscolhidos)
    {
        foreach (var pokemon in pokemonsEscolhidos)
        {
            var infoPokemon = await _pokemonClient.ObterInformacaoPokemon(pokemon);
            Console.WriteLine(infoPokemon);
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}