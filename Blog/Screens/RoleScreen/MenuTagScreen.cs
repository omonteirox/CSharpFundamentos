using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.RoleScreen
{
    public class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de perfils");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar perfils");
            Console.WriteLine("2 - Listar perfil específico");
            Console.WriteLine("3 - Cadastrar novo perfil");
            Console.WriteLine("4 - Atualizar perfil");
            Console.WriteLine("5 - Excluir perfil");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRolesScreen.Load();
                    break;
                case 2:
                    ListRoleScreen.Load();
                    break;
                case 3:
                    CreateRoleScreen.Load();
                    break;
                case 4:
                    UpdateRoleScreen.Load();
                    break;
                case 5:
                    DeleteRoleScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}