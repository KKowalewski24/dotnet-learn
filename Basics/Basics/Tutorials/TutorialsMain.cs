using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Basics.Tutorials {

    public class TutorialsMain {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly HttpClient _httpClient = new HttpClient();

        /*------------------------ METHODS REGION ------------------------*/
        public async Task Main() {
            List<Repository> repositories = await ProcessRepositories();
            repositories.ToList().ForEach(Console.WriteLine);
        }

        private async Task<List<Repository>> ProcessRepositories() {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );
            _httpClient.DefaultRequestHeaders
                       .Add("User-Agent", ".NET Foundation Repository Reporter");

            Task<Stream> stringTask = _httpClient
                .GetStreamAsync("https://api.github.com/orgs/dotnet/repos");

            return await JsonSerializer.DeserializeAsync<List<Repository>>(await stringTask);
        }

    }

}
