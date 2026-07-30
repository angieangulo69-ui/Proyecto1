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
        private Acceso_LocalidadesXPartido Acceso = new Acceso_LocalidadesXPartido();
        public bool Agregar(LocalidadesXpartido plocalidadesXpartido) //esta localidad viene de la capa de logica
        {
           
            //importante validar
            if (plocalidadesXpartido == null)
            {
                return false;
            }       
            //esta localidad va a la capa de acceso porque esta instancia y es static 
            return Acceso.ingresar(plocalidadesXpartido);
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
            List<LocalidadesXpartido> lista = Acceso.ObtenerLocalidadXPartido();
            
            foreach (LocalidadesXpartido item in lista)
            { 
                if (item.Partido.IdPartido == localidadXPartido.Partido.IdPartido &&
                    item.Localidades.IdLocalidad == localidadXPartido.Localidades.IdLocalidad)
                    {
                        return true;
                    }
                }           
            return false;
        }
        //Lista de registros
        public List<LocalidadesXpartido> Listar() //metodo para listar las localidades
        {
            return Acceso.ObtenerLocalidadXPartido(); //
        }
        //Obtiene las localidades por partido
        public List<LocalidadesXpartido> ObtenerPorPartido(int idPartido)
        {
            List<LocalidadesXpartido> lista = Acceso.ObtenerLocalidadXPartido();

            List<LocalidadesXpartido> resultado = new List<LocalidadesXpartido>();

            foreach (LocalidadesXpartido item in lista)
            {
                if (item.Partido.IdPartido == idPartido)
                {
                    resultado.Add(item);
                }
            }

            return resultado;
        }

        public bool ActualizarCantidad(int idLocalidadPartido, int cantidadDisponible)
        {
            return Acceso.ActualizarCantidadDisponible(idLocalidadPartido, cantidadDisponible);
        }

        //PErmite controlar si hay registros en la localidadxpartido
        public bool TieneLocalidadesXPartido()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.encontrar_registros();
        }

    }
}
