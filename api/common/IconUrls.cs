namespace COC_Clan_Member_Evaluator.api.common
{
    internal class IconUrls
    {
        string? tiny;
        string? small;
        string? medium;

        [JsonPropertyName("tiny")]
        public string? Tiny
        {
            get => tiny;
            init => tiny = value;
        }

        [JsonPropertyName("small")]
        public string? Small
        {
            get => small;
            init => small = value;
        }

        [JsonPropertyName("medium")]
        public string? Medium
        {
            get => medium;
            init => medium = value;
        }
    }
}
