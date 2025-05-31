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

            // Tworzenie �r�d�a log�w � tylko je�li nie istnieje
            // Ca�o�� w try-catch, bo wymaga uprawnie� administratora
            try
            {
                if (!EventLog.SourceExists(logSource))
                {
                    EventLog.CreateEventSource(logSource, logName);
                }
            }
            catch
            {
                // Ignorujemy wyj�tek � brak uprawnie� to nie dramat
            }
        }

        // Obs�uga klikni�cia przycisku �Oblicz�
        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double dzielna = double.Parse(textBoxDzielna.Text);
                double dzielnik = double.Parse(textBoxDzielnik.Text);

                if (dzielnik == 0)
                    throw new DivideByZeroException("Nie mo�na dzieli� przez zero.");

                double wynik = dzielna / dzielnik;
                textBoxWynik.Text = wynik.ToString();
            }
            catch (FormatException ex)
            {
                ZalogujBlad("B��d formatu: " + ex.Message);
                MessageBox.Show("Wpisz poprawne liczby (np. 5.2).", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DivideByZeroException ex)
            {
                ZalogujBlad("Dzielenie przez zero: " + ex.Message);
                MessageBox.Show("Nie mo�na dzieli� przez zero.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException ex)
            {
                ZalogujBlad("Zbyt du�a liczba: " + ex.Message);
                MessageBox.Show("Liczba jest zbyt du�a lub zbyt ma�a.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ZalogujBlad("Nieoczekiwany b��d: " + ex.Message);
                MessageBox.Show("Wyst�pi� nieoczekiwany b��d.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Logowanie b��d�w do dziennika zdarze�
        private void ZalogujBlad(string message)
        {
            try
            {
                EventLog.WriteEntry(logSource, message, EventLogEntryType.Error);
            }
            catch
            {
                // Brak dost�pu do logu = pomi�
            }
        }
    }
}
