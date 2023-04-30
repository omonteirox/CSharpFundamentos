using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Screens.ReportsScreen
{
    public class PostsWithCategoriesScreen
    {
        public static void Load()
        {
            System.Console.WriteLine("Relatório de categorias com quantidade de posts");
            System.Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }
        private static void List()
        {
            try
            {
                var repository = new Repositories.PostRepository(Database.Connection);
                // var posts = repository.GetWithPostsCount();
                // foreach (var post in posts)
                // {
                //     Console.WriteLine($"{post.Name} ({post.})");
                // }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Não foi possível listar as categorias com a quantidade de posts");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}