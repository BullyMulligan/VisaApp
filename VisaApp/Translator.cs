using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VisaApp
{
    public class Translator
    {
        //ключ берем на портале Azure. Нужно создать переводчик(https://www.youtube.com/watch?v=l6Rl4HSZVvg)
        private static readonly string key = "c3097151b06b4e21a24739a64bf29d41";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";

        public string TranslateText(string textToTranslate)
        {
            string route = $"/translate?api-version=3.0&to=en";
            var body = new[] { new { Text = textToTranslate } };
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
                var deserializedResponse = JsonConvert.DeserializeObject<JArray>(result);
                var translations = deserializedResponse[0]?["translations"];
                var translation = translations?[0]?["text"].ToString();

                return translation;
            }
        }
    }
}