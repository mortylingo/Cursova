namespace WindowsFormsApp1.forms
{
    partial class registrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            this.loginField = new System.Windows.Forms.TextBox();
            this.regField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.MenuText;
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginField.Location = new System.Drawing.Point(81, 38);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(148, 19);
            this.loginField.TabIndex = 0;
            this.loginField.Text = "Введіть логін";
            this.loginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginField.Click += new System.EventHandler(this.loginField_Click);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // regField
            // 
            this.regField.BackColor = System.Drawing.SystemColors.MenuText;
            this.regField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.regField.Location = new System.Drawing.Point(260, 38);
            this.regField.Name = "regField";
            this.regField.Size = new System.Drawing.Size(148, 19);
            this.regField.TabIndex = 0;
            this.regField.Text = "Введіть пароль";
            this.regField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regField.Click += new System.EventHandler(this.regField_Click);
            this.regField.Leave += new System.EventHandler(this.regField_Leave);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.MenuText;
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameField.Location = new System.Drawing.Point(81, 82);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(148, 19);
            this.nameField.TabIndex = 0;
            this.nameField.Text = "Введіть ім\'я";
            this.nameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameField.Click += new System.EventHandler(this.nameField_Click);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.SystemColors.MenuText;
            this.surnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.surnameField.Location = new System.Drawing.Point(260, 82);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(148, 19);
            this.surnameField.TabIndex = 0;
            this.surnameField.Text = "Введіть фамілію";
            this.surnameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameField.Click += new System.EventHandler(this.surnameField_Click);
            this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(186, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зареєструватись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(183, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вже маєте аккаунт?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(490, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.regField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.loginField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація користувача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox regField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button button1;
    }
}