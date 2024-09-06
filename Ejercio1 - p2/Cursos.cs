using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1___p2
{
    internal class Cursos
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Curso: {Nombre}");
            Console.WriteLine($"Recuento de Clases: {RecuentoClases}");
            Console.WriteLine($"Recuento de Ejercicios: {RecuentoEjercicios}");
        }

    }
}
