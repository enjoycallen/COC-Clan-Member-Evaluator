using COC_Clan_Member_Evaluator.api.common;
using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    class ClanMemberList : List<ClanMember>;

    internal class ClanMember
    {
        string? tag;
        string? name;
        Role role;
        int townHallLevel;

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

        [JsonPropertyName("role")]
        public Role Role
        {
            get => role;
            init => role = value;
        }

        [JsonPropertyName("townHallLevel")]
        public int TownHallLevel
        {
            get => townHallLevel;
            init => townHallLevel = value;
        }
    }
}