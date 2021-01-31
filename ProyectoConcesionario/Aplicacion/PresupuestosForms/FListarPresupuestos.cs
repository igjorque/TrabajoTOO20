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
    public partial class FListarPresupuestos : Form
    {
        private List<Presupuesto> lp;
        public FListarPresupuestos(List<Presupuesto> lp)
        {
            InitializeComponent();
            this.lp = lp;
            this.dgPresupuestos.DataSource = new BindingSource(new BindingList<Presupuesto>(this.lp), null);
        }
    }
}
