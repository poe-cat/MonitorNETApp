using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DzielnikApp
{
    public partial class Form1 : Form
    {
        private const string logSource = "DzielnikApp";
        private const string logName = "Application";

        public Form1()
        {
            InitializeComponent();

            // Tworzenie Ÿród³a logów — tylko jeœli nie istnieje
            // Ca³oœæ w try-catch, bo wymaga uprawnieñ administratora
            try
            {
                if (!EventLog.SourceExists(logSource))
                {
                    EventLog.CreateEventSource(logSource, logName);
                }
            }
            catch
            {
                // Ignorujemy wyj¹tek — brak uprawnieñ to nie dramat
            }
        }

        // Obs³uga klikniêcia przycisku „Oblicz”
        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double dzielna = double.Parse(textBoxDzielna.Text);
                double dzielnik = double.Parse(textBoxDzielnik.Text);

                if (dzielnik == 0)
                    throw new DivideByZeroException("Nie mo¿na dzieliæ przez zero.");

                double wynik = dzielna / dzielnik;
                textBoxWynik.Text = wynik.ToString();
            }
            catch (FormatException ex)
            {
                ZalogujBlad("B³¹d formatu: " + ex.Message);
                MessageBox.Show("Wpisz poprawne liczby (np. 5.2).", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DivideByZeroException ex)
            {
                ZalogujBlad("Dzielenie przez zero: " + ex.Message);
                MessageBox.Show("Nie mo¿na dzieliæ przez zero.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException ex)
            {
                ZalogujBlad("Zbyt du¿a liczba: " + ex.Message);
                MessageBox.Show("Liczba jest zbyt du¿a lub zbyt ma³a.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ZalogujBlad("Nieoczekiwany b³¹d: " + ex.Message);
                MessageBox.Show("Wyst¹pi³ nieoczekiwany b³¹d.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Logowanie b³êdów do dziennika zdarzeñ
        private void ZalogujBlad(string message)
        {
            try
            {
                EventLog.WriteEntry(logSource, message, EventLogEntryType.Error);
            }
            catch
            {
                // Brak dostêpu do logu = pomiñ
            }
        }
    }
}
