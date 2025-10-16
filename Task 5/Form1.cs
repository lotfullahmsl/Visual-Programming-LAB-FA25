using System;
using System.Windows.Forms;

namespace UserInformation
{
    public partial class Form1 : Form
    {
        private TextBox txtCountry;
        private TextBox txtState;
        private CheckBox chkPostalMail;
        private CheckBox chkEmail;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private ListBox lstCountry;
        private ComboBox cmbState;
        private Label lblDetails;
        private Button btnAdd;
        private Button btnRemoveCountry;
        private Button btnRemoveState;
        private Button btnShowDetails;

        public Form1()
        {
            
            SetupControls();
        }

        private void SetupControls()
        {
            // Labels
            Label lblCountry = new Label { Text = "Enter Country", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 20) };
            Label lblState = new Label { Text = "Enter State", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 20) };

            // TextBoxes
            txtCountry = new TextBox { Location = new System.Drawing.Point(130, 20), Size = new System.Drawing.Size(150, 22) };
            txtState = new TextBox { Location = new System.Drawing.Point(130, 60), Size = new System.Drawing.Size(150, 22) };

            // CheckBoxes
            chkPostalMail = new CheckBox { Text = "Postal Mail", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 20) };
            chkEmail = new CheckBox { Text = "Email", Location = new System.Drawing.Point(20, 130), Size = new System.Drawing.Size(100, 20) };

            // RadioButtons
            rdoMale = new RadioButton { Text = "Male", Location = new System.Drawing.Point(140, 100), Size = new System.Drawing.Size(60, 20) };
            rdoFemale = new RadioButton { Text = "Female", Location = new System.Drawing.Point(210, 100), Size = new System.Drawing.Size(80, 20) };
            rdoMale.Checked = true;

            // ListBox for countries
            lstCountry = new ListBox { Location = new System.Drawing.Point(320, 20), Size = new System.Drawing.Size(160, 100) };

            // ComboBox for states
            cmbState = new ComboBox { Location = new System.Drawing.Point(320, 135), Size = new System.Drawing.Size(160, 25) };

            // Label for details box
            lblDetails = new Label
            {
                Location = new System.Drawing.Point(320, 175),
                Size = new System.Drawing.Size(160, 90),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Buttons
            btnAdd = new Button { Text = "Add", Location = new System.Drawing.Point(20, 170), Size = new System.Drawing.Size(80, 27) };
            btnRemoveCountry = new Button { Text = "Remove Country", Location = new System.Drawing.Point(110, 170), Size = new System.Drawing.Size(110, 27) };
            btnRemoveState = new Button { Text = "Remove State", Location = new System.Drawing.Point(230, 170), Size = new System.Drawing.Size(100, 27) };
            btnShowDetails = new Button { Text = "Show Details", Location = new System.Drawing.Point(320, 275), Size = new System.Drawing.Size(160, 30) };

            // Event Handlers
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnRemoveCountry.Click += new EventHandler(btnRemoveCountry_Click);
            btnRemoveState.Click += new EventHandler(btnRemoveState_Click);
            btnShowDetails.Click += new EventHandler(btnShowDetails_Click);

            // Add controls to form
            this.Controls.AddRange(new Control[]
            {
                lblCountry, lblState, txtCountry, txtState,
                chkPostalMail, chkEmail, rdoMale, rdoFemale,
                lstCountry, cmbState, lblDetails,
                btnAdd, btnRemoveCountry, btnRemoveState, btnShowDetails
            });

            // Form properties
            this.Text = "User Information";
            this.Size = new System.Drawing.Size(520, 360);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCountry.Text))
            {
                if (!lstCountry.Items.Contains(txtCountry.Text))
                {
                    lstCountry.Items.Add(txtCountry.Text);
                }
                txtCountry.Clear();
            }

            if (!string.IsNullOrEmpty(txtState.Text))
            {
                if (!cmbState.Items.Contains(txtState.Text))
                {
                    cmbState.Items.Add(txtState.Text);
                }
                txtState.Clear();
            }
        }

        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            if (lstCountry.SelectedIndex != -1)
            {
                lstCountry.Items.RemoveAt(lstCountry.SelectedIndex);
            }
        }

        private void btnRemoveState_Click(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex != -1)
            {
                cmbState.Items.RemoveAt(cmbState.SelectedIndex);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            string details = "Selection Details:\n";
            if (chkPostalMail.Checked) details += "Postal Mail\n";
            if (chkEmail.Checked) details += "Email\n";
            details += rdoMale.Checked ? "Gender: Male\n" : "Gender: Female\n";
            lblDetails.Text = details;
        }
    }
}
