using COC_Clan_Member_Evaluator.api;

namespace COC_Clan_Member_Evaluator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var Wonderland = "#GP8YQYYYQ";
            var Hikari = "#GGU2PUPLC";
            var Mio = "#GCJG9GJC9";

            var 艾欧尼翁 = "#2RRPJC98L";
            var 科维斯 = "#2JQ88G9G2";
            var 空部落 = "#2RR0LJCRU";

            try
            {
                List<Task> tasks = [];
                //tasks.Add(TestGetPlayer(Wonderland));
                //tasks.Add(TestVerifyPlayer(Wonderland, "r87jf2sf"));
                tasks.Add(TestGetClan(空部落));
                Task.WhenAll(tasks).Wait();
            }
            catch (TypeInitializationException ex)
            {
                MessageBox.Show(ex.InnerException?.Message, "错误", default, MessageBoxIcon.Error);
            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.InnerException?.Message, "错误", default, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", default, MessageBoxIcon.Error);
            }
        }

        static async Task TestGetPlayer(string playerTag)
        {
            var getPlayer = await Players.GetPlayerAsync(playerTag);
            File.WriteAllText($@"{nameof(TestGetPlayer)}_{playerTag}.json", getPlayer.ToJsonString());
        }

        static async Task TestVerifyPlayer(string playerTag, string token)
        {
            var verifyPlayer = await Players.VerifyPlayerAsync(playerTag, token);
            File.WriteAllText($@"{nameof(TestVerifyPlayer)}_{playerTag}.json", verifyPlayer.ToString());
        }

        static async Task TestGetClan(string clanTag)
        {
            var getClan = await Clans.GetClanAsync(clanTag);
            File.WriteAllText($@"{nameof(TestGetClan)}_{clanTag}.json", getClan.ToJsonString());
        }
    }
}