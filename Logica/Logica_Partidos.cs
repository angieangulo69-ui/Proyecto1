using Acceso;
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
Descripción: Esta clase permite agregar los registros, y realizar validaciones, segun lo solicitado.
obtener cliente y permite una conexion con mi clase de acceso a mi almacenamiento. 
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Logica
{
    public class Logica_Partidos
    {//Permite agregar partidos a la lista
        private Acceso_Partido AccesoPartido = new Acceso_Partido(); 
        public bool Agregar(Partidos ppartidos)
        {
            //Validamos datos
            if (ppartidos == null)
            {
                return false;
            }
            //Obtenesmo los partidos registrados
            List<Partidos> listapartidos= AccesoPartido.ObtenerPartidos(); 

            // valida que no existe el mismo idPartido en el arreglo
            foreach(Partidos item in listapartidos)
            {   // Si encuentra un partido con el mismo idPartido, no se puede ingresar
                if (item != null && item.IdPartido == ppartidos.IdPartido)
                {
                    return false;
                }
            }

            return AccesoPartido.ingresar(ppartidos); //Llamamos a la capa de acceso para agregar el partido
        }

        public List<Partidos> Listar()//Llamamos a la capa de acceso para listar los partidos
        {
            return AccesoPartido.ObtenerPartidos();
        }

        //Controla si hay partidos registrados
        public bool TienePartidos() {
            //Llamamos a la capa de acceso para verificar si hay registros de partidos
            return AccesoPartido.encontrar_registros();
        }
    }
}
