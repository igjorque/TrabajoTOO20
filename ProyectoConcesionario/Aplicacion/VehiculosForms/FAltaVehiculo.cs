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
    public partial class FAltaVehiculo : Form
    {
        private Vehiculo vehic;

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public FAltaVehiculo()
        {
            InitializeComponent();
            this.ucDatos.tbBastidor.Enabled = false;
            this.ucDatos.rbNuevo.CheckedChanged += new EventHandler(this.rbCheckedChanged);
            this.ucDatos.rbUsado.CheckedChanged += new EventHandler(this.rbCheckedChanged);
            this.ucDatos.btAceptar.Click += new EventHandler(this.CrearVehiculo);
        }

        /// <summary>
        /// Propiedad para obtener el vehículo creado mediante el formulario.
        /// </summary>
        public Vehiculo Vehic
        {
            get
            {
                return this.vehic;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (this.ucDatos.rbNuevo.Checked == true)
            {
                if (this.Controls.ContainsKey("ucDatosUsado"))
                {
                    this.Controls.RemoveByKey("ucDatosUsado");
                }
                ucDatosVehiculoNuevo ucn = new ucDatosVehiculoNuevo();
                ucn.Name = "ucDatosNuevo";
                ucn.Location = new Point(300, 95);
                this.Controls.Add(ucn);
                ucn.Show();
                ucn.BringToFront();
            }
            else
            {
                if (this.Controls.ContainsKey("ucDatosNuevo"))
                {
                    this.Controls.RemoveByKey("ucDatosNuevo");
                }
                ucDatosVehiculoUsado ucu = new ucDatosVehiculoUsado();
                ucu.Name = "ucDatosUsado";
                ucu.Location = new Point(300, 100);
                
                this.Controls.Add(ucu);
                ucu.Show();
                ucu.BringToFront();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrearVehiculo(object sender, EventArgs e)
        {
            if (this.ucDatos.rbNuevo.Checked)
            {
                ucDatosVehiculoNuevo ucdn = this.Controls["ucDatosNuevo"] as ucDatosVehiculoNuevo;
                List<Extra> le = new List<Extra>();
                string nombre;
                float precio;
                Extra ex;
                for (int i = 0; i < ucdn.dgExtras.Rows.Count-1; i++)
                {
                    nombre = ucdn.dgExtras.Rows[i].Cells["clNombre"].Value.ToString();
                    precio = float.Parse(ucdn.dgExtras.Rows[i].Cells["clPrecio"].Value.ToString());
                    ex = new Extra(nombre, precio);
                    le.Add(ex);
                }
                Nuevo n = new Nuevo(this.ucDatos.tbBastidor.Text, this.ucDatos.tbMarca.Text, this.ucDatos.tbModelo.Text, int.Parse(this.ucDatos.tbPotencia.Text), double.Parse(this.ucDatos.tbPrecioRec.Text), true, le);
                this.vehic = n;
            }
            else
            {
                ucDatosVehiculoUsado ucdu = this.Controls["ucDatosUsado"] as ucDatosVehiculoUsado;
                string [] fecha = ucdu.tbFechaMatriculacion.Text.Split('/');
                DateTime dt = new DateTime(int.Parse(fecha[0]), int.Parse(fecha[1]), int.Parse(fecha[2]));
                Usado u = new Usado(this.ucDatos.tbBastidor.Text, this.ucDatos.tbMarca.Text, this.ucDatos.tbModelo.Text, int.Parse(this.ucDatos.tbPotencia.Text), double.Parse(this.ucDatos.tbPrecioRec.Text), true, ucdu.tbMatricula.Text, dt);
                this.vehic = u;
            }
        }
    }
}
