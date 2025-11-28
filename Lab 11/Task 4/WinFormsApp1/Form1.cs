using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11_MouseKeyboard
{
    public partial class Form1 : Form
    {
        private Label charLabel;
        private Label keyInfoLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Set up the Form
            this.Text = "Key Demo";
            this.Size = new Size(300, 300);

            // Crucial: The form must have focus to receive keyboard events.
            this.KeyPreview = true;

            // Initialize and set up charLabel (for KeyPress output)
            this.charLabel = new Label();
            this.charLabel.Text = "Key pressed: ";
            this.charLabel.Location = new Point(20, 20);
            this.charLabel.AutoSize = true;
            this.charLabel.Font = new Font("Arial", 10, FontStyle.Bold);

            // Initialize and set up keyInfoLabel (for KeyDown/KeyUp output)
            this.keyInfoLabel = new Label();
            this.keyInfoLabel.Text = "Press a key...";
            this.keyInfoLabel.Location = new Point(20, 50);
            this.keyInfoLabel.AutoSize = true;
            this.keyInfoLabel.Font = new Font("Courier New", 9, FontStyle.Regular);

            // Add controls to the form
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.keyInfoLabel);

            // Attach the three required keyboard event handlers to the Form
            this.KeyPress += new KeyPressEventHandler(this.KeyDemo_KeyPress);
            this.KeyDown += new KeyEventHandler(this.KeyDemo_KeyDown);
            this.KeyUp += new KeyEventHandler(this.KeyDemo_KeyUp);
        }

        // --- Keyboard Event Handlers ---

        /// <summary>
        /// Occurs when a character key is pressed and released. Uses KeyPressEventArgs (e).
        /// </summary>
        private void KeyDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Display the actual character that was pressed (e.KeyChar)
            this.charLabel.Text = "Key pressed: " + e.KeyChar;
        }

        /// <summary>
        /// Occurs when a key is pressed down. Uses KeyEventArgs (e).
        /// </summary>
        private void KeyDemo_KeyDown(object sender, KeyEventArgs e)
        {
            // Display various properties of the key press, including modifier keys and key codes.
            // \n is used to create new lines, as seen in the expected output image.
            this.keyInfoLabel.Text =
                "Alt: " + (e.Alt ? "Yes" : "No") + "\n" +
                "Shift: " + (e.Shift ? "Yes" : "No") + "\n" +
                "Ctrl: " + (e.Control ? "Yes" : "No") + "\n" +
                "KeyCode: " + e.KeyCode + "\n" +
                "KeyData: " + e.KeyData + "\n" +
                "KeyValue: " + e.KeyValue;
        }

        /// <summary>
        /// Occurs when a key is released. Uses KeyEventArgs (e).
        /// </summary>
        private void KeyDemo_KeyUp(object sender, KeyEventArgs e)
        {
            // Clear the labels when the key is released.
            this.charLabel.Text = "Key pressed: ";
            this.keyInfoLabel.Text = "Press a key...";
        }
    }
}