using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Screens.TagPostScreen
{
    public class MenuPostTagScreen
    {
        public static void Load()
        {
            System.Console.WriteLine("Vincular post/tag");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Informe o Id do post");
            var postId = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Informe o Id da tag");
            var tagId = int.Parse(Console.ReadLine()!);
            Vinculate(postId, tagId);
        }
        private static void Vinculate(int idPost, int idTag)
        {
            try
            {
                var repository = new Repositories.PostRepository(Database.Connection);
                repository.AddTag(idPost, idTag);
                System.Console.WriteLine("Post vinculado com sucesso");
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Não foi possível vincular");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}