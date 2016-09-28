using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarageconArray2011
{
    class Auto
    {
        private string _color;
        private double _precio;
        private DateTime _fecha;
        private EMarcas _marca;

        public Auto(EMarcas marca, string color)
        {
            this._marca = marca;
            this._color = color;
        }

        public Auto(EMarcas marca, string color, double precio):this(marca,color)
        {
            this._precio = precio;
        }

        public Auto(EMarcas marca, string color, double precio, DateTime fecha) : this(marca, color, precio)
        {
            this._fecha = fecha;
        }

        public Auto(EMarcas marca, string color, DateTime fecha):this(marca, color)
        {
            this._fecha = fecha;
        }



        public void AgregarImpuestos(double valor)
        {
            this._precio += valor; 
        }


        public static void MostrarAuto(Auto auto)
        {
            Console.WriteLine("" + auto._marca);
            Console.WriteLine("" + auto._color);
            Console.WriteLine("" + auto._precio);
            Console.WriteLine("" + auto._fecha);
        }

        public static bool operator ==(Auto autoUno,Auto autoDos)
        {
            return autoUno._marca == autoDos._marca;
        }

        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }

        public static double operator +(Auto autoUno, Auto autoDos)
        {
            return autoUno._precio + autoDos._precio;
        }

    }
}
