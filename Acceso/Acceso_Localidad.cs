using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Acceso
{
    public class Acceso_Localidad
    {
        //Mi arreglo para almacenamiento de localidades
        private static Localidades[] lista_Localidad = new Localidades[10];

        //Booleano para controlar el ingreso de localidades registradas
        public static bool ingresar(Localidades localidades) //clase y objeto
        {
            if (localidades == null) //si el objeto es nulo, no se puede ingresar
            {
                return false;
            }
            // recorro el arreglo para encontar la posion vacia y guardar el objeto localidades
            for (int i = 0; i < lista_Localidad.Length; i++)
            {
                if (lista_Localidad[i] == null) //si est vacia
                {
                    lista_Localidad[i] = localidades; //gudarde el objeto
                    return true;
                }
            }
            return false; //sino hay vacio false
        }

        public static Localidades[] Listar() //metodo para listar las localidades
        {
            return lista_Localidad; //retorna el arreglo de localidades
        }
        public static bool encontrar_registros()
        {
            if (lista_Localidad == null) //si el arreglo es nulo, no hay registros
            {
                return false;
            }

            for (int i = 0; i < lista_Localidad.Length; i++)
            {
                if (lista_Localidad[i] != null) //si hay al menos un registro
                {
                    return true;
                }
            }
            return false; //si no hay registros
        }
    }
}
