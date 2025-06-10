using System.Diagnostics.Eventing.Reader;

namespace Szamosszeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Számok összeadása";
        }

        private void btnOsszead_Click(object sender, EventArgs e)
        {
            double szam1, szam2;
            if (double.TryParse(tbSzam1.Text, out szam1)
                &&
                double.TryParse(tbSzam2.Text, out szam2))
            {
                labelEredmeny.Text = (szam1 + szam2).ToString();
            }
            else 
            { 
                MessageBox.Show("Érvénytelen számformátum!", "Hiba"); 
            }
        }
    }
}
