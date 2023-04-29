namespace WindowsFormsApp1.forms
{
    partial class tripsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tripsForm));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startPointField = new System.Windows.Forms.TextBox();
            this.endPointField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.cargoField = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.massField = new System.Windows.Forms.TextBox();
            this.backToTruck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(751, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Видалити рейс";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(751, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Додати рейс";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startPointField
            // 
            this.startPointField.BackColor = System.Drawing.SystemColors.MenuText;
            this.startPointField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startPointField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPointField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.startPointField.Location = new System.Drawing.Point(22, 29);
            this.startPointField.Name = "startPointField";
            this.startPointField.Size = new System.Drawing.Size(191, 15);
            this.startPointField.TabIndex = 11;
            this.startPointField.Text = "Місце загрузки";
            this.startPointField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startPointField.Enter += new System.EventHandler(this.startPointField_Enter);
            this.startPointField.Leave += new System.EventHandler(this.startPointField_Leave);
            // 
            // endPointField
            // 
            this.endPointField.BackColor = System.Drawing.SystemColors.MenuText;
            this.endPointField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endPointField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endPointField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.endPointField.Location = new System.Drawing.Point(22, 55);
            this.endPointField.Name = "endPointField";
            this.endPointField.Size = new System.Drawing.Size(191, 15);
            this.endPointField.TabIndex = 10;
            this.endPointField.Text = "Місце вигрузки";
            this.endPointField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endPointField.Enter += new System.EventHandler(this.endPointField_Enter);
            this.endPointField.Leave += new System.EventHandler(this.endPointField_Leave);
            // 
            // priceField
            // 
            this.priceField.BackColor = System.Drawing.SystemColors.MenuText;
            this.priceField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.priceField.Location = new System.Drawing.Point(22, 107);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(191, 15);
            this.priceField.TabIndex = 8;
            this.priceField.Text = "Ціна";
            this.priceField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceField.Enter += new System.EventHandler(this.priceField_Enter);
            this.priceField.Leave += new System.EventHandler(this.priceField_Leave);
            // 
            // cargoField
            // 
            this.cargoField.BackColor = System.Drawing.SystemColors.MenuText;
            this.cargoField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargoField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cargoField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cargoField.Location = new System.Drawing.Point(22, 81);
            this.cargoField.Name = "cargoField";
            this.cargoField.Size = new System.Drawing.Size(191, 15);
            this.cargoField.TabIndex = 9;
            this.cargoField.Text = "Вантаж";
            this.cargoField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cargoField.Enter += new System.EventHandler(this.cargoField_Enter);
            this.cargoField.Leave += new System.EventHandler(this.cargoField_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-32, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(702, 676);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // massField
            // 
            this.massField.BackColor = System.Drawing.SystemColors.MenuText;
            this.massField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.massField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.massField.Location = new System.Drawing.Point(22, 133);
            this.massField.Name = "massField";
            this.massField.Size = new System.Drawing.Size(191, 15);
            this.massField.TabIndex = 8;
            this.massField.Text = "Вага ";
            this.massField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.massField.Enter += new System.EventHandler(this.massField_Enter);
            this.massField.Leave += new System.EventHandler(this.massField_Leave);
            // 
            // backToTruck
            // 
            this.backToTruck.BackColor = System.Drawing.Color.Black;
            this.backToTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToTruck.ForeColor = System.Drawing.SystemColors.Control;
            this.backToTruck.Location = new System.Drawing.Point(751, 265);
            this.backToTruck.Name = "backToTruck";
            this.backToTruck.Size = new System.Drawing.Size(156, 23);
            this.backToTruck.TabIndex = 14;
            this.backToTruck.Text = "Повернутись до авто";
            this.backToTruck.UseVisualStyleBackColor = false;
            this.backToTruck.Click += new System.EventHandler(this.backToTruck_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(751, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startPointField);
            this.groupBox1.Controls.Add(this.endPointField);
            this.groupBox1.Controls.Add(this.massField);
            this.groupBox1.Controls.Add(this.priceField);
            this.groupBox1.Controls.Add(this.cargoField);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(714, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 169);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введіть інформацію про рейс";
            // 
            // tripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(990, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.backToTruck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tripsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поїздки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tripsForm_FormClosed);
            this.Load += new System.EventHandler(this.tripsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox startPointField;
        private System.Windows.Forms.TextBox endPointField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox cargoField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox massField;
        private System.Windows.Forms.Button backToTruck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}