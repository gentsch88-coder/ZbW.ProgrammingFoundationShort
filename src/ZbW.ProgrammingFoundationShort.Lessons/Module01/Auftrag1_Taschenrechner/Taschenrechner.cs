namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~15 Min.)
//
// Erstelle einen Konsolen-Taschenrechner, der zwei Zahlen und eine
// Operation einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Starten: In Lessons/Program.cs die Zeile
//          ...Auftrag1_Taschenrechner.Taschenrechner.Start();
//          einkommentieren (alle anderen Zeilen auskommentiert lassen).
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Startet den Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    double zahl1 = Input1();
    char operation = InputOperation();
    double zahl2 = Input2();
    Operation(zahl1, zahl2, operation);


  }
  public static double Input1()
  {
    Console.WriteLine("Bitte gebe deine erste Zahl ein: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl1))
      {
       Console.WriteLine("Ungültige Zahl.");    
      }
    return zahl1;
  }

  public static double Input2()
  {
    Console.WriteLine("Bitte gebe deine zweite Zahl ein: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl2))
    {
      Console.WriteLine("Ungültige Zahl.");
    }
    return zahl2;
  }

  public static char InputOperation()
  {
    Console.WriteLine("Bitte gebe eine dieser Operationen ein +, -, *, /, : ");
    if (!char.TryParse(Console.ReadLine() ?? "", out char operation))
    {
      Console.WriteLine("Ungültige Operation.");
    }
    return operation;
  }
  public static void Operation(double zahl1, double zahl2, char operation)
  {
     double result = 0;
    bool operationFunction = true;

    if (operation == '+')
    {
       result = zahl1 + zahl2;
    }
    else if (operation == '-')
    {
       result = zahl1 - zahl2;
    }
    else if (operation == '*')
    {
       result = zahl1 * zahl2;
    }
    else if (operation == '/')
    {
      if (zahl2 != 0)
      {
         result = zahl1 / zahl2;

      }
      else
      {
        Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt.");
        operationFunction = false;
      }
    }
    else
    {
      Console.WriteLine("Ungültige Operation.");
      operationFunction = false;
    }
    if(operationFunction)
    {
      Console.WriteLine($"Ergebnis: {result:F2}");
    }
    
  }
}
