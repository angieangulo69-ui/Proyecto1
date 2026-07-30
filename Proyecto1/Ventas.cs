using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        private Cliente cliente;  //Cliente que realiza la compra
        private Partidos partidos;
        private Localidades localidades;
        private Vendedores vendedores;
        private int cantidad;
        private DateTime fechaVenta;
        private Decimal montoTotal;
        private string tipoVenta;

        //Constructor: inicializa el objeto con valores proporcionados
        public Ventas(int idVenta, Cliente cliente, Partidos partidos, Localidades localidades, int cantidad, Vendedores vendedores, DateTime fechaVenta, decimal montoTotal, string tipoVenta)
        {
            IdVenta = idVenta;
            this.Cliente = cliente;
            this.Partidos = partidos;
            this.Localidades = localidades;
            this.Cantidad = cantidad;
            this.Vendedores = vendedores;
            FechaVenta = fechaVenta;
            MontoTotal = montoTotal;
            TipoVenta = tipoVenta;
        }
        // Constructor vacío: permite crear el objeto sin datos iniciales
        public Ventas()
        {

        }

        //Propiedades nos permiten acceder a los datos de forma segura
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Partidos Partidos { get => partidos; set => partidos = value; }
        public Localidades Localidades { get => localidades; set => localidades = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Vendedores Vendedores { get => vendedores; set => vendedores = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public string TipoVenta { get => tipoVenta; set => tipoVenta = value; }
     
    

     public override string ToString()
        {   
            return IdVenta + " - " + Partidos.Rival + " - " + Cliente.Nombre;
        }
    }
    
}