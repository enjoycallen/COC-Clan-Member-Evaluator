using COC_Clan_Member_Evaluator.config;
using System.Net;

namespace COC_Clan_Member_Evaluator.api
{
    internal static class Client
    {
        static readonly HttpClient client = new();

        static Client()
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Config.Api.Key}");
            }
            catch(Exception ex)
            {
                throw new NestedException(nameof(Client), "TypeInitializer", "API客户端初始化失败", ex);
            }
        }

        public static async Task<string> GetAsync(string path, params string[] requestParams)
        {
            requestParams = [.. requestParams.Select(param => WebUtility.UrlEncode(param))];
            try
            {
                string requestUrl = string.Format(Config.Api.BaseUrl + path, requestParams);
                return await client.GetStringAsync(requestUrl);
            }
            catch (FormatException ex)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "请求路径格式化错误", ex);
            }
            catch(HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "请求参数错误");
            }
            catch(HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "拒绝访问");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "找不到资源");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.TooManyRequests)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "访问过于频繁");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "未知错误");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "服务暂不可用");
            }
            catch (Exception ex)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "请求错误", ex);
            }
        }

        public static async Task<string> PostAsync(string path, StringContent content, params string[] requestParams)
        {
            requestParams = [.. requestParams.Select(param => WebUtility.UrlEncode(param))];
            try
            {
                string requestUrl = string.Format(Config.Api.BaseUrl + path, requestParams);
                var response = await client.PostAsync(requestUrl, content);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (FormatException ex)
            {
                throw new NestedException(nameof(Client), nameof(PostAsync), "请求路径格式化错误", ex);
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "请求参数错误");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "拒绝访问");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "找不到资源");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.TooManyRequests)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "访问过于频繁");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "未知错误");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "服务暂不可用");
            }
            catch (Exception ex)
            {
                throw new NestedException(nameof(Client), nameof(GetAsync), "请求错误", ex);
            }
        }
    }
}