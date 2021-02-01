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

namespace Aplicacion.PresupuestosForms
{
    public partial class FConsultarPresupuesto : Form
    {
        private Presupuesto presu;

        /// <summary>
        /// Constructor del formulario. Muestra los datos del presupuesto recibido como parámetro.
        /// </summary>
        /// <param name="p"></param>
        public FConsultarPresupuesto(Presupuesto p)
        {
            InitializeComponent();
            this.presu = p;
            this.tbIDPresupuesto.Text = this.presu.Id;
            this.tbIDCliente.Text = this.presu.Client.Dni;
            this.tbFecha.Text = this.presu.Fecha.ToString("yyyy/MM/dd");
            foreach (LineaPresupuesto lp in this.presu.Lineas)
            {
                this.dgLineas.Rows.Add(lp.IdLinea, lp.VehiculoPr.Bastidor, lp.Precio, lp.EstadoLinea);
            }
        }

        /// <summary>
        /// Al hacer click en el botón aceptar, se cerrará el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
