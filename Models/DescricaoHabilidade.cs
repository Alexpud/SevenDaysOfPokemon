using System.Text.Json.Serialization;

namespace SevenDaysOfPokemon.Models;

public class DescricaoHabilidade
{
    [JsonPropertyName("is_hidden")]
    public bool EOculta { get; set; }
    public int Slot { get; set; }
    [JsonPropertyName("Ability")]
    public ApiReference Habilidade { get; set; }
}
