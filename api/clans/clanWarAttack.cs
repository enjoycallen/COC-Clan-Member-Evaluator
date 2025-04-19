using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class ClanWarAttackList : List<ClanWarAttack>;

    internal class ClanWarAttack
    {
        int order;
        string? attackerTag;
        string? defenderTag;
        int stars;
        int destructionPercentage;
        int duration;

        [JsonPropertyName("order")]
        public int Order
        {
            get => order;
            init => order = value;
        }

        [JsonPropertyName("attackerTag")]
        public string AttackerTag
        {
            get => attackerTag ?? "";
            init => attackerTag = value;
        }

        [JsonPropertyName("defenderTag")]
        public string DefenderTag
        {
            get => defenderTag ?? "";
            init => defenderTag = value;
        }

        [JsonPropertyName("stars")]
        public int Stars
        {
            get => stars;
            init => stars = value;
        }

        [JsonPropertyName("destructionPercentage")]
        public int DestructionPercentage
        {
            get => destructionPercentage;
            init => destructionPercentage = value;
        }

        [JsonPropertyName("duration")]
        public int Duration
        {
            get => duration;
            init => duration = value;
        }
    }
}
