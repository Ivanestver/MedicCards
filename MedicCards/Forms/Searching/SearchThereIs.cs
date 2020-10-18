using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicCards
{
    public partial class SearchThereIs : Form
    {
        public SearchThereIs()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            new Common().Show();
        }

        private void SearchThereIs_Load(object sender, EventArgs e)
        {
            Placing();

            Db db = new Db();

            dataGridView1.Rows.Clear();

            db.getConnection().Open();

            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [MyTable] WHERE Архив = @yes ORDER BY Номер_карты", db.getConnection());
                command.Parameters.Add("@yes", OleDbType.VarChar).Value = "Да";

                OleDbDataReader reader = command.ExecuteReader();

                List<string[]> list = new List<string[]>();

                while (reader.Read())
                {
                    list.Add(new string[8]);

                    list[list.Count - 1][0] = reader[0].ToString();
                    list[list.Count - 1][1] = reader[1].ToString();
                    list[list.Count - 1][2] = reader[2].ToString();
                    list[list.Count - 1][3] = reader[3].ToString();
                    list[list.Count - 1][4] = reader[4].ToString();
                    list[list.Count - 1][5] = reader[5].ToString();
                    list[list.Count - 1][6] = reader[6].ToString();
                }

                if (list.Count != 0)
                {
                    count.Text = "Количество: " + list.Count.ToString();

                    foreach (var i in list)
                    {
                        dataGridView1.Rows.Add(i);
                    }
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            db.getConnection().Close();
        }

        private void SearchThereIs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchThereIs_ClientSizeChanged(object sender, EventArgs e)
        {
            Placing();
        }

        private void Placing()
        {
            dataGridView1.Size = new Size((int)(ClientSize.Width * 0.9), (int)(ClientSize.Height * 0.8));
            dataGridView1.Location = new Point((int)(ClientSize.Width * 0.05), (int)(ClientSize.Height * 0.1));

            count.Location = new Point(dataGridView1.Left, dataGridView1.Bottom + 1);

            back.Width = (int)(ClientSize.Width * 0.09);
            back.Location = new Point(dataGridView1.Right - back.Width, dataGridView1.Bottom + 20);

            archiev.Width = (int)(0.1 * dataGridView1.Width);
            number.Width = (int)(0.1 * dataGridView1.Width);
            name.Width = (int)(0.2 * dataGridView1.Width);
            birth.Width = (int)(0.1 * dataGridView1.Width);
            handOver.Width = (int)(0.1 * dataGridView1.Width);
            arriving.Width = (int)(0.1 * dataGridView1.Width);
            notes.Width = (int)(0.2 * dataGridView1.Width);
        }
    }
}
