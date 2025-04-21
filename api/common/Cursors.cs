namespace COC_Clan_Member_Evaluator.api.common
{
    internal class Cursors
    {
        private string? _before;
        private string? _after;

        [JsonPropertyName("before")]
        public string? Before
        {
            get => _before;
            init => _before = value;
        }

        [JsonPropertyName("after")]
        public string? After
        {
            get => _after;
            init => _after = value;
        }
    }
}
