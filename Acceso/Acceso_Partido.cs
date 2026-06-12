using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso
{
    public class Acceso_Partido
    {
        //Mi arreglo para almacenamiento
        private static Partidos[] lista_Partidos = new Partidos[30];

        //boleano para controlar el ingreso de datos
        public static bool ingreso(Partidos partido) //Clase y objeto
        {
            if (partido == null)
            { //Valida que no este nulo
                return false;
            }
            // valida que no existe el mismo idPartido en el arreglo
            for (int i = 0; i < lista_Partidos.Length; i++)
            {   // Si encuentra un partido con el mismo idPartido, no se puede ingresar
                if (lista_Partidos[i] != null && lista_Partidos[i].getIdPartido() == partido.getIdPartido())
                {
                    return false;
                }
            }
            for (int i = 0; i < lista_Partidos.Length; i++)
            {   // Busca un espacio vacio en el arreglo para ingresar el nuevo partido
                if (lista_Partidos[i] == null)
                {
                    lista_Partidos[i] = partido; //Guarda el partido en el arreglo
                    return true; // Ingreso exitoso
                }
            }
            return false; // No se pudo ingresar el partido
        }
        public static Partidos[] Listar () // Método para listar los partidos
        {
            return lista_Partidos; // Devuelve el arreglo de partidos
        }
        public static bool encontrar_registros()
        {
            if (lista_Partidos == null)
            {
                return false; // No hay registros
            }
            for (int i = 0; i < lista_Partidos.Length; i++)
            {
                if (lista_Partidos[i] != null) //si hay almenos un registro 
                {
                    return true; 
                }
            }
            return false; // No se encontraron registros
        }

    }
}
