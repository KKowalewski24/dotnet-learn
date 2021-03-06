namespace EFCoreBasicsConsole.Models {

    public class Post : BaseEntity {

        /*------------------------ FIELDS REGION ------------------------*/
        public string Title { get; set; }
        public string Content { get; set; }
        public Blog Blog { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public Post() {
        }

        public Post(string title, string content) {
            Title = title;
            Content = content;
        }

        public Post(string title, string content, Blog blog) {
            Title = title;
            Content = content;
            Blog = blog;
        }

        public override string ToString() {
            return $"{base.ToString()}, " +
                   $"{nameof(Title)}: {Title}, " +
                   $"{nameof(Content)}: {Content}, " +
                   $"{nameof(Blog)}: {Blog}";
        }

    }

}
