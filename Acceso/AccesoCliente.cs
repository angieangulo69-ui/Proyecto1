using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso
{
    public class AccesoCliente
    {
        //Mi arreglo para almacenamiento
        private static Clientes[] lista_Clientes = new Clientes[50];

        //Booleano para controlar el ingreso de datos
        public static bool ingresar(Clientes cliente)
        {
            if (cliente == null)
            {
                return false;
            }

            //Recorre el arrglo para encontrar la posicion vacia y guardar el objeto vendedor
            for (int i = 0; i < lista_Clientes.Length; i++)
            {
                if (lista_Clientes[i] == null)
                {
                    lista_Clientes[i] = cliente;
                    return true;
                }
            }
            return false;
        }
        //lista de clientes
        public static Clientes[] Listar()
        {
            return lista_Clientes;
        }

        public static bool encontrar_registro()
        {
            if(lista_Clientes == null)
            {
                return false;
            }
            for (int i = 0; i < lista_Clientes.Length; i++)
            {
                if (lista_Clientes[i] != null)
                {
                    return true; //si hay registros
                }
            }
                return false; //No hay registros
        }
     }       
}

