using System;
using System.Linq;
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
                Blog blog = new Blog("abc1", 15);
                Post post1 = new Post("cde1", "def1", blog);
                Post post2 = new Post("ccc1", "ddd1", blog);

                context.Blogs.Add(blog);
                context.SaveChanges();
                PrintBlogs(context);

                blog.Posts.Add(post1);
                blog.Posts.Add(post2);
                context.Posts.Add(post1);
                context.Posts.Add(post2);
                context.SaveChanges();
                PrintBlogs(context);

                context.Remove(post1);
                context.Remove(post2);
                context.Remove(blog);
                context.SaveChanges();
                PrintBlogs(context);
            }
        }

        private static void PrintBlogs(ApplicationContext context) {
            IOrderedQueryable<Blog> blogs =
                from contextBlog in context.Blogs
                orderby contextBlog.Id
                select contextBlog;

            foreach (Blog item in blogs) {
                Console.WriteLine(item);
            }
        }

    }

}
