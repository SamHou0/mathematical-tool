using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using MyClassLibrary;

namespace 数学工具
{
    public partial class 数学工具 : Form
    {
        private bool start = false;
        private bool Error = false;

        public 数学工具()
        {
            InitializeComponent();
        }

        public int a = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Users\public\settings.txt"))
            {
                File.AppendAllText(@"C:\Users\public\settings.txt", "true\n");
                File.AppendAllText(@"C:\Users\public\settings.txt", "true\n");
            }
            else
            {
                string[] result = File.ReadAllLines(@"C:\Users\public\settings.txt");
                if (result[0] == "true")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                if (result[1] == "true")
                    radioButton3.Checked = true;
                else
                    radioButton4.Checked = true;
            }
            start = true;
            cancel_button.Enabled = false;
            if (radioButton3.Checked)
            {
                start_button.Enabled = false;
                install_update_button.Enabled = false;
                check_update.RunWorkerAsync();
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            cancel_button.Enabled = true;
            a = Convert.ToInt32(input_box.Value);
            start_button.Enabled = false;
            if (background_decomposition.IsBusy == false)
            {
                background_decomposition.RunWorkerAsync();
                status_indication.Text = "计算中...";
            }
        }

        private void background_decomposition_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Error = false;
            int y = 1;
            List<int> list = new List<int>();
            while (y <= a)
            {
                if (background_decomposition.CancellationPending)
                {
                    Error = true;
                    return;
                }
                bool zhi_shu = factor_of_decomposition.prime_number_judgment(y);
                if (zhi_shu == true)
                {
                    if (a % y == 0)
                    {
                        list.Add(y);
                        a /= y;
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
            if (Error == true)
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
            File.AppendAllText(@"C:\Users\Public\history_record.txt", input_box.Value + ":" + e.Result.ToString() + "\n");
        }

        

        private void check_update_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            MyClassLibrary.check_update.start_check_update(
                start, "2.7.4",//TODO:升级后记得修改版本号
                "https://samhou2007.github.io/mathematical-tool/check_update_information/version_number.txt",
                "https://samhou2007.github.io/mathematical-tool/Setup/Release/Setup.msi",
                "https://samhou2007.github.io/mathematical-tool/check_update_information/release_notes.txt");
        }

        private void install_update_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            start = false;
            check_update.RunWorkerAsync();
            install_update_button.Enabled = false;
        }

        private void check_update_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            start_button.Enabled = true;
            install_update_button.Enabled = true;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Public\history_record.txt"))
                Process.Start("notepad.exe", @"C:\Users\Public\history_record.txt");
            else
                MessageBox.Show("没有历史记录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\Public\history_record.txt");
            MessageBox.Show("已经清除历史记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            background_decomposition.CancelAsync();
        }

        private void input_box_ValueChanged(object sender, EventArgs e)
        {
            string[] result = File.ReadAllLines(@"C:\Users\public\settings.txt");
            if (result[0]=="true"&&Convert.ToInt32(input_box.Value)<=10000)
            {
                cancel_button.Enabled = true;
                a = Convert.ToInt32(input_box.Value);
                start_button.Enabled = false;
                if (background_decomposition.IsBusy == false)
                {
                    background_decomposition.RunWorkerAsync();
                    status_indication.Text = "计算中...";
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            save_settings.do_save_settings(radioButton1.Checked, radioButton3.Checked);
            MessageBox.Show("保存成功！", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://samhou2007.github.io/mathematical-tool/internet_fix.html");
        }
    }
}