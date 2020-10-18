using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MedicCards
{
    public partial class SearchHandOver : Form
    {
        private sbyte row;

        public SearchHandOver()
        {
            InitializeComponent();
        }

        private void SearchHandOver_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Values.getIsFirstForHandOver())
            {
                l();
            }
            else
            {
                l();
                date.Text = Values.getNum();
                new Change().Add(dataGridView1, date, "Период_сдачи");
                count.Text = "Количество: " + dataGridView1.Rows.Count.ToString();
                Values.setIsFirstForHandOver(true);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            Values.setIsFirstForHandOver(false);
            new Change().Add(dataGridView1, date, "Период_сдачи");
            count.Text = "Количество: " + dataGridView1.Rows.Count.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Values.setIsFirstForHandOver(true);
            Hide();
            new Common().Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = 0;
            Values.setNum(date.Text);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = (sbyte)e.RowIndex;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = (sbyte)e.RowIndex;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            new Change().Delete(dataGridView1, row);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue)
                    list.Add(i);

            new Change().Delete(dataGridView1, list);
            date.Text = "";
            count.Text = "Количество: 0";
            dataGridView1.Rows.Clear();
        }

        private void l()
        {
            sbyte a = 5;
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, date.Top - a - label1.Height);
            date.Location = new Point(label1.Left, label1.Bottom + 5);
            search.Location = new Point(label1.Left + (label1.Width - search.Width) / 2, date.Bottom + a);
            dataGridView1.Location = new Point(30, search.Bottom + a);
            dataGridView1.Size = new Size(ClientSize.Width - 60, ClientSize.Height - search.Bottom + 3 - 105);
            back.Location = new Point(dataGridView1.Right - back.Width, dataGridView1.Bottom + 2 * a);
            count.Location = new Point(dataGridView1.Left, dataGridView1.Bottom + 5);

            changing.Width = (int)(0.1 * dataGridView1.Width);
            archiev.Width = (int)(0.1 * dataGridView1.Width);
            number.Width = (int)(0.2 * dataGridView1.Width);
            name.Width = (int)(0.2 * dataGridView1.Width);
            birth.Width = (int)(0.1 * dataGridView1.Width);
            handOver.Width = (int)(0.1 * dataGridView1.Width);
            arriving.Width = (int)(0.1 * dataGridView1.Width);
            notes.Width = (int)(0.2 * dataGridView1.Width);
        }

        private void SearchHandOver_ClientSizeChanged(object sender, EventArgs e)
        {
            l();
        }

        private void SearchHandOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
