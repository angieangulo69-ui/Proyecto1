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
    public class Logica_localidades
    {  //Pemite agregar localiaddes
        public bool Agregar(Localidades plocalidades) //esta localidad viene de la capa de logica
        {
            //importante validar
            if (plocalidades == null)
            {
                return false;
            }

            Localidades[] lista_Localidad = Acceso.Acceso_Localidad.Listar(); //listamos para obtener las localidades guardados y poder validar 

            // Validar que no exista el mismo IdLocalidad
            for (int i = 0; i < lista_Localidad.Length; i++)
            {
                if (lista_Localidad[i] != null)
                {
                    if (lista_Localidad[i].IdLocalidad == plocalidades.IdLocalidad)
                    {
                        return false; // eL ID existe
                    }
                }

            }
            //esta localidad va a la capa de acceso porque esta instancia y es static 
            return Acceso.Acceso_Localidad.ingresar(plocalidades);
        }

        public Localidades[] Listar() //metodo para listar las localidades
        {
            return Acceso.Acceso_Localidad.Listar(); //retorna el arreglo de localidades desde la capa de acceso
        }
        //Permite controlar que tengamos localidades registradas
        public bool TieneLocalidades()
        {
            //retorna true si hay registros, false si no hay registros
            return Acceso.Acceso_Localidad.encontrar_registros();
        }
    }
}
