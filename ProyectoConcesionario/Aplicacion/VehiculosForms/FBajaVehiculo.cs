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

        public FBajaVehiculo(Vehiculo veh)
        {
            InitializeComponent();
            this.vehiculo = veh;

            this.ucDatos.tbBastidor.Text = this.vehiculo.Bastidor;
            this.ucDatos.tbMarca.Text = this.vehiculo.Marca;
            this.ucDatos.tbModelo.Text = this.vehiculo.Modelo;
            this.ucDatos.tbPotencia.Text = this.vehiculo.Potencia.ToString();
            this.ucDatos.tbPrecioRec.Text = this.vehiculo.PrecioRec.ToString();
            this.ucDatos.Enabled = false;

            if (this.vehiculo.getTipo() == Tipo.Nuevo)
            {
                this.ucDatos.rbNuevo.Select();
                ucDatosVehiculoNuevo ucn = new ucDatosVehiculoNuevo();
                Nuevo vn = this.vehiculo as Nuevo;
                ucn.Name = "ucDatosNuevo";
                ucn.Location = new Point(300, 95);
                ucn.dgExtras.DataSource = vn.Extra; // Revisar cómo mostrar lista de extras con datagrid
                ucn.Enabled = false;
                this.Controls.Add(ucn);
                ucn.Show();
            }
            else // Es Tipo.Usado
            {
                this.ucDatos.rbUsado.Select();
                ucDatosVehiculoUsado ucu = new ucDatosVehiculoUsado();
                Usado vu = this.vehiculo as Usado;
                ucu.Name = "ucDatosNuevo";
                ucu.Location = new Point(300, 100);
                ucu.tbMatricula.Text = vu.Matricula;
                ucu.tbFechaMatriculacion.Text = vu.FechaMatricula.ToString();
                ucu.Enabled = false;
                this.Controls.Add(ucu);
                ucu.Show();
            }
        }
    }
}
