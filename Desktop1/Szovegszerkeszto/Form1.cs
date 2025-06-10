namespace Szovegszerkeszto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text (*.txt) | *.txt | Rich text (*.rtf) | *.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                rtb.SaveFile(saveFileDialog1.FileName);
            }

        }
    }
}
