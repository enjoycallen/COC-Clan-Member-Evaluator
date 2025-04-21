using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal class Location
    {
        private string? _localizedName;
        private int _id;
        private string? _name;
        private bool _isCountry;
        private string? _countryCode;

        [JsonPropertyName("localizedName")]
        public string? LocalizedName
        {
            get => _localizedName;
            init => _localizedName = value;
        }

        [JsonPropertyName("id")]
        public int ID
        {
            get => _id;
            init => _id = value;
        }

        [JsonPropertyName("name")]
        public string Name
        {
            get => _name ?? throw new NullPropertyException(nameof(Location), nameof(Name));
            init => _name = value;
        }

        [JsonPropertyName("isCountry")]
        public bool IsCountry
        {
            get => _isCountry;
            init => _isCountry = value;
        }

        [JsonPropertyName("countryCode")]
        public string? CountryCode
        {
            get => _countryCode;
            init => _countryCode = value;
        }
    }
}
