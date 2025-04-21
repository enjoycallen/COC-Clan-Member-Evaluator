using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.clans
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    internal enum WarFrequency
    {
        unknown,
        always,
        moreThanOncePerWeek,
        oncePerWeek,
        lessThanOncePerWeek,
        never,
        any
    }
}
