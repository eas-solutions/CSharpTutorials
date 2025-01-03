# RocketFuel

Übungsaufgabe\
**Schwierigkeitsstufe**: Mittel

---
```
Sehr geehrter Herr Raketenwissenschaftler,

um nicht unnötig viel Treibstoff zu verbrauchen und die somit die Kosten für den
Steuerzahler möglichst gering zu halten, ist die für den nächsten Raketenstart
exakt benötigte Menge an Treibstoff erforderlich.

Im Anhang an diese Nachricht finden Sie die einzelnen Gewichte aller unserer Raketenmodule.
Die benötigte Menge Treibstoff pro Modul ergibt sich, indem Sie das Gewicht durch drei
teilen, abrunden und zwei abziehen.

Beispiel:
Ein Modul wiegt 14 Kilogramm. Durch drei geteilt und abgerundet sind das 4 kg.
Zwei subtrahiert ergibt eine benötigte Treibstoffmenge von 2 kg.

Das Ergebnis ist die Summe der Treibstoffmengen aller Module.
```

---
## Aufgabe 1
```
Finde anhand der gegebenen Regeln zur Treibstoffberechnung heraus, wieviel Treibstoff
insgesamt benötigt wird.

totalFuel sollte 3178783 ergeben
```

---
## Aufgabe 2
```
Während einer routinemäßgen Überprüfung der Berechnungen wurde festgestellt, dass der
geladene Treibstoff zusätzliches Gewicht bedeutet. Also benötigt der Treibstoff ebenfalls
Treibstoff, welcher natürlich ebenfalls Treibstoff benötigt und so weiter. Wenn ein
Gewicht eine negative Menge an Treibstoff benötigen würde, wird diese ignoriert.

Beispiel:
- Ein Modul wiegt 14 kg und benötigt 2 kg Treibstoff. Dieser Treibstoff benötigt keinen
  weiteren Treibstoff (2 geteilt durch 3 ergibt abgerundet 0. Minus 2 wäre negativ, daher ignoiert)
- Ein Modul wiegt 86 kg und benötigt 26 kg Treibstoff. Dieser Treibstoff benötigt 6 kg Treibstoff.
  Dieser Treibstoff benötigt keinen weiteren Treibstoff.

Berechne nach den oben angegebenen Regeln den Treibstoff für den Treibstoff.

totalFuel2 sollte 4765294 ergeben
```