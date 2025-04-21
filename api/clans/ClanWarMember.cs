using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanWarMemberList : List<ClanWarMember>;

    internal class ClanWarMember
    {
        string? tag;
        string? name;
        int mapPostion;
        int townHallLevel;
        int opponentAttacks;
        ClanWarAttack? bestOpponentAttack;
        ClanWarAttackList? attacks;

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => tag ?? "";
            set => tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => name ?? "";
            set => name = value;
        }

        [JsonPropertyName("mapPosition")]
        public int MapPostion
        {
            get => mapPostion;
            set => mapPostion = value;
        }

        [JsonPropertyName("townHallLevel")]
        public int TownHallLevel
        {
            get => townHallLevel;
            set => townHallLevel = value;
        }

        [JsonPropertyName("opponentAttacks")]
        public int OpponentAttacks
        {
            get => opponentAttacks;
            set => opponentAttacks = value;
        }

        [JsonPropertyName("bestOpponentAttack")]
        public ClanWarAttack? BestOpponentAttack
        {
            get => bestOpponentAttack;
            set => bestOpponentAttack = value;
        }

        [JsonPropertyName("attacks")]
        public ClanWarAttackList? Attacks
        {
            get => attacks;
            set => attacks = value;
        }
    }
}
