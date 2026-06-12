using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Acceso
{
    public class Acceso_Vendedor
    {
        //Mi arreglo para almacenamiento
        private static Vendedores[] lista_Vendedores = new Vendedores[15];

        //Booleado pára controlar el ingreso de vendedores registrados
        public static bool ingresar(Vendedores vendedores) //Clase objeto
        {
            if (vendedores == null)
            {
                return false; 
            }

            //Validar que no existe el mismo IDVendedor
            for (int i = 0; i < lista_Vendedores.Length; i++)
            {

                if (lista_Vendedores[i] != null && lista_Vendedores[i].GetIdVendedor == vendedores.GetIdVendedor)
                {
                    return false; //Id repetido
                }
            }

            //REcorre el arreglo para encontar la psoicion vacia y guiardar el objeto vendedor
            for (int i = 0; i < lista_Vendedores.Length; i++) {
                if (lista_Vendedores == null)
                {
                    lista_Vendedores[i] = vendedores; //guarde le objeto
                    return true;
                }
            }
            return false;
        }

        public static Vendedores[]Listar() //lista los vendedores
        {
            return lista_Vendedores;

        }

        public static bool encontrar_registros()
        {
            if (lista_Vendedores == null)
            { //Si la lista es nula, esta vacia
              return false;
            }

            for (int i = 0; i < lista_Vendedores.Length; i++)
            {
                if (lista_Vendedores[i]!= null) //Si es diferente de nulo
                {
                    return true;//Si hay registros
                }
            }
            return false; //No hay registros
        }

        
    }
}
