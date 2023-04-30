using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.UserScreens
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Excluir usuário");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Qual o id do usuário que deseja excluir?");
            var id = int.Parse(Console.ReadLine()!);
            DeleteUser(id);
        }
        static void DeleteUser(int id)
        {

            try
            {
                var repository = new Repositories.UserRepository(Database.Connection);
                repository.Delete(id);
                System.Console.WriteLine("Usuário deletado com sucesso");
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine("Não foi possível deletar o usuário");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}