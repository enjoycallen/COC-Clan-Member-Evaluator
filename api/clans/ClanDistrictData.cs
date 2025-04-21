namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanDistrictDataList : List<ClanDistrictData>;

    internal class ClanDistrictData
    {
        private string? _name;
        private int _id;
        private int _districtHallLevel;

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(ClanDistrictData), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id;
            init => _id = value;
        }

        [JsonPropertyName("districtHallLevel")]
        public int DistrictHallLevel
        {
            get => _districtHallLevel;
            init => _districtHallLevel = value;
        }
    }
}
