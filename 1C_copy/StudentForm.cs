using System;
using System.Data;
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
            label1.Text = "Student ID: " + userId.ToString();
            LoadUserInfo();
            LoadGrades();
        }

        private void LoadUserInfo()
        {
            string query = $"SELECT full_name, email FROM Users WHERE user_id = {userId}";
            var result = sqlAdapter.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                string fullName = result.Rows[0]["full_name"].ToString();
                string email = result.Rows[0]["email"].ToString();

                label6.Text = "Student NAME: " + fullName;
                label8.Text = "Email: " + email;
            }
        }

        private void LoadGrades()
        {
            string query = $@"
                SELECT 
                    s.subject_name AS 'Название предмета',
                    u.full_name AS 'Преподаватель',
                    g.grade AS 'Оценка',
                    g.graded_at AS 'Дата выставления'
                FROM Grades g
                JOIN Subjects s ON g.subject_id = s.subject_id
                JOIN Users u ON s.teacher_id = u.user_id
                WHERE g.student_id = {userId}
            ";

            var result = sqlAdapter.ExecuteQuery(query);
            dataGridViewGrades.DataSource = result;
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;

            string fullName = $"{lastName} {firstName} {middleName}".Trim();

            string query = $"UPDATE Users SET full_name='{fullName}' WHERE user_id={userId}";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("ФИО успешно обновлено.");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении ФИО.");
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Пароль не может быть пустым.");
                return;
            }

            string query = $"UPDATE Users SET password='{newPassword}' WHERE user_id={userId}";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Пароль успешно обновлён.");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении пароля.");
            }
        }

        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadGrades();
        }

        private void label5_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) {
            string newEmail = textBox1.Text;

            if (string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Почта не может быть пустой.");
                return;
            }

            string query = $"UPDATE Users SET email='{newEmail}' WHERE user_id={userId}";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Почта успешно обновлена.");
                LoadUserInfo(); 
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении почты.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }
    }
}