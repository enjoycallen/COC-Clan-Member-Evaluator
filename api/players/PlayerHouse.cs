namespace COC_Clan_Member_Evaluator.api.players
{
    internal class PlayerHouse
    {
        private PlayerHouseElementList? _elements;

        [JsonPropertyName("elements")]
        public PlayerHouseElementList? Elements
        {
            get => _elements;
            set => _elements = value;
        }
    }
}
