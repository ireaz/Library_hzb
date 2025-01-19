namespace Library_hzb
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Topic = new System.Windows.Forms.PictureBox();
            this.Books = new System.Windows.Forms.PictureBox();
            this.BorrowBooks = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Topic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Topic
            // 
            this.Topic.Image = ((System.Drawing.Image)(resources.GetObject("Topic.Image")));
            this.Topic.Location = new System.Drawing.Point(216, 255);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(157, 148);
            this.Topic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Topic.TabIndex = 15;
            this.Topic.TabStop = false;
            this.Topic.Click += new System.EventHandler(this.Topic_Click);
            // 
            // Books
            // 
            this.Books.Image = ((System.Drawing.Image)(resources.GetObject("Books.Image")));
            this.Books.Location = new System.Drawing.Point(216, 13);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(157, 148);
            this.Books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Books.TabIndex = 13;
            this.Books.TabStop = false;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // BorrowBooks
            // 
            this.BorrowBooks.Image = ((System.Drawing.Image)(resources.GetObject("BorrowBooks.Image")));
            this.BorrowBooks.Location = new System.Drawing.Point(37, 255);
            this.BorrowBooks.Name = "BorrowBooks";
            this.BorrowBooks.Size = new System.Drawing.Size(157, 148);
            this.BorrowBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorrowBooks.TabIndex = 12;
            this.BorrowBooks.TabStop = false;
            this.BorrowBooks.Click += new System.EventHandler(this.BorrowBooks_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "موضوعات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "امانت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "کتاب ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "کاربر";
            // 
            // FUser
            // 
            this.FUser.Image = ((System.Drawing.Image)(resources.GetObject("FUser.Image")));
            this.FUser.Location = new System.Drawing.Point(37, 13);
            this.FUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FUser.Name = "FUser";
            this.FUser.Size = new System.Drawing.Size(157, 148);
            this.FUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FUser.TabIndex = 6;
            this.FUser.TabStop = false;
            this.FUser.Click += new System.EventHandler(this.FUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 477);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.BorrowBooks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FUser);
            this.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Topic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox Topic;
        private System.Windows.Forms.PictureBox Books;
        private System.Windows.Forms.PictureBox BorrowBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FUser;

        internal class ShowDialog
        {
            public ShowDialog()
            {
            }
        }

        #endregion
    }
}