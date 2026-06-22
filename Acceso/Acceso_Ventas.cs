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
Descripción: permite el acceso a los datos registrados
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Acceso
{
    public class Acceso_Ventas
    {
            //Mi arreglo para almacenamiento
            private static Ventas[] lista_Ventas = new Ventas[200];

        //Booleano para controlar el ingreso de datos
        public static bool ingresar(Ventas venta)
        {
            if (lista_Ventas == null)
                return false;

            for (int i = 0; i < lista_Ventas.Length; i++)
            {
                if (lista_Ventas[i] == null)
                {
                    lista_Ventas[i] = venta;
                    return true;
                }
            }

            return false;
        }
        //lista de ventas
        public static Ventas[] Listar()
        {
            return lista_Ventas;
        }
        //Metodo permite encontrar si hay registros
        public static bool encontrar_registros()
        {
            if (lista_Ventas == null)
            {
                return false;
            }
            for (int i = 0; i < lista_Ventas.Length; i++)
            {
                if (lista_Ventas[i] != null)
                {
                    return true; //si hay registros
                }
            }
            return false; //No hay registros
        }
    }
    
}
