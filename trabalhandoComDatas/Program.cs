using System.Globalization;

namespace trabalhandoComDatas
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;
            var dataFormatada = String.Format("{0:dd/MM/yyyy}", data);
            // formatação manual
            Console.WriteLine(dataFormatada);

            data.AddDays(1);
            // adiciona um dia
            data.AddMonths(1);
            // adiciona um mês
            data.AddYears(1);
            // adiciona um ano

            var br = new CultureInfo("pt-BR");
            // seta a cultura do brasil por exemplo
            var atual = CultureInfo.CurrentCulture;
            // pega a cultura atual do sistema
            System.Console.WriteLine(string.Format(br, "{0:dd/MM/yyyy}", data));
            System.Console.WriteLine(DateTime.Now.ToString("D", br));


            var utc = DateTime.UtcNow;
            // pega a data no horário puro, sem interferências de UTC é o horário global
            System.Console.WriteLine(utc.ToLocalTime());
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // pegamos o timezone da australia
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utc, timezoneAustralia);
            // convertemos a hora global para a hora da australia



            var timeSpan = new TimeSpan();
            // UNIDADE DE MEDIDA




        }
    }
}