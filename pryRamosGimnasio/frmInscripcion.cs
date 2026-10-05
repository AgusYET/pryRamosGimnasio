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

            
            }

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
    }
}
