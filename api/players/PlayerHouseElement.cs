namespace COC_Clan_Member_Evaluator.api.players
{
    internal class PlayerHouseElementList : List<PlayerHouseElement>;
    internal class PlayerHouseElement
    {
        private int _id;
        private string? _type;

        [JsonPropertyName("id")]
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [JsonPropertyName("type")]
        public string Type
        {
            get => _type ?? throw new NullPropertyException(nameof(PlayerHouseElement), nameof(Type));
            set => _type = value;
        }
    }
}