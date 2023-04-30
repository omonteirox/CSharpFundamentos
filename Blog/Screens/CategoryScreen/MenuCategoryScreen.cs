using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.CategoryScreen
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Listar categoria");
            Console.WriteLine("3 - Cadastrar categorias");
            Console.WriteLine("4 - Atualizar categoria");
            Console.WriteLine("5 - Excluir categoria");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoriesScreen.Load();
                    break;
                case 2:
                    ListCategorysScreen.Load();
                    break;
                case 3:
                    CreateCategoryScreen.Load();
                    break;
                case 4:
                    UpdateCategoryScreen.Load();
                    break;
                case 5:
                    DeleteCategoryScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}