using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11_MouseKeyboard
{
    public partial class Form1 : Form
    {
        // Drawing Parameters
        private bool ShouldPaint = false;
        private SolidBrush drawBrush = new SolidBrush(Color.Black); // Initial brush color
        private int brushSize = 6; // Initial brush thickness (size of the circle's diameter)

        // UI Components
        private MenuStrip mainMenuStrip;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // --- Form Setup ---
            this.Text = "Menu Painter Application";
            this.Size = new Size(600, 450);
            this.BackColor = Color.White; // Initial background color

            // --- Drawing Event Handlers (from Exercise 3) ---
            this.MouseDown += new MouseEventHandler(this.Painter_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Painter_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Painter_MouseUp);

            // --- Menu Strip Setup ---
            this.mainMenuStrip = new MenuStrip();

            // 1. Color Menu (Parent)
            ToolStripMenuItem colorMenuItem = new ToolStripMenuItem("Color");

            // 1.1 Custom Color (Child)
            ToolStripMenuItem customColorItem = new ToolStripMenuItem("Custom Color");
            customColorItem.Click += new EventHandler(this.CustomColor_Click);

            // 1.2 Custom Background Color (Child)
            ToolStripMenuItem customBgColorItem = new ToolStripMenuItem("Custom Background Color");
            customBgColorItem.Click += new EventHandler(this.CustomBackgroundColor_Click);

            colorMenuItem.DropDownItems.Add(customColorItem);
            colorMenuItem.DropDownItems.Add(customBgColorItem);

            // 2. Brush Thickness Menu (Parent)
            ToolStripMenuItem thicknessMenuItem = new ToolStripMenuItem("Brush Thickness");

            // 2.1 Thickness options (Children)
            thicknessMenuItem.DropDownItems.Add(CreateThicknessMenuItem("6, 6", 6));
            thicknessMenuItem.DropDownItems.Add(CreateThicknessMenuItem("10, 10", 10));
            thicknessMenuItem.DropDownItems.Add(CreateThicknessMenuItem("20, 20", 20));
            thicknessMenuItem.DropDownItems.Add(CreateThicknessMenuItem("40, 40", 40));

            // 3. Reset Parameters Menu (Standalone)
            ToolStripMenuItem resetItem = new ToolStripMenuItem("Reset Parameters");
            resetItem.Click += new EventHandler(this.ResetParameters_Click);

            // Add all top-level items to the MenuStrip
            this.mainMenuStrip.Items.Add(colorMenuItem);
            this.mainMenuStrip.Items.Add(thicknessMenuItem);
            this.mainMenuStrip.Items.Add(resetItem);

            // Add the MenuStrip to the form
            this.Controls.Add(this.mainMenuStrip);
        }

        // Helper function to create thickness menu items
        private ToolStripMenuItem CreateThicknessMenuItem(string text, int size)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text);
            // Store the size value in the Tag property for easy retrieval in the handler
            item.Tag = size;
            item.Click += new EventHandler(this.BrushThickness_Click);
            return item;
        }

        // --- Menu Strip Event Handlers ---

        /// <summary>
        /// Handles the Custom Color selection to change the brush color.
        /// </summary>
        private void CustomColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    // Dispose of the old brush and create a new one with the selected color
                    this.drawBrush.Dispose();
                    this.drawBrush = new SolidBrush(colorDlg.Color);
                }
            }
        }

        /// <summary>
        /// Handles the Custom Background Color selection.
        /// </summary>
        private void CustomBackgroundColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDlg.Color;
                    this.Invalidate(); // Force a repaint of the form background
                }
            }
        }

        /// <summary>
        /// Handles the Brush Thickness selection.
        /// </summary>
        private void BrushThickness_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null && item.Tag is int newSize)
            {
                this.brushSize = newSize;
            }
        }

        /// <summary>
        /// Resets the brush color, thickness, and background color to default.
        /// </summary>
        private void ResetParameters_Click(object sender, EventArgs e)
        {
            // Reset brush color to Black
            this.drawBrush.Dispose();
            this.drawBrush = new SolidBrush(Color.Black);

            // Reset brush thickness to 6
            this.brushSize = 6;

            // Reset background color to White
            this.BackColor = Color.White;

            // Clear the drawing by invalidating the form (causing a repaint)
            this.Invalidate();
        }

        // --- Drawing Logic (Adapted from Exercise 3) ---

        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                // We use the brushSize for both width and height, creating a circle.
                // Subtract half the size from X and Y to center the circle on the mouse pointer.
                int halfSize = this.brushSize / 2;

                using (Graphics graphics = this.CreateGraphics())
                {
                    graphics.FillEllipse(
                        this.drawBrush,
                        e.X - halfSize,
                        e.Y - halfSize,
                        this.brushSize,
                        this.brushSize
                    );
                }
            }
        }

        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }

        // --- Cleanup ---

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.drawBrush != null)
            {
                this.drawBrush.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}