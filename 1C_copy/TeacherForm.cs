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
    public partial class TeacherForm : Form
    {
        private int userId;
        private SQLAdapter sqlAdapter;

        internal TeacherForm(int userId, SQLAdapter sqlAdapter)
        {
            InitializeComponent();
            this.userId = userId;
            this.sqlAdapter = sqlAdapter;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных для преподавателя
            LoadSubjects();
            LoadStudents();
        }

        private void LoadSubjects()
        {
            string query = $"SELECT * FROM Subjects WHERE teacher_id={userId}";
            var result = sqlAdapter.ExecuteQuery(query);

            // Отображение данных в DataGridView или другом контроле
            dataGridViewSubjects.DataSource = result;
        }

        private void LoadStudents()
        {
            string query = "SELECT * FROM Users WHERE role='student'";
            var result = sqlAdapter.ExecuteQuery(query);

            // Отображение данных в DataGridView или другом контроле
            dataGridViewStudents.DataSource = result;
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            // Логика добавления оценки студенту
            int selectedStudentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["user_id"].Value);
            int selectedSubjectId = Convert.ToInt32(dataGridViewSubjects.SelectedRows[0].Cells["subject_id"].Value);
            int grade = Convert.ToInt32(txtGrade.Text);

            string query = $"INSERT INTO Grades (student_id, subject_id, grade) VALUES ({selectedStudentId}, {selectedSubjectId}, {grade})";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Оценка успешно добавлена.");
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении оценки.");
            }
        }
    }
}
