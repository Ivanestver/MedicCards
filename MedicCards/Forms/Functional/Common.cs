using System;
using System.Windows.Forms;

namespace MedicCards
{
    public partial class Common : Form
    {
        public Common()
        {
            InitializeComponent();
        }

        private void every_Click(object sender, EventArgs e)
        {
            Hide();
            new Main().Show();
        }

        private void searchNumbers_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchNumbers().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchName_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchNames().Show();
        }

        private void birth_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchBirth().Show();
        }

        private void handover_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchHandOver().Show();
        }

        private void arrive_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchArrive().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new SearchThereIs().Show();
        }

        private void Common_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
