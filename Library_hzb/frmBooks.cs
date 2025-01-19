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
using Excel = Microsoft.Office.Interop.Excel;

namespace Library_hzb
{
    public partial class frmBooks : Form
    {
        int j, NOP, P, T, idubdate;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;

        void init()
        {

            j = -1;

            cmd = new SqlCommand("SELECT * FROM BookData");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            da = new SqlDataAdapter("use Library2 select BookId,NameBook,PrintYear,Published,Publisher,Price,NumberOfPages,PublisherEmail,TopicTitle from BookData INNER JOIN Topic on BookData.Topicid=Topic.Topicid ", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;







            this.bookDataTableAdapter1.Fill(this.library2_data.BookData);
            // TODO: This line of code loads data into the 'library2_data.View_Books' table. You can move, or remove it, as needed.
            this.view_BooksTableAdapter.Fill(this.library2_data.View_Books);
            // TODO: This line of code loads data into the 'library_data.View_Books' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'library2_data.View_Books' table. You can move, or remove it, as needed.
            this.view_BooksTableAdapter.Fill(this.library2_data.View_Books);
            // TODO: This line of code loads data into the 'library_data.View_borros' table. You can move, or remove it, as needed.



            this.topicTableAdapter.Fill(this.library_data.Topic);
            // TODO: This line of code loads data into the 'library_data.BookData' table. You can move, or remove it, as needed.
            this.bookDataTableAdapter.Fill(this.library_data.BookData);


            this.bookDataTableAdapter.Fill(this.library_data.BookData);






        }

        public frmBooks()
        {
            
            //  this.Font = new Font(MyFont.vazir(), 10, FontStyle.Regular);
            this.Font = new Font(MyFont.vazir(), 11, FontStyle.Regular);

            InitializeComponent();
            con = new SqlConnection(@"Data Source=.;Initial Catalog=Library2;Integrated Security=True");
            con.Open();
            init();




        }

        private void btnBdel_Click(object sender, EventArgs e)
        {
            int itemdelete;
            if (cbBook.Checked == true)
            {
                itemdelete = int.Parse(coBNDel.SelectedValue.ToString());
                if (MessageBox.Show(" ایا میخواهید کتاب   " + coBNDel.Text + " را حذف کنید ؟  ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete from BookData Where BookId=@Pi", con);
                    
                    cmd.Parameters.AddWithValue("@Pi", itemdelete);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("موضوع حذف شد ");
                    init();
                }
            }

            else if (cbId.Checked == true)
            {
                itemdelete = int.Parse(TId.Text.ToString());
                if (MessageBox.Show(" ایا میخواهید کتاب   " + itemdelete + " را حذف کنید ؟  ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete from BookData Where BookId=@Pi", con);
                    cmd.Parameters.AddWithValue("@Pi", itemdelete);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("موضوع حذف شد ");
                    init();
                }
            }
        }

        private void ser_TextChanged(object sender, EventArgs e)

        {
            if (ser.Text!=""||sertype.Text == "NameBook" || sertype.Text == "PrintYear" || sertype.Text == "Published" || sertype.Text == "Publisher" || sertype.Text == "Price" || sertype.Text == "TopicTitle")
            {
                da = new SqlDataAdapter("use Library2 select BookId,NameBook,PrintYear,Published,Publisher,Price,NumberOfPages,PublisherEmail,TopicTitle from BookData INNER JOIN Topic on BookData.Topicid=Topic.Topicid    where " + sertype.Text + " like N'%" + ser.Text + "%'   ", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
             
              
              
            }
            else {
                MessageBox.Show("فلیدی که میخواهید سرچ کنید را انتخاب کنید ");
            }
           // (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("NameBook = '{0}'", ser.Text);
        }

        private void txtBYear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBYear.Text, "  ^ [0-9]") )
            {
                txtBYear.Text = "";
            }
        }

        private void txtBYear_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
            {
                e.Handled = true;
            }
        }

        private void txtBPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBPrice.Text, "  ^ [0-9]"))
            {
                txtBPrice.Text = "";
            }
        }

        private void txtBPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbuyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbuyear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbuyear.Text, "  ^ [0-9]"))
            {
                tbuyear.Text = "";
            }
        }

        private void tbuPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbuPrice.Text, "  ^ [0-9]"))
            {
                tbuPrice.Text = "";
            }
        }

        private void tbuPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BookView_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnU_Click(object sender, EventArgs e)
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



                    if (worksheets.Cells[i, 1].value.ToString() != "" && worksheets.Cells[i, 2].value.ToString() != "" && worksheets.Cells[i, 3].value.ToString() != ""&& worksheets.Cells[i, 4].value.ToString() != "" && worksheets.Cells[i, 5].value.ToString() != "" && worksheets.Cells[i, 6].value.ToString() != ""&& worksheets.Cells[i, 7].value.ToString() != "" && worksheets.Cells[i, 8].value.ToString() != "" )
                    {




                     
                        cmd = new SqlCommand("use Library2 select Topicid from Topic Where TopicTitle=@PN", con);
                        cmd.Parameters.AddWithValue("@PN", worksheets.Cells[i, 8].value.ToString());
                        SqlDataReader Read = cmd.ExecuteReader();
                        if (Read.Read())
                        {
                            T = int.Parse(Read["Topicid"].ToString());
                            Read.Close();
                        }
                        else
                        {
                            Read.Close();
                            cmd = new SqlCommand("INSERT INTO Topic(TopicTitle)VAlUES(@PN)", con);
                            cmd.Parameters.AddWithValue("@PN", worksheets.Cells[i, 8].value.ToString());
                            cmd.ExecuteNonQuery();
                            
                            cmd = new SqlCommand("use Library2 select Topicid from Topic Where TopicTitle=@PN" , con);
                            cmd.Parameters.AddWithValue("@PN", worksheets.Cells[i, 8].value.ToString());
                            Read = cmd.ExecuteReader();
                            T = int.Parse(Read["Topicid"].ToString());
                            Read.Close();

                        }

                        
                        NOP = int.Parse(worksheets.Cells[i, 6].value.ToString());


                        P = int.Parse(worksheets.Cells[i, 5].value.ToString());
                        try
                        {
                            cmd = new SqlCommand("INSERT INTO BookData(NameBook,PrintYear,Published,Publisher,Price,NumberOfPages,PublisherEmail,Topicid) VAlUES(@NB,@PY,@PD,@PR,@P,@NOP,@PE,@T)", con);
                            cmd.Parameters.AddWithValue("@NB", worksheets.Cells[i, 1].value.ToString());
                            cmd.Parameters.AddWithValue("@PY", worksheets.Cells[i, 2].value.ToString());
                            cmd.Parameters.AddWithValue("@PD", worksheets.Cells[i, 3].value.ToString());
                            cmd.Parameters.AddWithValue("@PR", worksheets.Cells[i, 4].value.ToString());

                            cmd.Parameters.AddWithValue("@P", P);

                            cmd.Parameters.AddWithValue("@NOP", NOP);
                            cmd.Parameters.AddWithValue("@PE", worksheets.Cells[i, 7].value.ToString());
                            cmd.Parameters.AddWithValue("@T", T);

                            cmd.ExecuteNonQuery();

                            init();
                        }
                        catch
                        {

                            MessageBox.Show("تعداد صفحات , قیمت را عدد وارد کنید  ");
                        }







                    }




                }
                MessageBox.Show("اطلاعات ثبت شد ");

            }
        }

        private void cbId_CheckedChanged(object sender, EventArgs e)
        {
        
           
        }

        private void cbBook_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void cbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cbId_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void cbBook_MouseClick(object sender, MouseEventArgs e)
        {
            cbBook.Checked = true;
            cbId.Checked = false;
        }

        private void cbId_MouseClick(object sender, MouseEventArgs e)
        {
            cbId.Checked = true;
            cbBook.Checked = false;
        }

        private void bbUpdate_Click(object sender, EventArgs e)
        {
            if (tbuid.Text != "")
            {
                if (tbuName.Text != "" && tbuyear.Text != "" && tbunobat.Text != "" && tbuPublisher.Text != "" && tbuPrice.Text != "" && tbuNOP.Text != "" && tbuEmail.Text != "" && ctbTopic.Text != "")
                {
                    idubdate = int.Parse(tbuid.Text.ToString());
                    NOP = int.Parse(tbuNOP.Text.ToString());
                    P = int.Parse(tbuPrice.Text.ToString());
                    T = int.Parse(ctbTopic.SelectedValue.ToString());
                    cmd = new SqlCommand("UPDATE BookData SET NameBook=@NB,PrintYear=@PY,Published=@PD,Publisher=@PR,Price=@P,NumberOfPages=@NOP,PublisherEmail=@PE,Topicid=@T  Where Bookid=@upd", con);
                    cmd.Parameters.AddWithValue("@NB", tbuName.Text);
                    cmd.Parameters.AddWithValue("@PY", tbuyear.Text);
                    cmd.Parameters.AddWithValue("@PD", tbunobat.Text);
                    cmd.Parameters.AddWithValue("@PR", tbuPublisher.Text);

                    cmd.Parameters.AddWithValue("@P", P);

                    cmd.Parameters.AddWithValue("@NOP", NOP);
                    cmd.Parameters.AddWithValue("@PE", tbuEmail.Text);
                    cmd.Parameters.AddWithValue("@T", T);
                    cmd.Parameters.AddWithValue("@upd", idubdate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("اطلاعات ثبت شد ");
                    tbuName.Text = tbuyear.Text = tbunobat.Text = tbuPublisher.Text = tbuPrice.Text = tbuNOP.Text = tbuEmail.Text = "";
                    init();
                }
                else
                {
                    MessageBox.Show("کامل پرشود ");

                }
            }
            else
            {
                MessageBox.Show("شماره کتاب را وارد کنید ");
            }
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library2_data.BookData' table. You can move, or remove it, as needed.
            this.bookDataTableAdapter1.Fill(this.library2_data.BookData);
            // TODO: This line of code loads data into the 'library2_data.View_Books' table. You can move, or remove it, as needed.
            this.view_BooksTableAdapter.Fill(this.library2_data.View_Books);
            // TODO: This line of code loads data into the 'library_data.View_Books' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'library2_data.View_Books' table. You can move, or remove it, as needed.
            this.view_BooksTableAdapter.Fill(this.library2_data.View_Books);
            // TODO: This line of code loads data into the 'library_data.View_borros' table. You can move, or remove it, as needed.
         


            this.topicTableAdapter.Fill(this.library_data.Topic);
            // TODO: This line of code loads data into the 'library_data.BookData' table. You can move, or remove it, as needed.
           this.bookDataTableAdapter.Fill(this.library_data.BookData);
   
          
            this.bookDataTableAdapter.Fill(this.library_data.BookData);
       



           




        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtBName.Text != "" && txtBYear.Text != "" && txtBnobat.Text != "" && txtBPublisher.Text != "" && txtBPrice.Text != "" && txtBPage.Text != "" && txtBEmail.Text != "" && comboTopic.Text != "")
            {
                NOP = int.Parse(txtBPage.Text.ToString());
                P = int.Parse(txtBPrice.Text.ToString());
                T = int.Parse(comboTopic.SelectedValue.ToString());
                cmd = new SqlCommand("INSERT INTO BookData(NameBook,PrintYear,Published,Publisher,Price,NumberOfPages,PublisherEmail,Topicid) VAlUES(@NB,@PY,@PD,@PR,@P,@NOP,@PE,@T)", con);
                cmd.Parameters.AddWithValue("@NB", txtBName.Text);
                cmd.Parameters.AddWithValue("@PY", txtBYear.Text);
                cmd.Parameters.AddWithValue("@PD", txtBnobat.Text);
                cmd.Parameters.AddWithValue("@PR", txtBPublisher.Text);

                cmd.Parameters.AddWithValue("@P", P);

                cmd.Parameters.AddWithValue("@NOP", NOP);
                cmd.Parameters.AddWithValue("@PE", txtBEmail.Text);
                cmd.Parameters.AddWithValue("@T", T);
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات ثبت شد ");
                txtBName.Text = txtBYear.Text = txtBnobat.Text = txtBPublisher.Text = txtBPrice.Text = txtBPage.Text = txtBEmail.Text = "";
                init();
            }
            else
            {
                MessageBox.Show("کامل پرشود ");

            }
        }
    }
}
