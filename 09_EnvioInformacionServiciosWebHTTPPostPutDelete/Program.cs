using _09_EnvioInformacionServiciosWebHTTPPostPutDelete.Models;
using System.Text.Json;

namespace _09_EnvioInformacionServiciosWebHTTPPostPutDelete
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // GET
            //////{
            //////    string url = "https://jsonplaceholder.typicode.com/posts";
            //////    HttpClient client = new HttpClient();

            //////    var httpResponse = await client.GetAsync(url);

            //////    if (httpResponse.IsSuccessStatusCode)
            //////    {
            //////        var content = await httpResponse.Content.ReadAsStringAsync();
            //////        List<Models.Post> posts =
            //////            JsonSerializer.Deserialize<List<Models.Post>>(content);
            //////    }
            //////}

            // POST
            //{
            //    string url = "https://jsonplaceholder.typicode.com/posts";
            //    var client = new HttpClient();

            //    Post post = new Post()
            //    {
            //        userId = 50,
            //        body = "Hola como estan",
            //        title = "titulo de saludo"
            //    };

            //    var data = JsonSerializer.Serialize<Post>(post);
            //    HttpContent content =
            //        new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            //    var httpResponse = await client.PostAsync(url, content);

            //    if (httpResponse.IsSuccessStatusCode)
            //    {
            //        var result = await httpResponse.Content.ReadAsStringAsync();

            //        var postResult = JsonSerializer.Deserialize<Post>(result);
            //    }
            //}

            //// PUT 
            //{
            //    string url = "https://jsonplaceholder.typicode.com/posts/99";
            //    var client = new HttpClient();

            //    Post post = new Post()
            //    {
            //        userId = 50,
            //        body = "Hola como estan",
            //        title = "titulo de saludo"
            //    };

            //    var data = JsonSerializer.Serialize<Post>(post);
            //    HttpContent content =
            //        new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            //    var httpResponse = await client.PutAsync(url, content);

            //    if (httpResponse.IsSuccessStatusCode)
            //    {
            //        var result = await httpResponse.Content.ReadAsStringAsync();

            //        var postResult = JsonSerializer.Deserialize<Post>(result);
            //    }
            //}

            // DELETE 
            {
                string url = "https://jsonplaceholder.typicode.com/posts/99";
                var client = new HttpClient();

                //Post post = new Post()
                //{
                //    userId = 50,
                //    body = "Hola como estan",
                //    title = "titulo de saludo"
                //};

                // var data = JsonSerializer.Serialize<Post>(post);
                // HttpContent content =
                    //new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                var httpResponse = await client.DeleteAsync(url);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();

                    // var postResult = JsonSerializer.Deserialize<Post>(result);
                }
            }
        }
    }
}