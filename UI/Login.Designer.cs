namespace Simple_Screen_Recorder.UI
{
    partial class Login
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
            txt_usernane = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_usernane
            // 
            txt_usernane.Location = new Point(66, 60);
            txt_usernane.Name = "txt_usernane";
            txt_usernane.Size = new Size(155, 23);
            txt_usernane.TabIndex = 0;
            txt_usernane.Text = "cuong1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 26);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhâp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 101);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(66, 135);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(155, 23);
            txt_password.TabIndex = 2;
            txt_password.Text = "cuong1";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(66, 194);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(104, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 238);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_usernane);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usernane;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Button btn_login;
    }
}