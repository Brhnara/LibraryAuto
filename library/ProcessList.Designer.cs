namespace library
{
    partial class ProcessList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewProcessList = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxMember = new System.Windows.Forms.TextBox();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dateTimePickerBorrowed = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDelivery = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerBorrowed2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDelivery2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Borrowed Time Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivered Time Range";
            // 
            // dataGridViewProcessList
            // 
            this.dataGridViewProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessList.Location = new System.Drawing.Point(12, 313);
            this.dataGridViewProcessList.Name = "dataGridViewProcessList";
            this.dataGridViewProcessList.Size = new System.Drawing.Size(569, 167);
            this.dataGridViewProcessList.TabIndex = 5;
            this.dataGridViewProcessList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessList_CellClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(32, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Undelivered Books";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxMember
            // 
            this.textBoxMember.Location = new System.Drawing.Point(254, 10);
            this.textBoxMember.Name = "textBoxMember";
            this.textBoxMember.Size = new System.Drawing.Size(139, 20);
            this.textBoxMember.TabIndex = 7;
            this.textBoxMember.TextChanged += new System.EventHandler(this.textBoxMember_TextChanged);
            // 
            // textBoxBook
            // 
            this.textBoxBook.Location = new System.Drawing.Point(254, 42);
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.Size = new System.Drawing.Size(139, 20);
            this.textBoxBook.TabIndex = 8;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(153, 258);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(122, 47);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dateTimePickerBorrowed
            // 
            this.dateTimePickerBorrowed.CustomFormat = "YYYY/MM/DD";
            this.dateTimePickerBorrowed.Location = new System.Drawing.Point(254, 76);
            this.dateTimePickerBorrowed.Name = "dateTimePickerBorrowed";
            this.dateTimePickerBorrowed.ShowCheckBox = true;
            this.dateTimePickerBorrowed.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerBorrowed.TabIndex = 14;
            // 
            // dateTimePickerDelivery
            // 
            this.dateTimePickerDelivery.CustomFormat = "YYYY/MM/DD";
            this.dateTimePickerDelivery.Location = new System.Drawing.Point(254, 111);
            this.dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            this.dateTimePickerDelivery.ShowCheckBox = true;
            this.dateTimePickerDelivery.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerDelivery.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerBorrowed2
            // 
            this.dateTimePickerBorrowed2.CustomFormat = "YYYY/MM/DD";
            this.dateTimePickerBorrowed2.Location = new System.Drawing.Point(383, 78);
            this.dateTimePickerBorrowed2.Name = "dateTimePickerBorrowed2";
            this.dateTimePickerBorrowed2.ShowCheckBox = true;
            this.dateTimePickerBorrowed2.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerBorrowed2.TabIndex = 17;
            // 
            // dateTimePickerDelivery2
            // 
            this.dateTimePickerDelivery2.CustomFormat = "YYYY/MM/DD";
            this.dateTimePickerDelivery2.Location = new System.Drawing.Point(383, 111);
            this.dateTimePickerDelivery2.Name = "dateTimePickerDelivery2";
            this.dateTimePickerDelivery2.ShowCheckBox = true;
            this.dateTimePickerDelivery2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePickerDelivery2.TabIndex = 18;
            // 
            // ProcessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(593, 492);
            this.Controls.Add(this.dateTimePickerDelivery2);
            this.Controls.Add(this.dateTimePickerBorrowed2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerDelivery);
            this.Controls.Add(this.dateTimePickerBorrowed);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxBook);
            this.Controls.Add(this.textBoxMember);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridViewProcessList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessList";
            this.Text = "ProcessList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxMember;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowed;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelivery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowed2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelivery2;
        public System.Windows.Forms.DataGridView dataGridViewProcessList;
    }
}