using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1___p2
{
    internal class Profesor : Persona
    {
        public List<Cursos> Cursos { get; set; } = new List<Cursos>();


        public void AgregarCurso(Cursos cursos)
        {
            Cursos.Add(cursos);
        }
        public override void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------Profesor:" + Nombre + "------------------------------------------------");

            // Imprimir datos de los cursos
            if (Cursos.Count > 0)
            {
                Console.WriteLine($"Cursos asignados a {Nombre}:");
                foreach (var curso in Cursos)
                {
                    Console.WriteLine($"- Curso: {curso.Nombre}");
                    Console.WriteLine($"  Recuento de clases: {curso.RecuentoClases}");
                    Console.WriteLine($"  Recuento de ejercicios: {curso.RecuentoEjercicios}");
                }
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene cursos asignados.");
            }

            // Agregar salto de línea entre cada profesor
            Console.WriteLine();  // Esto agrega un salto de línea extra.
            








        }
    }
}


