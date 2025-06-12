namespace Programa05_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Image miImagen = Image.FromFile("yts.png");

            picImagen.Image = miImagen;
        }
    }
}
