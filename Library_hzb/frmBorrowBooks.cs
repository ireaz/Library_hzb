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
    public partial class frmBorrowBooks : Form
    {
        int j;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public frmBorrowBooks()
        {
            InitializeComponent();
          
            con = new SqlConnection(@"Data Source=.;Initial Catalog=Library2;Integrated Security=True");
            con.Open();
            init();
  

        }
        void init()
        {
            j = -1;

            cmd = new SqlCommand("SELECT * FROM BorrowBooks");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            this.borrowBooksTableAdapter.Fill(this.library_data.BorrowBooks);
            // TODO: This line of code loads data into the 'library_data.View_borros' table. You can move, or remove it, as needed.
            this.view_borrosTableAdapter.Fill(this.library_data.View_borros);
            // TODO: This line of code loads data into the 'library_data.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.library_data.Students);
            // TODO: This line of code loads data into the 'library_data.BookData' table. You can move, or remove it, as needed.
            this.bookDataTableAdapter.Fill(this.library_data.BookData);


        }
        private void frmBorrowBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_data.BorrowBooks' table. You can move, or remove it, as needed.
            this.borrowBooksTableAdapter.Fill(this.library_data.BorrowBooks);
            // TODO: This line of code loads data into the 'library_data.View_borros' table. You can move, or remove it, as needed.
            this.view_borrosTableAdapter.Fill(this.library_data.View_borros);
            // TODO: This line of code loads data into the 'library_data.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.library_data.Students);
            // TODO: This line of code loads data into the 'library_data.BookData' table. You can move, or remove it, as needed.
            this.bookDataTableAdapter.Fill(this.library_data.BookData);
            // TODO: This line of code loads data into the 'library2_data.BorrowBooks' table. You can move, or remove it, as needed.
           
           
            this.Font = new Font(MyFont.vazir(), 11, FontStyle.Regular);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cbook.Text != "" && cstudent.Text != "" && dtime.Text != "")
            {
                int St = int.Parse(cbook.SelectedValue.ToString());
                int user = int.Parse(cstudent.SelectedValue.ToString());
               
                
                cmd = new SqlCommand("Insert into BorrowBooks(iduser,Bookid,Data)VAlUES(@SN,@BI,@D)", con);
                cmd.Parameters.AddWithValue("@SN",user );
                cmd.Parameters.AddWithValue("@BI", St);
                cmd.Parameters.AddWithValue("@D", dtime.Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد ");
                init();
            }
            else
            {
                MessageBox.Show(" خالی است ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemdelete = int.Parse(ComBorrow.SelectedValue.ToString());

            if (MessageBox.Show(" ایا میخواهید موضوع  " + ComBorrow.Text + " را حذف کنید ؟  ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("Delete from BorrowBooks Where BorrowBooksid=@Pi", con);
                cmd.Parameters.AddWithValue("@Pi", itemdelete);
                cmd.ExecuteNonQuery();
                MessageBox.Show("موضوع حذف شد ");
                init();
            }
        }

        private void btnUPDate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ایا میخواهید موضوع  " + ComBorrow.Text + " را بروز کنید ؟  ", "بروز رسانی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                int up = int.Parse(ComBorrow.SelectedValue.ToString());
                int St = int.Parse(comUBook.SelectedValue.ToString());
                int user = int.Parse(comSN.SelectedValue.ToString());


                cmd = new SqlCommand("  UPDATE BorrowBooks SET iduser=@SN,Bookid=@BI,Data=@D  Where BorrowBooksid=@upd", con);
                cmd.Parameters.AddWithValue("@SN", user);
                cmd.Parameters.AddWithValue("@BI", St);
                cmd.Parameters.AddWithValue("@upd", up);
                cmd.Parameters.AddWithValue("@D", dataU.Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد ");
                init();
            }
            else
            {
                MessageBox.Show(" خالی است ");
            }
        }

        private void ser_TextChanged(object sender, EventArgs e)
        {
            if (sertype.Text == "NameBook" || sertype.Text == "PrintYear" || sertype.Text == "BorrowBooksid" || sertype.Text == "Publisher" || sertype.Text == "StudenyNumbers" || sertype.Text == "Name" || sertype.Text == "Family" || sertype.Text == "TellNumber")
            {
                da = new SqlDataAdapter("use Library2 SELECT    dbo.BorrowBooks.BorrowBooksid, dbo.BorrowBooks.Data, dbo.BookData.NameBook, dbo.BookData.PrintYear, dbo.BookData.Publisher, dbo.Students.StudenyNumbers, dbo.Students.Name, dbo.Students.Family, dbo.Students.TellNumber FROM       dbo.BookData INNER JOIN                 dbo.BorrowBooks ON dbo.BookData.BookId = dbo.BorrowBooks.Bookid INNER JOIN                dbo.Students ON dbo.BorrowBooks.iduser = dbo.Students.idUser    where " + sertype.Text + " like N'%" + ser.Text + "%'   ", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("فلیدی که میخواهید سرچ کنید را انتخاب کنید ");
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
       
        }
    }
}
