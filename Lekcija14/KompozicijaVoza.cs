using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcija14
{
    public class KompozicijaVoza
    {
        private Lokomotiva lokomotivaVoza;
        private List<Vagon> vagoni;
        private string nazivKompozicije;

        public KompozicijaVoza(string nazivKompozicije, Lokomotiva lokomotivaVoza)
        {
            this.nazivKompozicije = nazivKompozicije;
            this.lokomotivaVoza = lokomotivaVoza;
            vagoni = new List<Vagon>(); //pravimo praznu listu vagona, na koju cemo posle da dodajemo vagona naknadno
        }

        public string getNazivKompozicije()
        {
            return this.nazivKompozicije;
        }

        public Lokomotiva getLokomotiva()
        {
            return this.lokomotivaVoza;
        }

        public void setLokomotiva(Lokomotiva lokomotivaVoza)
        {
            this.lokomotivaVoza = lokomotivaVoza;
        }

        public void dodajVagonNaKopmoziciju(Vagon vagon)
        {
            vagoni.Add(vagon);
            Console.WriteLine(vagon+" je dodat na kompoziciju");
        }

        public void KolikoImaVagona()
        {
            Console.WriteLine("Trenutno vagona ima " + vagoni.Count);

            Console.WriteLine("Vagoni su:");
            for(int i=0; i < vagoni.Count; i++)
            {
                Console.WriteLine(vagoni.ElementAt(i));
            }
        }

        public void NadjiVagonSaMininalnomTezinom()
        {
            if (vagoni.Count == 0)
            {
                Console.WriteLine("Broj vagona je 0, ne mogu naci minimum");

            }
            else
            {
                Vagon minTezina = vagoni[0]; //uzimamo 0 vagon i proglasavamo ga za minimum

                for(int i=0; i < vagoni.Count; i++)
                {
                    if (vagoni.ElementAt(i).getTezinaVagona() < minTezina.getTezinaVagona())
                    {
                        minTezina=vagoni[i];
                    }

                }
                Console.WriteLine("Vagon koji ima najmanju tezinu tezi " + minTezina.getTezinaVagona());

            }         

        }

        public void NadjiVagonSaMaksimalnomTezinom()
        {
            if (vagoni.Count == 0)
            {
                Console.WriteLine("Broj vagona je 0, ne mogu naci maximum");

            }
            else
            {
                Vagon maxTezina = vagoni[0]; //uzimamo 0 vagon i proglasavamo ga za maximum

                for (int i = 0; i < vagoni.Count; i++)
                {
                    if (vagoni.ElementAt(i).getTezinaVagona() > maxTezina.getTezinaVagona())
                    {
                        maxTezina = vagoni[i];
                    }

                }
                Console.WriteLine("Vagon koji ima najvecu tezinu tezi " + maxTezina.getTezinaVagona());
            }
        }

        public void NadjiTezinuKompozicije()
        {
            int suma = 0;

            for(int i=0; i < vagoni.Count; i++)
            {
                //suma=suma+
                suma+= vagoni.ElementAt(i).getTezinaVagona();
            }
            suma += lokomotivaVoza.getTezinaLokomotive();

            Console.WriteLine("Nasa kompozicija je teska " + suma + " tona");
        }

        public void sortirajKompoziciju()
        {

            for(int i=0; i < vagoni.Count-1; i++)
            {
                for(int j=i+1; j < vagoni.Count; j++)
                {
                    if (vagoni.ElementAt(j).getTezinaVagona() > vagoni.ElementAt(i).getTezinaVagona())
                    {
                        //Zamena elemenata u listi
                        Vagon temp=vagoni.ElementAt(i);
                        vagoni[i] = vagoni[j];
                        vagoni[j] = temp;
                    }

                }
            }
        }


    }
}
