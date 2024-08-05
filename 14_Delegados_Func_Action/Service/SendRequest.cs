using _14_Delegados_Func_Action.Models;
using System.Text.Json;

namespace _14_Delegados_Func_Action.Service
{
    public class SendRequest<T> where T : IRequestable

    {
        private HttpClient _client = new HttpClient();
        public async Task<T> Send(T model)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/";

            var data = JsonSerializer.Serialize(model);
            HttpContent content =
                new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await _client.PostAsync(url, content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<T>(result);

                return postResult;
            }

            return default;
        }
    }
}
