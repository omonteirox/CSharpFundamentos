
using Blog.Models;

namespace Blog.Screens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Cadastro de usuário");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Nome do usuário:");
            var name = Console.ReadLine();
            System.Console.WriteLine("Email do usuário:");
            var email = Console.ReadLine();
            System.Console.WriteLine("Senha do usuário:");
            var password = Console.ReadLine();
            System.Console.WriteLine("Bio do usuário:");
            var bio = Console.ReadLine();
            System.Console.WriteLine("Imagem do usuário:");
            var image = Console.ReadLine();
            System.Console.WriteLine("Slug do usuário:");
            var slug = Console.ReadLine();
            var user = new Models.User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            };
            CreateUser(user);
        }
        static void CreateUser(User user)
        {
            try
            {
                var repository = new Repositories.UserRepository(Database.Connection);
                repository.Create(user);
                System.Console.WriteLine("Usuário cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Não foi possível salvar o usuário");
                System.Console.WriteLine(ex.Message);
            }


        }
    }
}