using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtetel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy négyjegyű kódot: ");
            int kod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adjon meg egy szöveget: ");
            string szoveg = Console.ReadLine();

            Console.WriteLine($"A(z) {szoveg} szöveg titkosítva:{titkosito(kod,szoveg)}");

        }
        static string titkosito(int kod, string kodolando)
        {
            string abc = "aábceéfghijklmnoóöőpqrstuúüűvwxyzaábceéfghijklmnoóöőpqrstuúüűvwxyz";
            string titkositott = " ";
            string kodsz = kod.ToString();
            int index = 0;
            int szovegin = 0;
            int szam = 0;
            for (int i = 0; i < kodolando.Length; i++)
            {
                if (!abc.Contains(kodolando[i]))
                {
                    continue;
                }
                
                szam = int.Parse(kodsz[index].ToString());
                
                szovegin = abc.IndexOf(kodolando[i]);

                titkositott += abc[szovegin + szam];
                if (index == 3)
                {
                   index = -1;
                }
                index++;
            }
            

            return titkositott;
        }
    }
}
