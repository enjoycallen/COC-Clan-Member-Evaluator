namespace COC_Clan_Member_Evaluator
{
    internal static class JsonHelper
    {
        static readonly JsonSerializerOptions option = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };

        public static string ToJsonString<T>(this T obj) where T : class
        {
            return JsonSerializer.Serialize(obj, option);
        }

        public static Exception NullDeserialization { get; } = new("反序列化失败，返回null。");
    }

    internal class NestedException(string throwerClass, string thrower, string message = "", Exception? innerException = null)
        : Exception(@$"In {throwerClass}.{thrower}: {message}
{(innerException is TypeInitializationException or AggregateException ? innerException.InnerException?.Message:innerException?.Message)}");

    internal class NullPropertyException(string propertyClass, string propertyName)
        : Exception($"In {propertyClass}.{propertyName}: 属性不应为null。");
}