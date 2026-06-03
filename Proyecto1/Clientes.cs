using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        private int IdCliente;
        private string Nombre;
        private string Apellido;
        private string Identificacion;
        private DateTime FechaNacimiento;
        private DateTime FechaRegistro;
        private Boolean Activo;

        //Cosntructor 
        public Clientes(int idCliente, string nombre, string apellido, string identificacion, DateTime fechaNacimiento, DateTime fechaRegistro, Boolean activo)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
        //Getter 
        public int GetIdCliente()
        {
            return IdCliente;
        }
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
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.Apellido = apellido;
        }
        public void SetIdentificacion(string identificacion)
        {
            this.Identificacion = identificacion;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.FechaNacimiento = fechaNacimiento;
        }
        public void SetFechaRegistro(DateTime fechaRegistro)
        {
            this.FechaRegistro = fechaRegistro;
        }
        public void SetActivo(Boolean activo)
        {
            this.Activo = activo;
        }
    }
 }
