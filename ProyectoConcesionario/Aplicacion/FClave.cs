using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FClave : Form
    {
        private string clave;
        public FClave(string texto)
        {
            InitializeComponent();
            this.clave = "";
            this.lbClave.Text = texto;
        }

        public string Clave
        {
            get { return this.clave; }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.clave = this.lbClave.Text;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
