using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace MicroC
{
    public partial class Form1 : CrownForm
    {
        string rutaArchivoActual = "";

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
                rutaArchivoActual = openFileDialog.FileName;
                this.Text = "MicroC - " + openFileDialog.FileName;
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
            rutaArchivoActual = "";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaArchivoActual == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de C (*.c)|*.c|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar código fuente";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoActual = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(rutaArchivoActual, txtCodigo.Text);

                    this.Text = "MicroC - " + rutaArchivoActual;
                }
            }
            else
            {
                System.IO.File.WriteAllText(rutaArchivoActual, txtCodigo.Text);
                CrownMessageBox.ShowInformation("Archivo guardado correctamente", "Guardar");
            }
        }
    }
}
