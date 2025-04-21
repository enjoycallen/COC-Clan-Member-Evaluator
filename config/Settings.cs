namespace COC_Clan_Member_Evaluator.config
{
    internal class Settings
    {
        private api.Settings? _api;

        [JsonPropertyName("api")]
        public api.Settings Api
        {
            get => _api ?? throw new NullPropertyException(nameof(Settings), nameof(Api));
            init => _api = value;
        }
    }
}