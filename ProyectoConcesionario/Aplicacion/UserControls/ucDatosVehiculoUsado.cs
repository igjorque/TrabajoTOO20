using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplicacion.UserControls
{
    public partial class ucDatosVehiculoUsado : UserControl
    {
        public ucDatosVehiculoUsado()
        {
            InitializeComponent();
        }

        private void tbFechaMatriculacion_Validating(object sender, CancelEventArgs e)
        {
            string[] s = this.tbFechaMatriculacion.Text.Split('/');
            int y, m, d;
            int.TryParse(s[0], out y);
            int.TryParse(s[1], out m);
            int.TryParse(s[2], out d);
            if (y<0 || y > int.MaxValue || m > 12 || m == 0 || d > 31 || d == 0)
            {
                epFecha.SetError(tbFechaMatriculacion, "El formato no es correcto. Utilice Año/Mes/Dia con valores coherentes.");
                e.Cancel = true;
            }
        }

        private void tbFechaMatriculacion_Validated(object sender, EventArgs e)
        {
            epFecha.Clear();
        }
    }
}
