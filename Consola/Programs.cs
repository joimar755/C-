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

            /*Persona p = new Persona();
            p.Nombre = "joimar";
            p.TI=20;
            Console.WriteLine("el nombre es:  "+p.Nombre+" su edad es: "+p.TI);
            */

            Persona p = new Persona();
            p.loggin(1, 1002212701, "joimar", "lopez", "3004587894", "avenida 30 ", "joimar@gmail.com");

            Console.WriteLine("ID: " + p.Id);
            Console.WriteLine("Cedula: " + p.Cedula);
            Console.WriteLine("Nombre: " + p.Nombre);
            Console.WriteLine("Apellido: " + p.apellido);
            Console.WriteLine("Telefono: " + p.Telefono);
            Console.WriteLine("Direcion: " + p.Direccion);
            Console.WriteLine("Correo: " + p.Correo);

            Console.WriteLine("-------CLIENTE----------");

            Cliente c = new Cliente();
            c.Nombre = "mario perez";
            c.Cedula = 32558945;
            c.Direccion = "calle 30 #48";

            Console.WriteLine("Nombre: " + c.Nombre);
            Console.WriteLine("Cedula: " + c.Cedula);
            Console.WriteLine("Direccion: " + c.Direccion);
        }
    }
}