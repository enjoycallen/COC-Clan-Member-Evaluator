using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanWar
    {
        private WarClan? _clan;
        private int? _teamSize;
        private int? _attacksPerMember;
        private BattleModifier? _battleModifier;
        private WarClan? _opponent;
        private string? _startTime;
        private WarState _state;
        private string? _endTime;
        private string? _preparationStartTime;

        [JsonPropertyName("clan")]
        public WarClan Clan
        {
            get => _clan ?? throw new NullPropertyException(nameof(ClanWar), nameof(Clan));
            init => _clan = value;
        }

        [JsonPropertyName("teamSize")]
        public int? TeamSize
        {
            get => _teamSize;
            init => _teamSize = value;
        }

        [JsonPropertyName("attacksPerMember")]
        public int? AttacksPerMember
        {
            get => _attacksPerMember;
            init => _attacksPerMember = value;
        }

        [JsonPropertyName("battleModifier")]
        public BattleModifier? BattleModifier
        {
            get => _battleModifier;
            init => _battleModifier = value;
        }

        [JsonPropertyName("opponent")]
        public WarClan Opponent
        {
            get => _opponent ?? throw new NullPropertyException(nameof(ClanWar), nameof(Opponent));
            init => _opponent = value;
        }

        [JsonPropertyName("startTime")]
        public string? StartTime
        {
            get => _startTime;
            init => _startTime = value;
        }

        [JsonPropertyName("state")]
        public WarState State
        {
            get => _state;
            init => _state = value;
        }

        [JsonPropertyName("endTime")]
        public string? EndTime
        {
            get => _endTime;
            init => _endTime = value;
        }

        [JsonPropertyName("preparationStartTime")]
        public string? PreparationStartTime
        {
            get => _preparationStartTime;
            init => _preparationStartTime = value;
        }
    }
}
