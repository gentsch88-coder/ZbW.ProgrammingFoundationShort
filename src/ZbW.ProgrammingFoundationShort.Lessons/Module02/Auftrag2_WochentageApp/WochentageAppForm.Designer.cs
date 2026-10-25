namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

partial class WochentageAppForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblWochentag = new Label();
    CmbWochentag = new ComboBox();
    CmdAnzeigen = new Button();
    LblErgebnis = new Label();
    SuspendLayout();
    // 
    // LblWochentag
    // 
    LblWochentag.AutoSize = true;
    LblWochentag.Location = new Point(14, 27);
    LblWochentag.Name = "LblWochentag";
    LblWochentag.Size = new Size(87, 20);
    LblWochentag.TabIndex = 0;
    LblWochentag.Text = "Wochentag:";
    // 
    // CmbWochentag
    // 
    CmbWochentag.DropDownStyle = ComboBoxStyle.DropDownList;
    CmbWochentag.Location = new Point(137, 23);
    CmbWochentag.Margin = new Padding(3, 4, 3, 4);
    CmbWochentag.Name = "CmbWochentag";
    CmbWochentag.Size = new Size(171, 28);
    CmbWochentag.TabIndex = 1;
    CmbWochentag.SelectedIndexChanged += CmbWochentag_SelectedIndexChanged;
    // 
    // CmdAnzeigen
    // 
    CmdAnzeigen.Location = new Point(137, 67);
    CmdAnzeigen.Margin = new Padding(3, 4, 3, 4);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(137, 37);
    CmdAnzeigen.TabIndex = 2;
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(14, 120);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 20);
    LblErgebnis.TabIndex = 3;
    // 
    // WochentageAppForm
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(366, 173);
    Controls.Add(LblWochentag);
    Controls.Add(CmbWochentag);
    Controls.Add(CmdAnzeigen);
    Controls.Add(LblErgebnis);
    Margin = new Padding(3, 4, 3, 4);
    Name = "WochentageAppForm";
    Text = "WochentageApp – Auftrag 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblWochentag;
  private ComboBox CmbWochentag;
  private Button CmdAnzeigen;
  private Label LblErgebnis;
}
