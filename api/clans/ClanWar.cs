using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanWar
    {
        WarClan? clan;
        int teamSize;
        int attacksPerMember;
        BattleModifier? battleModifier;
        WarClan? opponent;
        string? startTime;
        WarState state;
        string? endTime;
        string? preparationStartTime;

        [JsonPropertyName("clan")]
        public WarClan? Clan
        {
            get => clan;
            init => clan = value;
        }

        [JsonPropertyName("teamSize")]
        public int TeamSize
        {
            get => teamSize;
            init => teamSize = value;
        }

        [JsonPropertyName("attacksPerMember")]
        public int AttacksPerMember
        {
            get => attacksPerMember;
            init => attacksPerMember = value;
        }

        [JsonPropertyName("battleModifier")]
        public BattleModifier? BattleModifier
        {
            get => battleModifier;
            init => battleModifier = value;
        }

        [JsonPropertyName("opponent")]
        public WarClan Opponent
        {
            get => opponent ?? new();
            init => opponent = value;
        }

        [JsonPropertyName("startTime")]
        public string StartTime
        {
            get => startTime ?? "";
            init => startTime = value;
        }

        [JsonPropertyName("state")]
        public WarState State
        {
            get => state;
            init => state = value;
        }

        [JsonPropertyName("endTime")]
        public string EndTime
        {
            get => endTime ?? "";
            init => endTime = value;
        }

        [JsonPropertyName("preparationStartTime")]
        public string PreparationStartTime
        {
            get => preparationStartTime ?? "";
            init => preparationStartTime = value;
        }
    }
}
