namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi;

partial class BmiForm
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
    LblGewicht = new Label();
    TxtGewicht = new TextBox();
    LblGewichtEinheit = new Label();
    LblGroesse = new Label();
    TxtGroesse = new TextBox();
    LblGroesseEinheit = new Label();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    SuspendLayout();
    // 
    // LblGewicht
    // 
    LblGewicht.AutoSize = true;
    LblGewicht.Location = new Point(14, 24);
    LblGewicht.Name = "LblGewicht";
    LblGewicht.Size = new Size(65, 20);
    LblGewicht.TabIndex = 0;
    LblGewicht.Text = "Gewicht:";
    // 
    // TxtGewicht
    // 
    TxtGewicht.Location = new Point(137, 20);
    TxtGewicht.Margin = new Padding(3, 4, 3, 4);
    TxtGewicht.Name = "TxtGewicht";
    TxtGewicht.Size = new Size(114, 27);
    TxtGewicht.TabIndex = 1;
    TxtGewicht.TextChanged += TxtGewicht_TextChanged;
    // 
    // LblGewichtEinheit
    // 
    LblGewichtEinheit.AutoSize = true;
    LblGewichtEinheit.Location = new Point(261, 24);
    LblGewichtEinheit.Name = "LblGewichtEinheit";
    LblGewichtEinheit.Size = new Size(25, 20);
    LblGewichtEinheit.TabIndex = 2;
    LblGewichtEinheit.Text = "kg";
    // 
    // LblGroesse
    // 
    LblGroesse.AutoSize = true;
    LblGroesse.Location = new Point(14, 71);
    LblGroesse.Name = "LblGroesse";
    LblGroesse.Size = new Size(56, 20);
    LblGroesse.TabIndex = 3;
    LblGroesse.Text = "Grösse:";
    // 
    // TxtGroesse
    // 
    TxtGroesse.Location = new Point(137, 67);
    TxtGroesse.Margin = new Padding(3, 4, 3, 4);
    TxtGroesse.Name = "TxtGroesse";
    TxtGroesse.Size = new Size(114, 27);
    TxtGroesse.TabIndex = 4;
    // 
    // LblGroesseEinheit
    // 
    LblGroesseEinheit.AutoSize = true;
    LblGroesseEinheit.Location = new Point(261, 71);
    LblGroesseEinheit.Name = "LblGroesseEinheit";
    LblGroesseEinheit.Size = new Size(93, 20);
    LblGroesseEinheit.TabIndex = 5;
    LblGroesseEinheit.Text = "m (z. B. 1.78)";
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(137, 113);
    CmdBerechnen.Margin = new Padding(3, 4, 3, 4);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(149, 37);
    CmdBerechnen.TabIndex = 6;
    CmdBerechnen.Text = "BMI berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblErgebnis.Location = new Point(14, 167);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 23);
    LblErgebnis.TabIndex = 7;
    // 
    // BmiForm
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(457, 213);
    Controls.Add(LblGewicht);
    Controls.Add(TxtGewicht);
    Controls.Add(LblGewichtEinheit);
    Controls.Add(LblGroesse);
    Controls.Add(TxtGroesse);
    Controls.Add(LblGroesseEinheit);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Margin = new Padding(3, 4, 3, 4);
    Name = "BmiForm";
    Text = "BMI-Rechner – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblGewicht;
  private TextBox TxtGewicht;
  private Label LblGewichtEinheit;
  private Label LblGroesse;
  private TextBox TxtGroesse;
  private Label LblGroesseEinheit;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
