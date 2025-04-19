using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal class PlayerItemLevelList : List<PlayerItemLevel>;

    internal class PlayerItemLevel
    {
        int level;
        string? name;
        int maxLevel;
        Village village;
        bool? superTroopIsActive;
        PlayerItemLevelList? equipment;

        [JsonPropertyName("level")]
        public int Level
        {
            get => level;
            set => level = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => name ?? "";
            set => name = value;
        }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel
        {
            get => maxLevel;
            set => maxLevel = value;
        }

        [JsonPropertyName("village")]
        public Village Village
        {
            get => village;
            set => village = value;
        }

        [JsonPropertyName("superTroopIsActive")]
        public bool? SuperTroopIsActive
        {
            get => superTroopIsActive;
            set => superTroopIsActive = value;
        }

        [JsonPropertyName("equipment")]
        public PlayerItemLevelList? Equipment
        {
            get => equipment;
            set => equipment = value;
        }
    }
}
