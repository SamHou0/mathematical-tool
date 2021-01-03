using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace math_tool
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void PrimeFactorsButton_Click(object sender, EventArgs e)
        {
            PrimeFactors primeFactors = new PrimeFactors();
            primeFactors.Show();
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/SamHou2007/mathematical-tool",
                UseShellExecute = true
            };
            Process.Start(processStartInfo);
         } 
    }
}
