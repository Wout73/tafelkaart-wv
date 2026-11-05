namespace tafeltje_wout_vullings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Van welk getal wil je het tafeltje maken?");
            int tafel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tot en met welk getal wil je vermenigvuldigen?");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= max; i++)
            {
                int uitkomst = i * tafel;
                Console.WriteLine(i + " x " + tafel + " = " + uitkomst);
            }
        }
    }
}