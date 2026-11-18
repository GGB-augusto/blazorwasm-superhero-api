using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    // resposta da busca
    public class SuperHeroResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; } = "";

        [JsonPropertyName("results")]
        public List<SuperHero>? Results { get; set; }
    }

    // cada heroi
    public class SuperHero
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("powerstats")]
        public Powerstats Powerstats { get; set; } = new Powerstats();

        [JsonPropertyName("biography")]
        public Biography Biography { get; set; } = new Biography();

        [JsonPropertyName("image")]
        public ImageInfo Image { get; set; } = new ImageInfo();
    }

    public class Powerstats
    {
        [JsonPropertyName("intelligence")]
        public string Intelligence { get; set; } = "";

        [JsonPropertyName("strength")]
        public string Strength { get; set; } = "";

        [JsonPropertyName("speed")]
        public string Speed { get; set; } = "";

        [JsonPropertyName("combat")]
        public string Combat { get; set; } = "";
    }

    public class Biography
    {
        [JsonPropertyName("full-name")]
        public string FullName { get; set; } = "";

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; } = "";

        [JsonPropertyName("first-appearance")]
        public string FirstAppearance { get; set; } = "";
    }

    public class ImageInfo
    {
        [JsonPropertyName("url")]
        public string Url { get; set; } = "";
    }
}