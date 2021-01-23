using System;
using System.Net.Http;

namespace XfMobileTemplate.Ca.Application.Features.Common.Exceptions
{
    public class ApiException: Exception
    {
        public ApiException(string message, int statusCode, HttpContent content):base(message)
        {
            StatusCode = statusCode;
            Content = content;
        }
        public int StatusCode { get; set; }
        public HttpContent Content { get; set; }
    }
}
