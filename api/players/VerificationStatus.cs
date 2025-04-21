namespace COC_Clan_Member_Evaluator.api.players
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum VerificationStatus
    {
        ok,
        invalid
    }
}
