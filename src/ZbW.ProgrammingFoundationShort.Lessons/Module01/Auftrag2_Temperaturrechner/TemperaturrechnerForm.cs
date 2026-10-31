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
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtCelsius.Text, out double celsius))
    {
      MessageBox.Show("Bitte einen gültigen Celsius-Wert eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Warnung: {celsius} °C liegt unter dem absoluten Nullpunkt ({AbsoluteZero} °C).",
        "Physikalisch unmöglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    double fahrenheit = celsius * 9.0 / 5.0 + 32;
    TxtFahrenheit.Text = $"{fahrenheit:F2}";
  }

  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtFahrenheit.Text, out double fahrenheit))
    {
      MessageBox.Show("Bitte einen gültigen Fahrenheit-Wert eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    double celsius = (fahrenheit - 32) * 5.0 / 9.0;

    if (celsius < AbsoluteZero)
    {
      MessageBox.Show($"Warnung: Ergebnis {celsius:F2} °C liegt unter dem absoluten Nullpunkt.",
        "Physikalisch unmöglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    TxtCelsius.Text = $"{celsius:F2}";
  }

  private void TxtCelsius_TextChanged(object sender, EventArgs e)
  {

  }

  private void TxtCelsius_TextChanged_1(object sender, EventArgs e)
  {

  }
}
