using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso
{
    public class Acceso_LocalidadesXPartido
    {
        //Mi arreglo para almacenamiento
        private static LocalidadesXpartido[] lista_LocalidadXPartido = new LocalidadesXpartido[200];

        //Booleano para controlar el ingreso de
        public static bool ingresar(LocalidadesXpartido localidadesXpartido) //clase y objeto
        {
            if (localidadesXpartido == null) //si el objeto es nulo, no se puede ingresar
            {
                return false;
            }

            // Validar que no exista el mismo IdLocalidadXPartido
            for (int i = 0; i < lista_LocalidadXPartido.Length; i++)
            {
                if (lista_LocalidadXPartido[i] != null &&
                    lista_LocalidadXPartido[i].getIdLocalidadPartido() == localidadesXpartido.getIdLocalidadPartido())
                {
                    return false; // ID repetido
                }
            }

            // recorro el arreglo para encontar la posion vacia y guardar el objeto localidades
            for (int i = 0; i < lista_LocalidadXPartido.Length; i++)
            {
                if (lista_LocalidadXPartido[i] == null) //si est vacia
                {

                    lista_LocalidadXPartido[i] = localidadesXpartido; //gudarde el objeto
                    return true;
                }
            }
            return false; //sino hay vacio false
        }

        public static LocalidadesXpartido[] Listar() //metodo para listar las localidades
        {
            return lista_LocalidadXPartido; //retorna el arreglo de localidades
        }
        public static bool encontrar_registros()
        {
            if (lista_LocalidadXPartido == null) //si el arreglo es nulo, no hay registros
            {
                return false;
            }

            for (int i = 0; i < lista_LocalidadXPartido.Length; i++)
            {
                if (lista_LocalidadXPartido[i] != null) //si hay al menos un registro
                {
                    return true;
                }
            }
            return false; //si no hay registros
        }
    }
}
