using lab7ex1;
using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Un autoturism detine un motor precum si un numar de usi. De asemenea autovehiculul este caracterizat de marca, model si an de fabricatie.
               • Motorul este caracterizat de:
                   Capacitate cilindrica;
                   Putere;
                   Tipul combustibilul.

            • Autoturismul va avea urmatoarele metode/proprietati:
                   -GetDescription;
                    Va returna descrierea completa a autovehicolului sub forma unui sir de caractere;
                        -Marca, model, anDeFabricatie, capacitate cilindrica, combustibil,putere motor, numar de usi'

                  In metoda Main, creati autoturisme si afisati-le descrierea.
                  Creati diagrama UML si salvati-o in git, alaturi de proiect. */



                        Autoturism auto=new Autoturism();

                         Motor motor = new Motor();

                         Usi numarUsi = new Usi();

            Console.WriteLine($"Autoturismul este marca {auto.Marca}, model {auto.Model}, anul de fabricatie {auto.AnDeFabricatie}, capacitate cilindrica {motor.CapacitateCilindrica},tip combustibil {motor.TipCombustibil}," +
                $"cu puterea de {motor.Putere}CP si {numarUsi.NumarUsi} usi.");
                         

                       
                     
                     
            




        }

    }
}
