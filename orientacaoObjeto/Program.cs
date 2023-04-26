using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orientacaoObjeto.ContentContext;

namespace orientacaoObjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo sobre CSHARP", "CSHARP"));
            articles.Add(new Article("Artigo sobre .NET", ".NET"));
            foreach (var item in articles)
            {
                System.Console.WriteLine(item.Id);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.Url);
                System.Console.WriteLine("\n\n");
            }
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSHARP = new Course("Fundamentos Csharp", "fundamentos-csharp");
            var courseASPNET = new Course("Fundamentos Asp.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCSHARP);
            courses.Add(courseASPNET);

            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseASPNET);
            var careers = new List<Career>();
            careerDotNet.Items.Add(careerItem);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                System.Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    System.Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
    }
}