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

namespace Aplicacion
{
    public partial class FPrincipal : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsListarClientes_Click(object sender, EventArgs e)
        {
            FListarClientes flc = new FListarClientes();
            flc.ShowDialog();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
                    fcv.ShowDialog();
                }
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsListarVehiculos_Click(object sender, EventArgs e)
        {
            List<Vehiculo> lv = GestionVehiculo.listarVehiculos();
            FListarVehiculos flv = new FListarVehiculos(lv);
            flv.ShowDialog();
        }

    }
}
