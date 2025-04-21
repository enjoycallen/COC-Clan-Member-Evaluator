namespace COC_Clan_Member_Evaluator.api.common
{
    internal class BadgeUrls
    {
        string? small;
        string? medium;
        string? large;

        [JsonPropertyName("small")]
        public string Small
        {
            get => small ?? throw new NullPropertyException(nameof(BadgeUrls), nameof(Small));
            init => small = value;
        }

        [JsonPropertyName("medium")]
        public string Medium
        {
            get => medium ?? throw new NullPropertyException(nameof(BadgeUrls), nameof(Medium));
            init => medium = value;
        }

        [JsonPropertyName("large")]
        public string Large
        {
            get => large ?? throw new NullPropertyException(nameof(BadgeUrls), nameof(Large));
            init => large = value;
        }
    }
}
