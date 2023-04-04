namespace TB_NET_2023_ALGO.exos
{
    internal class Convertisseur
    {
        static void Main()
        {
            Console.WriteLine("EXO-CONVERTISSEUR");
            Console.WriteLine("Quelles sont le nombre de secondes à convertir ?");
            int userSecond = int.Parse(Console.ReadLine());

            int days = userSecond / 86400;
            int hours = (userSecond % 86400) / 3600;
            int minutes = (userSecond % 86400 % 3600) / 60;
            int seconds = (userSecond % 86400 % 3600 % 60);

            Console.WriteLine($"{userSecond} correspond à {days} jour(s) {hours} heures {minutes} minutes {seconds} secondes.");
        }
    }
}
