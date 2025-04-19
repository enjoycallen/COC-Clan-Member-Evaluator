using COC_Clan_Member_Evaluator.api.clans;
using COC_Clan_Member_Evaluator.api.players;
using System.Diagnostics;

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

            var playerQuery = Task.Run(() =>
            {
                var Wonderland = "#GGGJ088L8";
                var Hikari = "#GGU2PUPLC";
                var 修尔克 = "#GR0L0GUR8";
                var 菲奥伦 = "#GGGJ088L8";
                try
                {
                    var player = Players.GetPlayer(Hikari);
                    File.WriteAllText(@"D:\Game\COC\API test\player.json", player.Result.ToJsonString());
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
            });

            var ClanQuery = Task.Run(() =>
            {
                var testClan = "#2GUVCQYQC";
                var 科维斯 = "#2JQ88G9G2";
                var 艾欧尼翁 = "#2RRPJC98L";
                try
                {
                    var clan = Clans.GetClan(艾欧尼翁);
                    File.WriteAllText(@"D:\Game\COC\API test\clan.json", clan.Result.ToJsonString());
                    //var clanWar = Clans.GetClanWar(艾欧尼翁);
                    //File.WriteAllText(@"D:\Game\COC\API test\clanWar.json", clanWar.Result.ToJsonString());
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

            });
            Task.WhenAll(playerQuery, ClanQuery).Wait();
        }
    }
}