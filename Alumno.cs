using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Alumno
    {
        public string Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public double Nota { get; set; }
        public string Calificacion { get; private set; }

        public Alumno(string dni, string apellidos, string nombre, double nota)
        {
            Dni = dni;
            Apellidos = apellidos;
            Nombre = nombre;
            Nota = nota;
            Calificacion = CalcularCalificacion(nota);
        }

        public string CalcularCalificacion(double nota)
        {
            if (nota < 5) return "SS"; // Suspenso
            if (nota >= 5 && nota < 7) return "AP"; // Aprobado
            if (nota >= 7 && nota < 9) return "NT"; // Notable
            return "SB"; // Sobresaliente
        }

        public void ModificarCalificacion(string calificacion)
        {
            Calificacion = calificacion;
        }
    }
}
