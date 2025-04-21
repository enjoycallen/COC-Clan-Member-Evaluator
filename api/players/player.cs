using COC_Clan_Member_Evaluator.api.common;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal class Player
    {
        private PlayerClan? _clan;
        private League? _league;
        private BuilerBaseLeague? _builderBaseLeague;
        private WarPreference _warPreference;
        private int _attackWins;
        private int _defenseWins;
        private int _townHallLevel;
        private int? _townHallWeaponLevel;
        private PlayerLegendStatistics? _legendStatistics;
        private PlayerItemLevelList? _troops;
        private PlayerItemLevelList? _heroes;
        private PlayerItemLevelList? _heroEquipment;
        private PlayerItemLevelList? _spells;
        private LabelList? _labels;
        private Role _role;
        private string? _tag;
        private string? _name;
        private int _expLevel;
        private int _trophies;
        private int _bestTrophies;
        private int _donations;
        private int _donationsReceived;
        private int? _builderHallLevel;
        private int? _builderBaseTrophies;
        private int? _bestBuilderBaseTrophies;
        private int _warStars;
        private PlayerAchievementProgressList? _achievements;
        private int _clanCapitalContributions;
        private PlayerHouse? _playerHouse;

        [JsonPropertyName("clan")]
        public PlayerClan? Clan
        {
            get => _clan;
            init => _clan = value;
        }

        [JsonPropertyName("league")]
        public League? League
        {
            get => _league;
            init => _league = value;
        }

        [JsonPropertyName("builderBaseLeague")]
        public BuilerBaseLeague? BuilderBaseLeague
        {
            get => _builderBaseLeague;
            init => _builderBaseLeague = value;
        }

        [JsonPropertyName("role")]
        public Role Role
        {
            get => _role;
            init => _role = value;
        }

        [JsonPropertyName("warPreference")]
        public WarPreference WarPreference
        {
            get => _warPreference;
            init => _warPreference = value;
        }

        [JsonPropertyName("attackWins")]
        public int AttackWins
        {
            get => _attackWins;
            init => _attackWins = value;
        }

        [JsonPropertyName("defenseWins")]
        public int DefenseWins
        {
            get => _defenseWins;
            init => _defenseWins = value;
        }

        [JsonPropertyName("townHallLevel")]
        public int TownHallLevel
        {
            get => _townHallLevel;
            init => _townHallLevel = value;
        }

        [JsonPropertyName("townHallWeaponLevel")]
        public int? TownHallWeaponLevel
        {
            get => _townHallWeaponLevel;
            init => _townHallWeaponLevel = value;
        }

        [JsonPropertyName("legendStatistics")]
        public PlayerLegendStatistics? LegendStatistics
        {
            get => _legendStatistics;
            init => _legendStatistics = value;
        }

        [JsonPropertyName("troops")]
        public PlayerItemLevelList Troops
        {
            get => _troops ?? throw new NullPropertyException(nameof(Player), nameof(Troops));
            init => _troops = value;
        }

        [JsonPropertyName("heroes")]
        public PlayerItemLevelList? Heroes
        {
            get => _heroes;
            init => _heroes = value;
        }

        [JsonPropertyName("heroEquipment")]
        public PlayerItemLevelList? HeroEquipment
        {
            get => _heroEquipment;
            init => _heroEquipment = value;
        }

        [JsonPropertyName("spells")]
        public PlayerItemLevelList? Spells
        {
            get => _spells;
            init => _spells = value;
        }

        [JsonPropertyName("labels")]
        public LabelList Labels
        {
            get => _labels ?? throw new NullPropertyException(nameof(Player), nameof(Labels));
            init => _labels = value;
        }

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => _tag ?? throw new NullPropertyException(nameof(Player), nameof(Tag));
            init => _tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(Player), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("expLevel")]
        public int ExpLevel
        {
            get => _expLevel;
            init => _expLevel = value;
        }

        [JsonPropertyName("trophies")]
        public int Trophies
        {
            get => _trophies;
            init => _trophies = value;
        }

        [JsonPropertyName("bestTrophies")]
        public int BestTrophies
        {
            get => _bestTrophies;
            init => _bestTrophies = value;
        }

        [JsonPropertyName("donations")]
        public int Donations
        {
            get => _donations;
            init => _donations = value;
        }

        [JsonPropertyName("donationsReceived")]
        public int DonationsReceived
        {
            get => _donationsReceived;
            init => _donationsReceived = value;
        }

        [JsonPropertyName("builderHallLevel")]
        public int? BuilderHallLevel
        {
            get => _builderHallLevel;
            init => _builderHallLevel = value;
        }

        [JsonPropertyName("builderBaseTrophies")]
        public int? BuilderBaseTrophies
        {
            get => _builderBaseTrophies;
            init => _builderBaseTrophies = value;
        }

        [JsonPropertyName("bestBuilderBaseTrophies")]
        public int? BestBuilderBaseTrophies
        {
            get => _bestBuilderBaseTrophies;
            init => _bestBuilderBaseTrophies = value;
        }

        [JsonPropertyName("warStars")]
        public int WarStars
        {
            get => _warStars;
            init => _warStars = value;
        }

        [JsonPropertyName("achievements")]
        public PlayerAchievementProgressList Achievements
        {
            get => _achievements ?? throw new NullPropertyException(nameof(Player), nameof(Achievements));
            init => _achievements = value;
        }

        [JsonPropertyName("clanCapitalContributions")]
        public int ClanCapitalContributions
        {
            get => _clanCapitalContributions;
            init => _clanCapitalContributions = value;
        }

        [JsonPropertyName("playerHouse")]
        public PlayerHouse? PlayerHouse
        {
            get => _playerHouse;
            init => _playerHouse = value;
        }
    }
}