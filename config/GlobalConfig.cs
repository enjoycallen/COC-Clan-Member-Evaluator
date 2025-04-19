using System.Text.Json;
using System.Text.Json.Serialization;

namespace COC_Clan_Member_Evaluator.config
{
    internal static class GlobalConfig
    {
        static readonly string file = $@"{Application.StartupPath}\config\config.json";

        static readonly GlobalSettings settings;

        public static string APIConfigFile => settings.APIConfigFile;

        static GlobalConfig()
        {
            try
            {
                string jsonString = File.ReadAllText(file);
                settings = JsonSerializer.Deserialize<GlobalSettings>(jsonString) ?? throw new Exception("配置信息为空。");
            }
            catch (FileNotFoundException ex)
            {
                throw new ConfigException("Global", "TypeInitializer", "找不到配置文件。", ex);
            }
            catch (JsonException ex)
            {
                throw new ConfigException("Global", "TypeInitializer", "读取配置信息失败。", ex);
            }
            catch (Exception ex)
            {
                throw new ConfigException("Global", "TypeInitializer", "加载配置文件失败。", ex);
            }
        }
    }

    internal class GlobalSettings
    {
        string? apiConfigFile;

        [JsonPropertyName("api_config_file")]
        public string APIConfigFile
        {
            get => apiConfigFile ?? throw new ConfigException("GlobalSettins", "APIFile", "未指定API配置文件。");
            init
            {
                apiConfigFile = $@"{Application.StartupPath}\config\{value}";
            }
        }
    }
}