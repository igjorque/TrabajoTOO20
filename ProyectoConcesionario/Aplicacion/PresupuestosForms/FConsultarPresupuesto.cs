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
        public FConsultarPresupuesto(Presupuesto p)
        {
            InitializeComponent();
            this.presu = p;
            this.tbIDPresupuesto.Text = this.presu.Id;
            this.tbIDCliente.Text = this.presu.Client.Dni;
            this.tbFecha.Text = this.presu.Fecha.ToString("yyyy/MM/dd");
            this.dgLineas.DataSource = new BindingSource(new BindingList<LineaPresupuesto>(this.presu.Lineas), null);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
