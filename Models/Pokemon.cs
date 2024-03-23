using System.Text;
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
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nome: {Nome}");
        sb.AppendLine($"Nome Pokemon: {Nome}");
        sb.AppendLine($"Altura: {Altura}");
        sb.AppendLine($"Peso: {Peso}");
        sb.AppendLine("Habilidades:");
        foreach (var habilidade in Habilidades)
            sb.AppendLine(habilidade.Habilidade.Nome);
        return sb.ToString();
    }
}
