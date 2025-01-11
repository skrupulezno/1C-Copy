using System;
using System.Data;
using System.Drawing;
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
            label9.Text = "Айди: " + userId.ToString();

            dataGridViewGrades.SelectionChanged += DataGridViewGrades_SelectionChanged;
        }

        private void DataGridViewGrades_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewGrades.SelectedRows.Count == 1)
            {
          
                DataGridViewRow row = dataGridViewGrades.SelectedRows[0];

         
                string studentName = row.Cells["student_name"].Value.ToString();
                string subjectName = row.Cells["subject_name"].Value.ToString();
                string currentGrade = row.Cells["grade"].Value.ToString();

        
                labelSelectedInfo.Text = $"Студент: {studentName}, Предмет: {subjectName}";
                labelSelectedInfo.Visible = true;

           
                comboBoxEditGrade.SelectedItem = currentGrade;
                comboBoxEditGrade.Visible = true;

             
                btnSaveEditedGrade.Visible = true;
            }
            else
            {
      
                labelSelectedInfo.Visible = false;
                comboBoxEditGrade.Visible = false;
                btnSaveEditedGrade.Visible = false;
            }
        }

        private void DataGridViewGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.ColumnIndex == dataGridViewGrades.Columns["grade"].Index && e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dataGridViewGrades.Rows[e.RowIndex];

              
                ComboBox comboBox = new ComboBox();
                comboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
                comboBox.SelectedItem = row.Cells["grade"].Value.ToString();
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

      
                dataGridViewGrades.Controls.Add(comboBox);
                Rectangle cellRectangle = dataGridViewGrades.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                comboBox.Size = cellRectangle.Size;
                comboBox.Location = cellRectangle.Location;

      
                comboBox.SelectedIndexChanged += (s, ev) =>
                {
        
                    row.Cells["grade"].Value = comboBox.SelectedItem;

              
                    UpdateGradeInDatabase(row);

           
                    dataGridViewGrades.Controls.Remove(comboBox);
                };

       
                comboBox.LostFocus += (s, ev) =>
                {
                    dataGridViewGrades.Controls.Remove(comboBox);
                };
            }
        }

        private void UpdateGradeInDatabase(DataGridViewRow row)
        {
            try
            {
 
                int studentId = Convert.ToInt32(row.Cells["student_id"].Value);
                int subjectId = Convert.ToInt32(row.Cells["subject_id"].Value);
                int newGrade = Convert.ToInt32(row.Cells["grade"].Value);

                string query = $@"
            UPDATE Grades 
            SET grade = {newGrade} 
            WHERE student_id = {studentId} AND subject_id = {subjectId}";

                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Оценка успешно обновлена.");
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении оценки.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Teacher ID: " + userId.ToString();

            ConfigureDataGridView();
            LoadUserInfo();
            LoadSubjectsComboBox();
            LoadStudentsComboBox();
            LoadGradesComboBox();
            LoadGrades();
            LoadSubjects();
            LoadStudents();
  
        }

        private void LoadSubjects()
        {
            try
            {
                string query = $"SELECT subject_id, subject_name FROM Subjects WHERE teacher_id = {userId}";
                var result = sqlAdapter.ExecuteQuery(query);

                if (result != null && result.Rows.Count > 0)
                {
                    dataGridViewSubjects.AutoGenerateColumns = true; 
                    dataGridViewSubjects.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No subjects found for this teacher.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        private void LoadStudents()
        {
            try
            {
                string query = "SELECT user_id, full_name FROM Users WHERE role = 'student'";
                var result = sqlAdapter.ExecuteQuery(query);

                if (result != null && result.Rows.Count > 0)
                {
                    dataGridViewStudents.AutoGenerateColumns = true; // Автоматическая генерация столбцов
                    dataGridViewStudents.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No students found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void LoadUserInfo()
        {
            try
            {
                string query = $"SELECT full_name, email FROM Users WHERE user_id = {userId}";
                var result = sqlAdapter.ExecuteQuery(query);

                if (result != null && result.Rows.Count > 0)
                {
                    string fullName = result.Rows[0]["full_name"].ToString();
                    string email = result.Rows[0]["email"].ToString();

                    label1.Text = "Teacher NAME: " + fullName;
                    label2.Text = "Email: " + email;
                }
                else
                {
                    MessageBox.Show("User information not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user info: " + ex.Message);
            }
        }

        private void LoadSubjectsComboBox()
        {
            try
            {
                string query = $"SELECT subject_id, subject_name FROM Subjects WHERE teacher_id={userId}";
                var result = sqlAdapter.ExecuteQuery(query);

                comboBoxSubjects.Items.Clear();

                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        string subjectName = row["subject_name"].ToString();
                        int subjectId = Convert.ToInt32(row["subject_id"]);

                        var item = new ComboboxItem
                        {
                            Text = subjectName,
                            Value = subjectId
                        };

                        comboBoxSubjects.Items.Add(item);
                    }

                    comboBoxSubjects.DisplayMember = "Text";
                }
                else
                {
                    MessageBox.Show("No subjects found for this teacher.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects combo box: " + ex.Message);
            }
        }

        private void LoadStudentsComboBox()
        {
            try
            {
                string query = "SELECT user_id, full_name FROM Users WHERE role='student'";
                var result = sqlAdapter.ExecuteQuery(query);

                comboBoxStudents.Items.Clear();

                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        string fullName = row["full_name"].ToString();
                        int userId = Convert.ToInt32(row["user_id"]);

                        var item = new ComboboxItem
                        {
                            Text = fullName,
                            Value = userId
                        };

                        comboBoxStudents.Items.Add(item);
                    }

                    comboBoxStudents.DisplayMember = "Text";
                }
                else
                {
                    MessageBox.Show("No students found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students combo box: " + ex.Message);
            }
        }

        private void LoadGradesComboBox()
        {
            comboBoxGrades.Items.Clear();
            comboBoxGrades.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxGrades.SelectedIndex = 0;
        }

        private void LoadGrades()
        {
            try
            {
                string query = $@"
                    SELECT 
                        U.user_id AS student_id, 
                        S.subject_id,
                        U.full_name AS student_name,
                        S.subject_name,
                        G.grade,
                        G.graded_at
                    FROM 
                        Grades G
                    JOIN 
                        Subjects S ON G.subject_id = S.subject_id
                    JOIN 
                        Users U ON G.student_id = U.user_id
                    WHERE 
                        S.teacher_id = {userId}
                    ORDER BY 
                        U.full_name, S.subject_name, G.graded_at;";

                var result = sqlAdapter.ExecuteQuery(query);

                if (result != null && result.Rows.Count > 0)
                {
                    dataGridViewGrades.AutoGenerateColumns = true; 
                    dataGridViewGrades.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No grades found for this teacher.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridViewGrades.AutoGenerateColumns = false;

            dataGridViewGrades.Columns.Clear();
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_id",
                HeaderText = "ID студента",
                Name = "student_id",
                Visible = false

            });
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "subject_id",
                HeaderText = "ID предмета",
                Name = "subject_id",
                Visible = false

            });
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_name",
                HeaderText = "Студент",
                Name = "student_name"
            });
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "subject_name",
                HeaderText = "Предмет",
                Name = "subject_name"
            });
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grade",
                HeaderText = "Оценка",
                Name = "grade"
            });
            dataGridViewGrades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "graded_at",
                HeaderText = "Дата оценки",
                Name = "graded_at"
            });
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSubjects.SelectedItem == null || comboBoxStudents.SelectedItem == null)
                {
                    MessageBox.Show("Please select a subject and a student.");
                    return;
                }

                var selectedSubject = (ComboboxItem)comboBoxSubjects.SelectedItem;
                int selectedSubjectId = selectedSubject.Value;

                var selectedStudent = (ComboboxItem)comboBoxStudents.SelectedItem;
                int selectedStudentId = selectedStudent.Value;

                int grade = Convert.ToInt32(comboBoxGrades.SelectedItem);

                string query = $@"
                    INSERT INTO Grades (student_id, subject_id, grade, graded_at) 
                    VALUES ({selectedStudentId}, {selectedSubjectId}, {grade}, NOW())";

                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Оценка успешно добавлена.");
                    LoadGrades();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении оценки.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
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
                MessageBox.Show("Пароль успешно обновлен.");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении пароля.");
            }
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;

            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName))
            {
                MessageBox.Show("Поля ФИО не могут быть пустыми.");
                return;
            }

            string query = $"UPDATE Users SET full_name='{lastName} {firstName} {middleName}' WHERE user_id={userId}";
            int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("ФИО успешно обновлено.");
                LoadUserInfo();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении ФИО.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadSubjectsComboBox();
            LoadStudentsComboBox();
            LoadGradesComboBox();
            LoadGrades();
            LoadSubjects();
            LoadStudents();
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

        private void button3_Click(object sender, EventArgs e)
        {
            string newEmail = textBox5.Text;

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

        private void btnSaveEditedGrade_Click(object sender, EventArgs e)
        {

            if (dataGridViewGrades.SelectedRows.Count == 1)
            {
            
                DataGridViewRow row = dataGridViewGrades.SelectedRows[0];

                int studentId = Convert.ToInt32(row.Cells["student_id"].Value);
                int subjectId = Convert.ToInt32(row.Cells["subject_id"].Value);
                int newGrade = Convert.ToInt32(comboBoxEditGrade.SelectedItem);

       
                UpdateGradeInDatabase(studentId, subjectId, newGrade);


                row.Cells["grade"].Value = newGrade;

                labelSelectedInfo.Visible = false;
                comboBoxEditGrade.Visible = false;
                btnSaveEditedGrade.Visible = false;
            }
        }

        private void UpdateGradeInDatabase(int studentId, int subjectId, int newGrade)
        {
            try
            {
  
                string query = $@"
            UPDATE Grades 
            SET grade = {newGrade} 
            WHERE student_id = {studentId} AND subject_id = {subjectId}";

                // Выполняем запрос
                int rowsAffected = sqlAdapter.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Оценка успешно обновлена.");
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении оценки.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }
    }
}