using System.Collections.Generic;

namespace EFCoreWebApi.Constants {

    public static class Constants {

        public const string SLASH = "/";
        public const string CONTROLLER = "[controller]";
        public const string BASE_PATH = SLASH + CONTROLLER;

        public const string PATH_SEED_DATA = "SeedData";

        public static IEnumerable<string> Endpoints => _endpoints;

        private static readonly IList<string> _endpoints = new List<string> {
            BASE_PATH
        };

    }

}
