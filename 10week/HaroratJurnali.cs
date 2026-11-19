namespace HaroratJurnali
{
    internal class Program
    {
        static void Main()
        {
            double[] haroratlar = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{i + 1}-kun haroratini kiriting:");
                haroratlar[i] = double.Parse(Console.ReadLine());
            }
            double engIssiq = haroratlar.Max();
            double engSovuq = haroratlar.Min();
            int issiqKun = Array.IndexOf(haroratlar, engIssiq) + 1;
            int sovuqKun = Array.IndexOf(haroratlar, engSovuq) + 1;

            Console.WriteLine($"\nEng issiq kun: {issiqKun}-kun ({engIssiq} gradus)");
            Console.WriteLine($"\nEng sovuq kun:{sovuqKun}-kun({engSovuq} gradus) ");
        }
    }
}
