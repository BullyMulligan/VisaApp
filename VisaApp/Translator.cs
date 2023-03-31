using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace VisaApp
{
    public class Translator
    {
        private static readonly string key = "6437b5dc34594f06a1dc9bbbe4f40891";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";

        public string TranslateText(string textToTranslate)
        {
            string route = $"/translate?api-version=3.0&to=en";
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key);

                // Send the request and get response.
                HttpResponseMessage response = client.SendAsync(request).GetAwaiter().GetResult();

                // Read response as a string.
                string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var deserializedResponseBody = JsonConvert.DeserializeObject<object[]>(result);
                var translations = deserializedResponseBody[0] as Newtonsoft.Json.Linq.JObject;
                var translation = translations["translations"][0]["text"].ToString();

                return translation;
            }
        }
    }
}