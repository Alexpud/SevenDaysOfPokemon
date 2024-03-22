using RestSharp;
using SevenDaysOfPokemon.Models;

public class PokemonClient
{
    private readonly RestClient _restClient;

    public PokemonClient()
    {
        var httpClient  = new HttpClient()
        {
            BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/")
        };
        _restClient = new RestClient(httpClient);
    }
    
    public  async Task<Pokemon?> ObterInformacaoPokemon(string nomePokemon)
    {
        var restRequest = new RestRequest(nomePokemon);
        return await _restClient.GetAsync<Pokemon>(restRequest);
    }
}