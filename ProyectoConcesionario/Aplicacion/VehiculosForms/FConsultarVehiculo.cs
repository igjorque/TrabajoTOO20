using Aplicacion.UserControls;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.VehiculosForms
{
    public partial class FConsultarVehiculo : Form
    {
        /// <summary>
        /// Constructor del formulario. Recibe un objeto de tipo Vehículo para mostrar todos sus datos.
        /// </summary>
        /// <param name="v"></param>
        public FConsultarVehiculo(Vehiculo v)
        {
            InitializeComponent();
            this.ucDatos.Enabled = false;
            DatosVehiculo(v);
            if (v.getTipo() == Tipo.Nuevo)
            {
                Nuevo n = v as Nuevo;
                this.ucDatos.rbNuevo.Checked = true;
                ucDatosVehiculoNuevo ucn = new ucDatosVehiculoNuevo();
                ucn.Name = "ucDatosNuevo";
                ucn.Location = new Point(300, 95);
                this.Controls.Add(ucn);
                ucn.Enabled = false;
                ucn.Show();
                ucn.BringToFront();

                int i = 0;
                ucn.dgExtras.Rows.Add(n.Extra.Count);
                foreach (Extra e in n.Extra)
                {
                    ucn.dgExtras.Rows[i].Cells["clNombre"].Value = e.Nombre;
                    ucn.dgExtras.Rows[i].Cells["clPrecio"].Value = e.Precio;
                    i++;
                }
                
            }
            else
            {
                Usado u = v as Usado;
                this.ucDatos.rbUsado.Checked = true;
                ucDatosVehiculoUsado ucu = new ucDatosVehiculoUsado();
                ucu.Name = "ucDatosUsado";
                ucu.Location = new Point(300, 100);
                this.Controls.Add(ucu);
                ucu.Enabled = false;
                ucu.Show();
                ucu.BringToFront();

                ucu.tbMatricula.Text = u.Matricula;
                ucu.tbFechaMatriculacion.Text = u.FechaMatricula.ToString();
            }
        }

        /// <summary>
        /// Método auxiliar para establecer los datos del vehículo en los textbox correspondientes.
        /// </summary>
        /// <param name="v"></param>
        private void DatosVehiculo(Vehiculo v)
        {
            this.ucDatos.tbBastidor.Text = v.Bastidor;
            this.ucDatos.tbMarca.Text = v.Marca;
            this.ucDatos.tbModelo.Text = v.Modelo;
            this.ucDatos.tbPotencia.Text = v.Potencia.ToString();
            this.ucDatos.tbPrecioRec.Text = v.PrecioRec.ToString();
        }
    }
}
