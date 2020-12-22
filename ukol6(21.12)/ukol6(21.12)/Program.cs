using System;

namespace ukol6_21._12_
{
    class Program
    {
        static void Main(string[] args)
        {
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
               
            Console.ReadKey();
        }
    }

}
    

