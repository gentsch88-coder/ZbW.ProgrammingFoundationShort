namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste;

// ============================================================
// AUFTRAG 1 – Einkaufsliste (⭐ Einfach | ~15 Min.)
//
// Verwaltet eine Einkaufsliste mit List<string>.
//
// Anforderungen:
//   - TxtArtikel: Artikel eingeben
//   - CmdHinzufuegen: Zur Liste hinzufügen
//   - CmdEntfernen: Ausgewählten Artikel entfernen
//   - CmdAlleLoeschen: Alle löschen
//   - LblAnzahl: Anzahl anzeigen
// ============================================================

public partial class EinkaufslisteForm : Form
{
  // TODO 1: private List<string> _artikel = new();
  private List<string> artikelListe = new();
  

  public EinkaufslisteForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Leere Eingabe prüfen
    string artikel = TxtArtikel.Text;
    if(string.IsNullOrWhiteSpace(artikel))
    {
      MessageBox.Show("Ungültige Eingabe");
      return;
    }
    // TODO 3: _artikel.Add(TxtArtikel.Text.Trim())
    artikelListe.Add(artikel);

    // TODO 4: ListBox aktualisieren, LblAnzahl setzen
    AktualisiereListBox();

    // TODO 5: TxtArtikel leeren und fokussieren
    TxtArtikel.Clear();
    TxtArtikel.Focus();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    // TODO 6: SelectedIndex prüfen (>= 0)
    if(LstArtikel.SelectedIndex >= 0)
    {
      // TODO 7: _artikel.RemoveAt(LstArtikel.SelectedIndex)  – Index statt Text (Duplikate!)
      artikelListe.RemoveAt(LstArtikel.SelectedIndex);
    }

    // TODO 8: ListBox aktualisieren
    AktualisiereListBox();
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    // TODO 9: _artikel.Clear(), ListBox leeren, LblAnzahl = "0"
    artikelListe.Clear();
    LstArtikel.Items.Clear();
    LblAnzahl.Text = $"Artikel: {artikelListe.Count}";

  }

  private void AktualisiereListBox()
  {
    // TODO 10: LstArtikel.Items.Clear();
    LstArtikel.Items.Clear();

    //          foreach (string a in _artikel) LstArtikel.Items.Add(a);
    foreach(string pos in artikelListe)
    {
      LstArtikel.Items.Add(pos);
    }
    //          LblAnzahl.Text = $"Artikel: {_artikel.Count}";

    LblAnzahl.Text = $"Artikel: {artikelListe.Count}";
  }
}
