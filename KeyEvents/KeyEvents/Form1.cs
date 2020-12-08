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
                // Implementiere mich
                // Die Position (new Point()) des Panels abhängig der aktuellen Position setzen
            }

            // Der gedrückte Key ist A (KeyCode = 97)
            // Das SpaceShipPanel soll sich nach links bewegen (X-Koordinate um 10 reduzieren)
            if (e.KeyChar == (char)97)
            {
                // Implementiere mich
            }

            // Der gedrückte Key ist S (KeyCode = 115)
            // Das SpaceShipPanel soll sich nach unten bewegen (Y-Koordinate um 10 erhöhen)
            if (e.KeyChar == (char)115)
            {
                // Implementiere mich
            }

            // Der gedrückte Key ist D (KeyCode = 100)
            // Das SpaceShipPanel soll sich nach unten bewegen (Y-Koordinate um 10 erhöhen)
            if (e.KeyChar == (char)100)
            {
                // Implementiere mich
            }


            ///////////////////
            //// AUFGABE 2 ////
            ///////////////////
            // PositionLabel soll die aktuelle Position (X und Y) des SpaceShipPanel anzeigen
            PositionLabel.Text = "...";

            ///////////////////////
            //// ZUSATZAUFGABE ////
            ///////////////////////
            // Wenn die Leertaste gedrückt wird, soll das SpaceShipPanel auf Position X = 10, Y = 10 gesetzt werden
            // Gleiche if-Abfrage wie oben. Der KeyCode der Leertaste ist 32
            if (e.KeyChar == (char)32)
            {
                // Implementiere mich
            }
        }
    }
}
