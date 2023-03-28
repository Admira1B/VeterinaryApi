using System.Text.Json.Serialization;

namespace VeterinaryApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Sex
    {
        Male = 1,
        Female = 2
    }
}