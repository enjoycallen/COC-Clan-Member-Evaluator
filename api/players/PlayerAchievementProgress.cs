using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal class PlayerAchievementProgressList : List<PlayerAchievementProgress>;

    internal class PlayerAchievementProgress
    {
        private int _stars;
        private int _value;
        private string? _name;
        private int _target;
        private string? _info;
        private string? _completionInfo;
        private Village _village;

        [JsonPropertyName("stars")]
        public int Stars
        {
            get => _stars;
            init => _stars = value;
        }

        [JsonPropertyName("value")]
        public int Value
        {
            get => _value;
            init => _value = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(PlayerAchievementProgress), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("target")]
        public int Target
        {
            get => _target;
            init => _target = value;
        }

        [JsonPropertyName("info")]
        public string Info
        {
            get => _info ?? throw new NullPropertyException(nameof(PlayerAchievementProgress), nameof(Info));
            init => _info = value;
        }

        [JsonPropertyName("completionInfo")]
        public string? CompletionInfo
        {
            get => _completionInfo;
            init => _completionInfo = value;
        }

        [JsonPropertyName("village")]
        public Village Village
        {
            get => _village;
            init => _village = value;
        }
    }
}