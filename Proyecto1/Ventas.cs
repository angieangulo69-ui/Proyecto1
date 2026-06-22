using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Universidad:UNED
II Cuatrimestre
Proyecto I
Descripción: Esta clase representa la venta,cuenta con constructores para la 
reación de objetos, atributos y propiedades que permiten el acceso a los datos de una forma segura.
Estudiante: Angie Angulo Chacón 
Fecha:21/06/2026
*/
namespace Entidades
{
    public class Ventas
    {
        //Atributos de la clase
        private int idVenta;
        private Clientes clientes;  //Cliente que realiza la compra
        private Partidos partidos;
        private Localidades localidades;       
        private Vendedores vendedores;
        private int cantidad;
        private DateTime fechaVenta;
        private Decimal montoTotal;
        private string tipoVenta = "Boleteria";

        //Constructor: inicializa el objeto con valores proporcionados
        public Ventas(int idVenta, Clientes clientes, Partidos partidos, Localidades localidades, int cantidad, Vendedores vendedores, DateTime fechaVenta, decimal montoTotal)
        {
            IdVenta = idVenta;
            this.Clientes = clientes;
            this.Partidos = partidos;
            this.Localidades = localidades;
            this.Cantidad = cantidad;
            this.Vendedores = vendedores;
            FechaVenta = fechaVenta;
            MontoTotal = montoTotal;
        }
        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Ventas()
        {

        }

        //Propiedades nos permiten acceder a los datos de forma segura
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public Clientes Clientes { get => clientes; set => clientes = value; }
        public Partidos Partidos { get => partidos; set => partidos = value; }
        public Localidades Localidades { get => localidades; set => localidades = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Vendedores Vendedores { get => vendedores; set => vendedores = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public string TipoVenta { get => tipoVenta; set => tipoVenta = value; }
     
    }

        
}
