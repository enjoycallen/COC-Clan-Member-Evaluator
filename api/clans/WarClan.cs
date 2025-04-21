using COC_Clan_Member_Evaluator.api.common;
using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class WarClan
    {
        private float _destruptionPercentage;
        private string? _tag;
        private string? _name;
        private BadgeUrls? _badgeUrls;
        private int _clanLevel;
        private int _attacks;
        private int _stars;
        private int? _expEarned;
        private ClanWarMemberList? _members;

        [JsonPropertyName("destructionPercentage")]
        public float DestruptionPercentage
        {
            get => _destruptionPercentage;
            init => _destruptionPercentage = value;
        }

        [JsonPropertyName("tag")]
        public string? Tag
        {
            get => _tag;
            init => _tag = value;
        }

        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name;
            init => _name = value;
        }

        [JsonPropertyName("badgeUrls")]
        public BadgeUrls BadgeUrls
        {
            get => _badgeUrls ?? throw new NullPropertyException(nameof(WarClan), nameof(BadgeUrls));
            init => _badgeUrls = value;
        }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel
        {
            get => _clanLevel;
            init => _clanLevel = value;
        }

        [JsonPropertyName("attacks")]
        public int Attacks
        {
            get => _attacks;
            init => _attacks = value;
        }

        [JsonPropertyName("stars")]
        public int Stars
        {
            get => _stars;
            init => _stars = value;
        }

        [JsonPropertyName("expEarned")]
        public int? ExpEarned
        {
            get => _expEarned;
            init => _expEarned = value;
        }

        [JsonPropertyName("members")]
        public ClanWarMemberList? Members
        {
            get => _members;
            init => _members = value;
        }
    }
}