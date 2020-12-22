using System;

namespace ukol6_21._12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Vypis (50) hodnot ");
            /**
             * https://www.itnetwork.cz/csharp/zaklady/c-sharp-tutorial-cykly-for-while
             * vytvoreni promenne o velikosti 50 hodnot
             */
            int[] Polecisel = new int[50];

            /**
             * cyklus pocet opakovani 
             */
            Random rnd = new Random();


            for (int i = 0; i < Polecisel.Length; i++)
            {
                Polecisel[i] = rnd.Next(-999, 999);
            }


            for (int i = 0; i < Polecisel.Length; i++)
            {
                Console.WriteLine(Polecisel[i]);
            }
            Console.WriteLine("----------------------------------------------");
            vypis_cisla(Polecisel);
            float prumerna_hodnota_a = prumerna_hodnota(Polecisel);
             vypis_cisla_vetsi_nez_prumerna_hodnota(Polecisel, prumerna_hodnota_a);
            Console.ReadKey();

        }
        static void vypis_cisla(int[] Polecisel)

        {

            Console.WriteLine("2) VYPIS VETSIHO CISLA NEZ ZADA UZIVATEL");
            Console.Write("Zadej cislo: ");
            int uzivatelsky_vstup =int.Parse(Console.ReadLine());

            for (int i = 0; i < Polecisel.Length; i++)
            {

                if (Polecisel[i] > uzivatelsky_vstup)
                {
                    Console.WriteLine(Polecisel[i]);
                }
            }
            Console.WriteLine("-------------------------------------------");
            Console.ReadKey();
        }
        static float prumerna_hodnota(int[] Polecisel)
        {
            Console.WriteLine("3) prumerna hodnota");
            float soucet_cisel = 0;

            for (int i = 0; i < Polecisel.Length; i++)
            {
                soucet_cisel += Polecisel[i];

            }

            float prumerna_hodnota = soucet_cisel / Polecisel.Length;
            Console.WriteLine("prumer: {0}", prumerna_hodnota);
            Console.WriteLine("---------------------------------------------");
            Console.ReadKey();
            return prumerna_hodnota;

        }
        static void vypis_cisla_vetsi_nez_prumerna_hodnota(int[] Polecisel, float prumerna_hodnota)
        {
            int ;
            for (int i = 0; i < Polecisel.Length; i++);
            {
                if (Polecisel)
                {

                }
            }

        }

    }

}
    

