using System;
using System.Collections.Generic;
using System.Linq;

namespace Examen
{
    public class GestorAlumnos
    {
        private List<Alumno> alumnos;

        public GestorAlumnos()
        {
            alumnos = new List<Alumno>();
        }

        // Agregar un nuevo alumno
        public void AgregarAlumno(Alumno alumno)
        {
            if (alumnos.Any(a => a.Dni == alumno.Dni)) // Validamos si el DNI ya existe
            {
                throw new InvalidOperationException("El alumno con ese DNI ya existe.");
            }

            alumnos.Add(alumno);
        }

        // Eliminar un alumno por su DNI
        public bool EliminarAlumno(string dni)
        {
            var alumno = alumnos.FirstOrDefault(a => a.Dni == dni);
            if (alumno != null)
            {
                alumnos.Remove(alumno);
                return true;
            }
            return false;
        }

        // Consultar un alumno por su DNI
        public Alumno ConsultarAlumno(string dni)
        {
            return alumnos.FirstOrDefault(a => a.Dni == dni);
        }

        // Modificar la nota de un alumno por su DNI
        public bool ModificarNota(string dni, double nuevaNota)
        {
            var alumno = alumnos.FirstOrDefault(a => a.Dni == dni);
            if (alumno != null)
            {
                alumno.Nota = nuevaNota;
                alumno.ModificarCalificacion(alumno.CalcularCalificacion(nuevaNota));
                return true;
            }
            return false;
        }

        // Modificar la calificación de un alumno (manual)
        public bool ModificarCalificacion(string dni, string nuevaCalificacion)
        {
            var alumno = alumnos.FirstOrDefault(a => a.Dni == dni);
            if (alumno != null)
            {
                alumno.ModificarCalificacion(nuevaCalificacion);
                return true;
            }
            return false;
        }

        // Mostrar los alumnos suspensos (nota < 5)
        public List<Alumno> MostrarSuspensos()
        {
            return alumnos.Where(a => a.Nota < 5).ToList();
        }

        // Mostrar los alumnos aprobados (nota >= 5)
        public List<Alumno> MostrarAprobados()
        {
            return alumnos.Where(a => a.Nota >= 5).ToList();
        }

        // Mostrar los alumnos con Matrícula de Honor (nota = 10)
        public List<Alumno> MostrarCandidatosMH()
        {
            return alumnos.Where(a => a.Nota == 10).ToList();
        }

        // Obtener la lista completa de alumnos
        public List<Alumno> ObtenerListaAlumnos()
        {
            return alumnos;
        }
    }
}
