using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11_MouseKeyboard
{
    public partial class Form1 : Form
    {
        private Label label1;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Set up the Form
            this.Text = "Form1";
            this.Size = new Size(400, 300);
            this.BackColor = Color.LightPink; // Matching the screenshot color roughly

            // Initialize and set up the Label
            this.label1 = new Label();
            this.label1.Text = "Click anywhere on the form...";
            this.label1.Location = new Point(50, 50); // Position the label
            this.label1.AutoSize = true; // Allow the label to resize based on content
            this.label1.Font = new Font("Arial", 12, FontStyle.Regular);

            // Add the label to the form's controls
            this.Controls.Add(this.label1);

            // Attach the MouseClick event handler to the Form itself
            this.MouseClick += new MouseEventHandler(this.myForm_MouseClick);
        }

        // The MouseClick event handler function
        private void myForm_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the X and Y coordinates of the mouse click from the MouseEventArgs (e)
            int x = e.X;
            int y = e.Y;

            // Update the label's text to show the coordinates
            // Note: The coordinates are relative to the client area of the form.
            this.label1.Text = "Mouse Clicked at " + x + " , " + y;
        }

        // Note: In a real non-designer environment, you often need to define 
        // the Form1 class in two files (Form1.cs and Form1.Designer.cs) 
        // for separation. Since you requested all code in Form1.cs, 
        // the InitializeComponent method is included here.
    }
}