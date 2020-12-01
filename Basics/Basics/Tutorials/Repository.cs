using System;
using System.Text.Json.Serialization;

namespace Basics.Tutorials {

    public class Repository {

        /*------------------------ FIELDS REGION ------------------------*/
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("html_url")]
        public Uri GitHubHomeUrl { get; set; }

        [JsonPropertyName("homepage")]
        public Uri Homepage { get; set; }

        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public override string ToString() {
            return $"{nameof(name)}: {name}, " +
                   $"{nameof(Description)}: {Description}," +
                   $" {nameof(GitHubHomeUrl)}: {GitHubHomeUrl}, " +
                   $"{nameof(Homepage)}: {Homepage}," +
                   $" {nameof(Watchers)}: {Watchers}";
        }

    }

}
