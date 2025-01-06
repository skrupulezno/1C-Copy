namespace _1C_copy
{
    partial class AuthForm
    {
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.RadioButton rbLogin;
        private System.Windows.Forms.RadioButton rbRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlRegisterFields;

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.rbRegister = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlRegisterFields = new System.Windows.Forms.Panel();
            this.pnlRegisterFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 118);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(0, 16);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(102, 268);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(200, 30);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Войти";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // rbLogin
            // 
            this.rbLogin.AutoSize = true;
            this.rbLogin.Checked = true;
            this.rbLogin.Location = new System.Drawing.Point(102, 65);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Size = new System.Drawing.Size(49, 17);
            this.rbLogin.TabIndex = 4;
            this.rbLogin.TabStop = true;
            this.rbLogin.Text = "Вход";
            this.rbLogin.UseVisualStyleBackColor = true;
            this.rbLogin.CheckedChanged += new System.EventHandler(this.rbLogin_CheckedChanged);
            // 
            // rbRegister
            // 
            this.rbRegister.AutoSize = true;
            this.rbRegister.Location = new System.Drawing.Point(201, 65);
            this.rbRegister.Name = "rbRegister";
            this.rbRegister.Size = new System.Drawing.Size(90, 17);
            this.rbRegister.TabIndex = 5;
            this.rbRegister.Text = "Регистрация";
            this.rbRegister.UseVisualStyleBackColor = true;
            this.rbRegister.CheckedChanged += new System.EventHandler(this.rbRegister_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(102, 98);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(102, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(0, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name";
            // 
            // pnlRegisterFields
            // 
            this.pnlRegisterFields.Controls.Add(this.txtFullName);
            this.pnlRegisterFields.Controls.Add(this.lblFullName);
            this.pnlRegisterFields.Location = new System.Drawing.Point(102, 212);
            this.pnlRegisterFields.Name = "pnlRegisterFields";
            this.pnlRegisterFields.Size = new System.Drawing.Size(200, 36);
            this.pnlRegisterFields.TabIndex = 9;
            this.pnlRegisterFields.Visible = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(400, 377);
            this.Controls.Add(this.pnlRegisterFields);
            this.Controls.Add(this.rbRegister);
            this.Controls.Add(this.rbLogin);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "AuthForm";
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.pnlRegisterFields.ResumeLayout(false);
            this.pnlRegisterFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}