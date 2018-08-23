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

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Juan Perez";
            alumno1.materias.Add(new Materia("Historia", "HST741"));
            alumno1.materias.Add(new Materia("Matematicas", "MAT789"));
            alumno1.materias.Add(new Materia("Civismo", "CVC753"));

            alumnos.Add(alumno1);

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Pepe Gomez";
            alumno2.materias.Add(new Materia("Historia", "HST741"));
            alumno2.materias.Add(new Materia("Matematicas", "MAT789"));
            alumno2.materias.Add(new Materia("Civismo", "CVC753"));

            alumnos.Add(alumno2);

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Jeferson Gutierritos";
            alumno3.materias.Add(new Materia("Historia", "HST741"));
            alumno3.materias.Add(new Materia("Matematicas", "MAT789"));
            alumno3.materias.Add(new Materia("Civismo", "CVC753"));

            alumnos.Add(alumno3);

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Alvin Yaquitori";
            alumno4.materias.Add(new Materia("Historia", "HST741"));
            alumno4.materias.Add(new Materia("Matematicas", "MAT789"));
            alumno4.materias.Add(new Materia("Civismo", "CVC753"));

            alumnos.Add(alumno4);

            /* Materia matematicas = new Materia();
             matematicas.Nombre = "Matematicas";
             matematicas.Identificador = "MT12358";
             */

            // alumnos[0].Materias.Add(new Materia());
            /*
            alumnos[0].Materias.Add(matematicas);
            alumnos[1].Materias.Add(matematicas);
            alumnos[2].Materias.Add(matematicas);
            alumnos[3].Materias.Add(matematicas);
            */

            /* 
            alumno.Materias.RemoveAt(1);
            alumno.Materias.RemoveAt(1);
            alumno.Materias.Clear();
            */

            foreach(Alumno alumnox in alumnos)
            {
                Console.WriteLine("Alumno: " + alumnox.Nombre);
                foreach(Materia materiax in alumnox.materias)
                {
                    Console.WriteLine("Materia: " + materiax.Nombre);
                }
                Console.WriteLine("");
                
            }
            /*foreach(Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }*/

            Console.ReadLine();
         }
    }
}
