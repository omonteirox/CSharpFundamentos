
namespace Blog.Screens.UserScreens
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de usuários");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar usuários");
            System.Console.WriteLine("2 - Listar usuário específico");
            System.Console.WriteLine("3 - Cadastrar usuário");
            System.Console.WriteLine("4 - Atualizar usuário");
            System.Console.WriteLine("5 - Excluir usuário");
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUsersScreen.Load();
                    break;
                case 2:
                    ListUserScreen.Load();
                    break;
                case 3:
                    CreateUserScreen.Load();
                    break;
                case 4:
                    UpdateUserScreen.Load();
                    break;
                case 5:
                    DeleteUserScreen.Load();
                    break;
                default: Load(); break;
            }
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            Desafio.Load();
        }









    }
}