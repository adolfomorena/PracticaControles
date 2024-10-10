namespace PracticaControles
{
    public partial class frmInicio : Form
    {
        String nombre;
        String direccion;
        String email;
        String genero;
        int edad;
        String fechaNacimiento;
        List<String> listaHobbies = new List<String>();
        String suscripcion;
        decimal satisfaccion;
        String pais;




        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //PAGINA 1 *****

        //nombre
        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txbNombre.Text;
        }
        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        //direccion
        private void txbDireccion_TextChanged(object sender, EventArgs e)
        {
            direccion = txbDireccion.Text;
        }

        //email
        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            email = txbEmail.Text;
        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        //genero
        private void pnlGeneros_Paint(object sender, PaintEventArgs e)
        {
            if (rbMasculino.Checked)
            {
                genero = rbMasculino.Text;
            }
            else if (rbFemenino.Checked)
            {
                genero = rbFemenino.Text;
            }
            else
            {
                genero = rbOtro.Text;
            }
        }

        //fechaNacimiento
        private void mthcldFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            mthcldFecha.RemoveAllBoldedDates();
            DateTime fecha = e.Start;
            fechaNacimiento = fecha.ToShortDateString();
            mthcldFecha.AddBoldedDate(fecha);
        }

        //edad
        private void numudEdad_ValueChanged(object sender, EventArgs e)
        {
            edad = (int)numudEdad.Value;
        }

        private void tbPgPreferencias_Click(object sender, EventArgs e)
        {

        }

        //hobbies
        private void cklListHobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaHobbies.Clear();

            foreach (var item in cklListHobbies.CheckedItems)
            {
                listaHobbies.Add((String)item);
            }

        }

        //suscripcion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (chkbSi.Checked)
            {
                suscripcion = chkbSi.Text;
            }
            else
            {
                suscripcion = chkbNo.Text;
            }
        }

        //satisfaccion
        private void trkBarSatisfaccion_Scroll(object sender, EventArgs e)
        {

            satisfaccion = trkBarSatisfaccion.Value;
        }

        //pais
        private void cmBoxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            pais = (String)cmBoxPaises.SelectedItem;
        }
    }
}
