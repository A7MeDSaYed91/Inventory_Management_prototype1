namespace Inventory
{
    partial class loginform
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            showpassCK = new CheckBox();
            label1 = new Label();
            signupB = new Button();
            loginB = new Button();
            passwordT = new TextBox();
            passwordL = new Label();
            usernameT = new TextBox();
            usernameL = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 556);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold);
            label2.Location = new Point(56, 83);
            label2.Name = "label2";
            label2.Size = new Size(223, 28);
            label2.TabIndex = 8;
            label2.Text = "Inventory LogIn";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(showpassCK);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(signupB);
            panel2.Controls.Add(loginB);
            panel2.Controls.Add(passwordT);
            panel2.Controls.Add(passwordL);
            panel2.Controls.Add(usernameT);
            panel2.Controls.Add(usernameL);
            panel2.Location = new Point(344, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 556);
            panel2.TabIndex = 1;
            // 
            // showpassCK
            // 
            showpassCK.AutoSize = true;
            showpassCK.Font = new Font("Verdana", 10.2F);
            showpassCK.Location = new Point(190, 295);
            showpassCK.Name = "showpassCK";
            showpassCK.Size = new Size(164, 24);
            showpassCK.TabIndex = 7;
            showpassCK.Text = "Show Password";
            showpassCK.UseVisualStyleBackColor = true;
            showpassCK.CheckedChanged += showpassCK_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 10.8F);
            label1.Location = new Point(449, 10);
            label1.Name = "label1";
            label1.Size = new Size(29, 26);
            label1.TabIndex = 6;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // signupB
            // 
            signupB.FlatStyle = FlatStyle.Flat;
            signupB.Font = new Font("Verdana", 10.8F);
            signupB.Location = new Point(135, 365);
            signupB.Name = "signupB";
            signupB.Size = new Size(94, 37);
            signupB.TabIndex = 5;
            signupB.Text = "SignUp";
            signupB.UseVisualStyleBackColor = true;
            signupB.Click += signupB_Click;
            // 
            // loginB
            // 
            loginB.FlatStyle = FlatStyle.Flat;
            loginB.Font = new Font("Verdana", 10.8F);
            loginB.Location = new Point(298, 365);
            loginB.Name = "loginB";
            loginB.Size = new Size(94, 37);
            loginB.TabIndex = 4;
            loginB.Text = "LogIn";
            loginB.UseVisualStyleBackColor = true;
            loginB.Click += loginB_Click;
            // 
            // passwordT
            // 
            passwordT.BackColor = SystemColors.Info;
            passwordT.Font = new Font("Segoe UI", 12F);
            passwordT.Location = new Point(180, 235);
            passwordT.Name = "passwordT";
            passwordT.Size = new Size(180, 34);
            passwordT.TabIndex = 3;
            passwordT.UseSystemPasswordChar = true;
            // 
            // passwordL
            // 
            passwordL.AutoSize = true;
            passwordL.Font = new Font("Verdana", 12F);
            passwordL.Location = new Point(51, 240);
            passwordL.Name = "passwordL";
            passwordL.Size = new Size(105, 25);
            passwordL.TabIndex = 2;
            passwordL.Text = "Password";
            // 
            // usernameT
            // 
            usernameT.BackColor = SystemColors.Info;
            usernameT.Font = new Font("Segoe UI", 12F);
            usernameT.Location = new Point(180, 164);
            usernameT.Name = "usernameT";
            usernameT.Size = new Size(180, 34);
            usernameT.TabIndex = 1;
            // 
            // usernameL
            // 
            usernameL.AutoSize = true;
            usernameL.Font = new Font("Verdana", 12F);
            usernameL.Location = new Point(51, 169);
            usernameL.Name = "usernameL";
            usernameL.Size = new Size(123, 25);
            usernameL.TabIndex = 0;
            usernameL.Text = "User Name";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 556);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "loginform";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox usernameT;
        private Label usernameL;
        private TextBox passwordT;
        private Label passwordL;
        private Button signupB;
        private Button loginB;
        private Label label1;
        private CheckBox showpassCK;
        private Label label2;
    }
}
