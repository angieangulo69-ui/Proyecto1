using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa un vendedor, hereda de la clase Persona,cuenta con constructores para la 
reación de objetos, atributos y propiedades que permiten el acceso a los datos de una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Entidades
{
    public class Vendedores : Persona
    {
        //Atributos 
        private int idVendedor;
        private DateTime fechaIngreso;

        //
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }


        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Vendedores() 
        { 
        }
        //Constructor: inicializa el objeto con valores proporcionados
        //base nos permite llamar al constructor de la base padre en este caso persona.
        public Vendedores(int idVendedor,string nombre,string apellido,string identificacion,DateTime fechaNacimiento, DateTime fechaIngreso)
           : base(nombre, apellido, identificacion, fechaNacimiento)
        {
            this.IdVendedor = idVendedor;
            this.FechaIngreso = fechaIngreso;
        }
        //Devuelve una cadena con la información principal del partido para mostrar en listas o ComboBox
        public override string ToString()
        {
            return Identificacion + " - " + Nombre + " " + Apellido;
        }

    }
}
