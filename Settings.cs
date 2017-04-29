using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace ElectronicCircles
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        PerformanceCounter cpuCounter,ramCounter;

        public Settings()
        {
            InitializeComponent();
            

        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Togle = energy.Checked;
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            energy.Checked = Properties.Settings.Default.Togle;
            timer1.Start();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Togle = energy.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void themeColor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpu = cpuCounter.NextValue();
            float ram = ramCounter.NextValue();
            cpuProgress.Value = (int)cpu;
            ramProgress.Value = (int)ram;
            materialLabel1.Text = "" + (int)cpu + "%";
            materialLabel2.Text = "" + (int)ram + "%";
            chart1.Series["CPU"].Points.AddY(cpu);
            chart1.Series["RAM"].Points.AddY(ram);
        }
    }
}
