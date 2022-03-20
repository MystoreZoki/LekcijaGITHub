using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcija14
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Lokomotiva l1 = new Lokomotiva(20, "siva", "putnicka lokomotiva");

            //  Lokomotiva l2 = new Lokomotiva(20, "crvena");

            //   Lokomotiva l3 = new Lokomotiva(30);


            /* Console.WriteLine("ovo je l1 lokomotiva "+l1);
             Console.WriteLine("ovo je l2 lokomotiva "+l2);
             Console.WriteLine("ovo je l3 lokomotiva" +l3);
            */


            Lokomotiva l1 = new Lokomotiva(20, "siva", "putnicka lokomotiva");

            Vagon v1 = new Vagon(10);
            Vagon v2 = new Vagon(); // default konstruktor 5t 
            Vagon v3 = new Vagon(20);
            Vagon v4=new Vagon(2);

            KompozicijaVoza kompozicijaBeogradBudapest = new KompozicijaVoza("Avala", l1);

            kompozicijaBeogradBudapest.NadjiVagonSaMininalnomTezinom();

            kompozicijaBeogradBudapest.dodajVagonNaKopmoziciju(v1);
            kompozicijaBeogradBudapest.dodajVagonNaKopmoziciju(v2);
            kompozicijaBeogradBudapest.dodajVagonNaKopmoziciju(v3);
            kompozicijaBeogradBudapest.dodajVagonNaKopmoziciju(v4);

            kompozicijaBeogradBudapest.KolikoImaVagona();

            kompozicijaBeogradBudapest.NadjiVagonSaMininalnomTezinom();
            kompozicijaBeogradBudapest.NadjiVagonSaMaksimalnomTezinom();

            kompozicijaBeogradBudapest.NadjiTezinuKompozicije();

            kompozicijaBeogradBudapest.sortirajKompoziciju();

            kompozicijaBeogradBudapest.KolikoImaVagona();
            


        }
    }
}
