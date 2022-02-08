# Dev.Asterix (dev.*)

Hier finden sich diverse Vorträge und Workshops inklusive Code.

# Marp'en der Folien

Startet auf dem PC einnen Service auf Port [8080](http://localhost:8080) und erstellt die Folien on-demand bzw. bei Änderung.

    marp -p -s --input-dir .\slides\

Hiermit können alle Slides erzeugt werden. Output ist entsprechend der `build` Ordner.

    marp --input-dir .\slides\
    marp --input-dir .\slides\ --pdf
    
`.marprc.yml` enthält die Konfiguration für Theme, Output etc.

Die gerenderten Slides befinden sich `Slides`

