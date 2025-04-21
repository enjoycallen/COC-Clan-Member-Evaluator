using COC_Clan_Member_Evaluator.api.players;
using COC_Clan_Member_Evaluator.config;
using System.Text;

namespace COC_Clan_Member_Evaluator.api
{
    internal static class Players
    {
        static readonly Interface _players = Config.Api.Interfaces["players"];
        static readonly string _playerPath = _players["player"];
        static readonly string _verifyPath = _players["verify"];

        public static async Task<Player> GetPlayerAsync(string playerTag)
        {
            try
            {
                string jsonString = await Client.GetAsync(_playerPath, playerTag);
                return JsonSerializer.Deserialize<Player>(jsonString) ?? throw JsonHelper.NullDeserialization;
            }
            catch (Exception ex)
            {
                throw new NestedException(nameof(Players), nameof(GetPlayerAsync), "获取玩家信息失败。", ex);
            }
        }

        public static async Task<bool> VerifyPlayerAsync(string playerTag, string token)
        {
            var content = new StringContent(new { token }.ToJsonString(), Encoding.UTF8, "application/json");
            try
            {
                string jsonString = await Client.PostAsync(_verifyPath, content, playerTag);
                return JsonSerializer.Deserialize<VerificationResponse>(jsonString)?.Status == VerificationStatus.ok;
            }
            catch(Exception ex)
            {
                throw new NestedException(nameof(Players), nameof(VerifyPlayerAsync), "验证玩家身份失败。", ex);
            }
            
        }
    }
}