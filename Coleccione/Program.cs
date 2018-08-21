using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "194536";

            Alumno alumno2 = new Alumno();
            alumno.Nombre = "Pepe Gomez";
            alumno.Matricula = "194536";

            Alumno alumno3 = new Alumno();
            alumno.Nombre = "Jeferson Gutierritos";
            alumno.Matricula = "194536";

            Alumno alumno4 = new Alumno();
            alumno.Nombre = "Alvin Yaquitori";
            alumno.Matricula = "194536";

            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT12358";

           // alumnos[0].Materias.Add(new Materia());
            alumnos[0].Materias.Add(matematicas);
            alumnos[1].Materias.Add(matematicas);
            alumnos[2].Materias.Add(matematicas);
            alumnos[3].Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "HT96465";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "ES852";

            /* 
            alumno.Materias.RemoveAt(1);
            alumno.Materias.RemoveAt(1);
            alumno.Materias.Clear();
            */


            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Numero de materias: " + alumno.Materias.Count);

            foreach(Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Console.ReadLine();
         }
    }
}
