using SevenDaysOfPokemon.Services;

var pokemonsEscolhidos = new List<string>()
{
    "vulpix",
    "steelix",
    "abra"
};
var NomePlayer = string.Empty;
var escolhaPokemon = string.Empty;
var pokemonService = new PokemonService();
const int OpcaoSair = -1;

NomePlayer = MenuService.ExibirBoasVindas();

await Jogar();

async Task Jogar()
{
    int escolha = 0;
    while (true)
    {
        MenuService.ExibirMenuSuperior(NomePlayer);
        if (!string.IsNullOrEmpty(escolhaPokemon))
            await JogarComPokemonJaEscolhido();
        else
            escolha = await JogarSemPokemonEscolhido();
        if (escolha == OpcaoSair)
            return;
    }

}

async Task<int> JogarSemPokemonEscolhido()
{
    MenuService.ExibirOpcoesSemPokemonEscolhido();
    switch (Console.ReadKey().KeyChar)
    {
        case '1':
            escolhaPokemon = pokemonService.AdotarUmMascote(pokemonsEscolhidos);
            return 0;
        case '2':
            await pokemonService.ExibirInformacoesPokemons(pokemonsEscolhidos);
            return 0;
        case '3':
            return OpcaoSair;
        default:
            MenuService.ExibirOpcaoInvalida();
            return OpcaoSair;
    }
}


async Task JogarComPokemonJaEscolhido()
{
    MenuService.ExibirOpcoesComPokemonEscolhido(escolhaPokemon);
    switch (Console.ReadKey().KeyChar)
    {
        case '1':
            await pokemonService.ExibirInformacoesPokemons(new List<string>() { escolhaPokemon });
            break;
        case '2':
            Console.WriteLine("Adotado!");
            break;
        case '3':
            escolhaPokemon = string.Empty;
            break;
        default:
            MenuService.ExibirOpcaoInvalida();
            break;
    }
}
