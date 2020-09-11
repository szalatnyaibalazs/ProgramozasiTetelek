using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] szamok = new int[] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };

        private static void TombKiiras()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("{0}, ",szamok[i]);
            }
            Console.WriteLine();
        }
        private static void Összegzes()
        {
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                //osszeg = osszeg + szamok[i];
                osszeg += szamok[i];
            }
            Console.WriteLine("A számok összege:{0}", osszeg);
        }
        static void Main(string[] args)
        {
            TombKiiras();


            Összegzes();


            Megszamolas();

            Console.ReadKey();
        }

        private static void Megszamolas()
        {
            int s = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]%3==0)
                {
                    s++;
                }
            }
            Console.WriteLine("3-mal osztható számok száma:{0}",s);
        }
    }
}
