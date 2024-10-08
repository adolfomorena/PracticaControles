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
            tbPgPreferencias = new TabPage();
            tbPgVisualizacion = new TabPage();
            numudEdad = new NumericUpDown();
            lblFecha = new Label();
            mthcldFecha = new MonthCalendar();
            pnlGeneros = new Panel();
            lblGenero = new Label();
            txbEmail = new TextBox();
            lblEmail = new Label();
            txbDireccion = new TextBox();
            lblDireccion = new Label();
            txbNombre = new TextBox();
            lblNombre = new Label();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            rbOtro = new RadioButton();
            lblEdad = new Label();
            tbCntrl.SuspendLayout();
            tbPgDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numudEdad).BeginInit();
            pnlGeneros.SuspendLayout();
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
            // tbPgPreferencias
            // 
            tbPgPreferencias.Location = new Point(4, 29);
            tbPgPreferencias.Name = "tbPgPreferencias";
            tbPgPreferencias.Padding = new Padding(3);
            tbPgPreferencias.Size = new Size(777, 453);
            tbPgPreferencias.TabIndex = 1;
            tbPgPreferencias.Text = "Preferencias";
            tbPgPreferencias.UseVisualStyleBackColor = true;
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
            // lblEdad
            // 
            lblEdad.Location = new Point(508, 327);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(142, 25);
            lblEdad.TabIndex = 20;
            lblEdad.Text = "Selecciona tu Edad";
            lblEdad.Click += lblEdad_Click;
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
    }
}
