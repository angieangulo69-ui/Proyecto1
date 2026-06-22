using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa los partidos,cuenta con construcores para la 
reación de objetos, atributos y propiedades que permiten el acceso a los datos de una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/

namespace Entidades
{
    public class Partidos
    {
        //Atributos de la clase
        private int idPartido;
        private string rival;
        private DateTime fecha;
        private string hora;
        private Boolean activo;

        //Propiedades nos permiten acceder a los datos de forma segura
        public int IdPartido { get => idPartido; set => idPartido = value; }
        public string Rival { get => rival; set => rival = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public bool Activo { get => activo; set => activo = value; }

        //Constructor: inicializa el objeto con valores proporcionados
        public Partidos(int idPartido, string rival, DateTime fecha, string hora, Boolean activo)
        {
            IdPartido = idPartido;
            Rival = rival;
            Fecha = fecha;
            Hora = hora;
            Activo = activo;
        }
        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Partidos()
        {
        }
        // Devuelve una cadena con la información principal del partido para mostrar en listas o ComboBox
        public override string ToString()
        {
            return IdPartido + " - " + Rival + " - " +
                   Fecha.ToShortDateString() + " - " + Hora;
        }

    }
 }

       
