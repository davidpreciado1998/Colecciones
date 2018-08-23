using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }

        public List<Materia> materias { get; set; }

        public Alumno()
        {
            materias = new List<Materia>();
        }
    }
}
