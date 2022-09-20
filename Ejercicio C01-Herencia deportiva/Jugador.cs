using System.Text;

namespace Ejercicio_C01_Estadística_deportiva
{
    public class Jugador : Persona
    {
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

       public Jugador(string nombre, int dni) : base(nombre, dni)
        {
            
        }

        public Jugador(string nombre, int dni, int totalGoles, int totalPartidos) : this(nombre, dni)
        {
            _totalGoles = totalGoles;
            _partidosJugados = totalPartidos;
        }

        public int PartidosJugados
        {
            get { return _partidosJugados; }
            set { _partidosJugados = value; }
        }
        public int TotalGoles
        {
            get { return _totalGoles; }
            set { _totalGoles = value; }
        }
        public float PromedioGoles
        {
            get {
                if (_partidosJugados > 0)
                {
                    _promedioGoles = (float)_totalGoles / _partidosJugados;
                    return _promedioGoles;
                }
                return 0;
            }
        }
 
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos Jugados:  {PartidosJugados}");
            sb.AppendLine($"Total de goles:  {TotalGoles}");
            sb.AppendLine($"Promedio de goles:  {PromedioGoles}");
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1 is not null && j2 is not null)
            {
                return j1.Dni == j2.Dni;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}