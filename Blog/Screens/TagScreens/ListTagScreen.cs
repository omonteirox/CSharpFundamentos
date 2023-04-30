using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                var tags = repository.GetAll();
                foreach (var item in tags)
                    Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Não foi possível listar as tags");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}