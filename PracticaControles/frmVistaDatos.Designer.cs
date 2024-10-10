namespace PracticaControles
{
    partial class frmVistaDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDatos = new Label();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.Location = new Point(227, 56);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(282, 310);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "label1";
            // 
            // frmVistaDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDatos);
            Name = "frmVistaDatos";
            Text = "Datos Usuario";
            Load += frmVistaDatos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblDatos;
    }
}