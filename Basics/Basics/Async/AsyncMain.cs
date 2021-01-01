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
        private const string SimpleTxt = "simple.txt";

        private readonly HttpClient _httpClient = new HttpClient();

        /*------------------------ METHODS REGION ------------------------*/
        public async Task Main() {
            await IoBound();
            Task task = Task.Run(DoSthLong);
            Console.WriteLine("abc");
            await task;

            IList<int> userIds = new List<int> { 1, 2, 3, 4 };

            foreach (var user in await AsyncLinq(userIds)) {
                Console.WriteLine(user);
            }

            await SimpleWriteAsync();
            await SimpleReadAsync();
            await SimpleParallelWriteAsync();

            Console.WriteLine("Started");
            Task<string> firstTask = Task.Run(FirstLongOperation);
            Task<string> secondTask = Task.Run(SecondLongOperation);
            Task<string> thirdTask = Task.Run(ThirdLongOperation);
            Console.WriteLine("Waiting to finish....");
            Console.WriteLine(await firstTask);
            Console.WriteLine(await secondTask);
            Console.WriteLine(await thirdTask);
        }

        private async Task<string> FirstLongOperation() {
            Console.WriteLine("FirstStarted");
            await Task.Delay(10000);
            Console.WriteLine("FirstFinished");
            return "First";
        }

        private async Task<string> SecondLongOperation() {
            Console.WriteLine("SecondStarted");
            await Task.Delay(2000);
            Console.WriteLine("SecondFinished");
            return "Second";
        }

        private async Task<string> ThirdLongOperation() {
            Console.WriteLine("ThirdStarted");
            await Task.Delay(3000);
            Console.WriteLine("ThirdFinished");
            return "Third";
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

        private async Task DoSthLong() {
            Console.WriteLine("begin");
            await Task.Delay(3000);
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
            await File.AppendAllTextAsync(SimpleTxt, "Sample text to save\n");
        }

        private async Task SimpleReadAsync() {
            string text = await File.ReadAllTextAsync(SimpleTxt);
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
