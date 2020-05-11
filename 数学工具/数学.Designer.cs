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
            this.start_button = new System.Windows.Forms.Button();
            this.background_decomposition = new System.ComponentModel.BackgroundWorker();
            this.cancel_button = new System.Windows.Forms.Button();
            this.input_box = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status_indication = new System.Windows.Forms.Label();
            this.check_update = new System.ComponentModel.BackgroundWorker();
            this.install_update_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.input_box)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.AutoSize = true;
            this.start_button.Location = new System.Drawing.Point(180, 158);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(172, 73);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "开始";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // background_decomposition
            // 
            this.background_decomposition.WorkerReportsProgress = true;
            this.background_decomposition.WorkerSupportsCancellation = true;
            this.background_decomposition.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_decomposition_DoWork);
            this.background_decomposition.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.background_decomposition_RunWorkerCompleted);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(454, 158);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(170, 73);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "取消计算";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(180, 45);
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 25);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "分解质因数";
            // 
            // status_indication
            // 
            this.status_indication.AutoSize = true;
            this.status_indication.Location = new System.Drawing.Point(374, 73);
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
            this.install_update_button.Location = new System.Drawing.Point(674, 368);
            this.install_update_button.Name = "install_update_button";
            this.install_update_button.Size = new System.Drawing.Size(98, 44);
            this.install_update_button.TabIndex = 9;
            this.install_update_button.Text = "检查更新";
            this.install_update_button.UseVisualStyleBackColor = true;
            this.install_update_button.Click += new System.EventHandler(this.install_update_button_Click);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(641, 33);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 25);
            this.open_button.TabIndex = 10;
            this.open_button.Text = "历史记录";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(641, 69);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "清除记录";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // 数学工具
            // 
            this.AcceptButton = this.start_button;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.install_update_button);
            this.Controls.Add(this.status_indication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.start_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(802, 467);
            this.MinimumSize = new System.Drawing.Size(802, 467);
            this.Name = "数学工具";
            this.Text = "数学工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.ComponentModel.BackgroundWorker background_decomposition;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.NumericUpDown input_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status_indication;
        private System.ComponentModel.BackgroundWorker check_update;
        private System.Windows.Forms.Button install_update_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button delete_button;
    }
}

