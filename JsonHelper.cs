using System.Text.Json;

namespace COC_Clan_Member_Evaluator
{
    internal static class JsonHelper
    {
        static readonly JsonSerializerOptions option = new()
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };

        public static string ToJsonString<T>(this T obj) where T : class
        {
            return JsonSerializer.Serialize(obj, option);
        }
    }
}
