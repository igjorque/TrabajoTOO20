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
using Negocio;
using Dominio;
using Implementacion;

namespace Aplicacion
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
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

        }
    }
}
