/*namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace ADO_Project
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM Student", con);
            ds = new DataSet();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Student VALUES (@ID,@F,@L,@M,@P)", con);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@F", txtFirst.Text);
            cmd.Parameters.AddWithValue("@L", txtLast.Text);
            cmd.Parameters.AddWithValue("@M", txtMajor.Text);
            cmd.Parameters.AddWithValue("@P", txtPhone.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            LoadData();
            MessageBox.Show("Inserted Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Student SET student_FirstName=@F, student_LastName=@L, major_ID=@M, student_Phone=@P WHERE student_ID=@ID", con);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@F", txtFirst.Text);
            cmd.Parameters.AddWithValue("@L", txtLast.Text);
            cmd.Parameters.AddWithValue("@M", txtMajor.Text);
            cmd.Parameters.AddWithValue("@P", txtPhone.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            LoadData();
            MessageBox.Show("Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Student WHERE student_ID=@ID", con);

            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            LoadData();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
