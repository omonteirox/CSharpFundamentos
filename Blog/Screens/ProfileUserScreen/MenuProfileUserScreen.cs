using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.ProfileUserScreen
{
    public class MenuProfileUserScreen
    {
        public static void Load()
        {
            System.Console.WriteLine("Vincular Perfil/Usuário");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Informe o Id do Perfil");
            var profileId = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Informe o Id do Usuário");
            var userId = int.Parse(Console.ReadLine()!);
            Vinculate(profileId, userId);
            Console.ReadKey();
            Desafio.Load();
        }
        private static void Vinculate(int idProfile, int idUser)
        {
            try
            {
                var repository = new Repositories.UserRepository(Database.Connection);
                repository.addRole(idUser, idProfile);
                System.Console.WriteLine("Perfil vinculado com sucesso");
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Não foi possível vincular");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}