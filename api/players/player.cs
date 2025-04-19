using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal class Player
    {
        PlayerClan? clan;
        Role role;
        int attackWins;
        int defenseWins;
        int townHallLevel;
        int townHallWeaponLevel;
        PlayerItemLevelList? troops;
        PlayerItemLevelList? heroes;
        PlayerItemLevelList? heroEquipment;
        PlayerItemLevelList? spells;
        string? tag;
        string? name;

        [JsonPropertyName("clan")]
        public PlayerClan? Clan
        {
            get => clan;
            init => clan = value;
        }

        [JsonPropertyName("role")]
        public Role Role
        {
            get => role;
            init => role = value;
        }

        [JsonPropertyName("attackWins")]
        public int AttackWins
        {
            get => attackWins;
            init => attackWins = value;
        }

        [JsonPropertyName("defenseWins")]
        public int DefenseWins
        {
            get => defenseWins;
            init => defenseWins = value;
        }

        [JsonPropertyName("townHallLevel")]
        public int TownHallLevel
        {
            get => townHallLevel;
            init => townHallLevel = value;
        }

        [JsonPropertyName("townHallWeaponLevel")]
        public int TownHallWeaponLevel
        {
            get => townHallWeaponLevel;
            init => townHallWeaponLevel = value;
        }

        [JsonPropertyName("troops")]
        public PlayerItemLevelList? Troops
        {
            get => troops;
            init => troops = value;
        }

        [JsonPropertyName("heroes")]
        public PlayerItemLevelList? Heroes
        {
            get => heroes;
            init => heroes = value;
        }

        [JsonPropertyName("heroEquipment")]
        public PlayerItemLevelList? HeroEquipment
        {
            get => heroEquipment;
            init => heroEquipment = value;
        }

        [JsonPropertyName("spells")]
        public PlayerItemLevelList? Spells
        {
            get => spells;
            init => spells = value;
        }

        [JsonPropertyName("tag")]
        public string Tag
        {
            get => tag ?? "";
            init => tag = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => name ?? "";
            init => name = value;
        }
    }
}