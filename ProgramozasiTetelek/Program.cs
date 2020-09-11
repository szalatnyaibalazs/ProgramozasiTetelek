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
        }
        static void Main(string[] args)
        {
            TombKiiras();

            Console.ReadKey();
        }

        
    }
}
