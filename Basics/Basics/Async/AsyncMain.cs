using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Basics.Async {

    public class AsyncMain {

        /*------------------------ FIELDS REGION ------------------------*/
        const string simpleTxt = "simple.txt";

        private readonly HttpClient _httpClient = new HttpClient();

        /*------------------------ METHODS REGION ------------------------*/
        public async Task Main() {

            await IoBound();
            await Task.Run(DoSthLong);
            IList<int> userIds = new List<int> {1, 2, 3, 4};

            foreach (var user in await AsyncLinq(userIds)) {
                Console.WriteLine(user);
            }

            await SimpleWriteAsync();
            await SimpleReadAsync();
            await SimpleParallelWriteAsync();
        }

        private async Task IoBound() {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );

            _httpClient.DefaultRequestHeaders
                .Add("User-Agent", ".NET Foundation Repository Reporter");

            string result = await _httpClient
                .GetStringAsync("https://api.github.com/orgs/dotnet/repos");

            Console.WriteLine(result.Length);
        }

        private void DoSthLong() {
            Console.WriteLine("begin");
            Task.Delay(3000);
            Console.WriteLine("end");
        }

        private async Task<List<User>> AsyncLinq(IList<int> userIds) {
            IEnumerable<Task<User>> res =
                from userId in userIds
                let abc = GetUserAsync(userId)
                select abc;

            return (await Task.WhenAll(res)).ToList();
        }

        private async Task<User> GetUserAsync(int userId) {
            await Task.Delay(500);
            return new User("John", 24);
        }

        private async Task SimpleWriteAsync() {
            await File.AppendAllTextAsync(simpleTxt, "Sample text to save\n");
        }

        private async Task SimpleReadAsync() {
            string text = await File.ReadAllTextAsync(simpleTxt);
            Console.WriteLine(text);
        }

        private async Task SimpleParallelWriteAsync() {
            const string tempDir = "tempDir";
            if (Directory.Exists(tempDir)) {
                Directory.Delete(tempDir, true);
            }

            string folderName = Directory.CreateDirectory(tempDir).Name;
            IList<Task> writeTasks = new List<Task>();

            for (int index = 11; index <= 20; ++index) {
                string fileName = $"file-{index:00}.txt";
                string filePath = $"{folderName}/{fileName}";
                string text = $"In file {index}{Environment.NewLine}";

                writeTasks.Add(File.WriteAllTextAsync(filePath, text));
            }

            await Task.WhenAll(writeTasks);
        }

    }

}
