namespace math_tool
{
    partial class Math
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Math));
            this.primeFactorsButton = new System.Windows.Forms.Button();
            this.githubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primeFactorsButton
            // 
            this.primeFactorsButton.Location = new System.Drawing.Point(112, 53);
            this.primeFactorsButton.Name = "primeFactorsButton";
            this.primeFactorsButton.Size = new System.Drawing.Size(173, 81);
            this.primeFactorsButton.TabIndex = 0;
            this.primeFactorsButton.Text = "分解质因数";
            this.primeFactorsButton.UseVisualStyleBackColor = true;
            this.primeFactorsButton.Click += new System.EventHandler(this.PrimeFactorsButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.Location = new System.Drawing.Point(520, 53);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(181, 81);
            this.githubButton.TabIndex = 1;
            this.githubButton.Text = "项目主页";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.primeFactorsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Math";
            this.Text = "Math";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button primeFactorsButton;
        private System.Windows.Forms.Button githubButton;
    }
}

