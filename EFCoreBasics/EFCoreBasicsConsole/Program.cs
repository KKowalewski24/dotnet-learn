using System;
using EFCoreBasicsConsole.EF;
using EFCoreBasicsConsole.Models;

namespace EFCoreBasicsConsole {

    public class Program {

        public static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            SampleSaveAndPrint();
        }

        private static void SampleSaveAndPrint() {
            using (ApplicationContext context = new ApplicationContext()) {
                Blog blog = new Blog("abc", 15);
                Post post1 = new Post("cde", "def", blog);
                Post post2 = new Post("ccc", "ddd", blog);
                blog.Posts.Add(post1);
                blog.Posts.Add(post2);

                context.Blogs.Add(blog);
                context.Posts.Add(post1);
                context.Posts.Add(post2);
                context.SaveChanges();

            }

            using (ApplicationContext context = new ApplicationContext()) {
                foreach (Blog item in context.Blogs) {
                    Console.WriteLine(item);
                }

                foreach (Post item in context.Posts) {
                    Console.WriteLine(item);
                }
            }
        }

    }

}
