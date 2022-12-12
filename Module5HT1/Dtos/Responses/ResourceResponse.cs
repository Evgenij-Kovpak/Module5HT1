using Newtonsoft.Json;

namespace Module5HT1.Dtos.Responses
{
    public class ResourceResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Year { get; set; } = null!;
        public string Color { get; set; } = null!;
        [JsonProperty(PropertyName = "pantone_value")]
        public string PantoneValue { get; set; } = null!;
    }
}
