namespace COC_Clan_Member_Evaluator.config
{
    internal static class Config
    {
        static readonly string _configFile = $@"{Application.StartupPath}\config.json";
        static readonly Settings _settings;

        public static api.Settings Api => _settings.Api;

        static Config()
        {
            try
            {
                string jsonString = File.ReadAllText(_configFile);
                _settings = JsonSerializer.Deserialize<Settings>(jsonString) ?? throw JsonHelper.NullDeserialization;
            }
            catch (FileNotFoundException ex)
            {
                throw new NestedException(nameof(Config), "TypeInitializer", "找不到配置文件。", ex);
            }
            catch (JsonException ex)
            {
                throw new NestedException(nameof(Config), "TypeInitializer", "配置文件反序列化失败。", ex);
            }
            catch (Exception ex)
            {
                throw new NestedException(nameof(Config), "TypeInitializer", "配置文件加载失败。", ex);
            }
        }
    }
}