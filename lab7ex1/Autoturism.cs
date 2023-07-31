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
        private readonly string model;
        private readonly int anDeFabricatie;
        private Usi[] usi;
        private Motor motor;



        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                
                marca = value;
            }
        }

       



        public string Model
        {
            get
            {
                return model;
            }
        }

        public int AnDeFabricatie
        {
            get
            {
                return anDeFabricatie;
            }
         
        }





        //public string GetDescriptionAuto()
        //{

        //    return $"Autoturismul este  marca{marca}, este fabricat in {anDeFabricatie}, are capac.cilindrica de {CapacitateCilin}, functioneaza pe {motor.GetTipCombustibil}, are puterea motorului de {motor.GetPutere}CP, si are {usi} usi.";
        //}

    }
}
