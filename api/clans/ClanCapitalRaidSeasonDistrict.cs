namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonDistrictList : List<ClanCapitalRaidSeasonDistrict>;

    internal class ClanCapitalRaidSeasonDistrict
    {
        private int _stars;
        private string? _name;
        private int _id;
        private int _destructionPercent;
        private int _attackCount;
        private int _TotalLooted;
        private ClanCapitalRaidSeasonAttackList? _attacks;
        private int _districtHallLevel;

        [JsonPropertyName("stars")]
        public int Stars
        {
            get => _stars;
            init => _stars = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonDistrict), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id;
            init => _id = value;
        }

        [JsonPropertyName("destructionPercent")]
        public int DestructionPercent
        {
            get => _destructionPercent;
            init => _destructionPercent = value;
        }

        [JsonPropertyName("attackCount")]
        public int AttackCount
        {
            get => _attackCount;
            init => _attackCount = value;
        }

        [JsonPropertyName("totalLooted")]
        public int TotalLooted
        {
            get => _TotalLooted;
            init => _TotalLooted = value;
        }

        [JsonPropertyName("attacks")]
        public ClanCapitalRaidSeasonAttackList? Attacks
        {
            get => _attacks;
            init => _attacks = value;
        }

        [JsonPropertyName("districtHallLevel")]
        public int DistrictHallLevel
        {
            get => _districtHallLevel;
            init => _districtHallLevel = value;
        }
    }
}
