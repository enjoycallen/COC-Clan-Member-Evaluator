using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum Village
    {
        home,
        builderBase,
        clanCapital
    }
}
