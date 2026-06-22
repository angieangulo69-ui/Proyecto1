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
        public bool Agregar(Partidos ppartidos)
        {
            //Validamos datos
            if (ppartidos == null)
            {
                return false;
            }
            //Obtenesmo los partidos registrados
            Partidos[] lista_Partidos = Acceso.Acceso_Partido.Listar();

            // valida que no existe el mismo idPartido en el arreglo
            for (int i = 0; i < lista_Partidos.Length; i++)
            {   // Si encuentra un partido con el mismo idPartido, no se puede ingresar
                if (lista_Partidos[i] != null && lista_Partidos[i].IdPartido == ppartidos.IdPartido)
                {
                    return false;
                }
            }

            return Acceso.Acceso_Partido.ingreso(ppartidos); //Llamamos a la capa de acceso para agregar el partido
        }

        public Partidos[] Listar()//Llamamos a la capa de acceso para listar los partidos
        {
            return Acceso.Acceso_Partido.Listar();
        } 
        
       //Controla si hay partidos registrados
        public bool TienePartidos() {
            //Llamamos a la capa de acceso para verificar si hay registros de partidos
            return Acceso.Acceso_Partido.encontrar_registros();
        }
    }
}
