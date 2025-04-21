using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonMemberList : List<ClanCapitalRaidSeasonMember>;

    internal class ClanCapitalRaidSeasonMember
    {
        private string? _tag;
        private string? _name;
        private int _attacks;
        private int _attackLimit;
        private int _bonusAttackLimit;
        private int _capitalResourcesLooted;

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => _tag ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonMember), nameof(Tag));
            init => _tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonMember), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("attacks")]
        public int Attacks
        {
            get => _attacks;
            init => _attacks = value;
        }

        [JsonPropertyName("attackLimit")]
        public int AttackLimit
        {
            get => _attackLimit;
            init => _attackLimit = value;
        }

        [JsonPropertyName("bonusAttackLimit")]
        public int BonusAttackLimit
        {
            get => _bonusAttackLimit;
            init => _bonusAttackLimit = value;
        }

        [JsonPropertyName("capitalResourcesLooted")]
        public int CapitalResourcesLooted
        {
            get => _capitalResourcesLooted;
            init => _capitalResourcesLooted = value;
        }
    }
}
