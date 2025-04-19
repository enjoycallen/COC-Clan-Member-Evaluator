using COC_Clan_Member_Evaluator.config;
using System.Text.Json;

namespace COC_Clan_Member_Evaluator.api.clans
{
    internal static class Clans
    {
        public static async Task<Clan> GetClan(string clanTag)
        {
            try
            {
                string jsonString = await APIclient.Get(APIConfig.Path.Clans.Clan, clanTag);
                return JsonSerializer.Deserialize<Clan>(jsonString) ?? throw new Exception("部落信息为空。");
            }
            catch (TypeInitializationException ex)
            {
                throw new APIException("Clans", "GetClan", "获取部落信息失败。", ex.InnerException);
            }
            catch (Exception ex)
            {
                throw new APIException("Clans", "GetClan", "获取部落信息失败。", ex);
            }
        }

        public static async Task<ClanWar> GetClanWar(string clanTag)
        {
            try
            {
                string jsonString = await APIclient.Get(APIConfig.Path.Clans.War, clanTag);
                return JsonSerializer.Deserialize<ClanWar>(jsonString) ?? throw new Exception("部落战争信息为空。");
            }
            catch (TypeInitializationException ex)
            {
                throw new APIException("Clans", "GetClanWar", "获取部落战争信息失败。", ex.InnerException);
            }
            catch (Exception ex)
            {
                throw new APIException("Clans", "GetClanWar", "获取部落战争信息失败。", ex);
            }
        }
    }
}
