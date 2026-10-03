namespace pryRamosGimnasio
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
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
        string nombre, edad, turno, meses, pago;
        const int MUSCULACION = 15000;
        const int FUNCIONAL = 18000;
        const int NATACION = 22000;
        const int CASILLERO = 3000;
        int Edad, Meses;

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= 47 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad, meses, pago;
            decimal precioPlan;
            decimal precioTurno;

        }
    }
}
