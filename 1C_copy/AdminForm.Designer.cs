namespace _1C_copy
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewGuests;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button btnAssignRole;
        private System.Windows.Forms.Button btnFireTeacher;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Button btnAssignTeacher;
        private System.Windows.Forms.Button btnExpelStudent;

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
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.btnAssignRole = new System.Windows.Forms.Button();
            this.btnFireTeacher = new System.Windows.Forms.Button();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.btnAssignTeacher = new System.Windows.Forms.Button();
            this.btnExpelStudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewGuests.TabIndex = 0;
            this.dataGridViewGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuests_CellClick);
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewTeachers.TabIndex = 1;
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(12, 350);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewSubjects.TabIndex = 2;
            this.dataGridViewSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubjects_CellClick);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 520);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewStudents.TabIndex = 3;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Location = new System.Drawing.Point(650, 50);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(150, 21);
            this.comboBoxRole.TabIndex = 9;
            this.comboBoxRole.Visible = false;
            // 
            // btnAssignRole
            // 
            this.btnAssignRole.Location = new System.Drawing.Point(650, 80);
            this.btnAssignRole.Name = "btnAssignRole";
            this.btnAssignRole.Size = new System.Drawing.Size(150, 30);
            this.btnAssignRole.TabIndex = 4;
            this.btnAssignRole.Text = "Назначить роль";
            this.btnAssignRole.Visible = false;
            this.btnAssignRole.Click += new System.EventHandler(this.btnAssignRole_Click);
            // 
            // btnFireTeacher
            // 
            this.btnFireTeacher.Location = new System.Drawing.Point(650, 200);
            this.btnFireTeacher.Name = "btnFireTeacher";
            this.btnFireTeacher.Size = new System.Drawing.Size(150, 30);
            this.btnFireTeacher.TabIndex = 5;
            this.btnFireTeacher.Text = "Уволить";
            this.btnFireTeacher.Click += new System.EventHandler(this.btnFireTeacher_Click);
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeachers.Location = new System.Drawing.Point(650, 370);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTeachers.TabIndex = 8;
            this.comboBoxTeachers.Visible = false;
            // 
            // btnAssignTeacher
            // 
            this.btnAssignTeacher.Location = new System.Drawing.Point(650, 400);
            this.btnAssignTeacher.Name = "btnAssignTeacher";
            this.btnAssignTeacher.Size = new System.Drawing.Size(150, 30);
            this.btnAssignTeacher.TabIndex = 6;
            this.btnAssignTeacher.Text = "Назначить";
            this.btnAssignTeacher.Visible = false;
            this.btnAssignTeacher.Click += new System.EventHandler(this.btnAssignTeacher_Click);
            // 
            // btnExpelStudent
            // 
            this.btnExpelStudent.Location = new System.Drawing.Point(650, 540);
            this.btnExpelStudent.Name = "btnExpelStudent";
            this.btnExpelStudent.Size = new System.Drawing.Size(150, 30);
            this.btnExpelStudent.TabIndex = 7;
            this.btnExpelStudent.Text = "Отчислить";
            this.btnExpelStudent.Click += new System.EventHandler(this.btnExpelStudent_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(779, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 40;
            this.button2.Text = "выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(650, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 39;
            this.button1.Text = "🔄";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 771);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExpelStudent);
            this.Controls.Add(this.btnAssignTeacher);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.btnFireTeacher);
            this.Controls.Add(this.btnAssignRole);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.dataGridViewGuests);
            this.Name = "AdminForm";
            this.Text = "Админ-панель";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}