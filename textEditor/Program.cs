namespace TextEditor
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo Arquivo");
            //INT BIGINT SHORT, USHORT
            ushort option = ushort.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }
        static void Open()
        {
            Console.Clear();
            using (var file = new StreamReader(@"C:\Users\omonteirox\Documents\file.txt"))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("\n\n---------------------------------------\n\n");
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Save(text);
        }
        static void Save(string text)
        {
            Console.Clear();

            using (var file = new StreamWriter(@"C:\Users\omonteirox\Documents\file.txt"))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo salvo em Documents com o nome file.txt");
            Menu();
        }
    }
}