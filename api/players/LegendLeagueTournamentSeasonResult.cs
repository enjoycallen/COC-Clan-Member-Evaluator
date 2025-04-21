namespace COC_Clan_Member_Evaluator.api.players
{
    internal class LegendLeagueTournamentSeasonResult
    {
        private int _trophies;
        private string? _id;
        private int _rank;

        [JsonPropertyName("trophies")]
        public int Trophies
        {
            get => _trophies;
            init => _trophies = value;
        }

        [JsonPropertyName("id")]
        public string? ID
        {
            get => _id;
            init => _id = value;
        }

        [JsonPropertyName("rank")]
        public int Rank
        {
            get => _rank;
            init => _rank = value;
        }
    }
}
