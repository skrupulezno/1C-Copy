using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1C_copy
{
    public partial class AdminForm : Form
    {
        private int userId;
        private SQLAdapter sqlAdapter;

        internal AdminForm(int userId, SQLAdapter sqlAdapter)
        {
            InitializeComponent();
            this.userId = userId;
            this.sqlAdapter = sqlAdapter;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT * FROM Users";
            var result = sqlAdapter.ExecuteQuery(query);

            dataGridViewUsers.DataSource = result;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Логика удаления пользователя
            int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["user_id"].Value);
            string query = $"DELETE FROM Users WHERE user_id={selectedUserId}";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Пользователь успешно удален.");
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении пользователя.");
            }
        }
    }
}
