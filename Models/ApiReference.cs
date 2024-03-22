using System.Text.Json.Serialization;

namespace SevenDaysOfPokemon.Models;

public class ApiReference
{
    [JsonPropertyName("Name")]
    public string Nome { get; set; }
    public string Url { get; set; }
}
