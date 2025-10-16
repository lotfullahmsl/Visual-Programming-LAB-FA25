using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Label label1;
        private PictureBox picBox;
        private CheckBox visCheckBox;
        private Button exitButton;

        private int imageNum = 0;
        private readonly string imagesFolder = "images";

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new Label
            {
                Text = "Click the picture to change image",
                Location = new Point(20, 15),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            this.picBox = new PictureBox
            {
                Location = new Point(20, 40),
                Size = new Size(200, 200),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };
            this.picBox.Click += PicBox_Click;

            this.visCheckBox = new CheckBox
            {
                Text = "Hide Picture",
                Location = new Point(240, 40),
                AutoSize = true
            };
            this.visCheckBox.CheckedChanged += VisCheckBox_CheckedChanged;

            this.exitButton = new Button
            {
                Text = "Exit",
                Location = new Point(240, 80),
                Size = new Size(100, 30)
            };
            this.exitButton.Click += ExitButton_Click;

            this.ClientSize = new Size(360, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.visCheckBox);
            this.Controls.Add(this.exitButton);
            this.Text = "Image Viewer";

            LoadImage();
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 3;
            LoadImage();
        }

        private void LoadImage()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string path = System.IO.Path.Combine(baseDir, imagesFolder, $"image{imageNum}.bmp");
                picBox.Image?.Dispose();
                picBox.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void VisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Visible = !visCheckBox.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
