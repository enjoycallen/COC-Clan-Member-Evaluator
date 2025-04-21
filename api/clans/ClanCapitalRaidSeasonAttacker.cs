namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonAttacker
    {
        private string? _tag;
        private string? _name;

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => _tag ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonAttacker), nameof(Tag));
            init => _tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonAttacker), nameof(Name));
            init => _name = value;
        }
    }
}