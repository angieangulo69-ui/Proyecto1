using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {        
        public string Nombre;
        public string Apellido;
        public string Identificacion;
        public DateTime FechaNacimiento;

        public Persona( string nombre, string apellido, string identificacion, DateTime fechaNacimiento)
        {          
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            FechaNacimiento = fechaNacimiento;          
        }

        public Persona() { }

        //Getter 
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetApellido()
        {
            return Apellido;
        }
        public string GetIdentificacion()
        {
            return Identificacion;
        }
        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }

        //Setter
        public void SetIdentificacion(string identificacion)
        {
            this.Identificacion = identificacion;
        }
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.Apellido = apellido;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.FechaNacimiento = fechaNacimiento;
        }
    }
}
