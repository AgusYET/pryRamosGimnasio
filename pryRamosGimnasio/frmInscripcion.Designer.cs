namespace pryRamosGimnasio
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblPlanes = new Label();
            lblTurno = new Label();
            lblMeses = new Label();
            lblFormaDePago = new Label();
            cboPlan = new ComboBox();
            cboTurno = new ComboBox();
            txtNombre = new TextBox();
            rdbEfectivo = new RadioButton();
            rdbTarjeta = new RadioButton();
            txtEdad = new TextBox();
            chbCasillero = new CheckBox();
            cboCuotas = new ComboBox();
            grbFormaDePago = new GroupBox();
            chkEstudiante = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            txtMeses = new TextBox();
            btnConsultar = new Button();
            lstClientes = new ListBox();
            grbFormaDePago.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("SimSun-ExtG", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Red;
            lblTitulo.Location = new Point(128, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INSCRIPCION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.Red;
            lblNombre.Location = new Point(65, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 16);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblEdad.ForeColor = Color.Red;
            lblEdad.Location = new Point(85, 103);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(53, 16);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad: ";
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.BackColor = Color.Transparent;
            lblPlanes.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblPlanes.ForeColor = Color.Red;
            lblPlanes.Location = new Point(90, 133);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(48, 16);
            lblPlanes.TabIndex = 4;
            lblPlanes.Text = "Plan: ";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblTurno.ForeColor = Color.Red;
            lblTurno.Location = new Point(79, 163);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(60, 16);
            lblTurno.TabIndex = 5;
            lblTurno.Text = "Turno: ";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.BackColor = Color.Transparent;
            lblMeses.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblMeses.ForeColor = Color.Red;
            lblMeses.Location = new Point(79, 196);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(61, 16);
            lblMeses.TabIndex = 6;
            lblMeses.Text = "Meses: ";
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.BackColor = Color.Transparent;
            lblFormaDePago.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblFormaDePago.ForeColor = Color.Red;
            lblFormaDePago.Location = new Point(20, 302);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(131, 16);
            lblFormaDePago.TabIndex = 8;
            lblFormaDePago.Text = "Formas de Pago: ";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(144, 131);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 4;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Location = new Point(144, 160);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(145, 65);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rdbEfectivo.Location = new Point(21, 17);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(100, 29);
            rdbEfectivo.TabIndex = 0;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            rdbTarjeta.Location = new Point(127, 17);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(90, 29);
            rdbTarjeta.TabIndex = 1;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Trajeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            rdbTarjeta.CheckedChanged += rbdTarjeta_CheckedChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(145, 96);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(38, 23);
            txtEdad.TabIndex = 2;
            txtEdad.TextChanged += txtNombre_TextChanged;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // chbCasillero
            // 
            chbCasillero.AutoSize = true;
            chbCasillero.BackColor = Color.Transparent;
            chbCasillero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbCasillero.ForeColor = Color.Red;
            chbCasillero.Location = new Point(68, 239);
            chbCasillero.Name = "chbCasillero";
            chbCasillero.Size = new Size(115, 34);
            chbCasillero.TabIndex = 7;
            chbCasillero.Text = "Casillero";
            chbCasillero.UseVisualStyleBackColor = false;
            // 
            // cboCuotas
            // 
            cboCuotas.Enabled = false;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(160, 52);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 2;
            // 
            // grbFormaDePago
            // 
            grbFormaDePago.BackColor = Color.Transparent;
            grbFormaDePago.Controls.Add(rdbTarjeta);
            grbFormaDePago.Controls.Add(cboCuotas);
            grbFormaDePago.Controls.Add(rdbEfectivo);
            grbFormaDePago.ForeColor = Color.Red;
            grbFormaDePago.Location = new Point(147, 279);
            grbFormaDePago.Name = "grbFormaDePago";
            grbFormaDePago.Size = new Size(293, 81);
            grbFormaDePago.TabIndex = 9;
            grbFormaDePago.TabStop = false;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.BackColor = Color.Transparent;
            chkEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstudiante.ForeColor = Color.Red;
            chkEstudiante.Location = new Point(189, 96);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(102, 24);
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Enabled = false;
            btnCalcular.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(315, 366);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 53);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(147, 366);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 53);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(144, 189);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 6;
            txtMeses.TextChanged += txtNombre_TextChanged;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.White;
            btnConsultar.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(105, 529);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(225, 55);
            btnConsultar.TabIndex = 12;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lstClientes
            // 
            lstClientes.BackColor = Color.White;
            lstClientes.FormattingEnabled = true;
            lstClientes.HorizontalScrollbar = true;
            lstClientes.Location = new Point(3, 425);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(463, 94);
            lstClientes.TabIndex = 13;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fitnet;
            ClientSize = new Size(461, 596);
            Controls.Add(lstClientes);
            Controls.Add(btnConsultar);
            Controls.Add(txtMeses);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkEstudiante);
            Controls.Add(grbFormaDePago);
            Controls.Add(chbCasillero);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(cboTurno);
            Controls.Add(cboPlan);
            Controls.Add(lblFormaDePago);
            Controls.Add(lblMeses);
            Controls.Add(lblTurno);
            Controls.Add(lblPlanes);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo--Inscripcion";
            Load += frmInscripcion_Load;
            grbFormaDePago.ResumeLayout(false);
            grbFormaDePago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPlanes;
        private Label lblTurno;
        private Label lblMeses;
        private Label lblFormaDePago;
        private ComboBox cboPlan;
        private ComboBox cboTurno;
        private TextBox txtNombre;
        private RadioButton rdbEfectivo;
        private RadioButton rdbTarjeta;
        private TextBox txtEdad;
        private CheckBox chbCasillero;
        private ComboBox cboCuotas;
        private GroupBox grbFormaDePago;
        private CheckBox chkEstudiante;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TextBox txtMeses;
        private Button btnConsultar;
        private ListBox lstClientes;
    }
}
