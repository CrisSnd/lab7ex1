using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7ex1
{
    internal class Autoturism
    {

        private string marca;
        private string model;
        private int anDeFabricatie;
        private Usi[] usi;
        private Motor motor;



        public string Marca
        {
           get
            {
                return marca="Dacia";
            }
          
        }

        public string Model
        {
            get
            {
              return model="Logan";
            }
        }

        public int AnDeFabricatie
        {
            get
            {
                return anDeFabricatie=2020;
            }
         
        }





        //public string GetDescriptionAuto()
        //{

        //    return $"Autoturismul este  marca{marca}, este fabricat in {anDeFabricatie}, are capac.cilindrica de {CapacitateCilin}, functioneaza pe {motor.GetTipCombustibil}, are puterea motorului de {motor.GetPutere}CP, si are {usi} usi.";
        //}

    }
}
