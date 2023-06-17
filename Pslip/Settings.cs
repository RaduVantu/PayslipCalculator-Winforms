using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pslip
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            HourlyRateTbox.Text = Properties.Settings.Default.HRate;
            OvertimeRateTbox.Text = Properties.Settings.Default.ORate;
            SickPayRateTbox.Text = Properties.Settings.Default.SRate;
            PensionPercentTbox.Text = Properties.Settings.Default.PensProc;
            TaxAllowanceTbox.Text = Properties.Settings.Default.PersAllow;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(LibraryClass.CheckValue(HourlyRateTbox.Text) && 
                LibraryClass.CheckValue(OvertimeRateTbox.Text) &&
                LibraryClass.CheckValue(SickPayRateTbox.Text) &&
                LibraryClass.CheckValue(PensionPercentTbox.Text) &&
                LibraryClass.CheckValue(TaxAllowanceTbox.Text))
            {
                Properties.Settings.Default.HRate = HourlyRateTbox.Text;
                Properties.Settings.Default.ORate = OvertimeRateTbox.Text;
                Properties.Settings.Default.SRate = SickPayRateTbox.Text;
                Properties.Settings.Default.PensProc = PensionPercentTbox.Text;
                Properties.Settings.Default.PersAllow = TaxAllowanceTbox.Text;

                MessageBox.Show("Values set!");
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("All values must be positive numbers!");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
