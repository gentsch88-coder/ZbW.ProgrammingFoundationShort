namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~30 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  public const double absoluteZero = -273.15;
  public const double absoluteZeroFahrenheit = -459.67;
  public double celsius;
  public double fahrenheit;
  public double resultFahrenheit;
  public double resultCelsius;
  

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    if (double.TryParse(TxtCelsius.Text, out double celsiusTemp))
    {
      if (celsiusTemp < absoluteZero)
      {
        MessageBox.Show("Wert ist unter dem absoluten Nullpunkt");
        resultFahrenheit = celsiusTemp * 9.0 / 5.0 + 32;
        TxtFahrenheit.Text = $"{resultFahrenheit:F2}";
      }
      else
      {
        resultFahrenheit = celsiusTemp * 9.0 / 5.0 + 32;
        TxtFahrenheit.Text = $"{resultFahrenheit:F2}";
      }
    }
  }
  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    if(double.TryParse(TxtFahrenheit.Text, out double fahrenheitTemp))
    {
      if (fahrenheitTemp < absoluteZeroFahrenheit )
      {
        MessageBox.Show("Wert ist unter dem absoluten Nullpunkt");
        resultCelsius = (fahrenheitTemp - 32) * 5.0 / 9.0;
        TxtCelsius.Text = $"{resultCelsius:F2}";
      }
      else
      {
        resultCelsius = (fahrenheitTemp - 32) * 5.0 / 9.0;
        TxtCelsius.Text = $"{resultCelsius:F2}";
      }
    }
    // TODO 6: Wert aus TxtFahrenheit lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    // TODO 7: Formel anwenden: celsius = (fahrenheit - 32) * 5.0 / 9.0

    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung

    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")
  }
}
