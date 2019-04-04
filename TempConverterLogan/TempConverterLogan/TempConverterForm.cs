/*
 * Created by: Logan Cantin
 * Created on: April 4th
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Area Procedure
 * This program converts celcius to Fahrenheit
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverterLogan
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        private void CtoF(double C)
        {
            double F = (9.0 / 5.0) * C + 32.0;
            MessageBox.Show("Temperature in Fahrenheit is " + Convert.ToString(F));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double userInput = Convert.ToDouble(tbxEntry.Text);
            CtoF(userInput);
        }
    }
}
