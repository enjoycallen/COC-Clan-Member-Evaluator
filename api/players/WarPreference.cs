namespace COC_Clan_Member_Evaluator.api.players
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum WarPreference
    {
        @in,
        @out
    }
}