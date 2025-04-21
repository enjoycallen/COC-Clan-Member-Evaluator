namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapital
    {
        private int? _capitalHallLevel;
        private ClanDistrictDataList? _districts;

        [JsonPropertyName("capitalHallLevel")]
        public int? CapitalHallLevel
        {
            get => _capitalHallLevel;
            init => _capitalHallLevel = value;
        }

        [JsonPropertyName("districts")]
        public ClanDistrictDataList? Districts
        {
            get => _districts;
            init => _districts = value;
        }
    }
}
