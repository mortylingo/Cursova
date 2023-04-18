namespace WindowsFormsApp1.forms
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.MenuText;
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginField.Location = new System.Drawing.Point(58, 60);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(170, 20);
            this.loginField.TabIndex = 0;
            this.loginField.Text = "Введіть логін";
            this.loginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginField.Click += new System.EventHandler(this.loginField_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.MenuText;
            this.passwordField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordField.Location = new System.Drawing.Point(58, 95);
            this.passwordField.Mask = "Введіть пароль";
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(170, 20);
            this.passwordField.TabIndex = 1;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordField.Click += new System.EventHandler(this.passwordField_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(80, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Увійти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(92, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Зареєструватись";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.MaskedTextBox passwordField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}