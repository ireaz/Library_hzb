using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_hzb
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

            private void frmMain_Load(object sender, EventArgs e)
        {
            this.Font = new Font(MyFont.vazir(), 10, FontStyle.Regular);
          
        }

        private void Books_Click(object sender, EventArgs e)
        {
           
            new frmBooks().ShowDialog();
        }

        private void FUser_Click(object sender, EventArgs e)
        {
            new frmStudents().ShowDialog();
        }

        private void Topic_Click(object sender, EventArgs e)
        {
            new frmTopic().ShowDialog();
        }

        private void BorrowBooks_Click(object sender, EventArgs e)
        {
            new frmBorrowBooks().ShowDialog();
        }
    }
}
