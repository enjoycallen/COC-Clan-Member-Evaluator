using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api
{
    internal class BadgeUrls
    {
        string? small;
        string? medium;
        string? large;

        [JsonPropertyName("small")]
        public string Small
        {
            get => small ?? "";
            init => small = value;
        }

        [JsonPropertyName("medium")]
        public string Medium
        {
            get => medium ?? "";
            init => medium = value;
        }

        [JsonPropertyName("large")]
        public string Large
        {
            get => large ?? "";
            init => large = value;
        }
    }
}
