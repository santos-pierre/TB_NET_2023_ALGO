namespace TB_NET_2023_ALGO.demos
{
    internal class Demo5
    {
        static void Main(string[] args)
        {
            int note1 = 15;
            int note2 = 12;
            int note3 = 18;

            double moyenne = (note1 + note2 + note3) / 3.0;

            Console.WriteLine($"Note 1 : {note1}\nNote 2 : {note2}\nNote 3 : {note3}");
            Console.WriteLine($"Moyenne : {moyenne}");

            if (moyenne >= 16)
            {
                Console.WriteLine("Très bien !");
            }
            else if (moyenne >= 14)
            {
                Console.WriteLine("Bien");
            }
            else if (moyenne >= 12)
            {
                Console.WriteLine("Assez bien");
            }
            else
            {
                Console.WriteLine("En dessous de la moyenne");
            }
        }
    }
}
