using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace math_tool
{
    public partial class PrimeFactors : Form
    {
        private int input = 0;
        public PrimeFactors()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            input = Convert.ToInt32(inputBox.Value);
            if (!BackgroundDecomposition.IsBusy)
            {
                BackgroundDecomposition.RunWorkerAsync();
                startButton.Enabled = false;
                cancelButton.Enabled = true;
            }
        }
        public static bool Prime_number_judgment(int input)
        {
            List<int> numbers = new List<int>();
            bool zhi_shu = true;
            for (int i = 2; i < input; i++)
                numbers.Add(i);

            foreach (int number in numbers)
            {
                if (input % number != 0)
                    zhi_shu = true;
                else
                    zhi_shu = false; break;
            }
            if (input == 1)
                zhi_shu = false;
            return zhi_shu;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackgroundDecomposition.CancelAsync();
        }

        private void PrimeFactors_Load(object sender, EventArgs e)
        {
            cancelButton.Enabled = false;
        }

        private void BackgroundDecomposition_DoWork(object sender, DoWorkEventArgs e)
        {
            int now = 1;
            List<int> list = new List<int>();
            while (now <= input)
            {
                if (BackgroundDecomposition.CancellationPending)
                    return;

                bool zhi_shu = Prime_number_judgment(now);
                if (zhi_shu == true)
                {
                    if (input % now == 0)
                    {
                        list.Add(now);
                        input /= now;
                        now = 1;
                    }
                    else
                        now += 1;
                }
                else
                    now += 1;
            }
            string result = "";
            foreach (int name in list)
                result += name + " ";

            e.Result = result;
        }

        private void BackgroundDecomposition_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                outputBox.Text = e.Result.ToString();
            }
            catch
            {
                MessageBox.Show("操作已取消！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            startButton.Enabled = true;
            cancelButton.Enabled = false;
        }

        private void PrimeFactors_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackgroundDecomposition.CancelAsync();
        }
    }
}
