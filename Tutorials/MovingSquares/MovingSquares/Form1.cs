using System;
using System.Windows.Forms;

namespace EAS.CodeTutorials.MovingSquares
{
    public partial class Form1 : Form
    {
        // Variablen zum Speichern der aktuellen Richtung eines Panels
        private ArrowDirection _redPanelDirection = ArrowDirection.Right;
        private ArrowDirection _bluePanelDirection = ArrowDirection.Down;
        private ArrowDirection _yellowPanelDirection = ArrowDirection.Left;
        private ArrowDirection _greenPanelDirection = ArrowDirection.Up;

        // Variablen zum Abstecken des "Bereichs"
        private int _topBorder = 10; // Oberen Grenze bei Position Y=10
        private int _rightBorder = 300; // Rechte Grenze bei Position X=300
        private int _bottomBorder = 300; // Untere Grenze bei Position Y=300
        private int _leftBorder = 10; // Untere Grenze bei Position X=10

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Einstiegsmethode in das Form. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
            IntervalLabel.Text = RotationTimer.Interval.ToString();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Tick-Event des Timers. Wird alle x Millisekunden ausgeführt (x = Intervall)
        /// </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="sender">   Das Steuerelement, welches das Event ausgelöst hat, hier nicht
        ///                         verwendet. </param>
        /// <param name="e">        Event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Bewegt ein Panel entsprechend der angegebenen Richtung. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="panel">        Das Panel, welches bewegt werden soll. </param>
        /// <param name="direction">    The direction. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MovePanel(Panel panel, ArrowDirection direction)
        {
            switch (direction)
            {
                case ArrowDirection.Right:
                    MoveRight(panel, 5); // Das Panel um 5 Pixel nach rechts bewegen
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Prüft, ob ein Panel den Rand des Bereichs erreicht hat und ändert ggf die Richtung.
        /// </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="panel">            Das Panel, welches bewegt werden soll. </param>
        /// <param name="panelDirection">   Die neue Richtung des Panels </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Bewegt ein Panel um die angegebenen Pixel nach oben auf der Y-Achse. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="panel">    Das panel, welches bewegt werden soll </param>
        /// <param name="pixel">    Die Anzahl an pixeln, um die das Panel nach oben bewegt werden soll </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MoveUp(Panel panel, int pixel)
        {
            // Implementiere mich
            // (Die Location des Panels basierend auf der aktuellen Location setzen)
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Bewegt ein Panel um die angegebenen Pixel nach unten auf der Y-Achse. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="panel">    Das panel, welches bewegt werden soll. </param>
        /// <param name="pixel">    Die Anzahl an pixeln, um die das Panel nach unten bewegt werden soll. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MoveDown(Panel panel, int pixel)
        {
            // Implementiere mich
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Bewegt ein Panel um die angegebenen Pixel nach rechts auf der X-Achse. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="panel">    Das panel, welches bewegt werden soll. </param>
        /// <param name="pixel">    Die Anzahl an pixeln, um die das Panel nach rechts bewegt werden soll. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MoveRight(Panel panel, int pixel)
        {
            // Implementiere mich
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Bewegt ein Panel um die angegebenen Pixel nach links auf der X-Achse. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="panel">    Das panel, welches bewegt werden soll. </param>
        /// <param name="pixel">    Die Anzahl an pixeln, um die das Panel nach links bewegt werden soll. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MoveLeft(Panel panel, int pixel)
        {
            // Implementiere mich
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Behandelt das Klick Event des StartButton. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="sender">   Das Steuerelement, welches das Event ausgelöst hat, hier nicht
        ///                         verwendet. </param>
        /// <param name="e">        Eventinformationen, hier nicht verwendet. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Implementiere mich
            // Timer starten (aktivieren)
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Behandelt das Klick Event des StopButton. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="sender">   Das Steuerelement, welches das Event ausgelöst hat, hier nicht
        ///                         verwendet. </param>
        /// <param name="e">        Eventinformationen, hier nicht verwendet </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void StopButton_Click(object sender, EventArgs e)
        {
            // Implementiere mich
            // Timer stoppen (deaktivieren)
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Behandelt das Klick Event des FasterButton. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="sender">   Das Steuerelement, welches das Event ausgelöst hat, hier nicht
        ///                         verwendet. </param>
        /// <param name="e">        Eventinformationen, hier nicht verwendet </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FasterButton_Click(object sender, EventArgs e)
        {
            // Implementiere mich
            // Intervall des Timers um 5 verringern (wird häufiger ausgeführt)
            // Der Intervall darf nicht 0 oder kleiner sein -> prüfen!

            // Den aktuellen Intervall in das IntervalLabel schreiben
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Behandelt das Klick Event des SlowerButton. </summary>
        ///
        /// <remarks>   A Beging, 08.12.2020. </remarks>
        ///
        /// <param name="sender">   Das Steuerelement, welches das Event ausgelöst hat, hier nicht
        ///                         verwendet. </param>
        /// <param name="e">        Eventinformationen, hier nicht verwendet </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SlowerButton_Click(object sender, EventArgs e)
        {
            // Implementiere mich
            // Intervall des Timers um 5 erhöhen (wird seltener ausgeführt)

            // Den aktuellen Intervall in das IntervalLabel schreiben
        }
    }
}