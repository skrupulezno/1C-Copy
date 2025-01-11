using System.Windows.Forms;

namespace _1C_copy
{
    partial class TeacherForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxGrades;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.comboBoxGrades = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSelectedInfo = new System.Windows.Forms.Label();
            this.comboBoxEditGrade = new System.Windows.Forms.ComboBox();
            this.btnSaveEditedGrade = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(23, 55);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.Size = new System.Drawing.Size(600, 234);
            this.dataGridViewSubjects.TabIndex = 0;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(23, 295);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(960, 120);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(133, 45);
            this.btnAddGrade.TabIndex = 3;
            this.btnAddGrade.Text = "Добавить оценку";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(645, 36);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSubjects.TabIndex = 4;
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(853, 36);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStudents.TabIndex = 5;
            // 
            // comboBoxGrades
            // 
            this.comboBoxGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrades.FormattingEnabled = true;
            this.comboBoxGrades.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxGrades.Location = new System.Drawing.Point(827, 133);
            this.comboBoxGrades.Name = "comboBoxGrades";
            this.comboBoxGrades.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGrades.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(767, 214);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(767, 244);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(767, 274);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(200, 20);
            this.txtMiddleName.TabIndex = 9;
            // 
            // btnSaveName
            // 
            this.btnSaveName.Location = new System.Drawing.Point(973, 272);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(100, 23);
            this.btnSaveName.TabIndex = 10;
            this.btnSaveName.Text = "Сохранить";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(765, 351);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 20);
            this.txtNewPassword.TabIndex = 11;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Location = new System.Drawing.Point(973, 351);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(100, 23);
            this.btnSavePassword.TabIndex = 12;
            this.btnSavePassword.Text = "Сохранить";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email: ";
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Location = new System.Drawing.Point(23, 501);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.Size = new System.Drawing.Size(600, 200);
            this.dataGridViewGrades.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Почта";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(973, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(765, 416);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(654, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 32;
            this.button1.Text = "🔄";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Айди:";
            // 
            // labelSelectedInfo
            // 
            this.labelSelectedInfo.AutoSize = true;
            this.labelSelectedInfo.Location = new System.Drawing.Point(679, 501);
            this.labelSelectedInfo.Name = "labelSelectedInfo";
            this.labelSelectedInfo.Size = new System.Drawing.Size(13, 13);
            this.labelSelectedInfo.TabIndex = 34;
            this.labelSelectedInfo.Text = "q";
            // 
            // comboBoxEditGrade
            // 
            this.comboBoxEditGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditGrade.FormattingEnabled = true;
            this.comboBoxEditGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEditGrade.Location = new System.Drawing.Point(682, 523);
            this.comboBoxEditGrade.Name = "comboBoxEditGrade";
            this.comboBoxEditGrade.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEditGrade.TabIndex = 35;
            this.comboBoxEditGrade.Visible = false;
            // 
            // btnSaveEditedGrade
            // 
            this.btnSaveEditedGrade.Location = new System.Drawing.Point(682, 562);
            this.btnSaveEditedGrade.Name = "btnSaveEditedGrade";
            this.btnSaveEditedGrade.Size = new System.Drawing.Size(100, 23);
            this.btnSaveEditedGrade.TabIndex = 36;
            this.btnSaveEditedGrade.Text = "Сохранить";
            this.btnSaveEditedGrade.UseVisualStyleBackColor = true;
            this.btnSaveEditedGrade.Click += new System.EventHandler(this.btnSaveEditedGrade_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Выберите студента и поменяйте оценку";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(972, 692);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 38;
            this.button2.Text = "выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSaveEditedGrade);
            this.Controls.Add(this.comboBoxEditGrade);
            this.Controls.Add(this.labelSelectedInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewGrades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnSaveName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.comboBoxGrades);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Name = "TeacherForm";
            this.Text = "Панель преподавателя";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        private TextBox textBox5;
        private Button button1;
        private Label label9;
        private Label labelSelectedInfo;
        private ComboBox comboBoxEditGrade;
        private Button btnSaveEditedGrade;
        private Label label8;
        private Button button2;
    }
}