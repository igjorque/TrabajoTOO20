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
    public partial class FListarVehiculos : Form
    {
        private BindingList<Vehiculo> blv;

        public FListarVehiculos(List<Vehiculo> lv)
        {
            InitializeComponent();
            this.blv = new BindingList<Vehiculo>(lv);
            BindingSource bsv = new BindingSource(this.blv, null);
            this.dgVehiculos.DataSource = bsv;
        }
    }
}
