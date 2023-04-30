using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.UserScreens
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Atualizar usuário");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Qual o id do usuário que deseja atualizar?");
            var id = int.Parse(Console.ReadLine()!);

        }
        static void UpdateUser(int id)
        {

            var repository = new Repositories.UserRepository(Database.Connection);
            var user = repository.Get(id);
            System.Console.WriteLine("Nome do usuário:");
            user.Name = Console.ReadLine();
            System.Console.WriteLine("Email do usuário:");
            user.Email = Console.ReadLine();
            System.Console.WriteLine("Senha do usuário:");
            user.PasswordHash = Console.ReadLine();
            System.Console.WriteLine("Bio do usuário:");
            user.Bio = Console.ReadLine();
            System.Console.WriteLine("Imagem do usuário:");
            user.Image = Console.ReadLine();
            System.Console.WriteLine("Slug do usuário:");
            user.Slug = Console.ReadLine();
            try
            {
                var update = repository.Update(user);
                System.Console.WriteLine("Usuário atualizado com sucesso");

            }
            catch (System.Exception e)
            {

                System.Console.WriteLine("Erro ao atualizar usuário");
                System.Console.WriteLine(e.Message);

            }

        }
    }
}