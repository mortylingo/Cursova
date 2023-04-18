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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startPointField = new System.Windows.Forms.TextBox();
            this.endPointField = new System.Windows.Forms.TextBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.cargoField = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.massField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backToTruck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(653, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(653, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Вантаж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(653, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Місце вигрузки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(653, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Місце загрузки";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(741, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Видалити рейс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Додати рейс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startPointField
            // 
            this.startPointField.Location = new System.Drawing.Point(793, 196);
            this.startPointField.Name = "startPointField";
            this.startPointField.Size = new System.Drawing.Size(191, 20);
            this.startPointField.TabIndex = 11;
            // 
            // endPointField
            // 
            this.endPointField.Location = new System.Drawing.Point(793, 222);
            this.endPointField.Name = "endPointField";
            this.endPointField.Size = new System.Drawing.Size(191, 20);
            this.endPointField.TabIndex = 10;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(793, 274);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(191, 20);
            this.priceField.TabIndex = 8;
            // 
            // cargoField
            // 
            this.cargoField.Location = new System.Drawing.Point(793, 248);
            this.cargoField.Name = "cargoField";
            this.cargoField.Size = new System.Drawing.Size(191, 20);
            this.cargoField.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-32, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 641);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // massField
            // 
            this.massField.Location = new System.Drawing.Point(793, 300);
            this.massField.Name = "massField";
            this.massField.Size = new System.Drawing.Size(191, 20);
            this.massField.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(653, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Вага вантажу";
            // 
            // backToTruck
            // 
            this.backToTruck.Location = new System.Drawing.Point(741, 49);
            this.backToTruck.Name = "backToTruck";
            this.backToTruck.Size = new System.Drawing.Size(156, 23);
            this.backToTruck.TabIndex = 14;
            this.backToTruck.Text = "Повернутись до авто";
            this.backToTruck.UseVisualStyleBackColor = true;
            this.backToTruck.Click += new System.EventHandler(this.backToTruck_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.backToTruck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startPointField);
            this.Controls.Add(this.endPointField);
            this.Controls.Add(this.massField);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.cargoField);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tripsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поїздки";
            this.Load += new System.EventHandler(this.tripsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox startPointField;
        private System.Windows.Forms.TextBox endPointField;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox cargoField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox massField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backToTruck;
        private System.Windows.Forms.Button button1;
    }
}