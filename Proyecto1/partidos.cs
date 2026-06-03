using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class partidos
    {
        //Atributos

        private int IdPartido;
        private string Rival;
        private DateTime Fecha;
        private string Hora;
        private Boolean Activo;

        //Constructor
        public partidos(int idPartido, string rival, DateTime fecha, string hora, Boolean activo)
        {
            IdPartido = idPartido;
            Rival = rival;
            Fecha = fecha;
            Hora = hora;
            Activo = activo;
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
    }
 }

       
