using System.Security.Cryptography.X509Certificates;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

// ============================================================
// AUFTRAG 3 – Datentyp-Quiz (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Erstelle ein Konsolen-Quiz mit 5 Fragen zu C#-Datentypen und Operatoren.
//
// Anforderungen:
//   - Fragen per Console.Write ausgeben, Antwort mit Console.ReadLine() einlesen
//   - Gross-/Kleinschreibung ignorieren: .Trim().ToLower()
//   - Mindestens 1 Frage erwartet eine Zahl → mit int.TryParse prüfen
//   - Am Ende: $"Resultat: {punkte}/5" ausgeben
//   - Bonus: Gesamtzeit mit Stopwatch messen
//
// Frage 1 ist als Beispiel fertig. Ergänze die Fragen 2–5.
// ============================================================

public static class DatentypQuiz
{
  public static int punkte = 0;
  /// <summary>
  ///   Startet das Quiz auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO (Bonus): Stopwatch starten
    //         var stopwatch = System.Diagnostics.Stopwatch.StartNew();
    var stopwatch = System.Diagnostics.Stopwatch.StartNew();
    Question1();
    Question2();
    Question3();
    Question4();
    Question5();
    stopwatch.Stop();

    Console.WriteLine($"Resultat: {punkte}/5");
    Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
  }
    // ── Frage 1 (Beispiel, Textantwort) ──────────────────────
    public static int Question1()
  {
    Console.Write("Frage 1: Welcher Datentyp speichert true/false? ");
    string antwort1 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort1 == "bool")
    {
      Console.WriteLine("  Richtig!");
      punkte+= 1;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: bool");
    }
    return punkte;
  }
  public static int Question2()
  {
    Console.WriteLine("Welcher Typ eignet sich für Geldbeträge? ");
    string antwort2 = (Console.ReadLine() ?? "").Trim().ToLower();

    if(antwort2 == "decimal")
    {
      Console.WriteLine(" Richtig!");
      punkte += 1;
    }
    else
    {
      Console.WriteLine(" Falsch. Richtige Antwort: decimal");
    }
    return punkte;
  }

  public static int Question3()
  {
    Console.WriteLine("Was ergibt 7 / 2, wenn beide Zahlen int sind?");
    if(int.TryParse(Console.ReadLine()?? "", out int antwort3) && antwort3 == 3)
    {
      Console.WriteLine(" Richtig");
      punkte += 1;
    }
    else
    {
      Console.WriteLine(" Falsch. Richtige Antwort: 3");
    }
    return punkte;
  }

  public static int Question4()
  {
    Console.WriteLine("Was ergibt 10 % 3? ");
    if (int.TryParse(Console.ReadLine() ?? "", out int antwort4) && antwort4 == 1)
    {
      Console.WriteLine(" Richtig");
      punkte += 1;
    }
    else
    {
      Console.WriteLine(" Falsch. Richtige Antwort: 1");
    }
    return punkte;
  }

  public static int Question5()
  {
    Console.WriteLine("Welcher Typ speichert genau ein Zeichen? ");
    string antwort5 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort5 == "char")
    {
      Console.WriteLine(" Richtig!");
      punkte += 1;
    }
    else
    {
      Console.WriteLine(" Falsch. Richtige Antwort: char");
    }
    return punkte;
  }




  // TODO 3: Frage 3 (Zahl) – z. B. «Was ergibt 7 / 2, wenn beide Zahlen int sind?» → 3
  //         if (int.TryParse(Console.ReadLine() ?? "", out int antwort3) && antwort3 == 3)

  // TODO 4: Frage 4 (Zahl) – z. B. «Was ergibt 10 % 3?» → 1

  // TODO 5: Frage 5 (Text) – z. B. «Welcher Typ speichert genau ein Zeichen?» → char



  // TODO (Bonus): Stopwatch stoppen und Zeit ausgeben
  //         stopwatch.Stop();
  //         Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");

}
