namespace COC_Clan_Member_Evaluator.api
{
    class Interface : Dictionary<string, string>;
    class Interfaces : Dictionary<string, Interface>;

    internal class Settings
    {
        private string? _baseUrl;
        private string? _key;
        Interfaces? _interfaces;

        [JsonPropertyName("base_url")]
        public string BaseUrl
        {
            get => _baseUrl ?? throw new NullPropertyException(nameof(Settings), nameof(BaseUrl));
            init => _baseUrl = value;
        }

        [JsonPropertyName("key")]
        public string Key
        {
            get => _key ?? throw new NullPropertyException(nameof(Settings), nameof(Key));
            init => _key = value;
        }

        [JsonPropertyName("interfaces")]
        public Interfaces Interfaces
        {
            get => _interfaces ?? throw new NullPropertyException(nameof(Settings), nameof(Interfaces));
            init => _interfaces = value;
        }
    }
}