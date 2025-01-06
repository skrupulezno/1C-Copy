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
    public partial class StudentForm : Form
    {
        private int userId;
        private SQLAdapter sqlAdapter;

        internal StudentForm(int userId, SQLAdapter sqlAdapter)
        {
            InitializeComponent();
            this.userId = userId;
            this.sqlAdapter = sqlAdapter;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных для студента
            LoadGrades();
        }

        private void LoadGrades()
        {
            string query = $"SELECT * FROM Grades WHERE student_id={userId}";
            var result = sqlAdapter.ExecuteQuery(query);

            // Отображение данных в DataGridView или другом контроле
            dataGridViewGrades.DataSource = result;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            // Логика редактирования личной информации
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;

            string query = $"UPDATE Users SET full_name='{fullName}', email='{email}' WHERE user_id={userId}";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Информация успешно обновлена.");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении информации.");
            }
        }
    }
}
