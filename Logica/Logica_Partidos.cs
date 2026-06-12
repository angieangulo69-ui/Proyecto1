using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Partidos
    {
        public bool Agregar(Partidos ppartidos)
        {
            //Validamos datos
            if (ppartidos == null)
            {
                return false;
            }
            return Acceso.Acceso_Partido.ingreso(ppartidos); //Llamamos a la capa de acceso para agregar el partido

        }

        public Partidos[] Listar()//Llamamos a la capa de acceso para listar los partidos
        {
            return Acceso.Acceso_Partido.Listar();
        } 
        
        public Partidos obtenerPartidos(string codigo)
        {
            //obtenemos la lista desde la capa de partidos
            var listaPartidos = Acceso.Acceso_Partido.Listar();

            //recorre la lista para ver si conside
            for (int i = 0; i < listaPartidos.Length; i++)
            {
                if (listaPartidos is not null && listaPartidos[i].getIdPartido().Equals (codigo))
                {
                    return listaPartidos[i];
                }
            }
            return null;
        }

        public bool TienePartidos() {
            //Llamamos a la capa de acceso para verificar si hay registros de partidos
            return Acceso.Acceso_Partido.encontrar_registros();
        }
    }
}
