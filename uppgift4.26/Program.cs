using System;
namespace uppgift426
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal, talen måste vara heltal.");
            string tal =Console.ReadLine();

            for (int i =0; i < tal.Length; i++)
            {
                string tecken = tal[i].ToString();
                int siffra = int.Parse(tecken);
                int tal2 = siffra + 1;
                if (tal2 == 10)
                {
                    tal2 = 0;
                }
                Console.Write(tal2);
            }
            Console.ReadKey();
        }
    }
}