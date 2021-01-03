namespace math_tool
{
    partial class PrimeFactors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.BackgroundDecomposition = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(152, 61);
            this.inputBox.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.inputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(490, 27);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(152, 150);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(224, 122);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "开始计算";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(404, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(238, 122);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(152, 357);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(490, 27);
            this.outputBox.TabIndex = 3;
            // 
            // BackgroundDecomposition
            // 
            this.BackgroundDecomposition.WorkerSupportsCancellation = true;
            this.BackgroundDecomposition.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDecomposition_DoWork);
            this.BackgroundDecomposition.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDecomposition_RunWorkerCompleted);
            // 
            // PrimeFactors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrimeFactors";
            this.Text = "PrimeFactors";
            this.Load += new System.EventHandler(this.PrimeFactors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inputBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.ComponentModel.BackgroundWorker BackgroundDecomposition;
    }
}