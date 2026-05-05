using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Anderson_Road.Models
{
    public class CustomDateTimeConverter : JsonConverter<DateTime?>
    {
        private readonly string[] _formats = new[]
        {
            "yyyy-MM-dd HH:mm:ss",
            "yyyy-MM-dd HH:mm",
            "yyyy-MM-dd"
        };

        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            var dateStr = reader.GetString();
            if (string.IsNullOrWhiteSpace(dateStr))
                return null;

            // Try to parse with our formats
            if (DateTime.TryParseExact(dateStr, _formats, CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out DateTime result))
            {
                return result;
            }

            // Fallback to normal parsing
            if (DateTime.TryParse(dateStr, out result))
                return result;

            throw new JsonException($"Unable to parse DateTime: {dateStr}");
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            else
                writer.WriteNullValue();
        }
    }
}