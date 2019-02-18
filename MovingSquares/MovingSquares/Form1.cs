using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovingSquares
{
    public partial class Form1 : Form
    {
        // Variablen zum Speichern der aktuellen Richtung eines Panels
        private ArrowDirection _redPanelDirection = ArrowDirection.Right;
        private ArrowDirection _bluePanelDirection = ArrowDirection.Down;
        private ArrowDirection _yellowPanelDirection = ArrowDirection.Left;
        private ArrowDirection _greenPanelDirection = ArrowDirection.Up;

        // Variablen zum Abstecken des "Bereichs"
        private int _topBorder = 10;
        private int _rightBorder = 300;
        private int _bottomBorder = 300;
        private int _leftBorder = 10;

        // Einstiegsmethode in das Form
        public Form1()
        {
            InitializeComponent();
            IntervalLabel.Text = RotationTimer.Interval.ToString();
        }

        // Tick-Event des Timers. Wird alle x Millisekunden ausgeführt (x = Intervall)
        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            // Rotes Panel
            MovePanel(RedPanel, _redPanelDirection);
            CheckDirectionChange(RedPanel, ref _redPanelDirection);

            // Blaues Panel
            MovePanel(BluePanel, _bluePanelDirection);
            CheckDirectionChange(BluePanel, ref _bluePanelDirection);

            // Gelbes Panel
            MovePanel(YellowPanel, _yellowPanelDirection);
            CheckDirectionChange(YellowPanel, ref _yellowPanelDirection);

            // Grünes Panel
            MovePanel(GreenPanel, _greenPanelDirection);
            CheckDirectionChange(GreenPanel, ref _greenPanelDirection);
        }

        // Bewegt ein Panel entsprechend der angegebenen Richtung
        private void MovePanel(Panel panel, ArrowDirection direction)
        {
            switch (direction)
            {
                case ArrowDirection.Right:
                    MoveRight(panel, 5);
                    break;
                case ArrowDirection.Down:
                    MoveDown(panel, 5);
                    break;
                case ArrowDirection.Left:
                    MoveLeft(panel, 5);
                    break;
                case ArrowDirection.Up:
                    MoveUp(panel, 5);
                    break;
            }
        }

        // Prüft, ob ein Panel den Rand des Bereichs erreicht hat und ändert ggf die Richtung
        private void CheckDirectionChange(Panel panel, ref ArrowDirection panelDirection)
        {
            if (panelDirection == ArrowDirection.Right && panel.Location.X == _rightBorder)
            {
                panelDirection = ArrowDirection.Down;
            }
            else if (panelDirection == ArrowDirection.Down && panel.Location.Y == _bottomBorder)
            {
                panelDirection = ArrowDirection.Left;
            }
            else if (panelDirection == ArrowDirection.Left && panel.Location.X == _leftBorder)
            {
                panelDirection = ArrowDirection.Up;
            }
            else if (panelDirection == ArrowDirection.Up && panel.Location.Y == _topBorder)
            {
                panelDirection = ArrowDirection.Right;
            }
        }

        // Bewegt ein Panel um die angegebenen Pixel nach oben auf der Y-Achse
        private void MoveUp(Panel panel, int pixel)
        {
            panel.Location = new Point(panel.Location.X, panel.Location.Y - pixel);
        }

        // Bewegt ein Panel um die angegebenen Pixel nach unten auf der Y-Achse
        private void MoveDown(Panel panel, int pixel)
        {
            panel.Location = new Point(panel.Location.X, panel.Location.Y + pixel);
        }

        // Bewegt ein Panel um die angegebenen Pixel nach rechts auf der X-Achse
        private void MoveRight(Panel panel, int pixel)
        {
            panel.Location = new Point(panel.Location.X + pixel, panel.Location.Y);
        }

        // Bewegt ein Panel um die angegebenen Pixel nach links auf der X-Achse
        private void MoveLeft(Panel panel, int pixel)
        {
            panel.Location = new Point(panel.Location.X - pixel, panel.Location.Y);
        }

        // Behandelt das Klick Event des StartButton
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Timer starten
            RotationTimer.Enabled = true;
        }

        // Behandelt das Klick Event des StopButton
        private void StopButton_Click(object sender, EventArgs e)
        {
            // Timer stoppen
            RotationTimer.Enabled = false;
        }

        // Behandelt das Klick Event des FasterButton
        private void FasterButton_Click(object sender, EventArgs e)
        {
            // Intervall des Timers verringern (wird häufiger ausgeführt)
            // Der Intervall darf nicht 0 oder kleiner sein -> prüfen
            if (RotationTimer.Interval > 5)
                RotationTimer.Interval -= 5;

            IntervalLabel.Text = RotationTimer.Interval.ToString();
        }

        // Behandelt das Klick Event des SlowerButton
        private void SlowerButton_Click(object sender, EventArgs e)
        {
            // Intervall des Timers erhöhen (wird seltener ausgeführt)
            RotationTimer.Interval += 5;

            IntervalLabel.Text = RotationTimer.Interval.ToString();
        }
    }
}