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
using Excel=Microsoft.Office.Interop.Excel;


namespace Library_hzb
{
    public partial class frmStudents : Form
    {
        int j;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;
     


        public frmStudents()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.;Initial Catalog=Library2;Integrated Security=True");
            con.Open();
            init();

        }
        void init()
        {
            j = -1;

            cmd = new SqlCommand("SELECT * FROM Students");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            // TODO: This line of code loads data into the 'library_data.View_students' table. You can move, or remove it, as needed.
            this.view_studentsTableAdapter.Fill(this.library_data.View_students);
            // TODO: This line of code loads data into the 'library_data.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.library_data.Students);

        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_data.View_students' table. You can move, or remove it, as needed.
            this.view_studentsTableAdapter.Fill(this.library_data.View_students);
            // TODO: This line of code loads data into the 'library_data.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.library_data.Students);
            this.Font = new System.Drawing.Font(MyFont.vazir(), 11, FontStyle.Regular);
        }

        private void btnInsertST_Click_1(object sender, EventArgs e)
        {
            if (txtFamily.Text != "" && txtUN.Text != "" && txtUNT.Text != "" && txtName.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Students(StudenyNumbers , Name,Family,TellNumber)VAlUES(@SN,@N,@F,@TN)", con);
                cmd.Parameters.AddWithValue("@SN", txtUN.Text);
                cmd.Parameters.AddWithValue("@N", txtName.Text);
                cmd.Parameters.AddWithValue("@F", txtFamily.Text);
                cmd.Parameters.AddWithValue("@TN", txtUNT.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد ");
                init();
            }
            else
            {
                MessageBox.Show(" خالی است ");
            }
        }

        private void btnInsertST_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int itemdelete = int.Parse(listBox1.SelectedValue.ToString());

            if (MessageBox.Show(" ایا میخواهید دانشجو با شماره  " + listBox1.Text + " را حذف کنید ؟  ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("Delete from Students Where idUser=@Pi", con);
                cmd.Parameters.AddWithValue("@Pi", itemdelete);
                cmd.ExecuteNonQuery();
                MessageBox.Show("موضوع حذف شد ");
                init();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemUpdate = int.Parse(listBox1.SelectedValue.ToString());
            if (MessageBox.Show(" ایا میخواهید دانشجو با شماره   " + listBox1.Text + " را بروز کنید ؟  ", "بروز رسانی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("UPDATE Students SET StudenyNumbers=@SN , Name=@Name , Family=@Family , TellNumber=@Tell Where idUser=@upd", con);
                cmd.Parameters.AddWithValue("@SN", txtUS.Text);
                cmd.Parameters.AddWithValue("@Name", txtUNA.Text);
                cmd.Parameters.AddWithValue("@Family", txtUF.Text);
                cmd.Parameters.AddWithValue("@Tell", txtUTell.Text);
                
                cmd.Parameters.AddWithValue("@upd", itemUpdate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد ");
                init();
            }
            else
                MessageBox.Show("فیلد بروز رسانب خالی است   ");

        }

        private void ser_TextChanged(object sender, EventArgs e)
        {


            if ( sertype.Text == "StudenyNumbers" || sertype.Text == "Name" || sertype.Text == "Family" || sertype.Text == "TellNumber")
            {
                da = new SqlDataAdapter("use Library2 SELECT StudenyNumbers,Name,Family,TellNumber From Students    where " + sertype.Text + " like N'%" + ser.Text + "%'   ", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("فلیدی که میخواهید سرچ کنید را انتخاب کنید ");
            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Excel.Application excel = new Excel.Application();
            openFileDialog1.Filter = @"Excel(*.xlsx)|*.xlsx";
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                Excel.Workbook workbooks = excel.Workbooks.Open(file);

                Excel.Worksheet worksheets = workbooks.Worksheets[1];
                Excel.Range range = worksheets.UsedRange;
                int r = int.Parse(numberR.Value.ToString());
                for (int i = r; i <= range.Rows.Count; i++)
                {



                    if (worksheets.Cells[i, 1].value.ToString() != "" && worksheets.Cells[i, 2].value.ToString() != "" && worksheets.Cells[i, 3].value.ToString() != "" && worksheets.Cells[i, 4].value.ToString() != "")
                    {

                        cmd = new SqlCommand("use Library2 select *  from Students Where StudenyNumbers=@SN", con);
                        cmd.Parameters.AddWithValue("@SN", worksheets.Cells[i, 1].value.ToString());
                        SqlDataReader Read = cmd.ExecuteReader();

                        if (!Read.Read())
                        {
                            cmd = new SqlCommand("INSERT INTO Students(StudenyNumbers , Name,Family,TellNumber)VAlUES(@SN,@N,@F,@TN)", con);
                            cmd.Parameters.AddWithValue("@SN", worksheets.Cells[i, 1].value.ToString());
                            cmd.Parameters.AddWithValue("@N", worksheets.Cells[i, 2].value.ToString());
                            cmd.Parameters.AddWithValue("@F", worksheets.Cells[i, 3].value.ToString());
                            cmd.Parameters.AddWithValue("@TN", worksheets.Cells[i, 4].value.ToString());


                            Read.Close();
                            cmd.ExecuteNonQuery();
                            init();
                        }
                        else
                        {
                            stre.Text += "     " + i.ToString() + "   ردیف \n ";
                            Read.Close();
                        }




                    }




                }
                MessageBox.Show("اطلاعات ثبت شد ");

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
