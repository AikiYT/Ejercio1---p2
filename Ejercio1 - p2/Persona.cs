using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1___p2
{
    internal abstract class Persona
    {
        public string Nombre;
    




       public virtual void ImprimirDatos()
       {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }
}
