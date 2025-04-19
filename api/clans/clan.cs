using System.Text.Json;
using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    class Clan
    {
        ClanMemberList? memberList;
        string? tag;
        int clanLevel;
        string? name;
        int members;
        string? description;
        BadgeUrls? badgeUrls;

        [JsonPropertyName("memberList")]
        public ClanMemberList MemberList
        {
            get => memberList ?? [];
            init => memberList = value;
        }

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

        [JsonPropertyName("members")]
        public int Members
        {
            get => members;
            init => members = value;
        }

        [JsonPropertyName("description")]
        public string Description
        {
            get => description ?? "";
            init => description = value;
        }

        [JsonPropertyName("badgeUrls")]
        public BadgeUrls? BadgeUrls
        {
            get => badgeUrls;
            init => badgeUrls = value;
        }
    }
}