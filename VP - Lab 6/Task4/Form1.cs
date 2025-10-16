using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private CheckedListBox checkedListBox;
        private ListBox displayListBox;

        public Form1()
        {
            
            SetupControls();
        }

        private void SetupControls()
        {
            // Initialize CheckedListBox
            checkedListBox = new CheckedListBox
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(200, 200),
                CheckOnClick = true
            };
            checkedListBox.Items.Add("C# HTP");
            checkedListBox.Items.Add("C++ HTP");
            checkedListBox.Items.Add("Internet & WWW HTP");
            checkedListBox.Items.Add("Java HTP");
            checkedListBox.Items.Add("VB .NET HTP");
            checkedListBox.Items.Add("Visual C++ 2008 HTP");
            checkedListBox.ItemCheck += new ItemCheckEventHandler(itemCheckedListBox_ItemCheck);

            // Initialize ListBox
            displayListBox = new ListBox
            {
                Location = new System.Drawing.Point(220, 10),
                Size = new System.Drawing.Size(200, 200)
            };

            // Add controls to form
            this.Controls.Add(checkedListBox);
            this.Controls.Add(displayListBox);

            // Set form properties
            this.Text = "CheckedListBox Test";
            this.Size = new System.Drawing.Size(440, 250);
        }

        private void itemCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBox.SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
            {
                displayListBox.Items.Add(item);
            }
            else
            {
                displayListBox.Items.Remove(item);
            }
        }
    }
}