using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Estadística_deportiva
{
    public class Persona
    {
        private int _dni;
        private string _nombre;

        public Persona(string nombre)
        {
            _nombre = nombre;
        }
        public Persona(string nombre, int dni) : this(nombre)
        {
            _dni = dni;
        }
        public int Dni
        {
            get => _dni;
            set => _dni = value;
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:  {Nombre}");
            sb.AppendLine($"Dni:  {Dni}");

            return sb.ToString();
        }
    }
}
