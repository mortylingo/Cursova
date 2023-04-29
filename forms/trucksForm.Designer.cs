namespace WindowsFormsApp1.forms
{
    partial class trucksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trucksForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelField = new System.Windows.Forms.TextBox();
            this.manufacturerField = new System.Windows.Forms.TextBox();
            this.driverField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.plateField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(889, 496);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // modelField
            // 
            this.modelField.BackColor = System.Drawing.SystemColors.ControlText;
            this.modelField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.modelField.Location = new System.Drawing.Point(33, 75);
            this.modelField.Name = "modelField";
            this.modelField.Size = new System.Drawing.Size(191, 15);
            this.modelField.TabIndex = 3;
            this.modelField.Text = "Модель вантажівки";
            this.modelField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelField.Enter += new System.EventHandler(this.modelField_Enter);
            this.modelField.Leave += new System.EventHandler(this.modelField_Leave);
            // 
            // manufacturerField
            // 
            this.manufacturerField.BackColor = System.Drawing.SystemColors.ControlText;
            this.manufacturerField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manufacturerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.manufacturerField.Location = new System.Drawing.Point(33, 49);
            this.manufacturerField.Name = "manufacturerField";
            this.manufacturerField.Size = new System.Drawing.Size(191, 15);
            this.manufacturerField.TabIndex = 2;
            this.manufacturerField.Text = "Марка вантажівки";
            this.manufacturerField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manufacturerField.Enter += new System.EventHandler(this.manufacturerField_Enter);
            this.manufacturerField.Leave += new System.EventHandler(this.manufacturerField_Leave);
            // 
            // driverField
            // 
            this.driverField.BackColor = System.Drawing.SystemColors.ControlText;
            this.driverField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driverField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.driverField.Location = new System.Drawing.Point(33, 23);
            this.driverField.Name = "driverField";
            this.driverField.Size = new System.Drawing.Size(191, 15);
            this.driverField.TabIndex = 1;
            this.driverField.Text = "Водій";
            this.driverField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.driverField.Enter += new System.EventHandler(this.driverField_Enter);
            this.driverField.Leave += new System.EventHandler(this.driverField_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(491, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Переглянути поїздки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(491, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Додати вантажівку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(491, 626);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Видалити вантажівку";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // plateField
            // 
            this.plateField.BackColor = System.Drawing.SystemColors.ControlText;
            this.plateField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plateField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.plateField.Location = new System.Drawing.Point(33, 101);
            this.plateField.Name = "plateField";
            this.plateField.Size = new System.Drawing.Size(191, 15);
            this.plateField.TabIndex = 4;
            this.plateField.Text = "Номерний знак";
            this.plateField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plateField.Enter += new System.EventHandler(this.plateField_Enter);
            this.plateField.Leave += new System.EventHandler(this.plateField_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.driverField);
            this.groupBox1.Controls.Add(this.manufacturerField);
            this.groupBox1.Controls.Add(this.plateField);
            this.groupBox1.Controls.Add(this.modelField);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(184, 528);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть інформацію про авто";
            // 
            // trucksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(888, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trucksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вантажівки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.trucksForm_FormClosed);
            this.Load += new System.EventHandler(this.trucksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox modelField;
        private System.Windows.Forms.TextBox manufacturerField;
        private System.Windows.Forms.TextBox driverField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox plateField;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}