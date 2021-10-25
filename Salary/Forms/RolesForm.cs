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
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();

            
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void rolesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delete 
            if (rolesDataGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id;
                string name;
                id = (int)rolesDataGrid.Rows[e.RowIndex].Cells["id"].Value;
                name = (string)rolesDataGrid.Rows[e.RowIndex].Cells["name"].Value;


                if (MessageBox.Show($"Удалить должность {name}?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Database db = new Database();
                    db.OpenConnection();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM `roles` WHERE id = @id", db.GetConnection());
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        cmd.Parameters.AddWithValue("@id", id);


                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Должность успешно удалена!");
                            rolesDataGrid.Refresh();
                            adapter.Update((DataTable)rolesDataGrid.DataSource);
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


            // Update
            if(rolesDataGrid.Columns[e.ColumnIndex].Name == "Update")
            {
                int id;
                string name;
                id = (int)rolesDataGrid.Rows[e.RowIndex].Cells["id"].Value;
                name = (string)rolesDataGrid.Rows[e.RowIndex].Cells["name"].Value;


            }
        }

        private void AddRoleBtn_Click(object sender, EventArgs e)
        {
            new Roles.AddRoleForm().ShowDialog();
        }

        private void RefreshDataBtn_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            Database db = new Database();

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id, name, salary FROM `roles`", db.GetConnection());

            adapter.Fill(table);
            rolesDataGrid.DataSource = table;

            db.CloseConnection();
        }

        private void RolesForm_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RolesForm_Enter(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
