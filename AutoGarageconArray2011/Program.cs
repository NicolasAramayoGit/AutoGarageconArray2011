using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarageconArray2011
{
    class Program
    {
        static void Main(string[] args)
        {


            // Creo dos objetos Autos.

            Auto autoUno = new Auto(EMarcas.Ford, "Rojo");
            Auto autoDos = new Auto(EMarcas.Ford, "Azul");


            // Creo dos objetos Autos.

            Auto autoTres = new Auto(EMarcas.Ferrari, "Rojo", 250000);
            Auto autoCuatro = new Auto(EMarcas.Ferrari, "Rojo", 750000);


            // Agrego impuesto a tres autos.
            autoDos.AgregarImpuestos(1000);
            autoTres.AgregarImpuestos(1000);
            autoCuatro.AgregarImpuestos(1000);

            // Agrego la línea pedida en la guía.
            double importeDouble = autoUno + autoDos;

            // Muestro el resultado del importe.
            Console.WriteLine("importe: " + importeDouble);


            if (autoUno == autoCuatro)
            {
                Console.WriteLine("Son iguales.");
            }
            else
            {
                Console.WriteLine("No son iguales.");
            }

            Garage miGarage = new Garage("razon social", 250);

            miGarage += autoTres;


        }
    }
}
