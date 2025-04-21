namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonList : List<ClanCapitalRaidSeason>;

    internal class ClanCapitalRaidSeason
    {
        private ClanCapitalRaidSeasonAttackLogList? _attackLog;
        private ClanCapitalRaidSeasonDefenseLogList? _defenseLog;
        private string? _state;
        private string? _startTime;
        private string? _endTime;
        private int _capitalTotalLoot;
        private int _raidsCompleted;
        private int _totalAttacks;
        private int _enemyDistrictsDestroyed;
        private int _offensiveReward;
        private int _defensiveReward;
        private ClanCapitalRaidSeasonMemberList? _members;

        [JsonPropertyName("attackLog")]
        public ClanCapitalRaidSeasonAttackLogList? AttackLog
        {
            get => _attackLog;
            init => _attackLog = value;
        }
        
        [JsonPropertyName("defenseLog")]
        public ClanCapitalRaidSeasonDefenseLogList? DefenseLog
        {
            get => _defenseLog;
            init => _defenseLog = value;
        }

        [JsonPropertyName("state")]
        public string State
        {
            get => _state ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeason), nameof(State));
            init => _state = value;
        }

        [JsonPropertyName("startTime")]
        public string StartTime
        {
            get => _startTime ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeason), nameof(StartTime));
            init => _startTime = value;
        }

        [JsonPropertyName("endTime")]
        public string EndTime
        {
            get => _endTime ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeason), nameof(EndTime));
            init => _endTime = value;
        }

        [JsonPropertyName("capitalTotalLoot")]
        public int CapitalTotalLoot
        {
            get => _capitalTotalLoot;
            init => _capitalTotalLoot = value;
        }

        [JsonPropertyName("raidsCompleted")]
        public int RaidsCompleted
        {
            get => _raidsCompleted;
            init => _raidsCompleted = value;
        }

        [JsonPropertyName("totalAttacks")]
        public int TotalAttacks
        {
            get => _totalAttacks;
            init => _totalAttacks = value;
        }

        [JsonPropertyName("enemyDistrictsDestroyed")]
        public int EnemyDistrictsDestroyed
        {
            get => _enemyDistrictsDestroyed;
            init => _enemyDistrictsDestroyed = value;
        }

        [JsonPropertyName("offensiveReward")]
        public int OffensiveReward
        {
            get => _offensiveReward;
            init => _offensiveReward = value;
        }

        [JsonPropertyName("defensiveReward")]
        public int DefensiveReward
        {
            get => _defensiveReward;
            init => _defensiveReward = value;
        }

        [JsonPropertyName("members")]
        public ClanCapitalRaidSeasonMemberList Members
        {
            get => _members ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeason), nameof(Members));
            init => _members = value;
        }
    }
}
