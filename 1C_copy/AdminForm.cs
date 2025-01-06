using System;
using System.Data;
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
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
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
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.");
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                txtUsername.Text = selectedRow.Cells["username"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["password"].Value.ToString();
                txtFullName.Text = selectedRow.Cells["full_name"].Value.ToString();
                cmbRole.SelectedItem = selectedRow.Cells["role"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите пользователя для редактирования.");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["user_id"].Value);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string fullName = txtFullName.Text;
                string role = cmbRole.SelectedItem.ToString();

                string query = $"UPDATE Users SET username='{username}', password='{password}', full_name='{fullName}', role='{role}' WHERE user_id={selectedUserId}";
                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Изменения успешно сохранены.");
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Ошибка при сохранении изменений.");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для сохранения изменений.");
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}