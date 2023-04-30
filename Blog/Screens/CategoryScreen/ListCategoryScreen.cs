
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public class ListCategorysScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de categoria");
            Console.WriteLine("-------------");
            System.Console.WriteLine("Qual o id categoria que você deseja listar?");
            var id = int.Parse(Console.ReadLine());
            List(id);
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void List(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                var category = repository.Get(id);
                Console.WriteLine($"{category.Id} - {category.Name} ({category.Slug})");
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine("Não foi possível listar as categorias");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}