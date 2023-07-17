using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logica.Program
{
    public abstract class Vehiculo
    {
        public string? _marca;
        public string? _modelo;
        public int _anio;

        public string? Marca
        {
            get => _marca;
            set => _marca = ValidateMarca(value);
        }

        public string? Modelo
        {
            get => _modelo;
            set => _modelo = ValidateModelo(value);
        }

        public int Anio
        {
            get => _anio;
            set => _anio = ValidateAnio(value);
        }

        public override string ToString()
        {
            return $"Marca........:{Marca,20}\n" +
                    $"Modelo.......:{Modelo,20}\n" +
                    $"Año..........:{_anio,20}\n";
        }
        private string? ValidateMarca(string? value)
        {
            if (value == "Chevrolet")

            {
                return value;

            }
            throw new ArgumentException("Marca no valida. La marca permitidas es Chevrolet");
        }


        private string? ValidateModelo(string? value)
        {
            if (value == "Sail" || value == "Sedan" || value == "Aveo")

            {
                return value;

            }
            throw new ArgumentException("Modelo no valido. Los modelos permitidos son Sail, Sedan y Aveo.");
        }

        private int ValidateAnio(int value)
        {
            if (value < 2015)
            {
                throw new ArgumentException("Año de vehiculo descontinuado");
            }
            else if (value > 2023)
            {
                throw new ArgumentException("Lo sentimos, solo disponemos hasta el año actual");
            }
            else
            {
                return value;
            }
        }

        public abstract decimal GetInformation();
        public abstract string runAction();
    }
}