namespace COC_Clan_Member_Evaluator.api.players
{
    internal class VerificationResponse
    {
        private string? _tag;
        private string? _token;
        private VerificationStatus _status;
        
        [JsonPropertyName("tag")]
        public string Tag
        {
            get => _tag ?? throw new NullPropertyException(nameof(VerificationResponse), nameof(Tag));
            init => _tag = value;
        }

        [JsonPropertyName("token")]
        public string Token
        {
            get => _token ?? throw new NullPropertyException(nameof(VerificationResponse), nameof(Token));
            init => _token = value;
        }

        [JsonPropertyName("status")]
        public VerificationStatus Status
        {
            get => _status;
            init => _status = value;
        }
    }
}
