using System.Text.Json.Serialization;

namespace superapi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TestEnum
    {
        Knight = 1,
        Mage = 2,
        Sorcerer = 3
    }
}