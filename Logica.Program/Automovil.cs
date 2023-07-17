using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Program
{
    public class Automovil : Vehiculo
    {
        private int _puertas;

        public int Puertas
        {
            get => _puertas;
            set => _puertas = ValidatePuertas(value);
        }

        public override decimal GetInformation()
        {
            throw new NotImplementedException();
        }

        public override string runAction()
        {
            return "Conducir automóvil";
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Puertas......:{Puertas,20}\n" +
                   $"Accion.......:{runAction(),20}\n";
        }

        private int ValidatePuertas(int value)
        {
            if (value == 4)
            {
                return value;

            }
            throw new ArgumentException("Puertas no validas");
        }


    }
}