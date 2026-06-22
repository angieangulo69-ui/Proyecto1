using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase administra el almacenamiento y acceso de los registros
de Localidades por Partido. Permite agregar, listar y verificar la existencia
de registros utilizando un arreglo de objetos como  almacenamiento.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Acceso
{
    public class Acceso_LocalidadesXPartido
    {
        //Mi arreglo para almacenamiento
        private static LocalidadesXpartido[] lista_LocalidadXPartido = new LocalidadesXpartido[200];

        //Booleano para controlar el ingreso de registros
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
                    lista_LocalidadXPartido[i].IdLocalidadPartido == localidadesXpartido.IdLocalidadPartido)
                {
                    return false; // ID repetido
                }
            }

            // Recorro el arreglo para encontar la posion vacia y guardar el objeto localidadesXPartido
            for (int i = 0; i < lista_LocalidadXPartido.Length; i++)
            {
                if (lista_LocalidadXPartido[i] == null) //si est vacia
                {

                    lista_LocalidadXPartido[i] = localidadesXpartido; //guardar el objeto
                    return true;
                }
            }
            return false; //sino hay vacio false
        }

        public static LocalidadesXpartido[] Listar() //metodo para listar las localidades x partido
        {
            return lista_LocalidadXPartido; //retorna el arreglo de localidadesx partido
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
