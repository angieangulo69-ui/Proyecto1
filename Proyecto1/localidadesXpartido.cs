using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa la combinacion de localidades por partido,cuenta con construcores para la 
reación de objetos, atributos y propiedades que permiten el acceso a los datos de una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Entidades
{
    public class LocalidadesXpartido
    {
        // Atributos de la clase
        private int idLocalidadPartido;
        private Partidos partido; // Relación con la clase partidos
        private Localidades localidades;
        private int cantidadDisponible;

        //Propiedades nos permiten acceder a los datos de forma segura
        public int IdLocalidadPartido { get => idLocalidadPartido; set => idLocalidadPartido = value; }
        public Partidos Partido { get => partido; set => partido = value; }
        public Localidades Localidades { get => localidades; set => localidades = value; }
        public int CantidadDisponible { get => cantidadDisponible; set => cantidadDisponible = value; }


        //Constructor vacio permite crear el objeto sin datos iniciales
        public LocalidadesXpartido()
        {

        }
        //Constructor: inicializa el objeto con valores proporcionados
        public LocalidadesXpartido(int idLocalidadPartido, Partidos partido, Localidades localidades, int cantidadDisponible)
        {
            this.IdLocalidadPartido = idLocalidadPartido;
            this.partido = partido;
            this.localidades = localidades;
            this.cantidadDisponible = cantidadDisponible;
        }

        public override string ToString()
        {
            return Partido.Rival + " - " + Localidades.NombreLocalidad;
        }
    }
}
