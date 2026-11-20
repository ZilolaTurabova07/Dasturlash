namespace JuftSonlar
{
    internal class Program
    {
        static void Main()
        {
            int[] sonlar = { 12, 7, 24, 33, 40, 15, 8, 19 };

            Console.Write("Massivdagi juft sonlar: ");
            foreach (int son in sonlar)
            {
                if (son % 2 == 0)
                {
                    Console.Write(son + " ");
                }
            }
            Console.ReadLine();
        }
    }
}  
