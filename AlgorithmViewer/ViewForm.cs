using System;
using System.IO;
using System.Windows.Forms;

namespace AlgorithmViewer
{
    public partial class ViewForm : Form
    {
        private string fileName;

        public ViewForm()
        {
            InitializeComponent();
            fileName = Path.ChangeExtension(Application.ExecutablePath, ".alg");
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            if (Location.IsEmpty)
                CenterToScreen();
        }

        private void tsmiCreate_Click(object sender, EventArgs e)
        {
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
            }
        }

        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
