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
    public class Logica_LocalidadXPartido
    {//Permite agregar registros de localidadesXPartidos
        public bool Agregar(LocalidadesXpartido plocalidadesXpartido) //esta localidad viene de la capa de logica
        {
            //importante validar
            if (plocalidadesXpartido == null)
            {
                return false;
            }       
            //esta localidad va a la capa de acceso porque esta instancia y es static 
            return Acceso.Acceso_LocalidadesXPartido.ingresar(plocalidadesXpartido);

        }
        //Valida que el partido este activo
        public static bool PartidoActivo(LocalidadesXpartido localidadXPartido)
        {
            return localidadXPartido.Partido.Activo;
        }
        //Controla que la cantidad de boletos sea mayor a 0
        public bool CantidadValida(LocalidadesXpartido localidadXPartido)
        {
            return localidadXPartido.CantidadDisponible > 0;
        }
        //Controla si existen localidadesxpartido registradas
        public bool ExisteLocalidadPartido(LocalidadesXpartido localidadXPartido)
        {
            LocalidadesXpartido[] lista =
                Acceso_LocalidadesXPartido.Listar();

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != null)
                {
                    if (lista[i].Partido.IdPartido ==
                        localidadXPartido.Partido.IdPartido &&

                        lista[i].Localidades.IdLocalidad ==
                        localidadXPartido.Localidades.IdLocalidad)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public LocalidadesXpartido[] Listar() //metodo para listar las localidades
        {
            return Acceso.Acceso_LocalidadesXPartido.Listar(); //retorna el arreglo de localidades desde la capa de acceso
        }
        //PErmite controlar si hay registros en la localidadxpartido
        public bool TieneLocalidadesXPartido()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.Acceso_LocalidadesXPartido.encontrar_registros();
        }

    }
}
