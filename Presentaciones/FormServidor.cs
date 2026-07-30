using Comunicaciones;
using Entidades;
using Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones
{
    public partial class FormServidor : Form
    {
        //delegados (Referencia a un metodo)
        private readonly Logica_Clientes LogicaCliente = new Logica_Clientes();
        private readonly Logica_Ventas LogicaVentas = new Logica_Ventas();
        private readonly Logica_Partidos logica_Partidos = new Logica_Partidos();
        private readonly Logica_localidades logica_Localidades = new Logica_localidades();

        private readonly Logica_LocalidadXPartido logicaLocalidadPartido = new Logica_LocalidadXPartido();
        private readonly Logica_Vendedores logica_Vendedores = new Logica_Vendedores();

        private readonly object bloqueoVentas = new object();
        private readonly ComunicacionTCP comunicacionTCP = new ComunicacionTCP();

        //Delegado, necesario para modificar controles de la interfaz gráfica desde un subproceso
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);

        //Declarar delegados
        private EscribirEnTextboxDelegado modificarTextotxtBitacora;
        private ModoficarListBoxDelegado modificarListBoxClientes;

        public ComunicacionTCP ComunicacionTCP => comunicacionTCP;

        public FormServidor()
        {
            InitializeComponent();
            //Suscribir el evento y los delegados
            ComunicacionTCP.MensajeRecibido += ComunicacionTCP_MensajeRecibido;

            modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);

            lblEstado.ForeColor = Color.Red;
            btnDetener.Enabled = false;
        }

        private void Servidor_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                ComunicacionTCP.Iniciar();

                lblEstado.ForeColor = Color.Green;
                lblEstado.Text = "Servidor iniciado";

                btnIniciar.Enabled = false;
                btnDetener.Enabled = true;

                txtBitacora.Text = "Servidor iniciado... en (127.0.0.1, 14500)";
                txtBitacora.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede iniciar el servidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            ComunicacionTCP.Detener();

            lblEstado.ForeColor = Color.Red;
            lblEstado.Text = "Servidor detenido";

            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void EscribirEnTextbox(string texto)
        {
            txtBitacora.AppendText(DateTime.Now.ToString() + " - " + texto);
            txtBitacora.AppendText(Environment.NewLine);
        }

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
                listConectados.Items.Add(texto);
            else
                listConectados.Items.Remove(texto);
        }

        private MensajeSocket<object> SeleccionarMetodo(string pMetodo, object entidad)
        {
            switch (pMetodo)
            {

                case "Conectar":
                    return Conectar((string)entidad);

                case "Desconectar":
                    return Desconectar((string)entidad);

                case "ValidarCliente":
                    return ValidarCliente((string)entidad);

                case "RegistrarVenta":
                    Ventas venta = JsonConvert.DeserializeObject<Ventas>(
                        JsonConvert.SerializeObject(entidad));
                    return RegistrarVenta(venta);

                case "ConsultarClientes":
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                        Entidad = LogicaCliente.Listar()
                    };

                case "ConsultarVendedores":
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                        Entidad = logica_Vendedores.Listar()
                    };

                case "ConsultarPartidos":
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                        Entidad = logica_Partidos.Listar()
                    };

                case "ConsultarCompras":
                    int idCliente = JsonConvert.DeserializeObject<int>(
                        JsonConvert.SerializeObject(entidad));
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                        Entidad = LogicaVentas.ListarPorCliente(idCliente)
                    };

                case "ConsultarLocalidades":
                    int idPartido = JsonConvert.DeserializeObject<int>(
                        JsonConvert.SerializeObject(entidad));
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                       Entidad = logicaLocalidadPartido.ObtenerPorPartido(idPartido)
                    };

                default:
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                        Entidad = "Método no reconocido."
                    };
            }
        }


        private MensajeSocket<object> Conectar(string cliente)
        {
            Invoke(modificarListBoxClientes, cliente, true);
            Invoke(modificarTextotxtBitacora, "Cliente conectado: " + cliente);

            return new MensajeSocket<object>
            {
                Metodo = "OK",
                Entidad = null
            };
        }
        private MensajeSocket<object> Desconectar(string cliente)
        {
            Invoke(modificarListBoxClientes, cliente, false);
            Invoke(modificarTextotxtBitacora, $"Cliente desconectado: {cliente}");
            return new MensajeSocket<object>
            {
                Metodo = "OK",
                Entidad = null
            };
        }

        private MensajeSocket<object> ValidarCliente(string identificacion)
        {
            Cliente cliente = LogicaCliente.ObtenerPorIdentificacion(identificacion);

            Invoke(modificarTextotxtBitacora,
                "Validación de cliente: " + identificacion);

            if (cliente == null)
            {
                return new MensajeSocket<object>
                {
                    Metodo = "ERROR",
                    Entidad = "Cliente no existe."
                };
            }

            if (!cliente.Activo)
            {
                return new MensajeSocket<object>
                {
                    Metodo = "ERROR",
                    Entidad = "Cliente inactivo."
                };
            }

            return new MensajeSocket<object>
            {
                Metodo = "OK",
                Entidad = cliente
            };
        }
        private void ComunicacionTCP_MensajeRecibido(object sender, (string mensaje, StreamWriter streamWriter) e)
        {
            try
            {
                Invoke(modificarTextotxtBitacora, "Mensaje recibido: " + e.mensaje);
                //
                if (string.IsNullOrEmpty(e.mensaje))
                {
                    return;
                }

                MensajeSocket<object> solicitud = JsonConvert.DeserializeObject<MensajeSocket<object>>(e.mensaje);
               
                MensajeSocket<object> respuesta = SeleccionarMetodo(solicitud.Metodo, solicitud.Entidad);

                e.streamWriter.WriteLine(JsonConvert.SerializeObject(respuesta));
                e.streamWriter.Flush();
            }
            catch (Exception ex)
            {

                Invoke(modificarTextotxtBitacora, "Error: " + ex.Message);

                try
                {
                    MensajeSocket<object> error = new MensajeSocket<object>
                    {
                        Metodo = "ERROR",
                        Entidad = "Error en el servidor: " + ex.Message
                    };

                    e.streamWriter.WriteLine(JsonConvert.SerializeObject(error));
                    e.streamWriter.Flush();
                }
                catch (Exception ex2)
                {
                    Invoke(modificarTextotxtBitacora,
                        "No fue posible enviar el mensaje de error al cliente: " + ex2.Message);
                    
                   
                }
            }
        }
        private MensajeSocket<object> RegistrarVenta(Ventas venta)
        {
            lock (bloqueoVentas)
            {
                try
                {
                    Cliente cliente = LogicaCliente.ObtenerPorIdentificacion(venta.Cliente.Identificacion);
                    if (cliente == null)
                    {
                        return new MensajeSocket<object>
                        {
                            Metodo = "ERROR",
                            Entidad = "Cliente no existe."
                        };
                    }

                    Vendedores vendedor = null;
                    if (venta.Vendedores != null)
                    {
                        vendedor = logica_Vendedores.ObtenerVendedor(venta.Vendedores.IdVendedor);
                        if (vendedor == null)
                        {
                            return new MensajeSocket<object>
                            {
                                Metodo = "ERROR",
                                Entidad = "Vendedor no existe."
                            };

                        }
                    }

                    // Se reemplazan los objetos recibidos del cliente por los reales de la base de datos:
                    // evita que el cliente falsifique precios, descuentos o datos de otro cliente.
                    venta.Cliente = cliente;
                    venta.Vendedores = vendedor;

                    string resultado = LogicaVentas.Agregar(venta);
                    Invoke(modificarTextotxtBitacora, string.IsNullOrEmpty(resultado)
                        ? "Venta registrada para " + cliente.Identificacion
                        : "Venta rechazada: " + resultado);

                    if (!string.IsNullOrEmpty(resultado))
                    {
                        return new MensajeSocket<object>
                        {
                            Metodo = "ERROR",
                            Entidad = resultado
                        };
                       
                    }
                    return new MensajeSocket<object>
                    {
                        Metodo = "OK",
                        Entidad = "Venta registrada correctamente."
                    };
                    
                }
                catch (Exception ex)
                {
                    Invoke(modificarTextotxtBitacora, "Error registrando venta: " + ex.Message);

                    return new MensajeSocket<object>
                    {
                        Metodo = "ERROR",
                        Entidad = "Error al registrar la venta."
                    };
                }  
            }
        }
    }
}
 

        