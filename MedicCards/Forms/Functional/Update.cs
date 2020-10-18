using System;
using System.Drawing;
using System.Windows.Forms;

namespace MedicCards
{
    public partial class Update : Form
    {
        int n;
        DataGridView data = new DataGridView();
        string form = "";

        public Update(int _n, DataGridView _data, string _form)
        {
            InitializeComponent();

            n = _n;
            data = _data;
            form = _form;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Loading();

            ar.Text = data.Rows[n].Cells[1].Value.ToString();
            number.Text = data.Rows[n].Cells[2].Value.ToString();
            name.Text = data.Rows[n].Cells[3].Value.ToString();
            birth.Text = data.Rows[n].Cells[4].Value.ToString();
            handover.Text = data.Rows[n].Cells[5].Value.ToString();
            arrive.Text = data.Rows[n].Cells[6].Value.ToString();
            notes.Text = data.Rows[n].Cells[7].Value.ToString();
        }

        private void Update_ClientSizeChanged(object sender, EventArgs e)
        {
            Loading();
        }

        void Loading()
        {
            // setup of locations of named elements
            const sbyte x = 30, y = 70;
            number.Location = new Point((ClientSize.Width - number.Width) / 2, y);
            name.Location = new Point(number.Right + x, number.Top);
            ar.Location = new Point(number.Left - x - ar.Width, number.Top);
            birth.Location = new Point(ar.Left, ar.Bottom + y);
            handover.Location = new Point(birth.Right + x, birth.Top);
            arrive.Location = new Point(handover.Right + x, birth.Top);
            notes.Location = new Point(ar.Left, birth.Bottom + y);

            // setup of locations of labels
            const sbyte yL = 16;
            label1.Location = new Point(ar.Left + ar.Width / 2 - label1.Width / 2, ar.Top - yL);
            label2.Location = new Point(number.Left + number.Width / 2 - label2.Width / 2, label1.Top);
            label3.Location = new Point(name.Left + name.Width / 2 - label3.Width / 2, label1.Top);
            label4.Location = new Point(birth.Left + (birth.Width - label4.Width) / 2, birth.Top - yL);
            label5.Location = new Point(handover.Left + (handover.Width - label5.Width) / 2, label4.Top);
            label6.Location = new Point(arrive.Left + (arrive.Width - label6.Width) / 2, label4.Top);
            label7.Location = new Point(notes.Left + (notes.Width - label7.Width) / 2, notes.Top - yL);

            // setup of locations of buttons
            back.Location = new Point(notes.Right - back.Width, notes.Bottom + 60);
            up.Location = new Point(back.Left - 40 - up.Width, back.Top);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            new Main().Show();
        }

        private void up_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Update(data, ar, number, name, "Архив", n);
            change.Update(data, number, number, name, "Номер_карты", n);
            change.Update(data, name, number, name, "ФИО", n);
            change.Update(data, birth, number, name, "Дата_рождения", n);
            change.Update(data, handover, number, name, "Период_сдачи", n);
            change.Update(data, arrive, number, name, "Дата_поступления", n);
            change.Update(data, notes, number, name, "Особые_пометки", n);

            Hide();
            switch (form)
            {
                case "SearchNumbers":
                    new SearchNumbers().Show();
                    break;
                case "Main":
                    new Main().Show();
                    break;
                case "SearchNames":
                    new SearchNames().Show();
                    break;
                case "SearchBirth":
                    new SearchBirth().Show();
                    break;
            }
        }
    }
}
