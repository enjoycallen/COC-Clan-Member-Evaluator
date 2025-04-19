using System.Net;
using COC_Clan_Member_Evaluator.config;

namespace COC_Clan_Member_Evaluator.api
{
    internal static class APIclient
    {
        static readonly HttpClient client = new();

        static APIclient()
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {APIConfig.Key}");
            }
            catch(TypeInitializationException ex)
            {
                throw new APIException("APIClient", "TypeInitializer", "API客户端初始化失败", ex.InnerException);
            }
            catch(Exception ex)
            {
                throw new APIException("APIClient", "TypeInitializer", "API客户端初始化失败", ex);
            }
        }

        public static async Task<string> Get(string path, params string[] requestParams)
        {
            requestParams = [.. requestParams.Select(param => WebUtility.UrlEncode(param))];
            try
            {
                string requestUrl = string.Format(APIConfig.BaseUrl + path, requestParams);
                return await client.GetStringAsync(requestUrl);
            }
            catch (FormatException ex)
            {
                throw new APIException("APIClient", "Get", "请求参数格式错误", ex);
            }
            catch(HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new APIException("APIClient", "Get", "请求参数错误");
            }
            catch(HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new APIException("APIClient", "Get", "拒绝访问");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                throw new APIException("APIClient", "Get", "找不到资源");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.TooManyRequests)
            {
                throw new APIException("APIClient", "Get", "访问过于频繁");
            }
            catch (Exception ex)
            {
                throw new APIException("APIClient", "Get", "请求错误", ex);
            }
        }
    }
}