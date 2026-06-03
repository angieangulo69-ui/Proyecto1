using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class vendedores
    {
        //Atributos 
        private int IdVendedor;
        private string Identificacion;
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
        private DateTime FechaIngreso;



        // Constructor
        public vendedores(int idVendedor, string identificacion, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso    )
        {
            this.IdVendedor = idVendedor;
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.FechaIngreso = fechaIngreso;
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
