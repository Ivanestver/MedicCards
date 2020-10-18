using System;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;


namespace MedicCards
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (ar.Text == "")
            {
                MessageBox.Show("Есть ли в архиве?");
                return;
            }

            if (number.Text == "")
            {
                MessageBox.Show("Не введён номер карты");
                return;
            }

            if (name.Text == "")
            {
                MessageBox.Show("Не введены ФИО");
                return;
            }

            Db db = new Db();
            db.getConnection().Open();

            OleDbCommand command = new OleDbCommand("INSERT INTO MyTable VALUES (@ar, @num, @nm, @br, @han, @arr, @nt) ", db.getConnection());

            command.Parameters.Add("@ar", OleDbType.VarChar).Value = ar.Text;
            command.Parameters.Add("@num", OleDbType.Integer).Value = number.Text;
            command.Parameters.Add("@nm", OleDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@br", OleDbType.VarChar).Value = birth.Text;
            command.Parameters.Add("@han", OleDbType.VarChar).Value = handover.Text;
            command.Parameters.Add("@arr", OleDbType.VarChar).Value = arrive.Text;
            command.Parameters.Add("@nt", OleDbType.VarChar).Value = notes.Text;

            command.ExecuteNonQuery();

            db.getConnection().Close();

            Hide();
            new Main().Show();
        }

        private void Addition_SizeChanged(object sender, EventArgs e)
        {
            Loading();
        }

        private void Addition_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            new Main().Show();
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
            label1.Location = new Point(ar.Left + ar.Width/2 - label1.Width/2, ar.Top - yL);
            label2.Location = new Point(number.Left + number.Width / 2 - label2.Width / 2, label1.Top);
            label3.Location = new Point(name.Left + name.Width / 2 - label3.Width / 2, label1.Top);
            label4.Location = new Point(birth.Left + (birth.Width - label4.Width) / 2, birth.Top - yL);
            label5.Location = new Point(handover.Left + (handover.Width - label5.Width) / 2, label4.Top);
            label6.Location = new Point(arrive.Left + (arrive.Width - label6.Width) / 2, label4.Top);
            label7.Location = new Point(notes.Left + (notes.Width - label7.Width) / 2, notes.Top - yL);

            // setup of locations of buttons
            back.Location = new Point(notes.Right - back.Width, notes.Bottom + 60);
            add.Location = new Point(back.Left - 40 - add.Width, back.Top);
        }
    }
}
