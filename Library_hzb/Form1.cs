using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_hzb
{
    public partial class Form1 : Form
    {
    

     

        public Form1()
        {
            InitializeComponent();
        }
        void frm() {
            Hide();
            new frmMain().ShowDialog();
            Close();
    

        }

        private void btnpw_Click(object sender, EventArgs e)
        {if (txtpw.Text == "1400")
            { frm(); }
           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.Font = new Font(MyFont.vazir(), 10, FontStyle.Regular);
            


        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtpw.Text == "1400")
                { frm(); }


            }
        }
    }
}
