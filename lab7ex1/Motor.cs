using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7ex1
{
    internal class Motor
    {
        private int capacitateCilindrica;
        private int putere;
        private int tipCombustibil;




        public int CapacitateCilindrica
        {
            get
            {
                return capacitateCilindrica;
            }
            set
            {
                capacitateCilindrica = value;
            }
        }


        public int Putere
        {
            get
            {
                return putere;
            }
        }


        public int TipCombustibil
        {
            get
            {
                return tipCombustibil;
            }
        }

         public int SetCapacCilin(int capacitateCilindrica)
        {
            // this.CapacitateCilindrica= 1200;
            return capacitateCilindrica;
        }

    }
}
