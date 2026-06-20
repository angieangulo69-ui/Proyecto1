using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partidos
    {
        //Atributos
        public int IdPartido;
        public string Rival;
        public DateTime Fecha;
        public string Hora;
        public Boolean Activo;
        //Constructor
        public Partidos(int idPartido, string rival, DateTime fecha, string hora, Boolean activo)
        {
            IdPartido = idPartido;
            Rival = rival;
            Fecha = fecha;
            Hora = hora;
            Activo = activo;
        }
        public Partidos()
        {
        }

        //Getter
        public int getIdPartido()
        {
            return IdPartido;
        }
        public string getRival()
        {
            return Rival;
        }
        public DateTime getFecha()
        {
            return Fecha;
        }
        public string getHora()
        {
            return Hora;
        }
        public Boolean getActivo()
        {
            return Activo;

        }
        //Setter

        public void setIdPartido(int idPartido)
        {
            this.IdPartido = IdPartido;

        }
        public void setRival(string rival)
        {
            this.Rival = Rival;
        }
        public void setFecha(DateTime fecha)
        {
            this.Fecha = Fecha;
        }
        public void setHora(string hora)
        {
            this.Hora = Hora;
        }
        public void setActivo(Boolean activo)
        {
            this.Activo = Activo;
        }

        public override string ToString()
        {
            return IdPartido + " - " + Rival + " - " +
                   Fecha.ToShortDateString() + " - " + Hora;
        }

    }
 }

       
