using testeForm.Forms;

namespace testeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrarPet_Click(object sender, EventArgs e)
        {
            CadastroPets form = new CadastroPets();
            form.ShowDialog();
        }

        private void btCadastrarDono_Click(object sender, EventArgs e)
        {
            CadastroDonos form = new CadastroDonos();
            form.ShowDialog();
        }

        private void btPets_Click(object sender, EventArgs e)
        {
            ListaPets form = new ListaPets();
            form.ShowDialog();
        }

        private void btDonos_Click(object sender, EventArgs e)
        {
            ListarDonos form = new ListarDonos();
            form.ShowDialog();
        }
    }
}
