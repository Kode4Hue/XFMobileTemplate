using System;
using System.Net.Http;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Application.Features.Common.Exceptions;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Services
{
    public class BaseHttpService
    {
        protected HttpClient HttpClient;
        public BaseHttpService(ICustomHttpClientFactory httpClientFactory)
        {
            HttpClient = httpClientFactory.GetInstance();
        }

        protected HttpRequestMessage GenerateHttpRequest(HttpMethod method,
            string requestUri, HttpContent content = default(HttpContent))
        {
            return new HttpRequestMessage(method, requestUri)
            {
                Content = content
            };
        }

        protected async Task<HttpResponseMessage> MakeRequest(HttpRequestMessage request)
        {

            HttpResponseMessage responseMessage = null;

            try
            {
                responseMessage = await HttpClient.SendAsync(request);
                responseMessage.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                var statusCode = (int) responseMessage.StatusCode;
                throw new ApiException($"API Error occured with status code: {statusCode}", 
                    ex, statusCode, responseMessage.Content);
            }
            catch(Exception ex)
            {
                throw new Exception("Error occured before sending API request", ex);
            }

            return responseMessage;
        }
    }
}
