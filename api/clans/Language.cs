using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class Language
    {
        private string? _name;
        private int _id;
        private string? _languageCode;

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(Language), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id;
            init => _id = value;
        }

        [JsonPropertyName("languageCode")]
        public string LanguageCode
        {
            get => _languageCode ?? throw new NullPropertyException(nameof(Language), nameof(LanguageCode));
            init => _languageCode = value;
        }
    }
}
