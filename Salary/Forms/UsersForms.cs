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
            Database db = new Database();

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT full_name AS \"ФИО сотрудника\", login AS \"Логин\", roles.name AS \"Должность\", roles.salary AS \"Оклад\" FROM `users` JOIN `roles` ON roles.id = users.role", db.GetConnection());

            adapter.Fill(table);
            usersDataGrid.DataSource = table;

            db.CloseConnection();

        }
    }
}
