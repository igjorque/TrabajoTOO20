using Aplicacion.ClientesForms;
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
        /// <summary>
        /// Atributo para almacenar el presupuesto que se cree mediante este formulario.
        /// </summary>
        private Presupuesto presu;

        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        public FAltaPresupuesto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Propiedad para obtener el presupuesto creado mediante el formulario.
        /// </summary>
        public Presupuesto Presu
        {
            get { return this.presu; }
        }

        /// <summary>
        /// Método de respuesta al evento de click en el botón "btAceptar".
        /// Intenta crear un presupuesto a partir de los datos introducidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            List<LineaPresupuesto> llp = new List<LineaPresupuesto>();
            LineaPresupuesto lpaux = null;
            Estado elinea = Estado.Pendiente, epresu = Estado.Pendiente;
            if (this.dgLineas.Rows.Count == 0) // Si no se han introducido líneas, pregunta si se desean introducir o si se cancela la operación
            {
                DialogResult dr0 = MessageBox.Show("No se han introducido líneas al presupuesto. ¿Desea introducirlas? Si no, se cancelará la operación.", "Sin líneas de presupuesto", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr0 == DialogResult.Cancel) // Si decide cancelar la operación, cierra el formulario. En caso contrario, el método no hará nada más.
                {
                    this.Close();
                }
            }
            else // Si se ha introducido al menos una línea...
            {
                for (int i = 0; i < this.dgLineas.Rows.Count; i++)
                { // Recorre las líneas introducidas creando los objetos de tipo LineaPresupuesto y añadiendolos a la lista de los mismos.
                    elinea = DeterminaEstado(this.dgLineas.Rows[i].Cells["clEstado"].Value.ToString());
                    lpaux = new LineaPresupuesto(this.dgLineas.Rows[i].Cells["clIDLinea"].Value.ToString(),
                                                GestionVehiculo.consultarVehiculo(new VehiculoDTO1(this.dgLineas.Rows[i].Cells["clIDVehiculo"].Value.ToString())),
                                                float.Parse(this.dgLineas.Rows[i].Cells["clPrecio"].Value.ToString()),
                                                elinea);
                    llp.Add(lpaux);
                    if (elinea == Estado.Aceptado) // Si cualquiera de las líneas tiene por estado "Aceptado", entonces el estado del presupuesto será "Aceptado"
                    {
                        epresu = Estado.Aceptado;
                    }
                }
                Cliente cl = GestionCliente.consultarCliente(new ClienteDTO1(this.tbIDCliente.Text));
                if (cl == null) // Si el cliente no existe en la BD...
                {
                    DialogResult dr = MessageBox.Show("El cliente introducido no existe. ¿Desea crearlo? Si no, se cancelará la operación.", "Cliente inexistente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    { //Pregunta si desea crearlo. En caso afirmativo...
                        FAltaCliente fac = new FAltaCliente(this.tbIDCliente.Text);
                        DialogResult dr2 = fac.ShowDialog();
                        if (dr2 == DialogResult.OK) // Si el formulario de creación de cliente tiene éxito, prosigue creando el presupuesto y cierra el formulario.
                        {
                            GestionCliente.altaCliente(fac.Client);
                            this.presu = new Presupuesto(this.tbIDPresupuesto.Text,
                                            cl,
                                            StringToDate(this.tbFecha.Text),
                                            llp,
                                            epresu);
                            this.Close();
                        }
                    }
                    else // En caso contrario, cancela la operación y cierra el formulario.
                    {
                        this.Close();
                    }
                }
                else // Si todo está en orden (cliente existente, etc.) prosigue creando el presupuesto y cierra el formulario.
                {
                    this.presu = new Presupuesto(this.tbIDPresupuesto.Text,
                                            cl,
                                            StringToDate(this.tbFecha.Text),
                                            llp,
                                            epresu);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Método auxiliar para determinar el estado de un presupuesto, en función de sus líneas.
        /// Si una de sus líneas tiene el estado "Aceptado", entonces el estado del presupuesto será aceptado.
        /// Si no, su estado será "Pendiente".
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método auxiliar para convertir una cadena en una DateTime.
        /// </summary>
        /// <param name="s">Cadena a convertir</param>
        /// <returns>DateTime equivalente</returns>
        private DateTime StringToDate(string s)
        {
            string[] ss = s.Split('/');
            int y, m, d;
            int.TryParse(ss[0], out y);
            int.TryParse(ss[1], out m);
            int.TryParse(ss[2], out d);
            return new DateTime(y, m, d);
        }

        /// <summary>
        /// Cancela la operación y cierra el formulario,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Valida el campo de tbFecha para que solo acepte valores con un formato específico y coherentes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFecha_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = StringToDate(this.tbFecha.Text);
            if (dt.Year < 0 || dt.Year > int.MaxValue || dt.Month > 12 || dt.Month <= 0 || dt.Day > 31 || dt.Day <= 0)
            {
                this.epFecha.SetError(tbFecha, "El formato no es correcto. Utilice Año/Mes/Dia con valores coherentes.");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Si se valida el campo, elimina cualquier error que hubiera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFecha_Validated(object sender, EventArgs e)
        {
            this.epFecha.Clear();
        }
    }
}
