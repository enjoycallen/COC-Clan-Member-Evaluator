namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonAttackLogList : List<ClanCapitalRaidSeasonAttackLogEntry>;

    internal class ClanCapitalRaidSeasonDefenseLogList : List<ClanCapitalRaidSeasonDefenseLogEntry>;

    internal class ClanCapitalRaidSeasonAttackLogEntry
    {
        private ClanCapitalRaidSeasonClanInfo? _defender;
        private int _attackCount;
        private int _districtCount;
        private int _districtsDestroyed;
        private ClanCapitalRaidSeasonDistrictList? _districts;

        [JsonPropertyName("defender")]
        public ClanCapitalRaidSeasonClanInfo Defender
        {
            get => _defender ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonAttackLogEntry), nameof(Defender));
            init => _defender = value;
        }

        [JsonPropertyName("attackCount")]
        public int AttackCount
        {
            get => _attackCount;
            init => _attackCount = value;
        }

        [JsonPropertyName("districtCount")]
        public int DistrictCount
        {
            get => _districtCount;
            init => _districtCount = value;
        }

        [JsonPropertyName("districtsDestroyed")]
        public int DistrictsDestroyed
        {
            get => _districtsDestroyed;
            init => _districtsDestroyed = value;
        }

        [JsonPropertyName("districts")]
        public ClanCapitalRaidSeasonDistrictList Districts
        {
            get => _districts ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonAttackLogEntry), nameof(Districts));
            init => _districts = value;
        }
    }

    internal class ClanCapitalRaidSeasonDefenseLogEntry
    {
        private ClanCapitalRaidSeasonClanInfo? _attacker;
        private int _attackCount;
        private int _districtCount;
        private int _districtsDestroyed;
        private ClanCapitalRaidSeasonDistrictList? _districts;

        [JsonPropertyName("attacker")]
        public ClanCapitalRaidSeasonClanInfo Attacker
        {
            get => _attacker ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonDefenseLogEntry), nameof(Attacker));
            init => _attacker = value;
        }

        [JsonPropertyName("attackCount")]
        public int AttackCount
        {
            get => _attackCount;
            init => _attackCount = value;
        }

        [JsonPropertyName("districtCount")]
        public int DistrictCount
        {
            get => _districtCount;
            init => _districtCount = value;
        }

        [JsonPropertyName("districtsDestroyed")]
        public int DistrictsDestroyed
        {
            get => _districtsDestroyed;
            init => _districtsDestroyed = value;
        }

        [JsonPropertyName("districts")]
        public ClanCapitalRaidSeasonDistrictList Districts
        {
            get => _districts ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonDefenseLogEntry), nameof(Districts));
            init => _districts = value;
        }
    }
}
