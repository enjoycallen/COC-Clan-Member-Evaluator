namespace COC_Clan_Member_Evaluator.api
{
    internal class APIException(string apiClassName, string thrower, string message = "", Exception? innerException = null)
        : Exception($"[API错误] In {apiClassName}.{thrower}: {message}\n{innerException?.Message}");
}