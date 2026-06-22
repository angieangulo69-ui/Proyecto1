using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa una localidad, cuenta con construcores para la 
reación de objetos, atributos y propiedades que permiten el acceso a los datos de una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Entidades
{
    public class Localidades
    {
        // Atributos de la clase
        private int idLocalidad;
        private string nombreLocalidad;
        private Decimal precio;

        //Propiedades nos permiten acceder a los datos de forma segura
        public int IdLocalidad { get => idLocalidad; set => idLocalidad = value; }
        public string NombreLocalidad { get => nombreLocalidad; set => nombreLocalidad = value; }
        public decimal Precio { get => precio; set => precio = value; }

        //Constructor: inicializa el objeto con valores proporcionados
        public Localidades(int idLocalidad, string nombreLocalidad,Decimal precio)
        {
            IdLocalidad = idLocalidad;
            NombreLocalidad = nombreLocalidad;           
            Precio = precio;
        }
        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Localidades()
        {   
            
        }
       // Devuelve una cadena con la información principal del partido para mostrar en listas o ComboBox
        public override string ToString()
        {
            return IdLocalidad + " - " + NombreLocalidad;
       
        }
    }
}
