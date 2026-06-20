using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes: Persona
    {
        public int IdCliente;
        public DateTime FechaRegistro;
        public Boolean Activo;

        public Clientes (int idCliente,string nombre, string apellido, string identificacion,DateTime fechaNacimiento,DateTime fechaRegistro, bool activo)
            :base(nombre,apellido,identificacion,fechaNacimiento) 
        {
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        //Cosntructor 
        public Clientes()
        {

        }
        
        //Getter 
        public int GetIdCliente()
        {
            return IdCliente;
        }        
        public DateTime GetFechaRegistro()
        {
            return FechaRegistro;
        }
        public Boolean GetActivo()
        {
            return Activo;
        }
        //Setter
        public void SetIdCliente(int idCliente)
        {
            this.IdCliente = idCliente;
        }
        
        public void SetFechaRegistro(DateTime fechaRegistro)
        {
            this.FechaRegistro = fechaRegistro;
        }
        public void SetActivo(Boolean activo)
        {
            this.Activo = activo;
        }

        public override string ToString()
        {
            return Identificacion + " - " + Nombre + " " + Apellido;
        }
    }
 }
