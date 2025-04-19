using System.Text.Json;
using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.config
{
    internal static class APIConfig
    {
        static readonly APISettings settings;

        public static string BaseUrl => settings.BaseUrl;

        public static string Key => settings.Key;

        public static PathSettings Path => settings.Path;

        static APIConfig()
        {
            try
            {
                string jsonString = File.ReadAllText(GlobalConfig.APIConfigFile);
                settings = JsonSerializer.Deserialize<APISettings>(jsonString) ?? throw new Exception("API配置信息为空。");
            }
            catch(TypeInitializationException ex)
            {
                throw new ConfigException("APIConfig", "TypeInitializer", "加载API配置文件失败。", ex.InnerException);
            }
            catch (FileNotFoundException ex)
            {
                throw new ConfigException("APIConfig", "TypeInitializer", "找不到API配置文件。", ex);
            }
            catch (JsonException ex)
            {
                throw new ConfigException("APIConfig", "TypeInitializer", "读取API配置信息失败。", ex);
            }
            catch (Exception ex)
            {
                throw new ConfigException("APIConfig", "TypeInitializer", "加载API配置文件失败。", ex);
            }
        }
    }

    internal class APISettings
    {
        string? baseUrl;
        string? key;
        PathSettings? path;

        [JsonPropertyName("base_url")]
        public string BaseUrl
        {
            get => baseUrl ?? throw new ConfigException("APISettings", "BaseURL", "未配置API基地址。");
            init => baseUrl = value;
        }

        [JsonPropertyName("key")]
        public string Key
        {
            get => key ?? throw new ConfigException("APISettings", "Key", "未配置API密钥。");
            init => key = value;
        }

        [JsonPropertyName("path")]
        public PathSettings Path
        {
            get => path ?? throw new ConfigException("APISettings", "InterfacePath", "未配置API路径");
            init => path = value;
        }
    }

    internal class PathSettings
    {
        PlayersSettings? players;
        ClansSettings? clans;

        [JsonPropertyName("players")]
        public PlayersSettings Players
        {
            get => players ?? throw new ConfigException("PathSettings", "Players", "未配置玩家API路径。");
            init => players = value;
        }

        [JsonPropertyName("clans")]
        public ClansSettings Clans
        {
            get => clans ?? throw new ConfigException("Interfaces", "Clans", "未配置部落API路径。");
            init => clans = value;
        }
    }

    internal class PlayersSettings
    {
        string? info;

        [JsonPropertyName("player")]
        public string Info
        {
            get => info ?? throw new ConfigException("PlayersSettings", "Info", "未配置玩家信息API路径。");
            init => info = value;
        }
    }

    internal class ClansSettings
    {
        string? clan;
        string? war;

        [JsonPropertyName("clan")]
        public string Clan
        {
            get => clan ?? throw new ConfigException("ClansSettings", "Clan", "未配置部落API路径。");
            init => clan = value;
        }

        [JsonPropertyName("war")]
        public string War
        {
            get => war ?? throw new ConfigException("ClansSettings", "War", "未配置部落战API路径。");
            init => war = value;
        }
    }
}