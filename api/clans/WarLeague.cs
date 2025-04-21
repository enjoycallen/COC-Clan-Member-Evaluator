namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class WarLeague
    {
        private string? _name;
        private int _id;

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(WarLeague), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id;
            init => _id = value;
        }
    }
}
