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
    public partial class frmTopic : Form
    {
        public frmTopic()
        {
          //  this.Font = new Font(MyFont.vazir(), 10, FontStyle.Regular);
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.;Initial Catalog=Library2;Integrated Security=True");
            con.Open();
            init();
        }

        private void frmTopic_Load(object sender, EventArgs e)
        {
            this.Font = new Font(MyFont.vazir(), 11, FontStyle.Regular);
            // TODO: This line of code loads data into the 'library_data.Topic' table. You can move, or remove it, as needed.
            this.topicTableAdapter.Fill(this.library_data.Topic);

        }
        int j;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;
        void init()
        {

            j = -1;

            cmd = new SqlCommand("SELECT * FROM Topic");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            this.topicTableAdapter.Fill(this.library_data.Topic);
        }
      

        private void btnTopic_Click(object sender, EventArgs e)
        {
            if (txtTopic.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Topic(TopicTitle)VAlUES(@PN)", con);
                cmd.Parameters.AddWithValue("@PN", txtTopic.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد ");
                init();
            }
            else
            {
                MessageBox.Show("موضوع خالی است ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemdelete = int.Parse(lbTopic.SelectedValue.ToString());

            if (MessageBox.Show(" ایا میخواهید موضوع  " + lbTopic.Text + " را حذف کنید ؟  ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("Delete from Topic Where Topicid=@Pi", con);
                cmd.Parameters.AddWithValue("@Pi", itemdelete);
                cmd.ExecuteNonQuery();
                MessageBox.Show("موضوع حذف شد ");
                init();
            }

        }



        private void txtTopic_TextChanged(object sender, EventArgs e)
        {
            if (btnTopic == null)
                btnTopic.Enabled = false;
            else
                btnTopic.Enabled = true;

        }

        private void btntupdate_Click(object sender, EventArgs e)
        {
            int itemupdate = int.Parse(lbTopic.SelectedValue.ToString());

            if (MessageBox.Show(" ایا میخواهید موضوع  " + lbTopic.Text + " را بروز کنید ؟  ", "بروز رسانی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("UPDATE Topic SET TopicTitle=@ti Where Topicid=@upd", con);
                cmd.Parameters.AddWithValue("@ti", txttupdate.Text);
                cmd.Parameters.AddWithValue("@upd", itemupdate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد ");
                init();
            }
            else
                MessageBox.Show("فیلد بروز رسانب خالی است   ");

        }
    }
}
