using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11_MouseKeyboard
{
    public partial class Form1 : Form
    {
        // 1. Class-level variable to track if the mouse button is currently pressed down
        private bool ShouldPaint = false;

        // Define the brush and size for the drawing (C# #)
        private readonly SolidBrush drawBrush = new SolidBrush(Color.BlueViolet);
        private const int dotSize = 8; // Diameter of the circle (4, 4 is radius, so diameter is 8)


        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Set up the Form
            this.Text = "Painter Form";
            this.Size = new Size(400, 300);

            // Attach the three required mouse event handlers to the Form itself
            this.MouseDown += new MouseEventHandler(this.Painter_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Painter_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Painter_MouseUp);
        }

        // --- Mouse Event Handlers for Drawing ---

        /// <summary>
        /// Occurs when a mouse button is pressed down. Starts the drawing.
        /// </summary>
        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {
            // Set the flag to true, indicating we should start drawing.
            ShouldPaint = true;
        }

        /// <summary>
        /// Occurs when the mouse moves. Performs the drawing if ShouldPaint is true.
        /// </summary>
        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the mouse button is being pressed (i.e., ShouldPaint is true)
            if (ShouldPaint)
            {
                // Create a Graphics object to draw on the form's surface
                using (Graphics graphics = this.CreateGraphics())
                {
                    // Draw a filled circle (Ellipse) at the current mouse coordinates (e.X, e.Y)
                    // The coordinates e.X and e.Y are the top-left corner of the bounding rectangle.
                    // To center the dot: (e.X - dotSize/2), (e.Y - dotSize/2) would be better,
                    // but we will follow the example's code which uses the coordinates directly.

                    // The provided code uses (e.X, e.Y, 4, 4) which draws an ellipse 4x4 with the top-left 
                    // corner at (e.X, e.Y). I'll use a slightly larger size for visibility, 
                    // assuming the original intent was a small dot.

                    // Note: The example image coordinates (e.X, e.Y, 4, 4) might be a typo for (e.X, e.Y, 8, 8) 
                    // or similar, but for strict adherence, I'll use 4, 4 for the width/height
                    // as shown in the original lab text, and update the Brush to match the color.
                    graphics.FillEllipse(drawBrush, e.X, e.Y, 4, 4);
                }
                // The 'using' statement automatically calls graphics.Dispose(), as shown in the lab text.
            }
        }

        /// <summary>
        /// Occurs when a mouse button is released. Stops the drawing.
        /// </summary>
        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            // Set the flag to false, indicating we should stop drawing.
            ShouldPaint = false;
        }

        // Clean up the Brush when the form is disposed
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                drawBrush.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}