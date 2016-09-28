using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarageconArray2011
{
    class Garage
    {

        private string _razonSocial;
        private double _precioPorHora;
        private Auto[] _autos;

        public Garage(string razonSocial, double precioPorHora):this()
        {
            this._precioPorHora = precioPorHora;
            this._razonSocial = razonSocial;
        }

       private Garage()
        {
            this._autos = new Auto[5];
        }


        public void MostrarGarage()
        {
            Console.WriteLine("Precio por Hora: " + this._precioPorHora);
            Console.WriteLine("Razon Social: " + this._razonSocial);
        }


        #region Sobrecargas de Operadores.

        public static bool operator ==(Garage unGarage, Auto unAuto)
        {
            for (int i = 0; i < unGarage._autos.GetLength(0); i++)
            {
                if (unAuto == unGarage._autos[i])
                {
                    // Si encontro el auto en el array de autos, devuelvo True.
                    return true;
                }
            }

            // Si no encontro, devuelvo False.
            return false;
        }

        public static bool operator !=(Garage unGarage, Auto unAuto)
        {
            return !(unGarage == unAuto);
        }


        public static Garage operator +(Garage unGarage, Auto unAuto)
        {
            if (unGarage != unAuto)
            {
                for (int i = 0; i < unGarage._autos.GetLength(0); i++)
                {
                    if (unGarage._autos[i].Equals(null))
                    {
                        // Agrego en la posicion donde esta vacia.
                        unGarage._autos[i] = unAuto;
                        return unGarage;
                    }
                }
            }
            else
            {
                Console.WriteLine("El auto ya se encuentra!");
            }

            return unGarage;
        }

        #endregion
    }
}
