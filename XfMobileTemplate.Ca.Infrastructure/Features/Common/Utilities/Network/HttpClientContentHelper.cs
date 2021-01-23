using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XfMobileTemplate.Ca.Infrastructure.Features.Common.Constants;

namespace XfMobileTemplate.Ca.Infrastructure.Features.Common.Utilities.Network
{
    public static class HttpClientContentHelper<T>
    {

        public static StringContent CreateRequestPayloadAsStringContent(T type)
        {
            string payload = SerializeFromObject(type);
            return new StringContent(payload, Encoding.UTF8, MimeTypes.Application.Json);
        }

        public async static Task<T> DeserializeObjectFromHttpContent(HttpContent content)
        {
            using (var stream = await content.ReadAsStreamAsync())
            using (var reader = new StreamReader(stream))
            {
                string textContent = GetStringContentFromStreamReader(reader);
                return DeserializeObjectFromString(textContent);
            }
        }

        public async static Task<string> ReadStringFromHttpContent(HttpContent content)
        {
            using (var stream = await content.ReadAsStreamAsync())
            using (var reader = new StreamReader(stream))
            {
                return  GetStringContentFromStreamReader(reader);
            }
        }
        private static T DeserializeObjectFromString(string textContent)
        {
            return JsonConvert.DeserializeObject<T>(textContent);
        }

        private static string GetStringContentFromStreamReader(StreamReader reader)
        {
            return reader.ReadToEnd();
        }

        private static string SerializeFromObject(T type)
        {
            return JsonConvert.SerializeObject(type);
        }
    }
}
