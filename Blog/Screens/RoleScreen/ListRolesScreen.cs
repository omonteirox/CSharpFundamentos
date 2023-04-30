using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreen
{
    public class ListRolesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de perfils");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                var roles = repository.GetAll();
                foreach (var role in roles)
                    Console.WriteLine($"{role.Id} - {role.Name} ({role.Slug})");

            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Não foi possível listar os perfils");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}