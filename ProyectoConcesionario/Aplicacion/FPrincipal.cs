using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.VehiculosForms;
using Negocio;
using Dominio;
using Implementacion;

namespace Aplicacion
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void tsBajaVehiculo_Click(object sender, EventArgs e)
        {
            FClave fc = new FClave("Número de bastidor:");

            DialogResult drbuscar = fc.ShowDialog();
            if (drbuscar == DialogResult.OK)
            {
                VehiculoDTO1 vdto = new VehiculoDTO1(fc.Clave);
                Vehiculo v = GestionVehiculo.consultarVehiculo(vdto);
                FBajaVehiculo fbv = new FBajaVehiculo(v);

                DialogResult drbaja = fbv.DialogResult;
                if (drbaja == DialogResult.OK)
                {
                    GestionVehiculo.bajaVehiculo(vdto);
                }
            }
        }
    }
}
