using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Program
{
    public class Camioneta : Vehiculo
    {
        private int _carga;

        public int Carga
        {
            get => _carga;
            set => _carga = ValidateCarga(value);
        }

        public override decimal GetInformation()
        {
            throw new NotImplementedException();
        }

        public override string runAction()
        {
            return "Cargar camioneta";
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Carga........:{Carga,18}Kg\n" +
                   $"Accion.......:{runAction(),20}\n";
        }

        private int ValidateCarga(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Capacidad de carga no válida. El camión no puede tener menos de 0 Kg.");
            }
            else if (value > 100)
            {
                throw new ArgumentException("Capacidad de carga no válida. El camión no puede tener más de 100 Kg.");
            }
            else
            {
                return value;
            }
        }
    }
}