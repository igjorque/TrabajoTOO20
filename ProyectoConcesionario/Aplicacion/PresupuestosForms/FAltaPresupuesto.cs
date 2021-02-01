using Aplicacion.ClientesForms;
using Aplicacion.VehiculosForms;
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
        /// Si el cliente introducido no existe, preguntará si el usuario desea crearlo.
        /// Si alguno de los vehículos cuyo número de bastidor se introduce en las líneas del presupuesto no existe, preguntará si el usuario desea crearlo.
        /// Si no se introducen líneas al presupuesto, preguntará si el usuario desea introducir alguna.
        /// En caso de que se cancele cualquiera de los anteriores mensajes de error, se cancelará la operación y se cerrará el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAceptar_Click(object sender, EventArgs e)
        {
            string aux;
            DialogResult drx = DialogResult.OK;
            int j;
            for (int i = 0; i < this.dgLineas.Rows.Count-1; i++) // Comprobamos que el valor del estado de cada línea sea correcto.
            {
                aux = this.dgLineas.Rows[i].Cells[3].Value.ToString().ToUpper();
                if (aux != "A" && aux != "ACEPTADO" && aux != "P" && aux != "PENDIENTE" && aux != "D" && aux != "DESESTIMADO")
                { // Comprueba que se haya introducido correctamente el estado en el datagrid. Si no es ninguno de los valores permitidos, informará al usuario y cancelará la operación, permitiendo modificarlos.
                    j = i + 1;
                    MessageBox.Show("El valor del estado en la línea " + j + " no es válido. Por favor, utilice 'A', 'P', 'D', 'Aceptado', 'Pendiente' o 'Desestimado'.",
                        "Estado introducido erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    drx = DialogResult.Cancel; // Cancela el resto de la operación para poder modificar los datos necesarios.
                }
            }
            if (drx == DialogResult.OK) // Si los datos son correctos... (no se cancela la operación)
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
                    for (int i = 0; i < this.dgLineas.Rows.Count-1; i++)
                    { // Recorre las líneas introducidas creando los objetos de tipo LineaPresupuesto y añadiendolos a la lista de los mismos.
                      // Cells -> 0: id linea, 1: id veh, 2: precio, 3: estado línea
                        string sdtov = this.dgLineas.Rows[i].Cells[1].Value.ToString();
                        VehiculoDTO1 vdto = new VehiculoDTO1(sdtov);
                        if (!GestionVehiculo.existeVehiculo(vdto))
                        { // Si no existe el vehículo introducido en cualquiera de las líneas de presupuesto, preguntará si el usuario desea crearlo.
                            DialogResult drveh = MessageBox.Show("El vehículo introducido en la línea " + i + " no existe. ¿Desea crearlo? Si no, se cancelará la operación.", "Vehículo inexistente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (drveh == DialogResult.OK)
                            { // Si acepta, creará el vehículo
                                FAltaVehiculo fav = new FAltaVehiculo();
                                fav.ucDatos.tbBastidor.Text = sdtov;
                                fav.ucDatos.tbBastidor.Enabled = false;
                                DialogResult drcv = fav.ShowDialog();
                                if (drcv == DialogResult.OK)
                                { // Si el formulario de creación tiene éxito, da de alta el vehículo en la BD.
                                    GestionVehiculo.altaVehiculo(fav.Vehic);

                                    // Y finalmente crea la línea correspondiente.
                                    elinea = DeterminaEstado(this.dgLineas.Rows[i].Cells[3].Value.ToString());
                                    lpaux = new LineaPresupuesto(this.dgLineas.Rows[i].Cells[0].Value.ToString(),
                                                                fav.Vehic,
                                                                float.Parse(this.dgLineas.Rows[i].Cells[2].Value.ToString()),
                                                                elinea);
                                    llp.Add(lpaux);
                                    if (elinea == Estado.Aceptado) // Si cualquiera de las líneas tiene por estado "Aceptado", entonces el estado del presupuesto será "Aceptado"
                                    {
                                        epresu = Estado.Aceptado;
                                    }
                                }
                            }
                            else // Si no se acepta, cancela la operación y cierra el formulario.
                            {
                                this.Close();
                            }
                        }
                        else // Si no, si el vehículo existe, crea la línea correspondiente.
                        {
                            elinea = DeterminaEstado(this.dgLineas.Rows[i].Cells[3].Value.ToString());
                            lpaux = new LineaPresupuesto(this.dgLineas.Rows[i].Cells[0].Value.ToString(),
                                                        GestionVehiculo.consultarVehiculo(new VehiculoDTO1(sdtov)),
                                                        float.Parse(this.dgLineas.Rows[i].Cells[2].Value.ToString()),
                                                        elinea);
                            llp.Add(lpaux);
                            if (elinea == Estado.Aceptado) // Si cualquiera de las líneas tiene por estado "Aceptado", entonces el estado del presupuesto será "Aceptado"
                            {
                                epresu = Estado.Aceptado;
                            }
                        }
                    } // Fin de la creación del listado de LineasPresupuesto
                    Cliente cl = GestionCliente.consultarCliente(new ClienteDTO1(this.tbIDCliente.Text));
                    if (cl == null) // Si el cliente no existe en la BD...
                    {
                        DialogResult dr = MessageBox.Show("El cliente introducido no existe. ¿Desea crearlo? Si no, se cancelará la operación.", "Cliente inexistente", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        { // Pregunta si desea crearlo. En caso afirmativo...
                            FAltaCliente fac = new FAltaCliente(this.tbIDCliente.Text);
                            DialogResult dr2 = fac.ShowDialog();
                            if (dr2 == DialogResult.OK) // Si el formulario de creación de cliente tiene éxito, prosigue creando el presupuesto y cierra el formulario.
                            {
                                GestionCliente.altaCliente(fac.Client);
                                this.presu = new Presupuesto(this.tbIDPresupuesto.Text,
                                                fac.Client,
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
        }

        /// <summary>
        /// Método auxiliar para determinar el estado de un presupuesto, en función de sus líneas.
        /// Si una de sus líneas tiene el estado "Aceptado", entonces el estado del presupuesto será aceptado.
        /// Si no, su estado será "Pendiente".
        /// </summary>
        /// <param name="estado">Cadena a convertir a tipo Estado.</param>
        /// <returns>Estado equivalente.</returns>
        private Estado DeterminaEstado(string est)
        {
            string estado = est.ToUpper();
            if (estado == "ACEPTADO" || estado == "A")
            {
                return Estado.Aceptado;
            }
            else if (estado == "PENDIENTE" || estado == "P")
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
