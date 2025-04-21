namespace COC_Clan_Member_Evaluator.api.common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum WarPreference
    {
        @in,
        @out
    }
}