using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KalkulatorApp
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private double? previousValue = null;
        private string operation = null;
        private readonly string logSource = "KalkulatorApp";
        private readonly string logName = "Application";

        public Form1(Stopwatch stoper)
        {
            InitializeComponent();
            stoper.Stop();

            try
            {
                if (!EventLog.SourceExists(logSource))
                {
                    EventLog.CreateEventSource(logSource, logName);
                }
            }
            catch { }

            if (stoper.ElapsedMilliseconds > 3000)
            {
                try
                {
                    EventLog.WriteEntry(logSource, $"Długi start: {stoper.ElapsedMilliseconds} ms", EventLogEntryType.Warning);
                }
                catch { }
            }
        }

        private void AppendNumber(string num)
        {
            currentInput += num;
            textBoxDisplay.Text = currentInput;
        }

        private void SetOperation(string op)
        {
            if (double.TryParse(currentInput, out double val))
            {
                previousValue = val;
                operation = op;
                currentInput = "";
                textBoxDisplay.Text = "";
            }
        }

        private void CalculateResult()
        {
            if (previousValue.HasValue && double.TryParse(currentInput, out double currentVal))
            {
                double result = 0;
                switch (operation)
                {
                    case "+": result = previousValue.Value + currentVal; break;
                    case "-": result = previousValue.Value - currentVal; break;
                    case "*": result = previousValue.Value * currentVal; break;
                    case "/":
                        if (currentVal == 0)
                        {
                            MessageBox.Show("Nie można dzielić przez zero.");
                            return;
                        }
                        result = previousValue.Value / currentVal;
                        break;
                }
                textBoxDisplay.Text = result.ToString();
                currentInput = result.ToString();
                previousValue = null;
                operation = null;
            }
        }

        private void ClearAll()
        {
            currentInput = "";
            previousValue = null;
            operation = null;
            textBoxDisplay.Text = "";
        }
    }
}
