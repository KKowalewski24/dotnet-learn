using System.Collections.Generic;

namespace EFCoreBasicsConsole.Models {

    public class Blog : BaseEntity {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();

        /*------------------------ METHODS REGION ------------------------*/
        public Blog() {
        }

        public Blog(string url, int rating) {
            Url = url;
            Rating = rating;
        }

        public Blog(string url, int rating, List<Post> posts) {
            Url = url;
            Rating = rating;
            Posts = posts;
        }

        public override string ToString() {
            return $"{base.ToString()}, " +
                   $"{nameof(Url)}: {Url}, " +
                   $"{nameof(Rating)}: {Rating}, " +
                   $"{nameof(Posts)}: {Posts}";
        }

    }

}
