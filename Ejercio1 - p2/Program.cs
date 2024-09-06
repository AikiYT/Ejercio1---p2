using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercio1___p2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Clase claseA = new Clase { Identificador = "A101" };
            Clase claseB = new Clase { Identificador = "A102" };
            

            Estudiante estudiante1 = new Estudiante { Nombre = "Juan Pérez", NumeroUnico = 1, Clase = claseA };
            Estudiante estudiante2 = new Estudiante { Nombre = "María García", NumeroUnico = 2, Clase = claseA };
            Estudiante estudiante3 = new Estudiante { Nombre = "Carlos Joel García", NumeroUnico = 3, Clase = claseA };
            Estudiante estudiante4 = new Estudiante { Nombre = "Miguel santos", NumeroUnico = 7, Clase = claseB };


            Profesor profesor1 = new Profesor { Nombre = "Dr. Smith" };
            Profesor profesor2 = new Profesor { Nombre = "Santos" };
            Profesor profesor3 = new Profesor { Nombre = "felix sanchez" };
            Profesor profesor4 = new Profesor { Nombre = "Jean jules" };


            Cursos curso1 = new Cursos { Nombre = "Matemáticas", RecuentoClases = 30, RecuentoEjercicios = 100 };
            Cursos curso2 = new Cursos { Nombre = "Ciencias", RecuentoClases = 25, RecuentoEjercicios = 80 };
            Cursos curso3 = new Cursos { Nombre = "sociales", RecuentoClases = 60, RecuentoEjercicios = 19 };


            profesor1.AgregarCurso(curso1);
            profesor2.AgregarCurso(curso2);

            claseA.AgregarEstudiante(estudiante1);
            claseA.AgregarEstudiante(estudiante2);
            claseA.AgregarEstudiante(estudiante3);
            claseA.AgregarProfesor(profesor1);
            claseA.AgregarProfesor(profesor2);


            claseB.AgregarEstudiante(estudiante4);
            claseB.AgregarEstudiante(estudiante2);
            claseB.AgregarEstudiante(estudiante3);
            
            claseB.AgregarProfesor(profesor2);
           




            
            claseA.ImprimirDatos();
            claseB.ImprimirDatos();

            Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }

        }
    }

