using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreen
{
    public class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Perfis");
            Console.WriteLine("-------------");
            System.Console.WriteLine("Insira o id do perfil que deseja buscar");
            var id = int.Parse(Console.ReadLine());
            List(id);
            Console.ReadKey();
            MenuRoleScreen.Load();
            List(id);
        }

        private static void List(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                var role = repository.Get(id);
                Console.WriteLine($"{role.Id} - {role.Name} ({role.Slug})");

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Não foi possível lista o perfil");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}