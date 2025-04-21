using COC_Clan_Member_Evaluator.api.common;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal class League
    {
        private string? _name;
        private int? _id;
        private IconUrls? _iconUrls;

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(League), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id ?? throw new NullPropertyException(nameof(League), nameof(ID));
            init => _id = value;
        }

        [JsonPropertyName("iconUrls")]
        public IconUrls IconUrls
        {
            get => _iconUrls ?? throw new NullPropertyException(nameof(League), nameof(IconUrls));
            init => _iconUrls = value;
        }
    }
}
