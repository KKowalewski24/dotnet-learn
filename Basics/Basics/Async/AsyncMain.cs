using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Basics.Async {

    public class AsyncMain {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly HttpClient _httpClient = new HttpClient();

        /*------------------------ METHODS REGION ------------------------*/
        public async Task Main() {
            await IoBound();
            await Task.Run(DoSthLong);
            IList<int> userIds = new List<int> {1, 2, 3, 4};

            foreach (var user in await AsyncLinq(userIds)) {
                Console.WriteLine(user);
            }

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
            Task.Delay(500);
            return new User("John", 24);
        }

    }

}
