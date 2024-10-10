namespace PracticaControles
{
    partial class frmInicio
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
            tbCntrl = new TabControl();
            tbPgDatos = new TabPage();
            lblEdad = new Label();
            numudEdad = new NumericUpDown();
            lblFecha = new Label();
            mthcldFecha = new MonthCalendar();
            pnlGeneros = new Panel();
            rbOtro = new RadioButton();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            lblGenero = new Label();
            txbEmail = new TextBox();
            lblEmail = new Label();
            txbDireccion = new TextBox();
            lblDireccion = new Label();
            txbNombre = new TextBox();
            lblNombre = new Label();
            tbPgPreferencias = new TabPage();
            lblSatisfaccion = new Label();
            trkBarSatisfaccion = new TrackBar();
            lblPais = new Label();
            cmBoxPaises = new ComboBox();
            lblHobbies = new Label();
            cklListHobbies = new CheckedListBox();
            lblSuscripcion = new Label();
            panel1 = new Panel();
            chkbNo = new CheckBox();
            chkbSi = new CheckBox();
            tbPgVisualizacion = new TabPage();
            tbCntrl.SuspendLayout();
            tbPgDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numudEdad).BeginInit();
            pnlGeneros.SuspendLayout();
            tbPgPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkBarSatisfaccion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbCntrl
            // 
            tbCntrl.Controls.Add(tbPgDatos);
            tbCntrl.Controls.Add(tbPgPreferencias);
            tbCntrl.Controls.Add(tbPgVisualizacion);
            tbCntrl.Location = new Point(31, 23);
            tbCntrl.Name = "tbCntrl";
            tbCntrl.SelectedIndex = 0;
            tbCntrl.Size = new Size(785, 486);
            tbCntrl.TabIndex = 0;
            // 
            // tbPgDatos
            // 
            tbPgDatos.Controls.Add(lblEdad);
            tbPgDatos.Controls.Add(numudEdad);
            tbPgDatos.Controls.Add(lblFecha);
            tbPgDatos.Controls.Add(mthcldFecha);
            tbPgDatos.Controls.Add(pnlGeneros);
            tbPgDatos.Controls.Add(txbEmail);
            tbPgDatos.Controls.Add(lblEmail);
            tbPgDatos.Controls.Add(txbDireccion);
            tbPgDatos.Controls.Add(lblDireccion);
            tbPgDatos.Controls.Add(txbNombre);
            tbPgDatos.Controls.Add(lblNombre);
            tbPgDatos.Location = new Point(4, 29);
            tbPgDatos.Name = "tbPgDatos";
            tbPgDatos.Padding = new Padding(3);
            tbPgDatos.Size = new Size(777, 453);
            tbPgDatos.TabIndex = 0;
            tbPgDatos.Text = "Datos Personales";
            tbPgDatos.UseVisualStyleBackColor = true;
            // 
            // lblEdad
            // 
            lblEdad.Location = new Point(508, 327);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(142, 25);
            lblEdad.TabIndex = 20;
            lblEdad.Text = "Selecciona tu Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // numudEdad
            // 
            numudEdad.Location = new Point(531, 366);
            numudEdad.Name = "numudEdad";
            numudEdad.Size = new Size(96, 27);
            numudEdad.TabIndex = 19;
            numudEdad.TextAlign = HorizontalAlignment.Center;
            numudEdad.Value = new decimal(new int[] { 33, 0, 0, 0 });
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(455, 53);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(243, 25);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Selecciona tu Fecha de Nacimiento";
            // 
            // mthcldFecha
            // 
            mthcldFecha.Location = new Point(465, 87);
            mthcldFecha.Name = "mthcldFecha";
            mthcldFecha.TabIndex = 17;
            // 
            // pnlGeneros
            // 
            pnlGeneros.Controls.Add(rbOtro);
            pnlGeneros.Controls.Add(rbFemenino);
            pnlGeneros.Controls.Add(rbMasculino);
            pnlGeneros.Controls.Add(lblGenero);
            pnlGeneros.Location = new Point(64, 237);
            pnlGeneros.Name = "pnlGeneros";
            pnlGeneros.Size = new Size(294, 105);
            pnlGeneros.TabIndex = 16;
            // 
            // rbOtro
            // 
            rbOtro.AutoSize = true;
            rbOtro.Location = new Point(216, 47);
            rbOtro.Name = "rbOtro";
            rbOtro.Size = new Size(60, 24);
            rbOtro.TabIndex = 5;
            rbOtro.TabStop = true;
            rbOtro.Text = "Otro";
            rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(115, 47);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(95, 24);
            rbFemenino.TabIndex = 4;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(12, 47);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(97, 24);
            rbMasculino.TabIndex = 3;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            lblGenero.Location = new Point(0, 9);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(62, 25);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Género:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(154, 179);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(152, 27);
            txbEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(64, 182);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 25);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(154, 131);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(152, 27);
            txbDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(64, 134);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(84, 25);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Dirección:";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(154, 84);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(152, 27);
            txbNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(64, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 25);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // tbPgPreferencias
            // 
            tbPgPreferencias.Controls.Add(lblSatisfaccion);
            tbPgPreferencias.Controls.Add(trkBarSatisfaccion);
            tbPgPreferencias.Controls.Add(lblPais);
            tbPgPreferencias.Controls.Add(cmBoxPaises);
            tbPgPreferencias.Controls.Add(lblHobbies);
            tbPgPreferencias.Controls.Add(cklListHobbies);
            tbPgPreferencias.Controls.Add(lblSuscripcion);
            tbPgPreferencias.Controls.Add(panel1);
            tbPgPreferencias.Location = new Point(4, 29);
            tbPgPreferencias.Name = "tbPgPreferencias";
            tbPgPreferencias.Padding = new Padding(3);
            tbPgPreferencias.Size = new Size(777, 453);
            tbPgPreferencias.TabIndex = 1;
            tbPgPreferencias.Text = "Preferencias";
            tbPgPreferencias.UseVisualStyleBackColor = true;
            tbPgPreferencias.Click += tbPgPreferencias_Click;
            // 
            // lblSatisfaccion
            // 
            lblSatisfaccion.AutoSize = true;
            lblSatisfaccion.Location = new Point(538, 258);
            lblSatisfaccion.Name = "lblSatisfaccion";
            lblSatisfaccion.Size = new Size(188, 20);
            lblSatisfaccion.TabIndex = 11;
            lblSatisfaccion.Text = "Satisfacción con el Servicio";
            // 
            // trkBarSatisfaccion
            // 
            trkBarSatisfaccion.Location = new Point(538, 304);
            trkBarSatisfaccion.Name = "trkBarSatisfaccion";
            trkBarSatisfaccion.Size = new Size(188, 56);
            trkBarSatisfaccion.TabIndex = 10;
            trkBarSatisfaccion.Scroll += trkBarSatisfaccion_Scroll;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(316, 78);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(130, 20);
            lblPais.TabIndex = 9;
            lblPais.Text = "Pais de Residencia";
            // 
            // cmBoxPaises
            // 
            cmBoxPaises.FormattingEnabled = true;
            cmBoxPaises.Items.AddRange(new object[] { "España", "Cuba", "Alemania", "Brasil", "Italia", "Honduras", "Francia", "Argentina", "Beligica" });
            cmBoxPaises.Location = new Point(306, 101);
            cmBoxPaises.Name = "cmBoxPaises";
            cmBoxPaises.Size = new Size(151, 28);
            cmBoxPaises.TabIndex = 8;
            cmBoxPaises.SelectedIndexChanged += cmBoxPaises_SelectedIndexChanged;
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.Location = new Point(115, 78);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(65, 20);
            lblHobbies.TabIndex = 7;
            lblHobbies.Text = "Hobbies";
            // 
            // cklListHobbies
            // 
            cklListHobbies.CheckOnClick = true;
            cklListHobbies.FormattingEnabled = true;
            cklListHobbies.Items.AddRange(new object[] { "Lectura", "Deportes", "Viajes", "Cine", "Música", "Pintura", "Cocina" });
            cklListHobbies.Location = new Point(42, 101);
            cklListHobbies.Name = "cklListHobbies";
            cklListHobbies.Size = new Size(209, 246);
            cklListHobbies.TabIndex = 6;
            cklListHobbies.SelectedIndexChanged += cklListHobbies_SelectedIndexChanged;
            // 
            // lblSuscripcion
            // 
            lblSuscripcion.AutoSize = true;
            lblSuscripcion.Location = new Point(554, 78);
            lblSuscripcion.Name = "lblSuscripcion";
            lblSuscripcion.Size = new Size(160, 20);
            lblSuscripcion.TabIndex = 5;
            lblSuscripcion.Text = "¿Suscribirse al Boletín?";
            // 
            // panel1
            // 
            panel1.Controls.Add(chkbNo);
            panel1.Controls.Add(chkbSi);
            panel1.Location = new Point(554, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 48);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // chkbNo
            // 
            chkbNo.AutoSize = true;
            chkbNo.Location = new Point(90, 12);
            chkbNo.Name = "chkbNo";
            chkbNo.Size = new Size(51, 24);
            chkbNo.TabIndex = 1;
            chkbNo.Text = "No";
            chkbNo.UseVisualStyleBackColor = true;
            // 
            // chkbSi
            // 
            chkbSi.AutoSize = true;
            chkbSi.Location = new Point(25, 12);
            chkbSi.Name = "chkbSi";
            chkbSi.Size = new Size(43, 24);
            chkbSi.TabIndex = 0;
            chkbSi.Text = "Sí";
            chkbSi.UseVisualStyleBackColor = true;
            // 
            // tbPgVisualizacion
            // 
            tbPgVisualizacion.Location = new Point(4, 29);
            tbPgVisualizacion.Name = "tbPgVisualizacion";
            tbPgVisualizacion.Padding = new Padding(3);
            tbPgVisualizacion.Size = new Size(777, 453);
            tbPgVisualizacion.TabIndex = 2;
            tbPgVisualizacion.Text = "Visualización";
            tbPgVisualizacion.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 540);
            Controls.Add(tbCntrl);
            Name = "frmInicio";
            Text = "Gestión Avanzada de Información Personal";
            Load += Form1_Load;
            tbCntrl.ResumeLayout(false);
            tbPgDatos.ResumeLayout(false);
            tbPgDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numudEdad).EndInit();
            pnlGeneros.ResumeLayout(false);
            pnlGeneros.PerformLayout();
            tbPgPreferencias.ResumeLayout(false);
            tbPgPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkBarSatisfaccion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbCntrl;
        private TabPage tbPgDatos;
        private TabPage tbPgPreferencias;
        private TabPage tbPgVisualizacion;
        private NumericUpDown numudEdad;
        private Label lblFecha;
        private MonthCalendar mthcldFecha;
        private Panel pnlGeneros;
        private RadioButton rbOtro;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private Label lblGenero;
        private TextBox txbEmail;
        private Label lblEmail;
        private TextBox txbDireccion;
        private Label lblDireccion;
        private TextBox txbNombre;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblSuscripcion;
        private Panel panel1;
        private CheckBox chkbNo;
        private CheckBox chkbSi;
        private Label lblPais;
        private ComboBox cmBoxPaises;
        private Label lblHobbies;
        private CheckedListBox cklListHobbies;
        private Label lblSatisfaccion;
        private TrackBar trkBarSatisfaccion;
    }
}
