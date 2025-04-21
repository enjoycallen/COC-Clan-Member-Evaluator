using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.clans
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum BattleModifier
    {
        none,
        hardMode
    }
}