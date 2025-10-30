using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // ----- CONTROLS (created in code) -----
        private Label displayLabel;
        private MenuStrip mainMenu;

        // Format -> Color
        private ToolStripMenuItem blackMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;

        // Format -> Font
        private ToolStripMenuItem timesMenuItem;
        private ToolStripMenuItem courierMenuItem;
        private ToolStripMenuItem comicMenuItem;

        // Format -> Style
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;

        public Form1()
        {
            InitializeComponent();   // calls the method below
        }

        private void InitializeComponent()
        {
            // ----- Form basics -----
            this.Text = "Menu Test";
            this.ClientSize = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ----- displayLabel -----
            displayLabel = new Label
            {
                Text = "Use the Format menu to change the appearance of this text.",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 12F),
                ForeColor = Color.Black
            };
            this.Controls.Add(displayLabel);

            // ----- MenuStrip -----
            mainMenu = new MenuStrip();
            this.MainMenuStrip = mainMenu;
            this.Controls.Add(mainMenu);

            // File (just a placeholder)
            var fileMenu = new ToolStripMenuItem("File");
            mainMenu.Items.Add(fileMenu);

            // Format
            var formatMenu = new ToolStripMenuItem("Format");
            mainMenu.Items.Add(formatMenu);

            // ----- Color submenu -----
            var colorMenu = new ToolStripMenuItem("Color");
            formatMenu.DropDownItems.Add(colorMenu);

            blackMenuItem = new ToolStripMenuItem("Black") { CheckOnClick = true };
            blueToolStripMenuItem = new ToolStripMenuItem("Blue") { CheckOnClick = true };
            redToolStripMenuItem = new ToolStripMenuItem("Red") { CheckOnClick = true };
            greenToolStripMenuItem = new ToolStripMenuItem("Green") { CheckOnClick = true };

            colorMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
                blackMenuItem, blueToolStripMenuItem, redToolStripMenuItem, greenToolStripMenuItem
            });

            // ----- Font submenu -----
            var fontMenu = new ToolStripMenuItem("Font");
            formatMenu.DropDownItems.Add(fontMenu);

            timesMenuItem = new ToolStripMenuItem("Times New Roman") { CheckOnClick = true };
            courierMenuItem = new ToolStripMenuItem("Courier New") { CheckOnClick = true };
            comicMenuItem = new ToolStripMenuItem("Comic Sans MS") { CheckOnClick = true };

            fontMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
                timesMenuItem, courierMenuItem, comicMenuItem
            });

            // ----- Style items (Bold / Italic) -----
            boldToolStripMenuItem = new ToolStripMenuItem("Bold") { CheckOnClick = true };
            italicToolStripMenuItem = new ToolStripMenuItem("Italic") { CheckOnClick = true };

            formatMenu.DropDownItems.AddRange(new ToolStripItem[]
            {
                new ToolStripSeparator(),
                boldToolStripMenuItem,
                italicToolStripMenuItem
            });

            // ----- Wire events -----
            blackMenuItem.Click += blackMenuItem_Click;
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;

            timesMenuItem.Click += timesToolStripMenuItem_Click;
            courierMenuItem.Click += courierToolStripMenuItem_Click;
            comicMenuItem.Click += comicMenuItem_Click;

            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;

            // ----- Initial checks -----
            blackMenuItem.Checked = true;
            timesMenuItem.Checked = true;
        }

        // ==================== COLOR HELPERS ====================
        private void ClearColor()
        {
            blackMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;
            blackMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        // ==================== FONT HELPERS ====================
        private void ClearFont()
        {
            timesMenuItem.Checked = false;
            courierMenuItem.Checked = false;
            comicMenuItem.Checked = false;
        }

        private void SetFontFamily(string familyName)
        {
            var newFamily = new FontFamily(familyName);
            displayLabel.Font = new Font(
                newFamily,
                displayLabel.Font.Size,
                displayLabel.Font.Style);
        }

        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            SetFontFamily("Times New Roman");
            timesMenuItem.Checked = true;
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            SetFontFamily("Courier New");
            courierMenuItem.Checked = true;
        }

        private void comicMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            SetFontFamily("Comic Sans MS");
            comicMenuItem.Checked = true;
        }

        // ==================== STYLE (Bold / Italic) ====================
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            FontStyle newStyle = displayLabel.Font.Style;
            if (italicToolStripMenuItem.Checked)
                newStyle |= FontStyle.Italic;
            else
                newStyle &= ~FontStyle.Italic;

            displayLabel.Font = new Font(displayLabel.Font.FontFamily,
                                         displayLabel.Font.Size,
                                         newStyle);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            FontStyle newStyle = displayLabel.Font.Style;
            if (boldToolStripMenuItem.Checked)
                newStyle |= FontStyle.Bold;
            else
                newStyle &= ~FontStyle.Bold;

            displayLabel.Font = new Font(displayLabel.Font.FontFamily,
                                         displayLabel.Font.Size,
                                         newStyle);
        }
    }
}