﻿using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using XfMobileTemplate.Ca.Application.Features.Common.Factories;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Constants;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Factories
{
    public class CustomHttpClientFactory : ICustomHttpClientFactory
    {
        private HttpClient _httpClient;

        public HttpClient GetInstance()
        {
            if (_httpClient is null)
            {
                _httpClient = GenerateHttpClient();
            }

            return _httpClient;
        }

        private WebProxy GenerateWebProxy()
        {
            return new WebProxy(AppSettings.HttpProxyAddress, AppSettings.HttpProxyPort);
        }

        private HttpClient GenerateHttpClient()
        {
            HttpClient client = null;

            if (AppSettings.CurrentEnvironment.Equals(AppEnvironment.Development) && AppSettings.EnableHttpProxy)
            {
                client = GenerateWebProxyClient();
            }
            else
            {
                client = new HttpClient();
            }

            ConfigureHttpClient(client);

            return client;
        }

        private void ConfigureHttpClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private HttpClient GenerateWebProxyClient()
        {
            var webProxy = GenerateWebProxy();
            var httpClientHandler = new HttpClientHandler()
            {
                Proxy = webProxy,
                UseProxy = true
            };

            return new HttpClient(httpClientHandler);
        }
    }
}
