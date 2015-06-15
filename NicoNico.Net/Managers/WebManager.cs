using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using NicoNico.Net.Entities.Web;
using NicoNico.Net.Interfaces;
using NicoNico.Net.Tools;

namespace NicoNico.Net.Managers
{
    public class WebManager : IWebManager
    {
        public WebManager(CookieContainer cookieContainer = null, string sessionKey = null)
        {
            CookieContainer = cookieContainer ?? new CookieContainer();
            SessionKey = sessionKey;
        }

        public bool IsNetworkAvailable => NetworkInterface.GetIsNetworkAvailable();

        public bool IsSessionKeySet => !string.IsNullOrEmpty(SessionKey);

        public bool IsCookieContainerSet => CookieContainer != null;

        public static CookieContainer CookieContainer { get; set; }

        public static string SessionKey { get; set; }
        public async Task<Result> PostData(Uri uri, MultipartContent header, StringContent content)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                CookieContainer = CookieContainer,
                UseCookies = true,
                UseDefaultCredentials = false
            };
            using (var httpClient = new HttpClient(handler))
            {
                try
                {
                    if (!string.IsNullOrEmpty(SessionKey))
                    {
                        httpClient.DefaultRequestHeaders.Add(Constants.VitaSessionHeader, SessionKey);
                    }
                    HttpResponseMessage response;
                    if (header == null)
                    {
                        if (content == null) content = new StringContent(string.Empty);
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                        response = await httpClient.PostAsync(uri, content);
                    }
                    else
                    {
                        response = await httpClient.PostAsync(uri, header);
                    }
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (Exception ex)
                {
                    throw new WebException("NicoNico API Error: Service error", ex);
                }
            }
        }

        public Task<Result> PutData(Uri uri, StringContent json)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteData(Uri uri, StringContent json)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> GetData(Uri uri)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                CookieContainer = CookieContainer,
                UseCookies = true,
                UseDefaultCredentials = false
            };

            using (var httpClient = new HttpClient(handler))
            {
                try
                {
                    if (!string.IsNullOrEmpty(SessionKey))
                    {
                        httpClient.DefaultRequestHeaders.Add(Constants.VitaSessionHeader, SessionKey);
                    }

                    var response = await httpClient.GetAsync(uri);
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        throw new WebException("NicoNico API Error: Service not found.");
                    }
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return string.IsNullOrEmpty(responseContent) ? new Result(response.IsSuccessStatusCode, string.Empty) : new Result(response.IsSuccessStatusCode, responseContent);
                }
                catch (Exception ex)
                {

                    throw new WebException("NicoNico API Error: Service error", ex);
                }
            }
        }
    }
}
