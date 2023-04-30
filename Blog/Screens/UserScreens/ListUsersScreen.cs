using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.UserScreens
{
    public class ListUsersScreen
    {
        public static void Load()
        {

            Console.Clear();
            System.Console.WriteLine("Lista de usuários");
            System.Console.WriteLine(value: "------------------");
            ListUsers();
        }
        static void ListUsers()
        {
            try
            {
                var repository = new Repositories.UserRepository(Database.Connection);
                var users = repository.GetAll();
                foreach (var item in users)
                {
                    System.Console.WriteLine($"{item.Id} - {item.Name} - {item.Email}");
                }
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine("Erro ao obter usuários");
                System.Console.WriteLine(e.Message);
            }


        }

    }
}