using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
         //public string Nombre {get; set;} 
         //public int Edad {get; set;} 
         //public int TI {get; set;} 
         
         public  int Id {get; set;} 
         public  int Cedula {get; set;} 
         public  string  Nombre {get; set;} 
         public  string  apellido {get; set;} 
         public  string  Telefono {get; set;} 
         public  string  Direccion {get; set;} 
         public  string  Correo {get; set;} 
         //public  string  Telefono {get; set;} 
         
         public void loggin(int _Id,int _Cedula,string _Nombre, string _apellido, string _Telefono, string _Direccion,string _Correo){
            this.Id = _Id; 
            this.Cedula = _Cedula;
            Nombre = _Nombre;
            apellido = _apellido;
            Telefono = _Telefono;
            Direccion = _Direccion;
            Correo = _Correo;

         }
    }
}