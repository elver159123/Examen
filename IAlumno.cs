using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IAlumno
    {
        string GetDni();
        string GetApellidos();
        string GetNombre();
        double GetNota();
        string GetCalificacion();
    }


}
