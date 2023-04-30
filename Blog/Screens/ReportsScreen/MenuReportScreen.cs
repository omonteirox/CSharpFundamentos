using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.ReportsScreen
{
    public class MenuReportScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Relatórios");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine("1 - Relatório de usuários com perfils");
            System.Console.WriteLine("2 - Relatório de categorias com quantidade de posts");
            System.Console.WriteLine("3 - Relatório de tags com quantidade de posts");
            System.Console.WriteLine("4 - Relatório de posts com categoria");
            System.Console.WriteLine("5 - Relatório de todos os posts posts com suas categorias");
            System.Console.WriteLine("6 - Relatório de posts com tags");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);
            switch (option)
            {
                case 1:
                    UserWithProfilesScreen.Load();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default: Load(); break;
            }
        }
    }
}