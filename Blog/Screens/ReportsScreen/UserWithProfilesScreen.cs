using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportsScreen
{
    public class UserWithProfilesScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Relatório de usuários com perfils");
            System.Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();

        }
        private static void List()
        {
            try
            {
                var repository = new Repositories.UserRepository(Database.Connection);
                var users = repository.GetWithRoles();
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id} - {user.Name} ({user.Email})");
                    foreach (var profile in user.Roles)
                    {
                        Console.WriteLine($"\t{profile.Id} - {profile.Name} ({profile.Slug})");
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Não foi possível listar os usuários com perfils");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}