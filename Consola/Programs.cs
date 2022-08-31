using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace Consola
{
    public class Programs
    {
        public static void Main(string[] args)
        {

            Persona p = new Persona();
            p.Nombre = "joimar";
            p.TI=20;
            Console.WriteLine("el nombre es:  "+p.Nombre+" su edad es: "+p.TI);
        }
    }
}