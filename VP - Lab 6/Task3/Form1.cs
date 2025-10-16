using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        // Declare controls as member variables
        private ListBox listBox1;
        private TextBox textBox1;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnExit;

        // Constructor for Form1
        public Form1()
        {
            // Initialize the controls
            InitializeComponent();
        }

        // Load event handler (can be removed if not needed)
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Add Button Click event handler
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;  // Get the text from the TextBox
            if (!string.IsNullOrEmpty(s))
            {
                listBox1.Items.Add(s);  // Add the text to the ListBox
                textBox1.Clear();  // Clear the TextBox after adding
            }
            else
            {
                MessageBox.Show("Please enter a valid text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Remove Button Click event handler
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);  // Remove the selected item from the ListBox
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Clear Button Click event handler
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  // Clear all items from the ListBox
        }

        // Exit Button Click event handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form
        }

        // Initialize all controls (instead of in a Designer file)
        private void InitializeComponent()
        {
            // Initialize controls
            this.listBox1 = new ListBox();
            this.textBox1 = new TextBox();
            this.btnAdd = new Button();
            this.btnRemove = new Button();
            this.btnClear = new Button();
            this.btnExit = new Button();

            // ListBox Settings
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 20);
            this.listBox1.Size = new System.Drawing.Size(200, 150);
            this.listBox1.TabIndex = 0;

            // TextBox Settings
            this.textBox1.Location = new System.Drawing.Point(20, 180);
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;

            // Add Button Settings
            this.btnAdd.Location = new System.Drawing.Point(20, 220);
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // Remove Button Settings
            this.btnRemove.Location = new System.Drawing.Point(105, 220);
            this.btnRemove.Size = new System.Drawing.Size(75, 30);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new EventHandler(this.btnRemove_Click);

            // Clear Button Settings
            this.btnClear.Location = new System.Drawing.Point(20, 260);
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // Exit Button Settings
            this.btnExit.Location = new System.Drawing.Point(105, 260);
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Text = "ListBox App";
        }

        // Main Method (Entry Point)
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());
        //}
    }
}
