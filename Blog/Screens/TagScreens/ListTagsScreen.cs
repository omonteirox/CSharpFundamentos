using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class ListTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            System.Console.WriteLine("Qual o id da tag que deseja listar?");
            var id = int.Parse(Console.ReadLine());
            List(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                var tag = repository.Get(id);
                Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Não foi possível listar a tag");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}