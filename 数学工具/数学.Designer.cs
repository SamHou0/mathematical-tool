namespace 数学工具
{
    partial class 数学工具
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(数学工具));
            this.background_decomposition = new System.ComponentModel.BackgroundWorker();
            this.input_box = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.status_indication = new System.Windows.Forms.Label();
            this.check_update = new System.ComponentModel.BackgroundWorker();
            this.install_update_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.save_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.input_box)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_decomposition
            // 
            this.background_decomposition.WorkerReportsProgress = true;
            this.background_decomposition.WorkerSupportsCancellation = true;
            this.background_decomposition.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_decomposition_DoWork);
            this.background_decomposition.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.background_decomposition_RunWorkerCompleted);
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(159, 63);
            this.input_box.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.input_box.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(444, 25);
            this.input_box.TabIndex = 5;
            this.input_box.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.input_box.ValueChanged += new System.EventHandler(this.input_box_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 25);
            this.textBox1.TabIndex = 6;
            // 
            // status_indication
            // 
            this.status_indication.AutoSize = true;
            this.status_indication.Location = new System.Drawing.Point(351, 133);
            this.status_indication.Name = "status_indication";
            this.status_indication.Size = new System.Drawing.Size(37, 15);
            this.status_indication.TabIndex = 8;
            this.status_indication.Text = "空闲";
            // 
            // check_update
            // 
            this.check_update.WorkerReportsProgress = true;
            this.check_update.WorkerSupportsCancellation = true;
            this.check_update.DoWork += new System.ComponentModel.DoWorkEventHandler(this.check_update_DoWork);
            this.check_update.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.check_update_RunWorkerCompleted);
            // 
            // install_update_button
            // 
            this.install_update_button.Location = new System.Drawing.Point(8, 113);
            this.install_update_button.Name = "install_update_button";
            this.install_update_button.Size = new System.Drawing.Size(188, 44);
            this.install_update_button.TabIndex = 9;
            this.install_update_button.Text = "立即检查";
            this.install_update_button.UseVisualStyleBackColor = true;
            this.install_update_button.Click += new System.EventHandler(this.install_update_button_Click);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(623, 50);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 25);
            this.open_button.TabIndex = 10;
            this.open_button.Text = "历史记录";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(623, 81);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "清除记录";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(666, 16);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(111, 33);
            this.about_button.TabIndex = 13;
            this.about_button.Text = "关于/帮助";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(159, 211);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(175, 81);
            this.start_button.TabIndex = 14;
            this.start_button.Text = "开始计算";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(409, 211);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(194, 81);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "取消计算";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 19);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "智能计算模式";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 19);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "手动模式";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 425);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.start_button);
            this.tabPage1.Controls.Add(this.cancel_button);
            this.tabPage1.Controls.Add(this.input_box);
            this.tabPage1.Controls.Add(this.status_indication);
            this.tabPage1.Controls.Add(this.delete_button);
            this.tabPage1.Controls.Add(this.open_button);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "分解质因数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.save_button);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.about_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(226, 6);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(144, 43);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "保存设置";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.install_update_button);
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 163);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检查更新";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 62);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 19);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.Text = "不自动检查";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 19);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "自动检查";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算模式";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 84);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 15);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "显示没有网络？点击这里。";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // 数学工具
            // 
            this.AcceptButton = this.start_button;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(802, 467);
            this.MinimumSize = new System.Drawing.Size(802, 467);
            this.Name = "数学工具";
            this.Text = "数学工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_box)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker background_decomposition;
        private System.Windows.Forms.NumericUpDown input_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label status_indication;
        private System.ComponentModel.BackgroundWorker check_update;
        private System.Windows.Forms.Button install_update_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

