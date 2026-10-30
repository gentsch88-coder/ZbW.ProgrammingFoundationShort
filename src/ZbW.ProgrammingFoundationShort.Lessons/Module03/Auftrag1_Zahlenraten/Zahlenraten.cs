namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  
  public static void Start()
  {
    int randomValue = 0;
  // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
  //         var random = new Random();
  //         int geheimzahl = random.Next(1, 101);
  Random r = new Random();
    randomValue = r.Next(1, 101);

    // TODO 2: Variablen für Versuchszähler und geraten-Flag
    int counter = 0;
    int geraten = 0;
    // TODO 3: while-Schleife (!geraten)
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen
    Console.WriteLine("Bitte Rate eine Zahl von 0-100");
    while (geraten!=randomValue)
    {
      geraten = Convert.ToInt32(Console.ReadLine());
      counter++;
      if(geraten < randomValue)
      {
        Console.WriteLine("Deine Zahl ist zu klein");
      }
      else
      {
        Console.WriteLine("Deine Zahl ist zu gross");
      }
    }

    Console.WriteLine($"Glückwunsch du hast die Zahl {randomValue} gefunden und du hast {counter} versuche gebraucht");

    // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben
  }
}
