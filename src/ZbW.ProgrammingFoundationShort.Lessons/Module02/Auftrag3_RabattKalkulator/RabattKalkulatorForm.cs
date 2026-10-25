using System.Drawing.Text;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

// ============================================================
// AUFTRAG 3 – RabattKalkulator (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Berechne einen Rabatt anhand von Kundentyp und Lehrling-Status.
//
// Anforderungen:
//   - TxtBetrag: Kaufbetrag einlesen
//   - RadioButtons: Normal (0%), Premium (10%), VIP (20%)
//   - CheckBox: Lehrling (+5% extra Rabatt)
//   - Anzeige: Originalbetrag, Rabatt in CHF, Endbetrag (2 Nachkommastellen)
//   - Geld als decimal (Block 01)
// ============================================================

public partial class RabattKalkulatorForm : Form
{
  public decimal inputValue = 0;
  public decimal discountTotal = 0;
  public decimal endPrice = 0;
  public RabattKalkulatorForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    ReadInput();
    decimal discountPrice = ReadRadioButton(inputValue);
    decimal lehrlingDiscountPrise = LehrlingChecked(inputValue);
    DiscountTotal(discountPrice, lehrlingDiscountPrise);
    CalculatePrice();
    Output();
  }
  private void ReadInput()
  {
    // TODO 1: Betrag aus TxtBetrag lesen (decimal.TryParse), muss grösser als 0 sein
    if (!decimal.TryParse(TxtBetrag.Text, out  inputValue) || inputValue < 0)
    {
      //         Bei ungültiger Eingabe: MessageBox anzeigen und return
      MessageBox.Show("Ungültige Eingabe");
      return;
    }
  }


  // TODO 2: Rabatt aus RadioButton ermitteln
  //         RadNormal = 0%, RadPremium = 10%, RadVip = 20%
  private decimal ReadRadioButton( decimal value)
  {
    if(RadPremium.Checked)
    {
      decimal premiumValue = value * 0.10m;
      return premiumValue;
    }
    else if (RadVip.Checked)
    {
      decimal vipValue = value * 0.2m;
      return vipValue;
    }
    else
    {
      decimal nomalValue = value * 0;
      return nomalValue;
    }
    
  }


  // TODO 3: Wenn ChkLehrling.Checked → Rabatt += 5
  private decimal LehrlingChecked(decimal value)
  {
    if(ChkLehrling.Checked)
    {
      decimal lehrlingsdiscount = value * 0.05m;
      return lehrlingsdiscount;
    }
    else
    {
      value = 0;
      return value;
    }
    
  }

  // TODO 4: Rabatt in CHF und Endbetrag berechnen:
  //         rabattBetrag = betrag * rabatt / 100m;  endbetrag = betrag - rabattBetrag
  private void CalculatePrice()
  {
    endPrice = inputValue - discountTotal;
  }

  private void DiscountTotal(decimal value1, decimal value2)
  {
    discountTotal = value1 + value2;
  }

  // TODO 5: LblErgebnis.Text setzen: Originalbetrag, Rabatt in CHF (und %), Endbetrag
  private void Output()
  {
    LblErgebnis.Text = $"Original Betrag: {inputValue:F2}Chf. Dein Rabatt ist {discountTotal:F2} Chf." +
      $" Dein Endbetrag: {endPrice:F2}Chf.";
  }
}
