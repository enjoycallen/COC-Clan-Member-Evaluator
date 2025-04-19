using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class WarClan
    {
        string? tag;
        string? name;
        int clanLevel;
        int attacks;
        ClanWarMemberList? members;

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => tag ?? "";
            init => tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => name ?? "";
            init => name = value;
        }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel
        {
            get => clanLevel;
            init => clanLevel = value;
        }

        [JsonPropertyName("attacks")]
        public int Attacks
        {
            get => attacks;
            init => attacks = value;
        }

        [JsonPropertyName("members")]
        public ClanWarMemberList Members
        {
            get => members ?? [];
            init => members = value;
        }
    }
}