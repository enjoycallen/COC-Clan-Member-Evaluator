using COC_Clan_Member_Evaluator.api.common;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonClanInfo
    {
        private string? _tag;
        private string? _name;
        private int _level;
        private BadgeUrls? _badgeUrls;

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => _tag ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonClanInfo), nameof(Tag));
            init => _tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonClanInfo), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("level")]
        public int Level
        {
            get => _level;
            init => _level = value;
        }

        [JsonPropertyName("badgeUrls")]
        public BadgeUrls BadgeUrls
        {
            get => _badgeUrls ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonClanInfo), nameof(BadgeUrls));
            init => _badgeUrls = value;
        }
    }
}
