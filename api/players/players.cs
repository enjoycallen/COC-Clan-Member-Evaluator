using COC_Clan_Member_Evaluator.config;
using System.Text.Json;

namespace COC_Clan_Member_Evaluator.api.players
{
    internal static class Players
    {
        public static async Task<Player> GetPlayer(string playerTag)
        {
            try
            {
                string jsonString = await APIclient.Get(APIConfig.Path.Players.Info, playerTag);
                return JsonSerializer.Deserialize<Player>(jsonString) ?? throw new Exception("玩家信息为空。");
            }
            catch (TypeInitializationException ex)
            {
                throw new APIException("Players", "GetPlayer", "获取玩家信息失败。", ex.InnerException);
            }
            catch (Exception ex)
            {
                throw new APIException("Players", "GetPlayer", "获取玩家信息失败。", ex);
            }
        }
    }
}