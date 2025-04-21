using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.common
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum Role
    {
        NOT_MEMBER,
        MEMBER,
        LEADER,
        ADMIN,
        COLEADER
    }
}
