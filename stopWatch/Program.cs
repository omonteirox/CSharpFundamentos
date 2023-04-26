namespace stopWatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int time)
        {
            int currentTime = 0;
            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine("Tempo atual -> " + currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Menu();
            Thread.Sleep(1500);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("\nPreparar...");
            Thread.Sleep(1000);
            Console.WriteLine("\nApontar...");
            Thread.Sleep(1000);
            Console.WriteLine("\nVai!!!");
            Thread.Sleep(2500);
            Start(time);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n S = Segundos \n M = MINUTO \n 0 = SAIR");
            Console.WriteLine("\n Quanto tempo deseja contar?\n\n");
            string data = Console.ReadLine().ToLower();
            char typeTime = Char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            if (typeTime == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
        }
    }
}