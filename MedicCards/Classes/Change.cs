using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;

namespace MedicCards
{
    class Change
    {
        public void Add(DataGridView date)
        {
            date.Rows.Clear();

            Db db = new Db();

            db.getConnection().Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [MyTable] ORDER BY Номер_карты", db.getConnection());

            OleDbDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][1] = reader[0].ToString();
                    data[data.Count - 1][2] = reader[1].ToString();
                    data[data.Count - 1][3] = reader[2].ToString();
                    data[data.Count - 1][4] = reader[3].ToString();
                    data[data.Count - 1][5] = reader[4].ToString();
                    data[data.Count - 1][6] = reader[5].ToString();
                    data[data.Count - 1][7] = reader[6].ToString();
                }

                if (data.Count != 0)
                    foreach (string[] i in data)
                        date.Rows.Add(i);

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public void Add(DataGridView date, TextBox text, string request, bool isName)
        {
            date.Rows.Clear();

            Db db = new Db();

            db.getConnection().Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [MyTable] WHERE " + request + " = @a ORDER BY Номер_карты", db.getConnection());
            if (isName)
                command.Parameters.Add("@a", OleDbType.VarChar).Value = text.Text;
            else
                command.Parameters.Add("@a", OleDbType.Integer).Value = text.Text;

            OleDbDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][1] = reader[0].ToString();
                    data[data.Count - 1][2] = reader[1].ToString();
                    data[data.Count - 1][3] = reader[2].ToString();
                    data[data.Count - 1][4] = reader[3].ToString();
                    data[data.Count - 1][5] = reader[4].ToString();
                    data[data.Count - 1][6] = reader[5].ToString();
                    data[data.Count - 1][7] = reader[6].ToString();
                }

                if (data.Count != 0)
                    foreach (string[] i in data)
                        date.Rows.Add(i);

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public void Add(DataGridView date, DateTimePicker dating, string request)
        {
            date.Rows.Clear();

            Db db = new Db();

            db.getConnection().Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [MyTable] WHERE " + request + " = @a ORDER BY Номер_карты", db.getConnection());
            command.Parameters.Add("@a", OleDbType.VarChar).Value = dating.Text;

            OleDbDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][1] = reader[0].ToString();
                    data[data.Count - 1][2] = reader[1].ToString();
                    data[data.Count - 1][3] = reader[2].ToString();
                    data[data.Count - 1][4] = reader[3].ToString();
                    data[data.Count - 1][5] = reader[4].ToString();
                    data[data.Count - 1][6] = reader[5].ToString();
                    data[data.Count - 1][7] = reader[6].ToString();
                }

                if (data.Count != 0)
                    foreach (string[] i in data)
                        date.Rows.Add(i);

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public void Add(DataGridView date, string numCard, string request)
        {
            date.Rows.Clear();

            Db db = new Db();

            db.getConnection().Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [MyTable] WHERE " + request + " = @a ORDER BY Номер_карты", db.getConnection());
            command.Parameters.Add("@a", OleDbType.VarChar).Value = numCard;

            OleDbDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][1] = reader[0].ToString();
                    data[data.Count - 1][2] = reader[1].ToString();
                    data[data.Count - 1][3] = reader[2].ToString();
                    data[data.Count - 1][4] = reader[3].ToString();
                    data[data.Count - 1][5] = reader[4].ToString();
                    data[data.Count - 1][6] = reader[5].ToString();
                    data[data.Count - 1][7] = reader[6].ToString();
                }

                if (data.Count != 0)
                    foreach (string[] i in data)
                        date.Rows.Add(i);

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public void Delete(DataGridView data, sbyte row)
        {
            Db db = new Db();
            db.getConnection().Open();

            try
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM MyTable WHERE Номер_карты = @a AND ФИО = @b", db.getConnection());

                command.Parameters.Add("@a", OleDbType.VarChar).Value = data.Rows[row].Cells[2].Value.ToString();
                command.Parameters.Add("@b", OleDbType.VarChar).Value = data.Rows[row].Cells[3].Value.ToString();

                command.ExecuteNonQuery();

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Delete(DataGridView data, List<int> list)
        {
            Db db = new Db();
            db.getConnection().Open();

            try
            {
                while(list.Count != 0)
                {
                    OleDbCommand command = new OleDbCommand("DELETE FROM MyTable WHERE Номер_карты = @a AND ФИО = @b", db.getConnection());

                    command.Parameters.Add("@a", OleDbType.VarChar).Value = data.Rows[list[0]].Cells[2].Value.ToString();
                    command.Parameters.Add("@b", OleDbType.VarChar).Value = data.Rows[list[0]].Cells[3].Value.ToString();

                    command.ExecuteNonQuery();

                    list.Remove(list[0]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                db.getConnection().Close();
            }
        }

        public void Update(DataGridView data, TextBox changed, TextBox number, TextBox name, string request, int n)
        {
            Db db = new Db();

            db.getConnection().Open();

            try
            {
                OleDbCommand command = new OleDbCommand("UPDATE MyTable SET " + request + " = @a WHERE Номер_карты = @b AND ФИО = @c", db.getConnection());

                command.Parameters.Add("@a", OleDbType.VarChar).Value = changed.Text.ToString();
                command.Parameters.Add("@b", OleDbType.VarChar).Value = data.Rows[n].Cells[2].Value.ToString();
                command.Parameters.Add("@c", OleDbType.VarChar).Value = data.Rows[n].Cells[3].Value.ToString();

                command.ExecuteNonQuery();

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(DataGridView data, ComboBox changed, TextBox number, TextBox name, string request, int n)
        {
            Db db = new Db();

            db.getConnection().Open();

            try
            {
                OleDbCommand command = new OleDbCommand("UPDATE MyTable SET " + request + " = @a WHERE Номер_карты = @b AND ФИО = @c", db.getConnection());

                command.Parameters.Add("@a", OleDbType.VarChar).Value = changed.Text.ToString();
                command.Parameters.Add("@b", OleDbType.VarChar).Value = data.Rows[n].Cells[2].Value.ToString();
                command.Parameters.Add("@c", OleDbType.VarChar).Value = data.Rows[n].Cells[3].Value.ToString();

                command.ExecuteNonQuery();

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(DataGridView data, DateTimePicker changed, TextBox number, TextBox name, string request, int n)
        {
            Db db = new Db();

            db.getConnection().Open();

            try
            {
                OleDbCommand command = new OleDbCommand("UPDATE MyTable SET " + request + " = @a WHERE Номер_карты = @b AND ФИО = @c", db.getConnection());

                command.Parameters.Add("@a", OleDbType.VarChar).Value = changed.Text.ToString();
                command.Parameters.Add("@b", OleDbType.VarChar).Value = data.Rows[n].Cells[2].Value.ToString();
                command.Parameters.Add("@c", OleDbType.VarChar).Value = data.Rows[n].Cells[3].Value.ToString();

                command.ExecuteNonQuery();

                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
