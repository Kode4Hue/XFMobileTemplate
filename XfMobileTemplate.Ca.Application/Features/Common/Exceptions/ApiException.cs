using System.Net.Http;

namespace XfMobileTemplate.Ca.Application.Features.Common.Exceptions
{
    public class ApiException: HttpRequestException
    {
        public ApiException(string message, HttpRequestException exception, int statusCode, HttpContent content):base(message, exception)
        {
            StatusCode = statusCode;
            Content = content;
        }
        public int StatusCode { get; set; }
        public HttpContent Content { get; set; }
    }
}
