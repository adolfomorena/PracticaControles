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




        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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


    }
}
