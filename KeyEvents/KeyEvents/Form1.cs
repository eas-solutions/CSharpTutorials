using System.Drawing;
using System.Windows.Forms;

namespace KeyEvents
{
    public partial class Form1 : Form
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Konstruktor. Initialisiert das Form-Element </summary>
        ///
        /// <remarks>   A Beging, 21.02.2019. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event wird bei jedem Tastendruck ausgelöst </summary>
        ///
        /// <remarks>   A Beging, 21.02.2019. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Key press event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///////////////////
            //// AUFGABE 1 ////
            ///////////////////
            // Das SpaceShipPanel soll mit den Pfeiltasten der Tastatur steuerbar sein
            // 

            // Der gedrückte Key ist W (KeyCode = 119)
            // Das SpaceShipPanel soll sich nach oben bewegen (Y-Koordinate um 10 reduzieren)
            if (e.KeyChar == (char) 119)
            {
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X, SpaceShipPanel.Location.Y - 20);
            }

            // Der gedrückte Key ist A (KeyCode = 97)
            // Das SpaceShipPanel soll sich nach links bewegen (X-Koordinate um 10 reduzieren)
            if (e.KeyChar == (char)97)
            {
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X - 20, SpaceShipPanel.Location.Y);
            }

            // Der gedrückte Key ist S (KeyCode = 115)
            // Das SpaceShipPanel soll sich nach unten bewegen (Y-Koordinate um 10 erhöhen)
            if (e.KeyChar == (char)115)
            {
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X, SpaceShipPanel.Location.Y + 20);
            }

            // Der gedrückte Key ist D (KeyCode = 100)
            // Das SpaceShipPanel soll sich nach unten bewegen (Y-Koordinate um 10 erhöhen)
            if (e.KeyChar == (char)100)
            {
                SpaceShipPanel.Location = new Point(SpaceShipPanel.Location.X + 20, SpaceShipPanel.Location.Y);
            }


            ///////////////////
            //// AUFGABE 2 ////
            ///////////////////
            // PositionLabel soll die aktuelle Position (X und Y) des SpaceShipPanel anzeigen
            PositionLabel.Text = "Position: X=" + SpaceShipPanel.Location.X + ", Y=" + SpaceShipPanel.Location.Y;

            ///////////////////////
            //// ZUSATZAUFGABE ////
            ///////////////////////
            // Wenn die Leertaste gedrückt wird, soll das SpaceShipPanel auf Position X = 10, Y = 10 gesetzt werden
            // Gleiche if-Abfrage wie oben. Der KeyCode der Leertaste ist 32
            if (e.KeyChar == (char)32)
            {
                SpaceShipPanel.Location = new Point(10, 30);
            }
        }
    }
}
