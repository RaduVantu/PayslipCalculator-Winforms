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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();            
        }

        

        private void CalculateBtn_Click(object sender, EventArgs e)
        {            
            double hours = LibraryClass.Unit(HoursTbox.Text);
            double overhours = LibraryClass.Unit(OverHoursTbox.Text);
            double sickDays = LibraryClass.Unit(SickDaysTbox.Text);

            if (hours == -1 || overhours == -1 || sickDays == -1)
            {
                MessageBox.Show("All values must be positive numbers!");                
            }
            else if (hours == 0 && overhours == 0 && sickDays == 0)
            {
                MessageBox.Show("Nothing to calculate :)");
            }
            else
            {
                double hourRate = double.Parse(Properties.Settings.Default.HRate);
                double overRate = double.Parse(Properties.Settings.Default.ORate);
                double sickRate = double.Parse(Properties.Settings.Default.SRate);
                double grossPay, taxablePay, tax, nino, pension, netPay;

                grossPay = hours * hourRate + overhours * overRate + sickDays * sickRate;
                taxablePay = grossPay - (double.Parse(Properties.Settings.Default.PersAllow) / 12);

                tax = taxablePay * 0.2;
                nino = taxablePay * 0.12;
                pension = grossPay * (double.Parse(Properties.Settings.Default.PensProc) / 100);

                if (nino < 0)
                {
                    nino = 0;
                }                
                
                if (tax < 0)
                {
                    tax = 0;
                }                

                netPay = grossPay - tax - nino - pension;
                
                grossLbl.Text = grossPay.ToString();
                taxLbl.Text = tax.ToString();
                niLbl.Text = nino.ToString();
                pensionLbl.Text = pension.ToString();
                netLbl.Text = netPay.ToString();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HoursTbox.Clear();
            OverHoursTbox.Clear();
            SickDaysTbox.Clear();

            grossLbl.Text = "";
            taxLbl.Text = "";
            niLbl.Text = "";
            pensionLbl.Text = "";
            netLbl.Text = "";
        }

        private void SetRatesBtn_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
