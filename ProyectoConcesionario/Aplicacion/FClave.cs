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

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        /// <param name="texto">Texto para el label</param>
        public FClave(string texto)
        {
            InitializeComponent();
            this.clave = "";
            this.lbClave.Text = texto;
        }

        /// <summary>
        /// Propiedad para obtener la clave introducida en el formulario.
        /// </summary>
        public string Clave
        {
            get { return this.clave; }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el botón Buscar.
        /// Almacena el valor introducido en el textbox y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.clave = this.tbClave.Text;
            this.Close();
        }

        /// <summary>
        /// Método de respuesta al evento de click en el botón Cancelar.
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
