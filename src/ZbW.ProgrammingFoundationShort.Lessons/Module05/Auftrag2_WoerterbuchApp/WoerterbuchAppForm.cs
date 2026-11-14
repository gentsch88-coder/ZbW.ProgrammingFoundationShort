namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~30 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  // TODO 1: private Dictionary<string, string> _woerterbuch = new();
  private Dictionary<string, string> woerterbuchListe = new(StringComparer.OrdinalIgnoreCase);

  public WoerterbuchAppForm()
  {
    InitializeComponent();
    // TODO 2: 5 Wörter vorab einfügen (z.B. Hund → Dog, Katze → Cat...)
    woerterbuchListe.Add("Bitübertragungschicht", "Physical Layer");
    woerterbuchListe.Add("Sicherungschicht", "Data Link Layer");
    woerterbuchListe.Add("Vermittlungschicht", "Network Layer");
    woerterbuchListe.Add("Transportschicht", "Transport Layer");
    woerterbuchListe.Add("Sitzungschicht", "Session Layer");
    woerterbuchListe.Add("Darstellungschicht", "Presentation Layer");
    woerterbuchListe.Add("Anwendungschicht", "Application Layer");

    // TODO 3: AktualisiereListBox() aufrufen
    AktualisiereListBox();
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TODO 4: TryGetValue für TxtSuche.Text
    if(woerterbuchListe.TryGetValue(TxtSuche.Text.Trim(),out string value))
    {
      //         Gefunden: LblErgebnis anzeigen
      LblErgebnis.Text = $"Das Englische Wort ist: {value}";
    }
    else
    {
      //         Nicht gefunden: "Kein Eintrag für..."
      LblErgebnis.Text = $"Kein Eintrag für {TxtSuche.Text}";
    }


  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string newKey = TxtKeyNeu.Text.Trim();
    string newValue = TxtValueNeu.Text.Trim();

    // TODO 5: Leere Felder prüfen
    if (string.IsNullOrWhiteSpace(newKey) || string.IsNullOrWhiteSpace(newValue))
    {
      MessageBox.Show("Ungültige Eingabe");
      return;
    }

    // TODO 6: ContainsKey-Prüfung → Überschreiben bestätigen
    if(!woerterbuchListe.ContainsKey(newKey))
    {
      // TODO 7: _woerterbuch[key] = value;
      woerterbuchListe.Add(newKey, newValue);
    }
    else
    {
      DialogResult antwort = MessageBox.Show(
         "Das Wort existiert bereits", "Möchtest du die Übersetzung überschreiben?",
         MessageBoxButtons.YesNo);

      if(antwort == DialogResult.Yes)
      {
        woerterbuchListe[newKey]=(newValue);
      }
      else
      {
        return;
      }

      
    }
    

    // TODO 8: AktualisiereListBox()
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    // TODO 9: LstEintraege befüllen aus _woerterbuch
    LstEintraege.Items.Clear();

    foreach(var wort in woerterbuchListe)
    {
      LstEintraege.Items.Add($"Deutsch: {wort.Key}  =>  Englisch: {wort.Value}");
    }
  }
}
