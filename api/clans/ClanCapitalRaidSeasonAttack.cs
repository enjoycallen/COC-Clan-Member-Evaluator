namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanCapitalRaidSeasonAttackList : List<ClanCapitalRaidSeasonAttack>;

    internal class ClanCapitalRaidSeasonAttack
    {
        private ClanCapitalRaidSeasonAttacker? attacker;
        private int _destructionPercent;
        private int _stars;

        [JsonPropertyName("attacker")]
        public ClanCapitalRaidSeasonAttacker Attacker
        {
            get => attacker ?? throw new NullPropertyException(nameof(ClanCapitalRaidSeasonAttack), nameof(Attacker));
            init => attacker = value;
        }

        [JsonPropertyName("destructionPercent")]
        public int DestructionPercent
        {
            get => _destructionPercent;
            init => _destructionPercent = value;
        }

        [JsonPropertyName("stars")]
        public int Stars
        {
            get => _stars;
            init => _stars = value;
        }
    }
}
