namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~30 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben, CmdHinzufuegen: Note ins Array
//   - Zähler _anzahl für belegte Plätze, Button deaktivieren, wenn voll
//   - Methoden MIT Parametern: Average/Best/Worst(double[] noten, int anzahl)
//   - LblNoten: Noten sortiert als Komma-Liste (Kopie mit Array.Copy, dann Array.Sort)
//   - LblStats: Durchschnitt, beste und schlechteste Note
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  //         private double[] _noten = new double[10];
  //         private int _anzahl = 0;
  private double[] score = new double[10];
  private double[] newScore;
  private int count = 0;
  
  public NotenVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)
    if(ReadInput(out double value))
    {
      // TODO 3: Note ins Array schreiben und _anzahl erhöhen
      
      score[count] = value;
      count++;

      // TODO 4: Wenn voll: CmdHinzufuegen.Enabled = false;
      if (count == 10)
      {
        CmdHinzufuegen.Enabled = false;
      MessageBox.Show("Dein Array ist voll");
      }
    }
    else
    {
      MessageBox.Show("Ungültige Eingabe");
      return;
    }
    newScore = Sort(score);
    Output();
    

    

    

    // TODO 5: Anzeige aktualisieren (sortierte Kopie + Statistik)
  }

  private bool ReadInput(out double value)
  {
    if (double.TryParse(TxtNote.Text,out  value) && value >=1 && value <=6 )
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  private double Average(double[] noten, int anzahl)
  {
    // TODO: Durchschnitt der ersten "anzahl" Noten
    double sum = 0;
    for(int i = 0; i< anzahl;i++)
    {
      sum += noten[i];
    }
    
    double result = sum / anzahl;
    return result;
  }

  private double Best(double[] noten, int anzahl)
  {
    double max = noten[anzahl-1];    
    return max;
  }

  private double Worst(double[] noten, int anzahl)
  {
    double min = noten[0];
    return min;
  }
  private double[] Sort(double[] numbers)
  {
    double[] copyNumbers = new double[count];
    Array.Copy(numbers, copyNumbers, count);
    Array.Sort(copyNumbers);
    return copyNumbers;
  }
  private void Output()
  {
    LblNoten.Text = "";
    LblStats.Text = "";
    LblStats.Text += $"Noten Druchschnitt: {Average(score, count)} {Environment.NewLine}";
    LblStats.Text += $"Beste Note : {Best(newScore, count)} {Environment.NewLine}";
    LblStats.Text += $"Schlechtest Note : {Worst(newScore, count)} {Environment.NewLine}";
    for(int i = 0; i < count; i++)
    {
      LblNoten.Text += $"Note: {newScore[i]}{Environment.NewLine}";
    }

  }
}
