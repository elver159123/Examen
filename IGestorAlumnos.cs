using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IGestorAlumnos
    {
        void MostrarAlumnos();
        void AgregarAlumno(Alumno alumno);
        void EliminarAlumno(string dni);
        Alumno ConsultarAlumno(string dni);  
        void ModificarNota(string dni, double nuevaNota);
        void MostrarSuspensos();
        void MostrarAprobados();
        void MostrarCandidatosMH();
        void ModificarCalificacion(string dni, string nuevaCalificacion);
    }

}
