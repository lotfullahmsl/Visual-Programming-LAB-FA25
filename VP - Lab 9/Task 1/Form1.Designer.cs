namespace Task_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Method required for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVisualProgramming = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblVisualProgramming
            // 
            this.lblVisualProgramming.AutoSize = true;
            this.lblVisualProgramming.Font = new System.Drawing.Font("Times New Roman", 24F,
                ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualProgramming.ForeColor = System.Drawing.Color.Purple;
            this.lblVisualProgramming.Location = new System.Drawing.Point(160, 80);
            this.lblVisualProgramming.Name = "lblVisualProgramming";
            this.lblVisualProgramming.Size = new System.Drawing.Size(282, 36);
            this.lblVisualProgramming.TabIndex = 0;
            this.lblVisualProgramming.Text = "Visual Programming";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChangeColor.Location = new System.Drawing.Point(240, 160);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(120, 35);
            this.btnChangeColor.TabIndex = 1;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.BtnChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblVisualProgramming);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise 9.1 - Visual Programming";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisualProgramming;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
