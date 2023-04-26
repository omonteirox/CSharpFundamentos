using System.Globalization;

namespace trabalhandoComMoedas
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            decimal valor = 10.25m;

            //formatando moedas
            var cultura = CultureInfo.CreateSpecificCulture("pt-br");
            var valorFormatado = valor.ToString("C", cultura);
            System.Console.WriteLine(valorFormatado);


        }
    }
}