using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa una clase padre , que va a heredar a clientes y vendedores,cuenta con
constructores para la reación de objetos, atributos y propiedades que permiten el acceso a los datos de 
una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Entidades
{
    public class Persona
    {
        //Atributos de la clase persona 
        private string nombre;
        private string apellido;
        private string identificacion;
        private DateTime fechaNacimiento;

        // Propiedades nos permiten acceder a los datos de forma segura
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        // //Constructor: inicializa el objeto con valores proporcionados
        public Persona(string nombre, string apellido, string identificacion, DateTime fechaNacimiento)
        {
           this.nombre = nombre;
           this.apellido = apellido;
           this.identificacion = identificacion;
           this.fechaNacimiento = fechaNacimiento;
        }
        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Persona() 
        {
        }


    }
}
