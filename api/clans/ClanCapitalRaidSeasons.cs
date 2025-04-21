using COC_Clan_Member_Evaluator.api.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasons
    {
        private ClanCapitalRaidSeasonList? _items;
        private Paging? _paging;

        [JsonPropertyName("items")]
        public ClanCapitalRaidSeasonList Items
        {
            get => _items ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasons), nameof(Items));
            init => _items = value;
        }

        [JsonPropertyName("paging")]
        public Paging Paging
        {
            get => _paging ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasons), nameof(Paging));
            init => _paging = value;
        }
    }
}