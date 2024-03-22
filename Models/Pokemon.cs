using System.Text.Json.Serialization;

namespace SevenDaysOfPokemon.Models;

public class Pokemon
{
    public int Id { get; set; }
    [JsonPropertyName("Name")]
    public required string Nome { get; set; }
    [JsonPropertyName("Weight")]
    public int Peso { get; set; }
    [JsonPropertyName("Height")]
    public int Altura { get; set; }
    [JsonPropertyName("Abilities")]
    public List<DescricaoHabilidade> Habilidades { get; set; }
}
