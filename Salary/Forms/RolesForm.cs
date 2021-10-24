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
            Database db = new Database();

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT name AS \"Должность\", salary AS \"Оклад\" FROM `roles`", db.GetConnection());

            adapter.Fill(table);
            rolesDataGrid.DataSource = table;

            db.CloseConnection();
        }

        private void rolesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
