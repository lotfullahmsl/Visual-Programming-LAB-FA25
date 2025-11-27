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

        // Controls
        private DataGridView dataGridView1;
        private TextBox txtLastName;
        private Button btnRetrieve;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();
            this.txtLastName = new TextBox();
            this.btnRetrieve = new Button();

            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Size = new System.Drawing.Size(750, 300);

            // TextBox
            this.txtLastName.Location = new System.Drawing.Point(20, 340);
            this.txtLastName.Width = 200;

            // Button
            this.btnRetrieve.Text = "Retrieve By Last Name";
            this.btnRetrieve.Location = new System.Drawing.Point(240, 338);
            this.btnRetrieve.Click += new EventHandler(this.btnRetrieve_Click);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnRetrieve);
            this.Text = "Student & Department Viewer";
            this.Load += new EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadData(string lastName = "")
        {
            string query = @"
                SELECT s.student_ID, s.student_FirstName, s.student_LastName, 
                       s.major_ID, d.dept_Name, d.dept_Chair
                FROM Student s
                INNER JOIN Department d ON s.major_ID = d.dept_ID";

            if (!string.IsNullOrEmpty(lastName))
            {
                query += " WHERE s.student_LastName = @LastName";
            }

            da = new SqlDataAdapter(query, con);

            if (!string.IsNullOrEmpty(lastName))
            {
                da.SelectCommand.Parameters.AddWithValue("@LastName", lastName);
            }

            ds = new DataSet();
            da.Fill(ds, "StudentDept");
            dataGridView1.DataSource = ds.Tables["StudentDept"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text.Trim();
            LoadData(lastName);
        }
    }
}
