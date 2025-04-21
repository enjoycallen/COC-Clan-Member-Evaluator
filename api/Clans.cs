using COC_Clan_Member_Evaluator.api.clans;
using COC_Clan_Member_Evaluator.config;

namespace COC_Clan_Member_Evaluator.api
{
    internal static class Clans
    {
        private static readonly Interface _clans = Config.Api.Interfaces["clans"];
        private static readonly string _leagueGroupPath = _clans["leaguegroup"];
        private static readonly string _leagueWarPath = _clans["leaguewar"];
        private static readonly string _warLogPath = _clans["warlog"];
        private static readonly string _clansPath = _clans["clans"];
        private static readonly string _warPath = _clans["war"];
        private static readonly string _clanPath = _clans["clan"];
        private static readonly string membersPath = _clans["members"];
        private static readonly string _raidPath = _clans["raid"];

        public static async Task<Clan> GetClanAsync(string clanTag)
        {
            try
            {
                string jsonString = await Client.GetAsync(_clanPath, clanTag);
                return JsonSerializer.Deserialize<Clan>(jsonString) ?? throw JsonHelper.NullDeserialization;
            }
            catch (Exception ex)
            {
                throw new NestedException(nameof(Clans), nameof(GetClanAsync), "获取部落信息失败。", ex);
            }
        }
        public static async Task<ClanWar> GetWarAsync(string clanTag)
        {
            try
            {
                string jsonString = await Client.GetAsync(_warPath, clanTag);
                return JsonSerializer.Deserialize<ClanWar>(jsonString) ?? throw JsonHelper.NullDeserialization;
            }
            catch (Exception ex)
            {
                throw new NestedException(nameof(Clans), nameof(GetWarAsync), "获取部落战争信息失败。", ex);
            }
        }
    }
}