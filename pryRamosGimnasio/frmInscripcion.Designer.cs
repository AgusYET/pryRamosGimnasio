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
            grbFormaDePago.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("SimSun-ExtG", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(184, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INSCRIPCION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(124, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 16);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblEdad.Location = new Point(144, 133);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(53, 16);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad: ";
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblPlanes.Location = new Point(149, 163);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(48, 16);
            lblPlanes.TabIndex = 4;
            lblPlanes.Text = "Plan: ";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblTurno.Location = new Point(138, 193);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(60, 16);
            lblTurno.TabIndex = 5;
            lblTurno.Text = "Turno: ";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblMeses.Location = new Point(138, 226);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(61, 16);
            lblMeses.TabIndex = 6;
            lblMeses.Text = "Meses: ";
            // 
            // lblFormaDePago
            // 
            lblFormaDePago.AutoSize = true;
            lblFormaDePago.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold);
            lblFormaDePago.Location = new Point(76, 321);
            lblFormaDePago.Name = "lblFormaDePago";
            lblFormaDePago.Size = new Size(131, 16);
            lblFormaDePago.TabIndex = 8;
            lblFormaDePago.Text = "Formas de Pago: ";
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(203, 161);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 4;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Location = new Point(203, 190);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(204, 95);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
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
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(204, 126);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(38, 23);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // chbCasillero
            // 
            chbCasillero.AutoSize = true;
            chbCasillero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbCasillero.Location = new Point(162, 258);
            chbCasillero.Name = "chbCasillero";
            chbCasillero.Size = new Size(115, 34);
            chbCasillero.TabIndex = 7;
            chbCasillero.Text = "Casillero";
            chbCasillero.UseVisualStyleBackColor = true;
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
            grbFormaDePago.Controls.Add(rdbTarjeta);
            grbFormaDePago.Controls.Add(cboCuotas);
            grbFormaDePago.Controls.Add(rdbEfectivo);
            grbFormaDePago.Location = new Point(203, 298);
            grbFormaDePago.Name = "grbFormaDePago";
            grbFormaDePago.Size = new Size(293, 81);
            grbFormaDePago.TabIndex = 9;
            grbFormaDePago.TabStop = false;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstudiante.Location = new Point(248, 126);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(102, 24);
            chkEstudiante.TabIndex = 3;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(139, 418);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 53);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(270, 418);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 53);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(203, 219);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 6;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 495);
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
    }
}
