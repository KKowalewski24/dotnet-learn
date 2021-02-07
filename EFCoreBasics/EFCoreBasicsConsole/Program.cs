using System;
using System.Linq;
using EFCoreBasicsConsole.EF;
using EFCoreBasicsConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasicsConsole {

    public class Program {

        /*------------------------ FIELDS REGION ------------------------*/
        private static readonly DbContextOptions<ApplicationContext> DbContextOptionsBuilder =
            new DbContextOptionsBuilder<ApplicationContext>()
                .UseNpgsql("Host=localhost;Database=EFCoreBasics;Username=postgres;Password=admin")
                .Options;

        /*------------------------ METHODS REGION ------------------------*/
        public static void Main(string[] args) {
            Console.WriteLine("Begin");

            Blog blog = new Blog("abc1", 15);
            Post post1 = new Post("cde1", "def1", blog);
            Post post2 = new Post("ccc1", "ddd1", blog);

            using (ApplicationContext context = new ApplicationContext(DbContextOptionsBuilder)) {
                PrepareDatabase(context);
                AddData(context, blog, post1, post2);
                DeleteData(context, post1, post2, blog);
            }

            Console.WriteLine("End");
        }

        private static void PrepareDatabase(DbContext context) {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        private static void AddData(ApplicationContext context, Blog blog, Post post1, Post post2) {
            context.Blogs.Add(blog);
            blog.Posts.Add(post1);
            blog.Posts.Add(post2);
            context.Posts.Add(post1);
            context.Posts.Add(post2);
            context.SaveChanges();
            PrintBlogs(context);
        }

        private static void DeleteData(ApplicationContext context,
                                       Post post1, Post post2, Blog blog) {
            context.Remove(post1);
            context.Remove(post2);
            context.Remove(blog);
            context.SaveChanges();
            PrintBlogs(context);
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
