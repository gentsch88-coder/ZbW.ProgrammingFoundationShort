namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern

    int[] numbers = ReadNumbers();

    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    //         Console.WriteLine($"Min: {Minimum(zahlen)}, Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");
    int min = Minimum(numbers);
    int max = Maximum(numbers);
    double avg = Average(numbers);
    Output(min, max, avg);
  }
  public static int[] ReadNumbers()
  {
    int[] readNumbers = new int[5];
    for(int i = 0; i < 5; i++)
    {
      Console.WriteLine("Bitte gib 5 Zahlen ein");
      readNumbers[i] = Convert.ToInt32(Console.ReadLine() ??"0");
    }
    return readNumbers;
    
  }

  public static int Minimum(int[] zahlen)
  {
    // TODO: Kleinste Zahl finden (Schleife, kein LINQ)

    int min = zahlen[0];
    foreach(int n in zahlen)
    {
      if(n < min)
      {
        min = n;
      }
    }
    return min;
  }

  public static int Maximum(int[] zahlen)
  {
    // TODO: Grösste Zahl finden (Schleife, kein LINQ)

    int max = zahlen[0];

    foreach(int n in zahlen)
    {
      if(n > max)
      {
        max = n;
      }
    }
    return max;
  }

  public static double Average(int[] zahlen)
  {
    // TODO: Durchschnitt berechnen (Summe / Länge)

    int sum = 0;
    foreach (int n in zahlen)
    {
      sum += n;
    }
    double result = (double)sum / zahlen.Length;
    return result;
  }

  public static void Output(int min, int max, double avg)
  {
    Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg:F2}");
  }
}
