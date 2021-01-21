using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.ClientesForms
{
    public partial class FBajaCliente : Form
    {
        public FBajaCliente()
        {
            InitializeComponent();
            //Ejemplo de desactivación de campo del UC
            this.ucDatos.tbNombre.Enabled = false;
        }
    }
}
