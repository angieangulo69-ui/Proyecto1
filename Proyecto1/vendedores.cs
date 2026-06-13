using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedores
    {
        //Atributos 
        public int IdVendedor;
        public string Identificacion;
        public string Nombre;
        public string Apellido;
        public DateTime FechaNacimiento;
        public DateTime FechaIngreso;



        // Constructor
        public Vendedores(int idVendedor, string identificacion, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso    )
        {
            this.IdVendedor = idVendedor;
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.FechaIngreso = fechaIngreso;
        }

        public Vendedores()
        {
        }
        // getter
        public int GetIdVendedor()
        {
            return IdVendedor;
        }
        public string GetIdentificacion()
        {
            return Identificacion;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetApellido()
        {
            return Apellido;
        }
        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public DateTime GetFechaIngreso()
        {
            return FechaIngreso;
        }
        //Setter
        public void SetIdVendedor(int idVendedor)
        {
            this.IdVendedor = idVendedor;
        }
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
        public void SetFechaIngreso(DateTime fechaIngreso)
        {
            this.FechaIngreso = fechaIngreso    ;
        }
                      
            
    }
}
