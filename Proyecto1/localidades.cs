using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidades
    {
        // Atributos
        public int IdLocalidad;
        public string NombreLocalidad;        
        public Decimal Precio;
        
       

        // Constructor
        public Localidades(int idLocalidad, string nombreLocalidad,Decimal precio)
        {
            IdLocalidad = idLocalidad;
            NombreLocalidad = nombreLocalidad;           
            Precio = precio;
        }
        // Constructor vacio
        public Localidades()
        {   
            
        }
        //Getter 
        public int GetIdLocalidad()
        { 
            return IdLocalidad; 
        }
        public string GetNombreLocalidad()
        {
            return NombreLocalidad;
        } public Decimal GetPrecio() {   
            return Precio;
            } 
     
        //Setter
        public void SetIdLocalidad(int idLocalidad)
        {
            IdLocalidad = idLocalidad;
        }
        public void SetNombreLocalidad(string nombreLocalidad)
        {
            NombreLocalidad = nombreLocalidad;
        }
            
        public void SetPrecio(Decimal precio)
        {
            Precio = precio;
        }
       
    }
}
