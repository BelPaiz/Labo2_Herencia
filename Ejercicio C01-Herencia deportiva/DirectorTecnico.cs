using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Estadística_deportiva
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DIRECTOR TECNICO");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha de nacimiento:  {fechaNacimiento}");
            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1 is not null && d2 is not null)
            {
                if (d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
