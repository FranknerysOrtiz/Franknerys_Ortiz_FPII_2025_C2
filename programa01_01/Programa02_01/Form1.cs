namespace Programa02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a todos");

            // MessageBox.Show("Hola a todos", "Mi MessageBox");

           DialogResult r = MessageBox.Show("Probando botones", "Diferentes botonos", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            if (r == DialogResult.Abort)
                lblMensaje.Text = "Anular";
            if (r == DialogResult.Retry)
                lblMensaje.Text = "Reintentar";
            if (r == DialogResult.Ignore)
                lblMensaje.Text = "Omitir";

        }
    }
}
