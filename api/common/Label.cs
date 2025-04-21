namespace COC_Clan_Member_Evaluator.api.common
{
    internal class LabelList : List<Label>;

    internal class Label
    {
        private string? _name;
        private int _id;
        private IconUrls? _iconUrls;

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(Label), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int Id
        {
            get => _id;
            init => _id = value;
        }

        [JsonPropertyName("iconUrls")]
        public IconUrls IconUrls
        {
            get => _iconUrls ?? throw new NullPropertyException(nameof(Label), nameof(IconUrls));
            init => _iconUrls = value;
        }
    }
}
