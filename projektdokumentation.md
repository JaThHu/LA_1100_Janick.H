# Projekt-Dokumentation



Gruppe: Janick Hurschler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Eine Applikation in der Konsole, bei der man eine Zahl raten muss und das Programm dir sagt, ob sie richtig oder falsch war.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |       muss          |   Funktionale Anforderung   | Als ein Spieler möchte ich eine Zahl raten, damit ich die richtige Zahl treffe. |
| 2  |        muss         |   Funktionale Anforderung   | Als Computer möchte ich eine Zufallszahl generieren, die der Spieler erraten muss.                                    |
| 3    |       muss          |   Qualitätsanforderung   | Als Computer möchte ich dem Spieler ausgeben, ob seine eingegebene Zahl zu gross oder zu klein ist, damit er näher an die Zahl heran kommt. |
| 4    |       muss          |   Qualitätsanforderung   | Als Computer möchte ich dem Spieler ausgeben, wie viele versuche er gebraucht hat, damit er weiss, wie gut er war. |
| 5   |       muss          |   Funktionale Anforderung   | Als Computer möchte ich Fehleingaben erkennen können, damit ich dem Spieler den Fehler anzeigen kann. |
| 6   |       kann         |   Qualitätsanforderung    | Als Computer will ich dem Spieler die Möglichkeit geben, das Spiel neu zu starten, damit er nochmal spielen kann. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Eine Zahl ins Eingabefeld schreiben           |    17     |        Richtige Zahl/Zu klein/zu gross           |
| 2.1  |   Nachschauen, ob der Computer eine Zufallszahl generiert         |     Start    |        Zufallszahl (nicht sichtbar)           |
| 3.1  |   Eine Zahl eingeben           |    17     |        Zu klein/zu gross           |
| 4.1  |   richtige Zahl erraten        |   richtige zahl    |        Richtige Zahl/ du hast x versuche gebraucht           |
| 5.1  |   Fehleingabe machen       |    Bameninhong     |        schreiben Sie hier bitte nur Zahlen von 0 bis 100           |
| 6.1  |  Auf "Spiel neu starten" klicken          |    spiel neu starten    |        Spiel fängt nochmal von vorne an          |


### 1.4 Diagramme

<img width="586" alt="PAP_zahlenratspiel_screenshot" src="https://user-images.githubusercontent.com/111045598/186599281-890138bf-2e16-4be0-bebd-111f3c42f37d.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   01.09.2022    |     Janick      |      US-1, 2        |       90 min        |
| 2.A  |    01.09.2022   |      Janick     |      US-3, 5        |        90 min       |
| 3.A  |    01.09.2022   |      Janick     |      US-4, 6        |        90 min       |

Total:  6 Lektionen


## 3 Entscheiden

Ich habe mich dazu entschiede, die Grundanforderungen zu machen, weil ich noch keine Erfahrung im Programmieren habe. Vielleicht muss ich bei den US im Verlauf des Projektes noch etwas hinzufügen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  01.09.2022     |     Janick      |       90 min        |      ca   75 min          |
| 3.A  |    01.09.2022   |     Janick      |       90 min        |        ca  90 min         |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten
