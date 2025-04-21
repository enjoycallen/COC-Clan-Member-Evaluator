using COC_Clan_Member_Evaluator.api.common;

namespace COC_Clan_Member_Evaluator.api.clans
{
    class Clan
    {
        private WarLeague? _warLeague;
        private CapitalLeague? _capitalLeague;
        private ClanMemberList? _memberList;
        private string? _tag;
        private WarFrequency _warFrequency;
        private int _clanLevel;
        private int _warWinStreak;
        private int _warWins;
        private int? _warTies;
        private int? _warLoses;
        private int _clanPoints;
        private int _clanBuilderBasePoints;
        private int _clanCapitalPoints;
        private int _requiredTrophies;
        private int _requiredBuilderBaseTrophies;
        private int _requiredTownhallLevel;
        private Language? _chatLanguage;
        private bool _isFamilyFriendly;
        private bool _isWarLogPublic;
        private LabelList? _labels;
        private string? _name;
        private Location? _location;
        private Type? _type;
        private int _members;
        private string? _description;
        private ClanCapital? _clanCapital;
        private BadgeUrls? _badgeUrls;

        [JsonPropertyName("warLeague")]
        public WarLeague WarLeague
        {
            get => _warLeague ?? throw new NullPropertyException(nameof(Clan), nameof(WarLeague));
            init => _warLeague = value;
        }

        [JsonPropertyName("capitalLeague")]
        public CapitalLeague CapitalLeague
        {
            get => _capitalLeague ?? throw new NullPropertyException(nameof(Clan), nameof(CapitalLeague));
            init => _capitalLeague = value;
        }

        [JsonPropertyName("memberList")]
        public ClanMemberList MemberList
        {
            get => _memberList ?? throw new NullPropertyException(nameof(Clan), nameof(MemberList));
            init => _memberList = value;
        }

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => _tag ?? "";
            init => _tag = value;
        }

        [JsonPropertyName("warFrequency")]
        public WarFrequency WarFrequency
        {
            get => _warFrequency;
            init => _warFrequency = value;
        }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel
        {
            get => _clanLevel;
            init => _clanLevel = value;
        }

        [JsonPropertyName("warWinStreak")]
        public int WarWinStreak
        {
            get => _warWinStreak;
            init => _warWinStreak = value;
        }

        [JsonPropertyName("warWins")]
        public int WarWins
        {
            get => _warWins;
            init => _warWins = value;
        }

        [JsonPropertyName("warTies")]
        public int? WarTies
        {
            get => _warTies;
            init => _warTies = value;
        }

        [JsonPropertyName("warLoses")]
        public int? WarLoses
        {
            get => _warLoses;
            init => _warLoses = value;
        }

        [JsonPropertyName("clanPoints")]
        public int ClanPoints
        {
            get => _clanPoints;
            init => _clanPoints = value;
        }

        [JsonPropertyName("clanBuilderBasePoints")]
        public int ClanBuilderBasePoints
        {
            get => _clanBuilderBasePoints;
            init => _clanBuilderBasePoints = value;
        }

        [JsonPropertyName("clanCapitalPoints")]
        public int ClanCapitalPoints
        {
            get => _clanCapitalPoints;
            init => _clanCapitalPoints = value;
        }

        [JsonPropertyName("requiredTrophies")]
        public int RequiredTrophies
        {
            get => _requiredTrophies;
            init => _requiredTrophies = value;
        }

        [JsonPropertyName("requiredBuilderBaseTrophies")]
        public int RequiredBuilderBaseTrophies
        {
            get => _requiredBuilderBaseTrophies;
            init => _requiredBuilderBaseTrophies = value;
        }

        [JsonPropertyName("requiredTownhallLevel")]
        public int RequiredTownhallLevel
        {
            get => _requiredTownhallLevel;
            init => _requiredTownhallLevel = value;
        }

        [JsonPropertyName("chatLanguage")]
        public Language? ChatLanguage
        {
            get => _chatLanguage;
            init => _chatLanguage = value;
        }

        [JsonPropertyName("isFamilyFriendly")]
        public bool IsFamilyFriendly
        {
            get => _isFamilyFriendly;
            init => _isFamilyFriendly = value;
        }

        [JsonPropertyName("isWarLogPublic")]
        public bool IsWarLogPublic
        {
            get => _isWarLogPublic;
            init => _isWarLogPublic = value;
        }

        [JsonPropertyName("labels")]
        public LabelList Labels
        {
            get => _labels ?? throw new NullPropertyException(nameof(Clan), nameof(Labels));
            init => _labels = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? "";
            init => _name = value;
        }

        [JsonPropertyName("location")]
        public Location? Location
        {
            get => _location;
            init => _location = value;
        }

        [JsonPropertyName("type")]
        public Type Type
        {
            get => _type ?? throw new NullPropertyException(nameof(Clan), nameof(Type));
            init => _type = value;
        }

        [JsonPropertyName("members")]
        public int Members
        {
            get => _members;
            init => _members = value;
        }

        [JsonPropertyName("description")]
        public string Description
        {
            get => _description ?? throw new NullPropertyException(nameof(Clan), nameof(Description));
            init => _description = value;
        }

        [JsonPropertyName("clanCapital")]
        public ClanCapital ClanCapital
        {
            get => _clanCapital ?? throw new NullPropertyException(nameof(Clan), nameof(ClanCapital));
            init => _clanCapital = value;
        }

        [JsonPropertyName("badgeUrls")]
        public BadgeUrls? BadgeUrls
        {
            get => _badgeUrls;
            init => _badgeUrls = value;
        }
    }
}