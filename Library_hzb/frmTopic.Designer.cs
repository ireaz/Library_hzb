namespace Library_hzb
{
    partial class frmTopic
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
            this.txttupdate = new System.Windows.Forms.TextBox();
            this.btntupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTopic = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.lbTopic = new System.Windows.Forms.ListBox();
            this.library_data = new Library_hzb.Library_data();
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicTableAdapter = new Library_hzb.Library_dataTableAdapters.TopicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.library_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txttupdate
            // 
            this.txttupdate.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttupdate.Location = new System.Drawing.Point(241, 193);
            this.txttupdate.Name = "txttupdate";
            this.txttupdate.Size = new System.Drawing.Size(291, 37);
            this.txttupdate.TabIndex = 14;
            // 
            // btntupdate
            // 
            this.btntupdate.Location = new System.Drawing.Point(443, 253);
            this.btntupdate.Name = "btntupdate";
            this.btntupdate.Size = new System.Drawing.Size(89, 33);
            this.btntupdate.TabIndex = 13;
            this.btntupdate.Text = "بروزرسانی";
            this.btntupdate.UseVisualStyleBackColor = true;
            this.btntupdate.Click += new System.EventHandler(this.btntupdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "بروزرسانی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "موضوع";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(444, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 37);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTopic
            // 
            this.btnTopic.Location = new System.Drawing.Point(444, 106);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Size = new System.Drawing.Size(89, 33);
            this.btnTopic.TabIndex = 9;
            this.btnTopic.Text = "اضافه کردن";
            this.btnTopic.UseVisualStyleBackColor = true;
            this.btnTopic.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // txtTopic
            // 
            this.txtTopic.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic.Location = new System.Drawing.Point(240, 55);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTopic.Size = new System.Drawing.Size(293, 37);
            this.txtTopic.TabIndex = 8;
            // 
            // lbTopic
            // 
            this.lbTopic.DataSource = this.topicBindingSource;
            this.lbTopic.DisplayMember = "TopicTitle";
            this.lbTopic.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTopic.ItemHeight = 29;
            this.lbTopic.Location = new System.Drawing.Point(0, 0);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTopic.Size = new System.Drawing.Size(131, 492);
            this.lbTopic.TabIndex = 7;
            this.lbTopic.ValueMember = "Topicid";
            // 
            // library_data
            // 
            this.library_data.DataSetName = "Library_data";
            this.library_data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataMember = "Topic";
            this.topicBindingSource.DataSource = this.library_data;
            // 
            // topicTableAdapter
            // 
            this.topicTableAdapter.ClearBeforeFill = true;
            // 
            // frmTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 492);
            this.Controls.Add(this.txttupdate);
            this.Controls.Add(this.btntupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTopic);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lbTopic);
            this.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimizeBox = false;
            this.Name = "frmTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTopic";
            this.Load += new System.EventHandler(this.frmTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttupdate;
        private System.Windows.Forms.Button btntupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.ListBox lbTopic;
        private Library_data library_data;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private Library_dataTableAdapters.TopicTableAdapter topicTableAdapter;
    }
}