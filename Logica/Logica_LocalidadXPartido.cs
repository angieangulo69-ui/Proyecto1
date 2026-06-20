using Acceso;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_LocalidadXPartido
    {
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
            return localidadXPartido.partido.Activo;
        }

        public bool CantidadValida(LocalidadesXpartido localidadXPartido)
        {
            return localidadXPartido.cantidadDisponible > 0;
        }

        public bool ExisteLocalidadPartido(LocalidadesXpartido localidadXPartido)
        {
            LocalidadesXpartido[] lista =
                Acceso_LocalidadesXPartido.Listar();

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != null)
                {
                    if (lista[i].partido.getIdPartido() ==
                        localidadXPartido.partido.getIdPartido() &&

                        lista[i].localidades.GetIdLocalidad() ==
                        localidadXPartido.localidades.GetIdLocalidad())
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

        public LocalidadesXpartido obtenerLocalidadXPartido(string codigo)
        {
            //obtiene la lista de localidades desde la capa de acceso
            var listaLocalidadesXpartido= Acceso.Acceso_LocalidadesXPartido.Listar();

            //Recorre la lista para ver si conside
            for (int i = 0; i < listaLocalidadesXpartido.Length; i++)
            {       //si no esta nula , compara el codigo de la localidad con el codigo proporcionado        
                if (listaLocalidadesXpartido is not null && listaLocalidadesXpartido[i].getIdLocalidadPartido().Equals(codigo))

                {
                    return listaLocalidadesXpartido[i];
                }
            }
            return null;
        }
        public bool TieneLocalidadesXPartido()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.Acceso_LocalidadesXPartido.encontrar_registros();
        }

    }
}
