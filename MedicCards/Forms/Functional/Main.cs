using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MedicCards
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        sbyte row;

        private void Main_Load(object sender, EventArgs e)
        {
            l();

            new Change().Add(dataGridView1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            new Common().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new Addition().Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            new Change().Delete(dataGridView1, row);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = (sbyte)e.RowIndex;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = (sbyte)e.RowIndex;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue)
                    list.Add(i);

            new Change().Delete(dataGridView1, list);

            new Change().Add(dataGridView1);
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue)
                {
                    n = i;
                    break;
                }
            }

            Hide();
            new Update(n, dataGridView1, Name).Show();
        }

        private void Main_ClientSizeChanged(object sender, EventArgs e)
        {
            l();
        }

        private void l()
        {
            dataGridView1.Size = new Size(ClientSize.Width - 60, ClientSize.Height - 100);
            dataGridView1.Location = new Point(30, ClientSize.Height / 2 - 10 - dataGridView1.Height / 2);
            back.Location = new Point(dataGridView1.Right - back.Width, dataGridView1.Bottom + 15);

            changing.Width = (int)(0.1 * dataGridView1.Width);
            archiev.Width = (int)(0.1 * dataGridView1.Width);
            number.Width = (int)(0.2 * dataGridView1.Width);
            name.Width = (int)(0.2 * dataGridView1.Width);
            birth.Width = (int)(0.1 * dataGridView1.Width);
            handOver.Width = (int)(0.1 * dataGridView1.Width);
            arriving.Width = (int)(0.1 * dataGridView1.Width);
            notes.Width = (int)(0.2 * dataGridView1.Width);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
