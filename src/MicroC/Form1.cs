using ReaLTaiizor.Forms;

namespace MicroC
{
    public partial class Form1 : CrownForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crownMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de C (*.c)|*.c|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Abrir código fuente";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCodigo.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                txtCodigo.ReadOnly = true;
                this.Text = "MicroC - " + openFileDialog.SafeFileName;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodigo.ReadOnly = false;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCodigo.ReadOnly = false;
            this.Text = "MicroC - NuevoArch.c";
            txtConsola.Text = "[Compilación en desarrollo]";
        }
    }
}
