using System.Numerics;

namespace pryRamosGimnasio
{
    public partial class frmInscripcion : Form
    {
        string nombre, edad, turno, meses, pago;
        const int MUSCULACION = 15000;
        const int FUNCIONAL = 18000;
        const int NATACION = 22000;
        const int CASILLERO = 3000;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        const decimal DESCUENTO_MENOR_EDAD = 0.25m;
        const decimal RECARGO_TARJETA = 0.10m;
        const decimal RECARGO_CASILLERO = 0.05m;
        
        int Edad, Meses;
        public frmInscripcion()
        {
            InitializeComponent();

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }


        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Clear();
            cboPlan.SelectedIndex = -1;
            cboTurno.SelectedIndex = -1;
            rdbEfectivo.Checked = false;
            rdbTarjeta.Checked = false;
            chbCasillero.Checked = false;
            chkEstudiante.Checked = false;

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
            cboCuotas.Items.Add("1");
            cboCuotas.Items.Add("3");
            cboCuotas.Items.Add("6");
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Funcional");
            cboPlan.Items.Add("Natación");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string meses = txtMeses.Text;
            string turno = cboTurno.SelectedIndex.ToString();
            string plan = cboPlan.SelectedItem.ToString();
            string pago = rdbEfectivo.Checked ? "Efectivo" : "Tarjeta";
            bool casillero = chbCasillero.Checked;
            bool estudiante = chkEstudiante.Checked;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edad) || string.IsNullOrEmpty(meses) || string.IsNullOrEmpty(turno) || string.IsNullOrEmpty(plan))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Edad = int.Parse(edad);
            Meses = int.Parse(meses);
            int costoPlan = 0;
            switch (plan)
            {
                case "Musculación":
                    costoPlan = MUSCULACION;
                    break;
                case "Funcional":
                    costoPlan = FUNCIONAL;
                    break;
                case "Natación":
                    costoPlan = NATACION;
                    break;
            }
            switch (turno)
            {
                case "0":
                    turno = "Mañana";
                    break;
                case "1":
                    turno = "Tarde";
                    break;
                case "2":
                    turno = "Noche";
                    break;
            }

            if (Edad < 18)
            {
                edad = "Menor de edad";
                if (Edad <= 14)
                {
                    MessageBox.Show("No se permite la inscripción de menores de 14 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPlan.Enabled = false;
                    txtEdad.Clear();
                    txtEdad.Focus();
                }
                else
                {
                    if (Edad >= 65)
                    {
                        edad = "Adulto mayor";
                    }

                }

            }

            if (rdbEfectivo.Checked)
            {
                pago = "Efectivo";
            }
            else 
            {
               int cuotas = int.Parse(cboCuotas.Text);
                if (cuotas == 1)
                {
                    pago = "Efectivo";
                }
                else if (cuotas == 3)
                {
                    pago = "Tarjeta - 3 cuotas";
                }
                else if (cuotas == 6)
                {
                    pago = "Tarjeta - 6 cuotas";
                }
            }

            string categoria = (Edad < 18) ? "Menor de edad" : (Edad >= 65) ? "Adulto mayor" : "Adulto";

            string textoPago = (rdbEfectivo.Checked) ? "Efectivo" : (cboCuotas.SelectedIndex != -1) ? $"Tarjeta - {cboCuotas.SelectedItem} cuotas" : "Tarjeta";

            Socio socio;
            socio.Nombre = nombre;
            socio.Edad = Edad;
            socio.Turno = turno;
            socio.Plan = plan;
            socio.Meses = Meses;
            socio.Pago = textoPago;
            socio.Casillero = casillero;
            socio.Estudiante = estudiante;

            string mensaje = "Nombre: " + socio.Nombre + "\n" +
                             "Edad: " + socio.Edad + "\n" +
                             "Categoría: " + categoria + "\n" +
                             "Turno: " + socio.Turno + "\n" +
                             "Plan: " + socio.Plan + "\n" +
                             "Meses: " + socio.Meses + "\n" +
                             "Pago: " + socio.Pago + "\n" +
                             "Casillero: " + (socio.Casillero ? "Sí" : "No") + "\n" +
                             "Estudiante: " + (socio.Estudiante ? "Sí" : "No");

            MessageBox.Show(mensaje, "Datos del Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "" && cboPlan.SelectedIndex != -1 && cboTurno.SelectedIndex != -1)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }

        }

        private void rbdTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }
    }

    public struct Socio
    {
        public string Nombre;
        public int Edad;
        public string Turno;
        public string Plan;
        public int Meses;
        public string Pago;
        public bool Casillero;
        public bool Estudiante;
    }

}
