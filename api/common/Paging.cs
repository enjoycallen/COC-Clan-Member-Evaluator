using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.common
{
    internal class Paging
    {
        private Cursors? _cursors;

        [JsonPropertyName("cursors")]
        public Cursors Cursors
        {
            get => _cursors ?? throw new NullPropertyException(nameof(Paging), nameof(Cursors));
            init => _cursors = value;
        }
    }
}
