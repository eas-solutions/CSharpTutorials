using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Sehr geehrter Herr Raketenwissenschaftler,
 * 
 * um einen reibungslosen Start und zu gewährleisten, muss noch die korrekte Funkfrequenz für die
 * sichere Kommunikation mit dem Cockpit berechnet werden.
 * 
 * Im Anhang finden Sie eine Sequenz an Fragmenten, hinter welchen sich die korrekte Funkfrequenz
 * befindet. Ihre Berechnung beginnt mit der Frequenz 0, jedes Fragment ändert die Frequenz um seinen
 * eigenen Wert.
 * 
 * Beispiel:
 * Ihr Input ist "+1, -2, +3, +1"
 * - Aktueller Wert 0, Fragment +1, Ergebnis 1
 * - Aktueller Wert 1, Fragment -2, Ergebnis -1
 * - Aktueller Wert -1, Fragment +3, Ergebnis 2
 * - Aktueller Wert 2, Fragment +1, Ergebnis 3
 *
 * Die Startfrequenz würde in diesem Beispiel 3 sein.
 */

// Alle Zeilen von input.txt in ein string-array lesen
var frequenceArrayString = EAS.CodeTutorials.Frequency.Input.Data;

// String-array in int-array konvertieren
var frequenceArray = frequenceArrayString.Select(int.Parse).ToList();

// ***********
// AUFGABE 1
// Berechne die Startfrequenz anhand der angegebenen Regeln
// ***********
int launchFrequency = 0;

Console.WriteLine("Startfrequenz: " + launchFrequency);
// launchFrequency sollte 484 ergeben

// ***********
// AUFGABE 2
// Zur Überprüfung wird weiterhin eine Kontrollfrequenz benötigt. Hierzu müssen Sie die erste
// Frequenz bestimmten, die zweimal erreicht wird. Ihre Sequenz wiederholt sich zu diesem Zweck
// unbegrenzt.
// 
// Beispiel:
// Aus dem Beispiel im ersten Teil "+1, -2, +3, +1" würde hier also "+1, -2, +3, +1, +1, -2, +3..."
// - Aktueller Wert 0, Fragment +1, Ergebnis 1
// - Aktueller Wert 1, Fragment -2, Ergebnis -1
// - Aktueller Wert -1, Fragment +3, Ergebnis 2
// - Aktueller Wert 2, Fragment +1, Ergebnis 3
// - (Ab hier wird die Sequenz erneut begonnen)
// - Aktueller Wert 3, Fragment +1, Ergebnis 4
// - Aktueller Wert 4, Fragment -2, Ergebnis 2 (stop)
// 
// Das Ergebnis 2 wurde hier als erstes zweimal erreicht und wäre somit unsere Kontrollfrequenz
// 
// Beispiel: 
// ***********

int controlFrequency = 0;

Console.WriteLine("Kontrollfrequenz: " + controlFrequency);
// launchFrequency sollte 367 ergeben

Console.Read();