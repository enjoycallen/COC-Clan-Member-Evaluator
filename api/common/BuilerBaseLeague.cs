using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.common
{
    internal class BuilerBaseLeague
    {
        private string? _name;
        private int? _id;

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(BuilerBaseLeague), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id ?? throw new NullPropertyException(nameof(BuilerBaseLeague), nameof(ID));
            init => _id = value;
        }
    }
}
