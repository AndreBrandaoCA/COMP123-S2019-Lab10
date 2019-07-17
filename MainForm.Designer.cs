namespace COMP123_S2019_Lab10
{
    partial class MainForm
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
            this.WelcomeMainFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeMainFormLabel
            // 
            this.WelcomeMainFormLabel.AutoSize = true;
            this.WelcomeMainFormLabel.Location = new System.Drawing.Point(229, 186);
            this.WelcomeMainFormLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WelcomeMainFormLabel.Name = "WelcomeMainFormLabel";
            this.WelcomeMainFormLabel.Size = new System.Drawing.Size(299, 31);
            this.WelcomeMainFormLabel.TabIndex = 0;
            this.WelcomeMainFormLabel.Text = "Welcome to Main Form!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WelcomeMainFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMainFormLabel;
    }
}