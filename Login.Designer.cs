namespace Assignment4
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtusername = new TextBox();
            txtpass = new TextBox();
            lbluser = new Label();
            lblpass = new Label();
            btnlogin = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Location = new Point(405, 127);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(187, 31);
            txtusername.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(405, 203);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(187, 31);
            txtpass.TabIndex = 1;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(300, 133);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(99, 25);
            lbluser.TabIndex = 2;
            lbluser.Text = "User Name";
            lbluser.Click += lbluser_Click;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(312, 209);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(87, 25);
            lblpass.TabIndex = 3;
            lblpass.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(355, 309);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 34);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(510, 309);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(112, 34);
            btnclear.TabIndex = 5;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 973);
            Controls.Add(btnclear);
            Controls.Add(btnlogin);
            Controls.Add(lblpass);
            Controls.Add(lbluser);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpass;
        private Label lbluser;
        private Label lblpass;
        private Button btnlogin;
        private Button btnclear;
    }
}
