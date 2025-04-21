namespace COC_Clan_Member_Evaluator.api.players
{
    internal class PlayerLegendStatistics
    {
        private LegendLeagueTournamentSeasonResult? _currentSeason;
        private int? _legendTrophies;
        private LegendLeagueTournamentSeasonResult? _previousSeason;
        private LegendLeagueTournamentSeasonResult? _previousBuilderBaseSeason;
        private LegendLeagueTournamentSeasonResult? _bestBuilderBaseSeason;
        private LegendLeagueTournamentSeasonResult? _bestSeason;

        [JsonPropertyName("currentSeason")]
        public LegendLeagueTournamentSeasonResult? CurrentSeason
        {
            get => _currentSeason;
            init => _currentSeason = value;
        }

        [JsonPropertyName("legendTrophies")]
        public int? LegendTrophies
        {
            get => _legendTrophies;
            init => _legendTrophies = value;
        }

        [JsonPropertyName("previousSeason")]
        public LegendLeagueTournamentSeasonResult? PreviousSeason
        {
            get => _previousSeason;
            init => _previousSeason = value;
        }

        [JsonPropertyName("previousBuilderBaseSeason")]
        public LegendLeagueTournamentSeasonResult? PreviousBuilderBaseSeason
        {
            get => _previousBuilderBaseSeason;
            init => _previousBuilderBaseSeason = value;
        }

        [JsonPropertyName("bestBuilderBaseSeason")]
        public LegendLeagueTournamentSeasonResult? BestBuilderBaseSeason
        {
            get => _bestBuilderBaseSeason;
            init => _bestBuilderBaseSeason = value;
        }

        [JsonPropertyName("bestSeason")]
        public LegendLeagueTournamentSeasonResult? BestSeason
        {
            get => _bestSeason;
            init => _bestSeason = value;
        }
    }
}
