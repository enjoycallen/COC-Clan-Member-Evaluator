using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal class PlayerClan
    {
        string? tag;
        int clanLevel;
        string? name;
        BadgeUrls? badgeUrls;

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => tag ?? "";
            init => tag = value;
        }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel
        {
            get => clanLevel;
            init => clanLevel = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => name ?? "";
            init => name = value;
        }

        [JsonPropertyName("badgeUrls")]
        public BadgeUrls BadgeUrls
        {
            get => badgeUrls ?? new();
            init => badgeUrls = value;
        }
    }
}
