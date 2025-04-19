namespace COC_Clan_Member_Evaluator.config
{
    internal class ConfigException(string configClassName, string thrower, string message = "", Exception? innerException = null)
        : Exception($"[配置错误] In {configClassName}.{thrower}: {message}\n{innerException?.Message}");
}