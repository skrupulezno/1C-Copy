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
            InitializeDataGridViewStudents();
            LoadGuests();
            LoadTeachers();
            LoadSubjects();
            LoadStudents();
        }

        private void LoadGuests()
        {
            string query = "SELECT * FROM Users WHERE role='guest'";
            var result = sqlAdapter.ExecuteQuery(query);
            dataGridViewGuests.DataSource = result;
        }

        private void LoadTeachers()
        {
            string query = @"
                SELECT U.user_id, U.full_name, U.email, S.subject_name 
                FROM Users U
                LEFT JOIN Subjects S ON U.user_id = S.teacher_id
                WHERE U.role='teacher'";
            var result = sqlAdapter.ExecuteQuery(query);
            dataGridViewTeachers.DataSource = result;
        }

        private void InitializeDataGridViewStudents()
        {
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.Columns.Clear();

            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "user_id",
                HeaderText = "User ID",
                Name = "user_id"
            });

            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "full_name",
                HeaderText = "Full Name",
                Name = "full_name"
            });

            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                HeaderText = "Email",
                Name = "email"
            });

            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "average_grade",
                HeaderText = "Average Grade",
                Name = "average_grade"
            });

            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grade_count",
                HeaderText = "Grade Count",
                Name = "grade_count"
            });
        }

        private void LoadSubjects()
        {
            string query = "SELECT * FROM Subjects";
            var result = sqlAdapter.ExecuteQuery(query);
            dataGridViewSubjects.DataSource = result;
        }

        private void LoadStudents()
        {
            string query = @"
        SELECT 
            U.user_id, 
            U.full_name, 
            U.email, 
            AVG(G.grade) AS average_grade, 
            COUNT(G.grade) AS grade_count
        FROM Users U
        LEFT JOIN Grades G ON U.user_id = G.student_id
        WHERE U.role='student'
        GROUP BY U.user_id, U.full_name, U.email
        HAVING COUNT(G.grade) > 0";

            var result = sqlAdapter.ExecuteQuery(query);
            dataGridViewStudents.DataSource = result;
        }

        private void dataGridViewGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
            if (e.RowIndex >= 0 && dataGridViewGuests.Rows[e.RowIndex].Cells["user_id"].Value != null)
            {
                DataGridViewRow row = dataGridViewGuests.Rows[e.RowIndex];
                int userId = Convert.ToInt32(row.Cells["user_id"].Value);

                comboBoxRole.Items.Clear();
                comboBoxRole.Items.AddRange(new object[] { "teacher", "student" });
                comboBoxRole.SelectedIndex = 0;
                comboBoxRole.Visible = true;

                btnAssignRole.Visible = true;
                btnAssignRole.Tag = userId;
            }
            else
            {
                comboBoxRole.Visible = false;
                btnAssignRole.Visible = false;
            }
        }

        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem != null && btnAssignRole.Tag != null && (int)btnAssignRole.Tag != 0)
            {
                int userId = (int)btnAssignRole.Tag;
                string newRole = comboBoxRole.SelectedItem.ToString();

                string query = $"UPDATE Users SET role='{newRole}' WHERE user_id={userId}";
                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Роль успешно изменена.");
                    LoadGuests();
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении роли.");
                }

                comboBoxRole.Visible = false;
                btnAssignRole.Visible = false;
            }
        }

        private void btnFireTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count > 0)
            {
                int teacherId = Convert.ToInt32(dataGridViewTeachers.SelectedRows[0].Cells["user_id"].Value);

                string query = $"DELETE FROM Users WHERE user_id={teacherId}";
                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Преподаватель успешно уволен.");
                    LoadTeachers();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении преподавателя.");
                }
            }
            else
            {
                MessageBox.Show("Выберите преподавателя для увольнения.");
            }
        }

        private void dataGridViewSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridViewSubjects.Rows[e.RowIndex].Cells["subject_id"].Value != null)
            {
                DataGridViewRow row = dataGridViewSubjects.Rows[e.RowIndex];
                int subjectId = Convert.ToInt32(row.Cells["subject_id"].Value);

                comboBoxTeachers.Items.Clear();
                string teacherQuery = "SELECT user_id, full_name FROM Users WHERE role='teacher'";
                var teachers = sqlAdapter.ExecuteQuery(teacherQuery);

                foreach (DataRow teacherRow in teachers.Rows)
                {
                    comboBoxTeachers.Items.Add(new ComboboxItem
                    {
                        Text = teacherRow["full_name"].ToString(),
                        Value = Convert.ToInt32(teacherRow["user_id"])
                    });
                }

                comboBoxTeachers.Visible = true;
                btnAssignTeacher.Visible = true;
                btnAssignTeacher.Tag = subjectId;
            }
            else
            {
    
                comboBoxTeachers.Visible = false;
                btnAssignTeacher.Visible = false;
            }
        }

        private void btnAssignTeacher_Click(object sender, EventArgs e)
        {
            if (comboBoxTeachers.SelectedItem != null && btnAssignTeacher.Tag != null)
            {
                int subjectId = (int)btnAssignTeacher.Tag;
                int teacherId = ((ComboboxItem)comboBoxTeachers.SelectedItem).Value;

                string query = $"UPDATE Subjects SET teacher_id={teacherId} WHERE subject_id={subjectId}";
                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Преподаватель успешно назначен на предмет.");
                    LoadSubjects();
                }
                else
                {
                    MessageBox.Show("Ошибка при назначении преподавателя.");
                }

                comboBoxTeachers.Visible = false;
                btnAssignTeacher.Visible = false;
            }
        }

        private void btnExpelStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["user_id"].Value);

                string query = $"DELETE FROM Users WHERE user_id={studentId}";
                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Студент успешно отчислен.");
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Ошибка при отчислении студента.");
                }
            }
            else
            {
                MessageBox.Show("Выберите студента для отчисления.");
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadGuests();
            LoadTeachers();
            LoadSubjects();
            LoadStudents();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }
    }
}