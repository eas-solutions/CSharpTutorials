using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Wir schreiben das Jahr 2027. Wie einst auch Al Capone konnte mittlerweile auch Jeff Bezoz ganz
 * klar der größte Fall von Steuerhinterziehung in der Menschheitsgeschichte nachgewiesen werden.
 * Sein Versandhandel wurde verstaatlicht und die verhängte Strafe lautet wie folgt:
 * Der Verurteilte muss nicht ins Gefängnis, ist dafür fortan für die Optimierung der
 * Geschenkverpackung aller versendeten Pakete zuständig. Für seine erste Aufgabe bekommt Jeff die
 * Maße von 1000 exakt rechtwinkligen Paketen mitgeteilt. Die benötigte Menge an Geschenkpapier pro
 * Paket ergibt sich aus der Oberfläche. Sicherheitshalber wird pro Paket noch Fläche der
 * kleinsten Seite zusätzlich benötigt.
 * 
 * Beispielpaket 2x3x4
 * Oberfläche des Pakets = 2*2*3 + 2*3*4 + 2*2*4 = 2*6 + 2*12 + 2*8 = 52
 * Kleinste Fläche = 2*3 = 6
 * Gesamt benötigtes Geschenkpapier = 52 + 6 = 58
 */

string[] boxData = EAS.CodeTutorials.GiftWrapping.Input.Data;
int wrappingPaper = 0;
int giftBand = 0;


// ***********
// AUFGABE 1
// Wie viel Geschenkpapier berechnet Jeff für alle 1000 Pakete?
// Das Ergebnis ist 1606483
// ***********





// ***********
// AUFGABE 2
// Nachdem Jeff diese Aufgabe erfolgreich meistern konnte, hat der Gefängniswärter Steve (ist
// eigentlich nur Betriebsleiter) eine weitere Aufgabe für ihn. Die 1000 Pakete sollen zusätzlich
// mit Geschenkband verschönert werden. Das benötigte Geschenkband ist die kürzeste Strecke um das
// Paket herum. Zusätzlich wird für eine schöne Schleife noch mehr gebraucht. Die Länge hierfür
// ergibt sich aus dem Produkt aller drei Seiten.
// 
// Beispielpaket 2x3x4
// Kürzeste Strecke um das Paket = Zweimal die beiden kürzeren Seiten
// Kürzeste Strecke um das Paket = 2+2+3+3 = 10
// Produkt der drei Seiten für die Schleife = 2*3*4 = 24
// Geschenkband = 10 + 24 = 34
// 
// Wieviel Geschenkband berechnet Jeff für alle 1000 Pakete?
// Das Ergebnis ist 3842356
// ***********

Console.WriteLine("Geschenkpapier gesamt: " + wrappingPaper);
Console.WriteLine("Geschenkband gesamt: " + giftBand);
Console.Read();