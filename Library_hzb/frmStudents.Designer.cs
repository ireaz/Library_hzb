namespace Library_hzb
{
    partial class frmStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ser = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.sertype = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studenyNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_data = new Library_hzb.Library_data();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stre = new System.Windows.Forms.RichTextBox();
            this.numberR = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertST = new System.Windows.Forms.Button();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUTell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUNA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUS = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Library_hzb.Library_dataTableAdapters.StudentsTableAdapter();
            this.view_studentsTableAdapter = new Library_hzb.Library_dataTableAdapters.View_studentsTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_data)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "دانشجو ها";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ser);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.sertype);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(597, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 615);
            this.panel4.TabIndex = 2;
            // 
            // ser
            // 
            this.ser.Location = new System.Drawing.Point(15, 91);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(213, 37);
            this.ser.TabIndex = 5;
            this.ser.TextChanged += new System.EventHandler(this.ser_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(199, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 30);
            this.label20.TabIndex = 6;
            this.label20.Text = "اسم  فیلد";
            // 
            // sertype
            // 
            this.sertype.FormattingEnabled = true;
            this.sertype.Items.AddRange(new object[] {
            "Name",
            "Family",
            "TellNumber"});
            this.sertype.Location = new System.Drawing.Point(52, 28);
            this.sertype.Name = "sertype";
            this.sertype.Size = new System.Drawing.Size(141, 37);
            this.sertype.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(234, 90);
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
            this.panel3.Size = new System.Drawing.Size(677, 615);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studenyNumbersDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.tellNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewstudentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 615);
            this.dataGridView1.TabIndex = 0;
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
            // viewstudentsBindingSource
            // 
            this.viewstudentsBindingSource.DataMember = "View_students";
            this.viewstudentsBindingSource.DataSource = this.library_data;
            // 
            // library_data
            // 
            this.library_data.DataSetName = "Library_data";
            this.library_data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stre);
            this.tabPage2.Controls.Add(this.numberR);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtUNT);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtFamily);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnInsertST);
            this.tabPage2.Controls.Add(this.txtUN);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اضافه کردن";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stre
            // 
            this.stre.Location = new System.Drawing.Point(443, 339);
            this.stre.Name = "stre";
            this.stre.Size = new System.Drawing.Size(142, 274);
            this.stre.TabIndex = 22;
            this.stre.Text = "";
            // 
            // numberR
            // 
            this.numberR.Location = new System.Drawing.Point(638, 262);
            this.numberR.Name = "numberR";
            this.numberR.Size = new System.Drawing.Size(120, 37);
            this.numberR.TabIndex = 21;
            this.numberR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(790, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "شروع از ردیف";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(663, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 30);
            this.label10.TabIndex = 20;
            this.label10.Text = "مثال اپلود فایل اکسل";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(735, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 42);
            this.button3.TabIndex = 18;
            this.button3.Text = "اپلود فایل ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "شماره تلفن";
            // 
            // txtUNT
            // 
            this.txtUNT.Location = new System.Drawing.Point(16, 204);
            this.txtUNT.Name = "txtUNT";
            this.txtUNT.Size = new System.Drawing.Size(349, 37);
            this.txtUNT.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "فامیلی";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(16, 148);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(349, 37);
            this.txtFamily.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 37);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "شماره دانشجوی";
            // 
            // btnInsertST
            // 
            this.btnInsertST.Location = new System.Drawing.Point(123, 311);
            this.btnInsertST.Name = "btnInsertST";
            this.btnInsertST.Size = new System.Drawing.Size(116, 41);
            this.btnInsertST.TabIndex = 10;
            this.btnInsertST.Text = "ثبت";
            this.btnInsertST.UseVisualStyleBackColor = true;
            this.btnInsertST.Click += new System.EventHandler(this.btnInsertST_Click_1);
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(16, 34);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(349, 37);
            this.txtUN.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtUTell);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtUF);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtUNA);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtUS);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(939, 621);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "حذف";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 30);
            this.label9.TabIndex = 28;
            this.label9.Text = "<-- برای انجام عملیات شماره دانشجو را انتخاب کنید ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 27;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "شماره تلفن";
            // 
            // txtUTell
            // 
            this.txtUTell.Location = new System.Drawing.Point(279, 242);
            this.txtUTell.Name = "txtUTell";
            this.txtUTell.Size = new System.Drawing.Size(349, 37);
            this.txtUTell.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "فامیلی";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(279, 186);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(349, 37);
            this.txtUF.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "نام";
            // 
            // txtUNA
            // 
            this.txtUNA.Location = new System.Drawing.Point(279, 126);
            this.txtUNA.Name = "txtUNA";
            this.txtUNA.Size = new System.Drawing.Size(349, 37);
            this.txtUNA.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(634, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "شماره دانشجوی";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "بروز رسانی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUS
            // 
            this.txtUS.Location = new System.Drawing.Point(279, 72);
            this.txtUS.Name = "txtUS";
            this.txtUS.Size = new System.Drawing.Size(349, 37);
            this.txtUS.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsBindingSource, "idUser", true));
            this.listBox1.DataSource = this.studentsBindingSource;
            this.listBox1.DisplayMember = "StudenyNumbers";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 613);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "idUser";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.library_data;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // view_studentsTableAdapter
            // 
            this.view_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(585, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(348, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "<-- شماره دانشجوی تکراری که ثبت نمی شوند ";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 663);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Vazir", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmStudents";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_data)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertST;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUTell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUNA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUS;
        private System.Windows.Forms.ListBox listBox1;
        private Library_data library_data;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Library_dataTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource viewstudentsBindingSource;
        private Library_dataTableAdapters.View_studentsTableAdapter view_studentsTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox sertype;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenyNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numberR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox stre;
        private System.Windows.Forms.Label label12;
    }
}