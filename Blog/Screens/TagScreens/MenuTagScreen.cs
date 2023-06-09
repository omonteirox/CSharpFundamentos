using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreens
{
    public class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Listar tag específica");
            Console.WriteLine("3 - Cadastrar tags");
            Console.WriteLine("4 - Atualizar tag");
            Console.WriteLine("5 - Excluir tag");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListTagsScreen.Load();
                    break;
                case 2:
                    ListTagScreen.Load();
                    break;
                case 3:
                    CreateCategoryScreen.Load();
                    break;
                case 4:
                    UpdateTagScreen.Load();
                    break;
                case 5:
                    DeleteTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}