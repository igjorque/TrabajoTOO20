using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.VehiculosForms;
using Aplicacion.ClientesForms;
using Negocio;
using Dominio;
using Implementacion;
using Aplicacion.PresupuestosForms;

namespace Aplicacion
{
    public partial class FPrincipal : Form
    {
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public FPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsConsultarCliente.
        /// Gestiona la operación de consulta de un cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsConsultarCliente_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("DNI del cliente: ");
            DialogResult dr = fc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ClienteDTO1 c = new ClienteDTO1(fc.Clave);
                if (GestionCliente.existeCliente(c))
                {
                    FBuscarCliente fbc = new FBuscarCliente(GestionCliente.consultarCliente(c));
                    fbc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente con DNI " + fc.Clave + ".", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsAltaCliente.
        /// Gestiona la operación de alta de un nuevo cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsAltaCliente_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("DNI del cliente: ");
            DialogResult dr = fc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ClienteDTO1 c = new ClienteDTO1(fc.Clave);
                if (!GestionCliente.existeCliente(c))
                {
                    FAltaCliente fac = new FAltaCliente(c.Dni);
                    fac.ucDatos.tbDni.Text = fc.Clave; //Establece el valor del campo al introducido anteriormente
                    fac.ucDatos.tbDni.Enabled = false; //Evita que este valor se pueda cambiar
                    DialogResult dr2 = fac.ShowDialog();
                    if (dr2 == DialogResult.OK)
                    {
                        GestionCliente.altaCliente(fac.Client);
                        MessageBox.Show("El cliente se ha añadido correctamente.", "Cliente añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Ya existe un cliente con DNI " + fc.Clave + ".", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsBajaCliente.
        /// Gestiona la operación de baja de un cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBajaCliente_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("DNI del cliente: ");
            DialogResult dr = fc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ClienteDTO1 c = new ClienteDTO1(fc.Clave);
                if (GestionCliente.existeCliente(c))
                {
                    FBajaCliente fbc = new FBajaCliente(GestionCliente.consultarCliente(c));
                    DialogResult dr2 = fbc.ShowDialog();
                    if (dr2 == DialogResult.Yes)
                    {
                        GestionCliente.bajaCliente(fbc.Client);
                        MessageBox.Show("El cliente se ha eliminado correctamente.", "Cliente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("No se ha encontrado el cliente con DNI " + fc.Clave + ".", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsListarClientes.
        /// Gestiona la operación de listado de todos los clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsListarClientes_Click(object sender, EventArgs e)
        {
            FListarClientes flc = new FListarClientes();
            flc.ShowDialog();
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsAltaVehiculo.
        /// Gestiona la operación de alta de un nuevo vehículo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsAltaVehiculo_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("Número de bastidor:");
            DialogResult dr1 = fc.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                if (!GestionVehiculo.existeVehiculo(new VehiculoDTO1(fc.Clave)))
                {
                    FAltaVehiculo fav = new FAltaVehiculo();
                    fav.ucDatos.tbBastidor.Text = fc.Clave;
                    DialogResult dr2 = fav.ShowDialog();
                    if (dr2 == DialogResult.OK)
                    {
                        GestionVehiculo.altaVehiculo(fav.Vehic);
                        MessageBox.Show("El vehículo se ha añadido correctamente.", "Vehículo añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El vehículo con el número de bastidor '" + fc.Clave + "' ya existe.", "El vehículo ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsBajaVehiculo.
        /// Gestiona la operación de baja lógica de un vehículo (cambia su stock a false - no disponible)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBajaVehiculo_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("Número de bastidor:");

            DialogResult drbuscar = fc.ShowDialog();
            if (drbuscar == DialogResult.OK)
            {
                VehiculoDTO1 vdto = new VehiculoDTO1(fc.Clave);
                Vehiculo v = GestionVehiculo.consultarVehiculo(vdto);
                if (v != null)
                {
                    FBajaVehiculo fbv = new FBajaVehiculo(v);

                    DialogResult drbaja = fbv.ShowDialog();
                    if (drbaja == DialogResult.OK)
                    {
                        GestionVehiculo.bajaVehiculo(vdto);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el vehículo con número de bastidor " + fc.Clave + ".", "Vehículo no encontrado",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsConsultarVehiculo.
        /// Gestiona la operación de consulta de un vehículo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsConsultarVehiculo_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("Número de bastidor:");

            DialogResult dr = fc.ShowDialog();

            if (dr == DialogResult.OK)
            {
                VehiculoDTO1 v = new VehiculoDTO1(fc.Clave);
                if (GestionVehiculo.existeVehiculo(v))
                {
                    FConsultarVehiculo fcv = new FConsultarVehiculo(GestionVehiculo.consultarVehiculo(v));
                    fcv.Show();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el vehículo con número de bastidor " + fc.Clave + ".", "Vehículo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsListarVehiculos.
        /// Gestiona la operación de listado de todos los vehículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsListarVehiculos_Click(object sender, EventArgs e)
        {
            List<Vehiculo> lv = GestionVehiculo.listarVehiculos();
            if (lv.Count == 0)
            {
                MessageBox.Show("No hay vehículos almacenados en la BD.", "Sin vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FListarVehiculos flv = new FListarVehiculos(lv);
                flv.Show();
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsAltaPresupuesto.
        /// Gestiona la creación de un nuevo presupuesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsAltaPresupuesto_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("ID Presupuesto:");
            DialogResult dr = fc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PresupuestoDTO1 pdto = new PresupuestoDTO1(fc.Clave);
                if (GestionPresupuesto.consultarPresupuesto(pdto) != null)
                {
                    MessageBox.Show("El presupuesto con ID " + fc.Clave + " ya existe.", "Presupuesto existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FAltaPresupuesto fap = new FAltaPresupuesto();
                    fap.tbIDPresupuesto.Text = fc.Clave;
                    DialogResult dr1 = fap.ShowDialog();
                    if (dr1 == DialogResult.OK)
                    {
                        GestionPresupuesto.altaPresupuesto(fap.Presu);
                        MessageBox.Show("El presupuesto se ha añadido correctamente.", "Presupuesto añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsConsultarPresupuesto.
        /// Gestiona la operación de consulta de un presupuesto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsConsultarPresupuesto_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("ID del presupuesto:");
            DialogResult dr = fc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Presupuesto p = GestionPresupuesto.consultarPresupuesto(new PresupuestoDTO1(fc.Clave));
                if(p != null)
                {
                    FConsultarPresupuesto fcp = new FConsultarPresupuesto(p);
                    fcp.Show();
                }
                else
                {
                    MessageBox.Show("El presupuesto no existe.", "Presupuesto inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsListarPresupuesto.
        /// Gestiona la operación de listado de todos los presupuestos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsListarPresupuestos_Click(object sender, EventArgs e)
        {
            FListarPresupuestos flp = new FListarPresupuestos(GestionPresupuesto.listarPresupuestos());
            flp.Show();
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsListadoOrdenado.
        /// Abre un formulario que lista los clientes de manera ordenada dependiendo de su DNI, Nombre o importe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListadoOrdenado flo = new FListadoOrdenado();
            flo.Show();
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsConsultaPorDNI.
        /// Abre un formulario donde puedes ver un cliente seleccionando su DNI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBuscarClienteOtro fbco = new FBuscarClienteOtro();
            fbco.Show();
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsRecorrido.
        /// Abre un formulario donde puedes ver los clientes uno a uno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> lcaux = GestionCliente.listarClientes();
            if (lcaux.Count == 0)
            {
                MessageBox.Show("No hay clientes almacenados.", "Sin clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FRecorridoCliente frc = new FRecorridoCliente(lcaux);
                frc.Show();
            }
            
        }

        /// <summary>
        /// Método de respuesta al evento de click en el menú tsImporteCliente.
        /// Devuelve un mensaje con el importe del cliente con el DNI introducido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsImporteCliente_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("ID Cliente (DNI):");
            DialogResult dr = fc.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ClienteDTO1 cdto = new ClienteDTO1(fc.Clave);
                if (GestionCliente.existeCliente(cdto))
                {
                    MessageBox.Show("El importe total del cliente " + fc.Clave + " es " + GestionCliente.getPresupuestos(cdto), "Importe total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente introducido no existe", "Cliente inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
