using System.Security.Cryptography.X509Certificates;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {


    // TODO 3: bool hatZiffer = false;
    bool hasNumber = false;
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);
    bool gueltig = false;
    string inPut = "";

    Console.WriteLine("Gib dein neues Passwort ein mind. 8 Zeichen und eine Ziffer ");
    Console.WriteLine("");

    do 
    {
      

      // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")
       inPut = Console.ReadLine() ?? "";
      //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen
      hasNumber = false;
      foreach (char sign in inPut)
      {
        if (char.IsDigit(sign)) 
        {
          hasNumber = true;
        }
        
      }
      if (!hasNumber)
      {
        Console.WriteLine("Dein Passwort braucht eine Zahl");
      }
      if(inPut.Length < 8)
      {
        Console.WriteLine("Dein Passwort ist zu kurz");
      }
      // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben
      if (inPut.Length >= 8 && hasNumber)
      {
        gueltig = true;
      }
      
    }
    while (!gueltig);

    Console.WriteLine("Dein Passwort entspricht den Anforderungen");

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
    Console.WriteLine("");
    Console.WriteLine($"Dein Passwort ist: {inPut}");
  }
}
