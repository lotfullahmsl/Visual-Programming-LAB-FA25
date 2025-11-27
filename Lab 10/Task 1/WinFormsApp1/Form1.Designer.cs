namespace ADO_Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.lblID = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Size = new System.Drawing.Size(650, 250);

            // Labels
            this.lblID.Text = "Student ID";
            this.lblID.Location = new System.Drawing.Point(20, 280);

            this.lblFirst.Text = "First Name";
            this.lblFirst.Location = new System.Drawing.Point(20, 320);

            this.lblLast.Text = "Last Name";
            this.lblLast.Location = new System.Drawing.Point(20, 360);

            this.lblMajor.Text = "Major ID";
            this.lblMajor.Location = new System.Drawing.Point(20, 400);

            this.lblPhone.Text = "Phone";
            this.lblPhone.Location = new System.Drawing.Point(20, 440);


            // Textboxes
            this.txtID.Location = new System.Drawing.Point(130, 280);
            this.txtFirst.Location = new System.Drawing.Point(130, 320);
            this.txtLast.Location = new System.Drawing.Point(130, 360);
            this.txtMajor.Location = new System.Drawing.Point(130, 400);
            this.txtPhone.Location = new System.Drawing.Point(130, 440);

            this.txtID.Width = this.txtFirst.Width = this.txtLast.Width = this.txtMajor.Width = this.txtPhone.Width = 150;

            // Buttons
            this.btnInsert.Text = "Insert";
            this.btnInsert.Location = new System.Drawing.Point(330, 300);
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(330, 350);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(330, 400);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);


            // Form Settings
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.dataGridView1);

            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblPhone);

            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtPhone);

            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            this.Text = "Student CRUD App";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
