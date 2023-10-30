
namespace MyStoreWinApp
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbLogin = new System.Windows.Forms.Label();
            lbUsername = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLog = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(186, 9);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(70, 30);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new System.Drawing.Point(12, 70);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(60, 15);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(12, 117);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(109, 68);
            txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(238, 23);
            txtUserName.TabIndex = 3;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(109, 117);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(238, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLog
            // 
            btnLog.Location = new System.Drawing.Point(109, 178);
            btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLog.Name = "btnLog";
            btnLog.Size = new System.Drawing.Size(82, 22);
            btnLog.TabIndex = 5;
            btnLog.Text = "&Login";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(264, 178);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(82, 22);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(383, 216);
            Controls.Add(btnCancel);
            Controls.Add(btnLog);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbLogin);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "LOGIN";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCancel;
    }
}