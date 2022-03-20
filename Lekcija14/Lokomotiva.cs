using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcija14
{
    public class Lokomotiva
    {
        private int tezinaLokomotive;
        private string bojaLokomotive;
        private string tipLokomotive;


        public Lokomotiva(int tezinaLokomotive, string bojaLokomotive, string tipLokomotive)
        {
            this.tezinaLokomotive = tezinaLokomotive;
            this.bojaLokomotive = bojaLokomotive;
            this.tipLokomotive = tipLokomotive;
        }

        public Lokomotiva(int tezinaLokomotive, string bojaLokomotive)
        {
            this.tezinaLokomotive = tezinaLokomotive;
            this.bojaLokomotive = bojaLokomotive;
            this.tipLokomotive = "tip je nepoznat";
        }

        public Lokomotiva(int tezinaLokomotive)
        {
            this.tezinaLokomotive = tezinaLokomotive;
            this.bojaLokomotive = "boja je nepoznata";
            this.tipLokomotive = "tip lokomotive je nepoznat";
        }

        public int getTezinaLokomotive()
        {
            return this.tezinaLokomotive;
        }
        public void setTezinaLokomotive(int tezinaLokomotive)
        {
            this.tezinaLokomotive = tezinaLokomotive;
        }

        public string getBojaLokomotive()
        {
            return this.bojaLokomotive;
        }
        
        public void setBojaLokomotive(string bojaLokomotive)
        {
            this.bojaLokomotive=bojaLokomotive;
        }

        public string getTipLokomotive() {

            return this.tipLokomotive;
        }

        public void setTipLokomotive(string tipLokomotive)
        {
            this.tipLokomotive = tipLokomotive;
        }

        public override string ToString()
        {
            return "Lokomotiva ima tezinu " + this.tezinaLokomotive + " tip lokomotive je " + this.tipLokomotive + " i boje je " + this.bojaLokomotive;
        }
    }
}
