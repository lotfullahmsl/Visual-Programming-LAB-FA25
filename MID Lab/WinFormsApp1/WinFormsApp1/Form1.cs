/*namespace Task1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           label2_Click.


        }
    }
}
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public class Form1 : Form
    {
        private Label lblTitle, lblName, lblEnrollment, lblDept, lblGender;
        private TextBox txtName, txtEnrollment;
        private ComboBox cmbDepartment;
        private RadioButton rbMale, rbFemale;
        private Button btnSave, btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private ListBox lb1;
        private ListBox lstData;

        public Form1()
        {
           
            this.Text = "Student Registration Form";
            this.Size = new Size(550, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

           
            lblTitle = new Label()
            {
                Text = "Student Registration",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(160, 20),
                AutoSize = true
            };
            Controls.Add(lblTitle);

            
            lblName = new Label()
            {
                Text = "Name:",
                Location = new Point(50, 80),
                AutoSize = true
            };
            txtName = new TextBox()
            {
                Location = new Point(180, 80),
                Width = 250
            };
            Controls.Add(lblName);
            Controls.Add(txtName);

           
            lblEnrollment = new Label()
            {
                Text = "Enrollment:",
                Location = new Point(50, 120),
                AutoSize = true
            };
            txtEnrollment = new TextBox()
            {
                Location = new Point(180, 120),
                Width = 250
            };
            Controls.Add(lblEnrollment);
            Controls.Add(txtEnrollment);

            
            lblDept = new Label()
            {
                Text = "Department:",
                Location = new Point(50, 160),
                AutoSize = true
            };
            cmbDepartment = new ComboBox()
            {
                Location = new Point(180, 160),
                Width = 250,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbDepartment.Items.AddRange(new string[]
            {
                "BSE",
                "BSIT",
                "BEE",
                "BCE",
                "BBA"
            });
            Controls.Add(lblDept);
            Controls.Add(cmbDepartment);

            
            lblGender = new Label()
            {
                Text = "Gender:",
                Location = new Point(50, 200),
                AutoSize = true
            };
            rbMale = new RadioButton()
            {
                Text = "Male",
                Location = new Point(180, 200),
                AutoSize = true
            };
            rbFemale = new RadioButton()
            {
                Text = "Female",
                Location = new Point(250, 200),
                AutoSize = true
            };
            Controls.Add(lblGender);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);

            // Save button
            btnSave = new Button()
            {
                Text = "Save",
                Location = new Point(100, 250),
                Width = 100,
                BackColor = Color.LightGreen
            };
            btnSave.Click += BtnSave_Click;
            Controls.Add(btnSave);

            // Clear button
            btnClear = new Button()
            {
                Text = "Clear",
                Location = new Point(220, 250),
                Width = 100,
                BackColor = Color.LightCoral
            };
            btnClear.Click += BtnClear_Click;
            Controls.Add(btnClear);

            // ListBox for displaying data
            lstData = new ListBox()
            {
                Location = new Point(50, 300),
                Width = 400,
                Height = 120
            };
            Controls.Add(lstData);
        }

        // Save button event handler
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string enrollment = txtEnrollment.Text.Trim();
            string department = cmbDepartment.SelectedItem as string;
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";

            // Validation
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(enrollment))
            {
                MessageBox.Show("Please enter your Enrollment number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please select a Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display in listbox
            string record = $"Name: {name} | Enrollment: {enrollment} | Department: {department} | Gender: {gender}";
            lstData.Items.Add(record);

            // Clear fields after saving
            ClearFields();
        }

        // Clear button event handler
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            lstData.Items.Clear();
        }

        // Helper method to reset fields
        private void ClearFields()
        {
            txtName.Text = "";
            txtEnrollment.Text = "";
            cmbDepartment.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            lb1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Regestration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 91);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 126);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Enrollment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 163);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 204);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 23);
            comboBox1.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(183, 204);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(283, 204);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(187, 257);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(283, 257);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 15;
            lb1.Location = new Point(166, 313);
            lb1.Name = "lb1";
            lb1.Size = new Size(226, 94);
            lb1.TabIndex = 12;
            // 
            // Form1
            // 
            ClientSize = new Size(589, 428);
            Controls.Add(lb1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
