using System;

namespace ukol6_21._12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vypis (50) hodnot ");
            /**
             * https://www.itnetwork.cz/csharp/zaklady/c-sharp-tutorial-cykly-for-while
             * vytvoreni promenne o velikosti 50 hodnot
             */
            int[] Polecisel = new int[50];

            /**
             * cyklus pocet opakovani 
             */
            Random rnd = new Random();


            for (int i = 0; i < 50; i++)
            {
                Polecisel[i] = rnd.Next(-999, 999);
            }


            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Polecisel[i]);
            }
            Console.WriteLine("----------------------------------------------");
            vypis_cisla(Polecisel);          
            Console.ReadKey();

        }
        static void vypis_cisla(int[] Polecisel)
        {
            Console.Write("Zadej cislo: ");
            int uzivatelsky_vstup =int.Parse(Console.ReadLine());

            for (int i = 0; i < 50; i++)
            {

                if (Polecisel[i] > uzivatelsky_vstup)
                {
                    Console.WriteLine(Polecisel[i]);
                }
            }


            Console.ReadKey();
        }

    }

}
    

