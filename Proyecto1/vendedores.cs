using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedores : Persona
    {
        //Atributos 
        public int IdVendedor;        
        public DateTime FechaIngreso;

        // Constructor vacio       
        public Vendedores()
        {
        }
        // getter
        public int GetIdVendedor()
        {
            return IdVendedor;
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
       
        public void SetFechaIngreso(DateTime fechaIngreso)
        {
            this.FechaIngreso = fechaIngreso    ;
        }

        public override string ToString()
        {
            return Identificacion + " - " + Nombre + " " + Apellido;
        }

    }
}
