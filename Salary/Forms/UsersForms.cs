using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary.Forms
{
    public partial class UsersForms : Form
    {
        public UsersForms()
        {
            InitializeComponent();
        }

        private void UsersForms_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void usersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(usersDataGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteUser(e);
            }

            if(usersDataGrid.Columns[e.ColumnIndex].Name == "Update")
            {

            }
        }

        private void RefreshDataBtn_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            new Users.AddUserForm().ShowDialog();
        }

        private void UpdateGrid()
        {
            Database db = new Database();

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT users.id, full_name, login, roles.name, roles.salary  FROM `users` JOIN `roles` ON roles.id = users.role", db.GetConnection());

            adapter.Fill(table);
            usersDataGrid.DataSource = table;

            db.CloseConnection();
        }

        private void UpdateUser(DataGridViewCellEventArgs e)
        {
            int id;
            string fullName;
            id = (int)usersDataGrid.Rows[e.RowIndex].Cells["id"].Value;
            fullName = (string)usersDataGrid.Rows[e.RowIndex].Cells["FullName"].Value;


            if (MessageBox.Show($"Удалить пользователя {fullName}?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE id = @id", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    cmd.Parameters.AddWithValue("@id", id);


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Пользователь успешно удален!");
                        usersDataGrid.Refresh();
                        adapter.Update((DataTable)usersDataGrid.DataSource);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void DeleteUser(DataGridViewCellEventArgs e)
        {
            int id;
            string fullName;
            id = (int)usersDataGrid.Rows[e.RowIndex].Cells["id"].Value;
            fullName = (string)usersDataGrid.Rows[e.RowIndex].Cells["FullName"].Value;


            if (MessageBox.Show($"Удалить пользователя {fullName}?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE id = @id", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    cmd.Parameters.AddWithValue("@id", id);


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Пользователь успешно удален!");
                        usersDataGrid.Refresh();
                        adapter.Update((DataTable)usersDataGrid.DataSource);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
