# LA_1100 Lern-Bericht
Janick Hurschler

## Einleitung

Ich habe ein Zahlenratspiel in C#, Konsolen App programmiert.

## Was habe ich gelernt?

Ich habe gelernt, wie man geschickt eine Kopf- oder Fussgesteuerte Schleife einbaut um den Code Übersichtlicher zu machen.

## Beschreibung

Als ich das Zahlenratspiel programmiert habe, kam ich auf einmal an einen Punkt, wo ich nicht mehr weiter wusste. 
Ich hatte schon einiges an Code geschrieben und musste, für eine Ausführung von ganz Unten nach ganz Oben. Ich hatte mir lange den Kopf zerbrochen darüber, 
wie ich das lösen könnte. Schlussendlich bin ich ins Internet gegangen um da eine Lösung zu finden. Was ich als erstes fand, und auch für gut befunden
habe, war ein "goto" befehl. Diesen arbeitete ich in meinen Text ein. Als ich dann in der nächsten LA-Stunde darauf hindegwiesen wurde, dass diese Methode veraltet ist,
musste ich eine andere Lösung finden - nämlich eine Schleife. Bei dieser musste ich zuerst mal überlegen, welche am besten passt. Ich habe mich schlussendlich
für eine Fussgesteuerte "while"-Schleife entchieden.
Diese bewirkt in meinem Code, das alles, was in der Schleife geschrieben ist, so lange durchläuft bis meine Variable "Fehler" = 1 ist. Das "Fehler" = 1 überhaupt passiert,
muss der Spieler eine Falsche eingabe machen. In diesem Code wäre das: Der Spieler gibt anstatt eine Zahl, einen Buchstaben ein. Dann würde es einen Absturz des Programmes
geben. Um das zu verhindern, schrieb ich ein "catch", der den Fehler abfängt und und dem Spieler zurückgibt, dass er bitte eine Zahl eingeben soll.

<img width="612" alt="2022-09-22" src="https://user-images.githubusercontent.com/111045598/191694447-996302cc-95a6-424c-abff-853e4857c248.png">

![image](https://user-images.githubusercontent.com/111045598/191702388-d62639e8-c515-4b48-b0af-1ec96b1c4c4e.png)



## Verifikation

Der Text zeigt wie ich auf die Schleife gekommen bin. Das Bild zeigt, wie sie im Code aussieht. 

# Reflexion zum Arbeitsprozess

Ich wusste sehr schnell wie ich das Programm schreiben muss, da ich ein PAP erstellt habe und dieses als "Vorlage" verwenden konnte.

Ich bin teilweise sehr von den Arbeitspaketen abgeschweift und habe diese auch nicht immer gleich aktualisiert oder eingetragen.

**VBV**: Ich mache mir beim nächsten Projekt eine Benachrichtigung auf dem Handy oder Laptop, die mich gegen ende der Arbeitszeit fragt, ob ich im Github alles suaber ausgefüllt habe. Zusätzlich halte ich mir immer meine Arbeitspakete auf dem Desktop offen, d
sodass ich den überblick behalte und sie nicht vergesse.
