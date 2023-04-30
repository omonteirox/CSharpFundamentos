using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class ListCategoriesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List()
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                var categories = repository.GetAll();
                foreach (var item in categories)
                    Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine("Não foi possível listar as categorias");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}