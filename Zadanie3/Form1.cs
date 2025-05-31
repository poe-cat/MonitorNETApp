using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MonitorApp
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private Timer monitorTimer;
        private const string logSource = "MonitorApp";
        private const string logName = "Application";

        public Form1()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            try
            {
                if (!EventLog.SourceExists(logSource))
                {
                    EventLog.CreateEventSource(logSource, logName);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Brak dostępu do dziennika zdarzeń: " + ex.Message);
            }


            monitorTimer = new Timer();
            monitorTimer.Interval = 3000;
            monitorTimer.Tick += MonitorTimer_Tick;
        }

        private void MonitorTimer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float ramUsage = ramCounter.NextValue();

            labelCpu.Text = $"CPU: {cpuUsage:F1}%";
            labelRam.Text = $"RAM: {ramUsage:F1}%";

            if (cpuUsage > 80)
                LogEvent($"Wysokie użycie CPU: {cpuUsage:F1}%");

            if (ramUsage > 70)
                LogEvent($"Wysokie użycie RAM: {ramUsage:F1}%");
        }

        private void LogEvent(string message)
        {
            try
            {
                EventLog.WriteEntry(logSource, message, EventLogEntryType.Warning);
            }
            catch {}
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            monitorTimer.Start();
        }
    }
}
