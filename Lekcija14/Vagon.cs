using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcija14
{
    public class Vagon
    {
        private int tezinaVagona;


        public Vagon()
        {
            this.tezinaVagona = 5;
        }

        public Vagon(int tezinaVagona)
        {
            this.tezinaVagona = tezinaVagona;
        }

        public int getTezinaVagona()
        {
            return this.tezinaVagona;
        }
        public void setTezinaVagona(int tezinaVagona)
        {
            this.tezinaVagona = tezinaVagona;
        }

        public override string ToString()
        {
            return "Vagon ima tezinu " + this.tezinaVagona;
        }
    }
}
