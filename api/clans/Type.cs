namespace COC_Clan_Member_Evaluator.api.clans
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum Type
    {
        open,
        inviteOnly,
        closed
    }
}
