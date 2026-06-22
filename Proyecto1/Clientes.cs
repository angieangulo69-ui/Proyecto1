using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa un cliente, hereda de la clase Persona,cuenta con constructores para la 
reación de objetos, atributos y propiedades que permiten el acceso a los datos de una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Entidades
{
    public class Clientes: Persona
    {
        //Atributos de la clase
        private int idCliente;
        private DateTime fechaRegistro;
        private Boolean activo;

        //Propiedades nos permiten acceder a los datos de forma segura
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public bool Activo { get => activo; set => activo = value; }

        //Constructor: inicializa el objeto con valores proporcionados
        //base nos permite llamar al constructor de la base padre en este caso persona.
        public Clientes (int idCliente,string nombre, string apellido, string identificacion,DateTime fechaNacimiento,DateTime fechaRegistro, bool activo)
            :base(nombre,apellido,identificacion,fechaNacimiento) 
        {
            this.IdCliente = idCliente;
            this.FechaRegistro = fechaRegistro;
            this.Activo = activo;
        }

        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Clientes()
        {

        }
        //Devuelve una cadena con la información principal del partido para mostrar en listas o ComboBox
        public override string ToString()
        {
            return Identificacion + " - " + Nombre + " " + Apellido;
        }
    }
 }
