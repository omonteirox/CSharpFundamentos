using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.UserScreens
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Qual o id do usuário que deseja visualizar?");
            var id = int.Parse(Console.ReadLine()!);
            ListUser(id);
        }
        private static void ListUser(int id)
        {

            try
            {
                var repository = new Repositories.UserRepository(Database.Connection);
                var user = repository.Get(id);
                System.Console.WriteLine($"{user.Id} - {user.Name} - {user.Email}");
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine("Erro ao obter usuário");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}