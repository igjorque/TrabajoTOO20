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
    public partial class FBajaVehiculo : Form
    {
        private Vehiculo vehiculo;

        /// <summary>
        /// Constructor del formulario. Recibe el vehículo para mostrar todos sus datos antes de hacer la baja lógica del mismo.
        /// </summary>
        /// <param name="veh"></param>
        public FBajaVehiculo(Vehiculo veh)
        {
            InitializeComponent();
            this.vehiculo = veh;

            this.ucDatos.tbBastidor.Text = this.vehiculo.Bastidor;
            this.ucDatos.tbBastidor.Enabled = false;
            this.ucDatos.tbMarca.Text = this.vehiculo.Marca;
            this.ucDatos.tbMarca.Enabled = false;
            this.ucDatos.tbModelo.Text = this.vehiculo.Modelo;
            this.ucDatos.tbModelo.Enabled = false;
            this.ucDatos.tbPotencia.Text = this.vehiculo.Potencia.ToString();
            this.ucDatos.tbPotencia.Enabled = false;
            this.ucDatos.tbPrecioRec.Text = this.vehiculo.PrecioRec.ToString();
            this.ucDatos.tbPrecioRec.Enabled = false;
            this.ucDatos.btCancelar.Dispose();
            this.ucDatos.rbNuevo.Enabled = false;
            this.ucDatos.rbUsado.Enabled = false;

            if (this.vehiculo.getTipo() == Tipo.Nuevo)
            {
                this.ucDatos.rbNuevo.Select();
                ucDatosVehiculoNuevo ucn = new ucDatosVehiculoNuevo();
                Nuevo vn = this.vehiculo as Nuevo;
                ucn.Name = "ucDatosNuevo";
                ucn.Location = new Point(300, 95);
                ucn.dgExtras.DataSource = new BindingSource(new BindingList<Extra>(vn.Extra), null);
                ucn.dgExtras.ReadOnly = true;
                this.Controls.Add(ucn);
                ucn.Show();
                ucn.BringToFront();
            }
            else // Es Tipo.Usado
            {
                this.ucDatos.rbUsado.Select();
                ucDatosVehiculoUsado ucu = new ucDatosVehiculoUsado();
                Usado vu = this.vehiculo as Usado;
                ucu.Name = "ucDatosUsado";
                ucu.Location = new Point(300, 100);
                ucu.tbMatricula.Text = vu.Matricula;
                ucu.tbFechaMatriculacion.Text = vu.FechaMatricula.ToString("yyyy/MM/dd");
                ucu.tbFechaMatriculacion.Enabled = false;
                ucu.tbMatricula.Enabled = false;
                this.Controls.Add(ucu);
                ucu.Show();
                ucu.BringToFront();
            }
        }
    }
}
