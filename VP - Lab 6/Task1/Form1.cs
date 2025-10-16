using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public class Form1 : Form
    {
        private Label label1;
        private RadioButton rbRed;
        private RadioButton rbGreen;
        private RadioButton rbBlue;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBox1;
        private ComboBox comboBoxFontSize;

        public Form1()
        {
            InitializeMyComponents();
        }

        private void InitializeMyComponents()
        {
            // Form settings
            this.Text = "Label Color and Font Size Changer";
            this.ClientSize = new Size(350, 180);

            // Label
            label1 = new Label
            {
                Text = "Show Color Here",
                Location = new Point(30, 20),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            this.Controls.Add(label1);

            // Radio Buttons for Color
            rbRed = new RadioButton
            {
                Text = "Red",
                Location = new Point(30, 60),
                AutoSize = true
            };
            rbRed.CheckedChanged += ColorRadioButton_CheckedChanged;
            this.Controls.Add(rbRed);

            rbGreen = new RadioButton
            {
                Text = "Green",
                Location = new Point(110, 60),
                AutoSize = true
            };
            rbGreen.CheckedChanged += ColorRadioButton_CheckedChanged;
            this.Controls.Add(rbGreen);

            rbBlue = new RadioButton
            {
                Text = "Blue",
                Location = new Point(200, 60),
                AutoSize = true
            };
            rbBlue.CheckedChanged += ColorRadioButton_CheckedChanged;
            this.Controls.Add(rbBlue);

            // ComboBox for Font Size
            comboBoxFontSize = new ComboBox
            {
                Location = new Point(30, 100),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 60
            };
            comboBoxFontSize.Items.AddRange(new object[] { "8", "10", "12", "14", "16", "18", "20" });
            comboBoxFontSize.SelectedIndexChanged += ComboBoxFontSize_SelectedIndexChanged;
            comboBoxFontSize.SelectedIndex = 2; // Default to 12
            this.Controls.Add(comboBoxFontSize);

            // Set defaults
            rbRed.Checked = true;
        }

        private void ColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
                label1.ForeColor = Color.Red;
            else if (rbGreen.Checked)
                label1.ForeColor = Color.Green;
            else if (rbBlue.Checked)
                label1.ForeColor = Color.Blue;
        }

        private void ComboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (float.TryParse(comboBoxFontSize.SelectedItem.ToString(), out float newSize))
            {
                label1.Font = new Font(label1.Font.Name, newSize, label1.Font.Style);
            }
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SimpleText";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Green";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(201, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Blue";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(338, 245);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
