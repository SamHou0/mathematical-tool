using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace 数学工具
{
    public partial class 数学工具 : Form
    {
        private bool Error = false;
        public 数学工具()
        {
            InitializeComponent();

        }
        public int a = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            cancel_button.Enabled = false;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            cancel_button.Enabled = true;
            a=Convert.ToInt32(input_box.Value);
            start_button.Enabled = false;
            background_decomposition.RunWorkerAsync();
            status_indication.Text = "计算中...";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            background_decomposition.CancelAsync();
        }

        private void background_decomposition_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Error = false;
            int y = 1;
            List<int> list = new List<int>();
            
            while (y <= a)
            {
                if(background_decomposition.CancellationPending)
                {
                    Error = true;
                    return;
                }
                bool zhi_shu = prime_number_judgment(y);
                if (zhi_shu == true)
                {
                    if (a % y == 0)
                    {
                        list.Add(y);
                        a = a / y;
                        y = 1;
                    }
                    else { y += 1; }
                }
                else { y += 1; }
            }
            string jieguo = "";
            foreach (int name in list)
            {
                jieguo += name + " ";
            }
            e.Result = jieguo;
        }

        private void background_decomposition_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(Error==true)
            {
                start_button.Enabled = true;
                cancel_button.Enabled = false;
                MessageBox.Show("错误！操作已取消！");
                status_indication.Text = "空闲";
                return;
            }
            textBox1.Text = e.Result.ToString();
            start_button.Enabled = true;
            status_indication.Text = "空闲";
            cancel_button.Enabled = false;
        }
        private bool prime_number_judgment(int y)
        {

            List<int> numbers = new List<int>();
            bool zhi_shu = true;
            for (int i = 2; i < y; i++)
            {
                numbers.Add(i);
            }
            foreach (int number in numbers)
            {
                if (y % number != 0)
                {
                    zhi_shu = true;
                }
                else { zhi_shu = false; break; }
            }

            if (y == 1)
            {
                zhi_shu = false;
            }
            return zhi_shu;
        }
    }
}

