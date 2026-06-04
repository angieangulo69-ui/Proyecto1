using Acceso;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_localidades
    {
        public bool Agregar(Localidades plocalidades) //esta localidad viene de la capa de logica
        {
            //importante validar
            if (plocalidades == null)
            {
                return false;
            }
            //esta localidad va a la capa de acceso porque esta instancia y es static 
            Acceso.Acceso_Localidad.ingresar(plocalidades);
            return true;
        }

        public Localidades[] Listar() //metodo para listar las localidades
        {
            return Acceso.Acceso_Localidad.Listar(); //retorna el arreglo de localidades desde la capa de acceso
        }

        public Localidades obtenerLocalidad(string codigo)
        {
            //obtiene la lista de localidades desde la capa de acceso
            var listaLocalidades = Acceso.Acceso_Localidad.Listar();

            //Recorre la lista para ver si conside
            for (int i = 0; i < listaLocalidades.Length; i++)
            {       //si no esta nula , compara el codigo de la localidad con el codigo proporcionado        
                if (listaLocalidades is not null && listaLocalidades[i].GetIdLocalidad().Equals(codigo))

                {
                    return listaLocalidades[i];
                }
            }
            return null;
        }
        public bool TieneLocalidades()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.Acceso_Localidad.encontrar_registros();
        }
    }
}
