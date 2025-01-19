namespace Library_hzb
{
    partial class frmBorrowBooks
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
            this.components = new System.ComponentModel.Container();
            this.viewborrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_data = new Library_hzb.Library_data();
            this.bookDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataTableAdapter = new Library_hzb.Library_dataTableAdapters.BookDataTableAdapter();
            this.studentsTableAdapter = new Library_hzb.Library_dataTableAdapters.StudentsTableAdapter();
            this.view_borrosTableAdapter = new Library_hzb.Library_dataTableAdapters.View_borrosTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComBorrow = new System.Windows.Forms.ComboBox();
            this.borrowBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.comSN = new System.Windows.Forms.ComboBox();
            this.btnUPDate = new System.Windows.Forms.Button();
            this.comUBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataU = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cstudent = new System.Windows.Forms.ComboBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.cbook = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ser = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.sertype = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrowBooksidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studenyNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.borrowBooksTableAdapter = new Library_hzb.Library_dataTableAdapters.BorrowBooksTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.viewborrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBooksBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewborrosBindingSource
            // 
            this.viewborrosBindingSource.DataMember = "View_borros";
            this.viewborrosBindingSource.DataSource = this.library_data;
            // 
            // library_data
            // 
            this.library_data.DataSetName = "Library_data";
            this.library_data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDataBindingSource
            // 
            this.bookDataBindingSource.DataMember = "BookData";
            this.bookDataBindingSource.DataSource = this.library_data;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.library_data;
            // 
            // bookDataTableAdapter
            // 
            this.bookDataTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // view_borrosTableAdapter
            // 
            this.view_borrosTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1380, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اضافه کردن ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ComBorrow);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.comSN);
            this.panel1.Controls.Add(this.btnUPDate);
            this.panel1.Controls.Add(this.comUBook);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataU);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(640, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 515);
            this.panel1.TabIndex = 56;
            // 
            // ComBorrow
            // 
            this.ComBorrow.DataSource = this.borrowBooksBindingSource;
            this.ComBorrow.DisplayMember = "BorrowBooksid";
            this.ComBorrow.FormattingEnabled = true;
            this.ComBorrow.Location = new System.Drawing.Point(37, 57);
            this.ComBorrow.Name = "ComBorrow";
            this.ComBorrow.Size = new System.Drawing.Size(382, 37);
            this.ComBorrow.TabIndex = 14;
            this.ComBorrow.ValueMember = "BorrowBooksid";
            // 
            // borrowBooksBindingSource
            // 
            this.borrowBooksBindingSource.DataMember = "BorrowBooks";
            this.borrowBooksBindingSource.DataSource = this.library_data;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(122, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 42);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comSN
            // 
            this.comSN.DataSource = this.studentsBindingSource;
            this.comSN.DisplayMember = "StudenyNumbers";
            this.comSN.FormattingEnabled = true;
            this.comSN.Location = new System.Drawing.Point(37, 133);
            this.comSN.Name = "comSN";
            this.comSN.Size = new System.Drawing.Size(382, 37);
            this.comSN.TabIndex = 6;
            this.comSN.ValueMember = "idUser";
            // 
            // btnUPDate
            // 
            this.btnUPDate.Location = new System.Drawing.Point(353, 421);
            this.btnUPDate.Name = "btnUPDate";
            this.btnUPDate.Size = new System.Drawing.Size(109, 42);
            this.btnUPDate.TabIndex = 12;
            this.btnUPDate.Text = "بروز رسانی";
            this.btnUPDate.UseVisualStyleBackColor = true;
            this.btnUPDate.Click += new System.EventHandler(this.btnUPDate_Click);
            // 
            // comUBook
            // 
            this.comUBook.DataSource = this.bookDataBindingSource;
            this.comUBook.DisplayMember = "NameBook";
            this.comUBook.FormattingEnabled = true;
            this.comUBook.Location = new System.Drawing.Point(37, 214);
            this.comUBook.Name = "comUBook";
            this.comUBook.Size = new System.Drawing.Size(382, 37);
            this.comUBook.TabIndex = 7;
            this.comUBook.ValueMember = "BookId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "تاریخ";
            // 
            // dataU
            // 
            this.dataU.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.dataU.CustomFormat = "yyyy mm dd";
            this.dataU.Location = new System.Drawing.Point(37, 290);
            this.dataU.Name = "dataU";
            this.dataU.Size = new System.Drawing.Size(382, 37);
            this.dataU.TabIndex = 8;
            this.dataU.TabStop = false;
            this.dataU.Value = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "اسم کتاب ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "شماره دانشجو ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "شماره امانت ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.cstudent);
            this.panel2.Controls.Add(this.btnBorrow);
            this.panel2.Controls.Add(this.cbook);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 515);
            this.panel2.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(976, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 37);
            this.comboBox2.TabIndex = 0;
            // 
            // cstudent
            // 
            this.cstudent.DataSource = this.studentsBindingSource;
            this.cstudent.DisplayMember = "StudenyNumbers";
            this.cstudent.FormattingEnabled = true;
            this.cstudent.Location = new System.Drawing.Point(43, 85);
            this.cstudent.Name = "cstudent";
            this.cstudent.Size = new System.Drawing.Size(382, 37);
            this.cstudent.TabIndex = 0;
            this.cstudent.ValueMember = "idUser";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(209, 323);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(109, 42);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "ثبت";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // cbook
            // 
            this.cbook.DataSource = this.bookDataBindingSource;
            this.cbook.DisplayMember = "NameBook";
            this.cbook.FormattingEnabled = true;
            this.cbook.Location = new System.Drawing.Point(43, 166);
            this.cbook.Name = "cbook";
            this.cbook.Size = new System.Drawing.Size(382, 37);
            this.cbook.TabIndex = 1;
            this.cbook.ValueMember = "BookId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "تاریخ";
            // 
            // dtime
            // 
            this.dtime.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.dtime.CustomFormat = "yyyy mm dd";
            this.dtime.Location = new System.Drawing.Point(43, 242);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(382, 37);
            this.dtime.TabIndex = 1;
            this.dtime.TabStop = false;
            this.dtime.Value = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم کتاب ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "شماره دانشجو ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "نمایش امانت برده شده ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ser);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.sertype);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1036, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 552);
            this.panel4.TabIndex = 0;
            // 
            // ser
            // 
            this.ser.Location = new System.Drawing.Point(14, 96);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(213, 37);
            this.ser.TabIndex = 5;
            this.ser.TextChanged += new System.EventHandler(this.ser_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(198, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 30);
            this.label20.TabIndex = 6;
            this.label20.Text = "اسم  فیلد";
            // 
            // sertype
            // 
            this.sertype.FormattingEnabled = true;
            this.sertype.Items.AddRange(new object[] {
            "BorrowBooksid",
            "NameBook",
            "PrintYear",
            "Publisher",
            "StudenyNumbers",
            "Name",
            "Family",
            "TellNumber"});
            this.sertype.Location = new System.Drawing.Point(51, 33);
            this.sertype.Name = "sertype";
            this.sertype.Size = new System.Drawing.Size(141, 37);
            this.sertype.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(233, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 30);
            this.label19.TabIndex = 7;
            this.label19.Text = "مقدار سرچ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 552);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowBooksidDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.nameBookDataGridViewTextBoxColumn,
            this.printYearDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.studenyNumbersDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.tellNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewborrosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // borrowBooksidDataGridViewTextBoxColumn
            // 
            this.borrowBooksidDataGridViewTextBoxColumn.DataPropertyName = "BorrowBooksid";
            this.borrowBooksidDataGridViewTextBoxColumn.HeaderText = "BorrowBooksid";
            this.borrowBooksidDataGridViewTextBoxColumn.Name = "borrowBooksidDataGridViewTextBoxColumn";
            this.borrowBooksidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            this.nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.HeaderText = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            this.nameBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printYearDataGridViewTextBoxColumn
            // 
            this.printYearDataGridViewTextBoxColumn.DataPropertyName = "PrintYear";
            this.printYearDataGridViewTextBoxColumn.HeaderText = "PrintYear";
            this.printYearDataGridViewTextBoxColumn.Name = "printYearDataGridViewTextBoxColumn";
            this.printYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studenyNumbersDataGridViewTextBoxColumn
            // 
            this.studenyNumbersDataGridViewTextBoxColumn.DataPropertyName = "StudenyNumbers";
            this.studenyNumbersDataGridViewTextBoxColumn.HeaderText = "StudenyNumbers";
            this.studenyNumbersDataGridViewTextBoxColumn.Name = "studenyNumbersDataGridViewTextBoxColumn";
            this.studenyNumbersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tellNumberDataGridViewTextBoxColumn
            // 
            this.tellNumberDataGridViewTextBoxColumn.DataPropertyName = "TellNumber";
            this.tellNumberDataGridViewTextBoxColumn.HeaderText = "TellNumber";
            this.tellNumberDataGridViewTextBoxColumn.Name = "tellNumberDataGridViewTextBoxColumn";
            this.tellNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1388, 600);
            this.tabControl1.TabIndex = 1;
            // 
            // borrowBooksTableAdapter
            // 
            this.borrowBooksTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 600);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "frmBorrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBorrowBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBorrowBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewborrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBooksBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Library_data library_data;
        private System.Windows.Forms.BindingSource bookDataBindingSource;
        private Library_dataTableAdapters.BookDataTableAdapter bookDataTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Library_dataTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource viewborrosBindingSource;
        private Library_dataTableAdapters.View_borrosTableAdapter view_borrosTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtime;
        private System.Windows.Forms.ComboBox cbook;
        private System.Windows.Forms.ComboBox cstudent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowBooksidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenyNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comSN;
        private System.Windows.Forms.Button btnUPDate;
        private System.Windows.Forms.ComboBox comUBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource borrowBooksBindingSource;
        private Library_dataTableAdapters.BorrowBooksTableAdapter borrowBooksTableAdapter;
        private System.Windows.Forms.ComboBox ComBorrow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox sertype;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}