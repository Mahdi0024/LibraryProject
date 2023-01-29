using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryProject.Forms
{
    public partial class LibMessageBox : Form
    {
        private bool moving = false;
        private Point movePoint;
        private Brush borderBrush;

        public LibMessageBox()
        {
            InitializeComponent();
            borderBrush = new SolidBrush(Color.Red);
        }
        public static void Show(string title, string messege)
        {
            using (LibMessageBox messageBox = new())
            {
                messageBox.titleLabel.Text = title;
                messageBox.messegeTextBox.Text = messege;
                messageBox.ShowDialog();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

       

        private void LibMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            movePoint = e.Location;
        }

        private void LibMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                var p = PointToScreen(e.Location);
                Location = Point.Subtract(p, (Size)movePoint);
            }
        }

        private void LibMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
    }
}
