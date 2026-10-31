namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

partial class NotenrechnerFormLoesung
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
    LblPunkte = new Label();
    TxtPunkte = new TextBox();
    CmdBerechnen = new Button();
    LblNote = new Label();
    LblBewertung = new Label();
    SuspendLayout();
    // 
    // LblPunkte
    // 
    LblPunkte.AutoSize = true;
    LblPunkte.Location = new Point(14, 27);
    LblPunkte.Name = "LblPunkte";
    LblPunkte.Size = new Size(110, 20);
    LblPunkte.TabIndex = 0;
    LblPunkte.Text = "Punkte (0–100):";
    // 
    // TxtPunkte
    // 
    TxtPunkte.Location = new Point(160, 23);
    TxtPunkte.Margin = new Padding(3, 4, 3, 4);
    TxtPunkte.Name = "TxtPunkte";
    TxtPunkte.Size = new Size(91, 27);
    TxtPunkte.TabIndex = 1;
   // tPunkte.TextChanged += TxtPunkte_TextChanged;
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(160, 67);
    CmdBerechnen.Margin = new Padding(3, 4, 3, 4);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(149, 37);
    CmdBerechnen.TabIndex = 2;
    CmdBerechnen.Text = "Note berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblNote
    // 
    LblNote.AutoSize = true;
    LblNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
    LblNote.Location = new Point(14, 120);
    LblNote.Name = "LblNote";
    LblNote.Size = new Size(0, 28);
    LblNote.TabIndex = 3;
    // 
    // LblBewertung
    // 
    LblBewertung.AutoSize = true;
    LblBewertung.Location = new Point(14, 157);
    LblBewertung.Name = "LblBewertung";
    LblBewertung.Size = new Size(0, 20);
    LblBewertung.TabIndex = 4;
    // 
    // NotenrechnerFormLoesung
    // 
    AutoScaleDimensions = new SizeF(8F, 20F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(366, 200);
    Controls.Add(LblPunkte);
    Controls.Add(TxtPunkte);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblNote);
    Controls.Add(LblBewertung);
    Margin = new Padding(3, 4, 3, 4);
    Name = "NotenrechnerFormLoesung";
    Text = "Notenrechner – Lösung";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblPunkte;
  private TextBox TxtPunkte;
  private Button CmdBerechnen;
  private Label LblNote;
  private Label LblBewertung;
}
