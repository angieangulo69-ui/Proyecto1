using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LocalidadesXpartido
    {
        // Atributos
        public int id_localidadPartido;
        public Partidos partido; // Relación con la clase partidos
        public Localidades localidades;
        public int cantidadDisponible;
        // Constructor
        public LocalidadesXpartido(int id_localidadPartido, Partidos partido, Localidades localidades, int cantidadDisponible)
        {
            this.id_localidadPartido = id_localidadPartido;
            this.partido = partido;
            this.localidades = localidades;
            this.cantidadDisponible = cantidadDisponible;
        }
         public LocalidadesXpartido()
        {

        }       

        //Getter
        public int getIdLocalidadPartido()
        {
            return id_localidadPartido;
        }
     
        public Partidos getPartido()
        {
            return partido;
        }
        public Localidades getLocalidades()
        {
            return localidades;
        }
        public int getCantidadDisponible()
        {
            return cantidadDisponible;
        }


        //Setter
        public void setPartido(Partidos partido)
        {
            this.partido = partido;
        }
        public void setIdLocalidadPartido(int idLocalidadPartido)
        {
            this.id_localidadPartido = idLocalidadPartido;
        }
        

        public void setLocalidades(Localidades localidades)
        {
            this.localidades = localidades;
        }
     
        public void setCantidadDisponible(int cantidadDisponible)
        {
            this.cantidadDisponible = cantidadDisponible;
        }
    }
}
