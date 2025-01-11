using System;
using System.Data;
using System.Windows.Forms;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;

namespace _1C_copy
{
    public partial class AuthForm : Form
    {
        private SQLAdapter sqlAdapter;

        public AuthForm()
        {
            InitializeComponent();
            sqlAdapter = new SQLAdapter();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
                sqlAdapter.OpenConnection();
                Console.WriteLine("Подключение к базе данных успешно установлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlAdapter.CloseConnection();
            }
        }

        private void rbLogin_CheckedChanged(object sender, EventArgs e)
        {
            pnlRegisterFields.Visible = false;
            btnAction.Text = "Войти";
        }

        private void rbRegister_CheckedChanged(object sender, EventArgs e)
        {
            pnlRegisterFields.Visible = true;
            btnAction.Text = "Зарегистрироваться";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (rbLogin.Checked)
            {
                Login();
            }
            else
            {
                Register();
            }
        }

        private void Login()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = $"SELECT * FROM Users WHERE username='{username}' AND password='{password}'";
            var result = sqlAdapter.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                string role = result.Rows[0]["role"].ToString();
                int userId = Convert.ToInt32(result.Rows[0]["user_id"]);
                MessageBox.Show($"Вход выполнен успешно! Ваша роль: {role}");

                switch (role)
                {
                    case "admin":
                        OpenAdminForm(userId);
                        break;
                    case "teacher":
                        OpenTeacherForm(userId);
                        break;
                    case "student":
                        OpenStudentForm(userId);
                        break;
                    case "guest":
                        OpenGuestForm();
                        break;
                    default:
                        MessageBox.Show("Неизвестная роль.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void Register()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;

            var validationResult = Validation.VerifyPassword(password);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.ErrorMessage);
                return;
            }

            string checkQuery = $"SELECT * FROM Users WHERE username='{username}'";
            var checkResult = sqlAdapter.ExecuteQuery(checkQuery);

            if (checkResult.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }

            string query = $"INSERT INTO Users (username, password, full_name, role) " +
                           $"VALUES ('{username}', '{password}', '{fullName}', 'guest')";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                
                OpenGuestForm();

                }
            else
            {
                MessageBox.Show("Ошибка при регистрации.");
            }
        }

        private void OpenAdminForm(int userId)
        {
            AdminForm adminForm = new AdminForm(userId, sqlAdapter);
            adminForm.Show();
            this.Hide();
        }

        private void OpenTeacherForm(int userId)
        {
            TeacherForm teacherForm = new TeacherForm(userId, sqlAdapter);
            teacherForm.Show();
            this.Hide();
        }

        private void OpenStudentForm(int userId)
        {
            StudentForm studentForm = new StudentForm(userId, sqlAdapter);
            studentForm.Show();
            this.Hide();
        }

        private void OpenGuestForm()
        {
            GuestForm guestForm = new GuestForm();
            guestForm.Show();
            this.Hide();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}