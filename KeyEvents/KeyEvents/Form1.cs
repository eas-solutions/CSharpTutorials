using System.Drawing;
using System.Windows.Forms;

namespace KeyEvents
{
    public partial class Form1 : Form
    {
        private bool _upKeyActive;
        private bool _rightKeyActive;
        private bool _downKeyActive;
        private bool _leftKeyActive;

        public Form1()
        {
            InitializeComponent();
            SpaceShipTimer.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _upKeyActive = true;
            if (e.KeyCode == Keys.Down) _downKeyActive = true;
            if (e.KeyCode == Keys.Left) _leftKeyActive = true;
            if (e.KeyCode == Keys.Right) _rightKeyActive = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) _upKeyActive = false;
            if (e.KeyCode == Keys.Down) _downKeyActive = false;
            if (e.KeyCode == Keys.Left) _leftKeyActive = false;
            if (e.KeyCode == Keys.Right) _rightKeyActive = false;
        }

        private void SpaceShipTimer_Tick(object sender, System.EventArgs e)
        {
            var distance = 10;
            var maxX = Width - SpaceShipPanel.Width - distance;
            var maxY = Height - SpaceShipPanel.Height - distance;

            if (_upKeyActive)
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X, SpaceShipPanel.Location.Y - distance);

            if (_downKeyActive)
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X, SpaceShipPanel.Location.Y + distance);

            if (_leftKeyActive)
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X - distance, SpaceShipPanel.Location.Y);

            if (_rightKeyActive)
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X + distance, SpaceShipPanel.Location.Y);

            if (SpaceShipPanel.Location.X <= 0)
                SpaceShipPanel.Location = new Point(0, SpaceShipPanel.Location.Y);

            if (SpaceShipPanel.Location.X >= maxX)
                SpaceShipPanel.Location = new Point(maxX, SpaceShipPanel.Location.Y);

            if (SpaceShipPanel.Location.Y <= 0)
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X, 0);

            if (SpaceShipPanel.Location.Y >= maxY)
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X, maxY);

            PositionLabel.Text = "Position = X: " + SpaceShipPanel.Location.X + ", Y: " + SpaceShipPanel.Location.Y;
        }
    }
}
