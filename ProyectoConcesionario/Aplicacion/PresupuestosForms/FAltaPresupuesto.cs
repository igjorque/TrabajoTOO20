using Dominio;
using Implementacion;
using Negocio;
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
    public partial class FAltaPresupuesto : Form
    {
        private Presupuesto presu;
        public FAltaPresupuesto()
        {
            InitializeComponent();
        }

        public Presupuesto Presu
        {
            get { return this.presu; }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            List<LineaPresupuesto> llp = new List<LineaPresupuesto>();
            LineaPresupuesto lpaux;
            Estado elinea, epresu = Estado.Pendiente;

            for(int i = 0; i<this.dgLineas.Rows.Count; i++)
            {
                elinea = DeterminaEstado(this.dgLineas.Rows[i].Cells["clEstado"].Value.ToString());
                lpaux = new LineaPresupuesto(this.dgLineas.Rows[i].Cells["clIDLinea"].Value.ToString(), 
                                            GestionVehiculo.consultarVehiculo(new VehiculoDTO1(this.dgLineas.Rows[i].Cells["clIDVehiculo"].Value.ToString())), 
                                            float.Parse(this.dgLineas.Rows[i].Cells["clPrecio"].Value.ToString()),
                                            elinea);
                llp.Add(lpaux);
                if (elinea == Estado.Aceptado)
                {
                    epresu = Estado.Aceptado;
                }
            }
            this.presu = new Presupuesto(this.tbIDPresupuesto.Text,
                                        GestionCliente.consultarCliente(new ClienteDTO1(this.tbIDCliente.Text)),
                                        StringToDate(this.tbFecha.Text),
                                        llp,
                                        epresu);
        }
        private Estado DeterminaEstado(string estado)
        {
            if (estado == "Aceptado")
            {
                return Estado.Aceptado;
            }
            else if (estado == "Pendiente")
            {
                return Estado.Pendiente;
            }
            else
            {
                return Estado.Desestimado;
            }
        }
        private DateTime StringToDate(string s)
        {
            string[] ss = s.Split('/');
            int y, m, d;
            int.TryParse(ss[0], out y);
            int.TryParse(ss[1], out m);
            int.TryParse(ss[2], out d);
            return new DateTime(y, m, d);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFecha_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = StringToDate(this.tbFecha.Text);
            if (dt.Year < 0 || dt.Year > int.MaxValue || dt.Month > 12 || dt.Month <= 0 || dt.Day > 31 || dt.Day <= 0)
            {
                this.epFecha.SetError(tbFecha, "El formato no es correcto. Utilice Año/Mes/Dia con valores coherentes.");
                e.Cancel = true;
            }
        }

        private void tbFecha_Validated(object sender, EventArgs e)
        {
            this.epFecha.Clear();
        }
    }
}
