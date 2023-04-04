namespace TB_NET_2023_ALGO.exos
{
    internal class DifferenceDuree
    {
        static void Main()
        {
            Console.WriteLine("EXO - DIFFERENCE DUREE");
            int duration1, duration2, differenceDuration;
            //Durée 1
            Console.WriteLine("Durée 1:");
            Console.WriteLine("Jour 1:");
            int day1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Heure 1:");
            int hour1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute 1:");
            int minute1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Secondes 1:");
            int seconde1 = int.Parse(Console.ReadLine());
            duration1 = (day1 * 86400) + (hour1 * 3600) + (minute1 * 60) + seconde1;
            //Durée 2
            Console.WriteLine("Durée 2:");
            Console.WriteLine("Jour 2:");
            int day2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Heure 2:");
            int hour2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute 2:");
            int minute2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Secondes 2:");
            int seconde2 = int.Parse(Console.ReadLine());
            duration2 = (day2 * 86400) + (hour2 * 3600) + (minute2 * 60) + seconde2;

            if (duration1 > duration2)
            {
                differenceDuration = duration1 - duration2;
            }else
            {
                differenceDuration = duration2 - duration1;
            }
            int days = differenceDuration / 86400;
            int hours = (differenceDuration % 86400) / 3600;
            int minutes = (differenceDuration % 86400 % 3600) / 60;
            int seconds = (differenceDuration % 86400 % 3600 % 60);

            Console.WriteLine($"{differenceDuration} correspond à {days} jour(s) {hours} heures {minutes} minutes {seconds} secondes.");
        }
    }
}
