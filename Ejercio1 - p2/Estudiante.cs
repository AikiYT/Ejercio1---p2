using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio1___p2
{
    
    internal class Estudiante : Persona
    {


        public int NumeroUnico { get; set; }
        public Clase Clase { get; set; }

        public override void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------Estudiantes:" +Nombre + "------------------------------------------------");
            base.ImprimirDatos();
            Console.WriteLine($"Número Único: {NumeroUnico}");
            Console.WriteLine($"Clase: {Clase.Identificador}");
        }
        
    }





}


