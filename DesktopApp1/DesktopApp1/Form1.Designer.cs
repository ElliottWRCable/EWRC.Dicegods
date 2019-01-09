namespace DesktopApp1
{
    partial class Form1
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
            this.D20button = new System.Windows.Forms.Button();
            this.Resultsbox = new System.Windows.Forms.TextBox();
            this.D100button = new System.Windows.Forms.Button();
            this.D12button = new System.Windows.Forms.Button();
            this.D10button = new System.Windows.Forms.Button();
            this.D8button = new System.Windows.Forms.Button();
            this.D6button = new System.Windows.Forms.Button();
            this.D4button = new System.Windows.Forms.Button();
            this.D3button = new System.Windows.Forms.Button();
            this.D66button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // D20button
            // 
            this.D20button.Location = new System.Drawing.Point(12, 41);
            this.D20button.Name = "D20button";
            this.D20button.Size = new System.Drawing.Size(75, 23);
            this.D20button.TabIndex = 0;
            this.D20button.Text = "1D20";
            this.D20button.UseVisualStyleBackColor = true;
            this.D20button.Click += new System.EventHandler(this.D20button_Click);
            // 
            // Resultsbox
            // 
            this.Resultsbox.Location = new System.Drawing.Point(12, 276);
            this.Resultsbox.Multiline = true;
            this.Resultsbox.Name = "Resultsbox";
            this.Resultsbox.Size = new System.Drawing.Size(260, 78);
            this.Resultsbox.TabIndex = 1;
            // 
            // D100button
            // 
            this.D100button.Location = new System.Drawing.Point(12, 12);
            this.D100button.Name = "D100button";
            this.D100button.Size = new System.Drawing.Size(75, 23);
            this.D100button.TabIndex = 2;
            this.D100button.Text = "1D100";
            this.D100button.UseVisualStyleBackColor = true;
            this.D100button.Click += new System.EventHandler(this.D100button_Click);
            // 
            // D12button
            // 
            this.D12button.Location = new System.Drawing.Point(12, 70);
            this.D12button.Name = "D12button";
            this.D12button.Size = new System.Drawing.Size(75, 23);
            this.D12button.TabIndex = 3;
            this.D12button.Text = "1D12";
            this.D12button.UseVisualStyleBackColor = true;
            this.D12button.Click += new System.EventHandler(this.D12button_Click);
            // 
            // D10button
            // 
            this.D10button.Location = new System.Drawing.Point(12, 99);
            this.D10button.Name = "D10button";
            this.D10button.Size = new System.Drawing.Size(75, 23);
            this.D10button.TabIndex = 4;
            this.D10button.Text = "1D10";
            this.D10button.UseVisualStyleBackColor = true;
            this.D10button.Click += new System.EventHandler(this.D10button_Click);
            // 
            // D8button
            // 
            this.D8button.Location = new System.Drawing.Point(12, 128);
            this.D8button.Name = "D8button";
            this.D8button.Size = new System.Drawing.Size(75, 23);
            this.D8button.TabIndex = 5;
            this.D8button.Text = "1D8";
            this.D8button.UseVisualStyleBackColor = true;
            this.D8button.Click += new System.EventHandler(this.D8button_Click);
            // 
            // D6button
            // 
            this.D6button.Location = new System.Drawing.Point(12, 157);
            this.D6button.Name = "D6button";
            this.D6button.Size = new System.Drawing.Size(75, 23);
            this.D6button.TabIndex = 6;
            this.D6button.Text = "1D6";
            this.D6button.UseVisualStyleBackColor = true;
            this.D6button.Click += new System.EventHandler(this.D6button_Click);
            // 
            // D4button
            // 
            this.D4button.Location = new System.Drawing.Point(12, 186);
            this.D4button.Name = "D4button";
            this.D4button.Size = new System.Drawing.Size(75, 23);
            this.D4button.TabIndex = 7;
            this.D4button.Text = "1D4";
            this.D4button.UseVisualStyleBackColor = true;
            this.D4button.Click += new System.EventHandler(this.D4button_Click);
            // 
            // D3button
            // 
            this.D3button.Location = new System.Drawing.Point(12, 215);
            this.D3button.Name = "D3button";
            this.D3button.Size = new System.Drawing.Size(75, 23);
            this.D3button.TabIndex = 8;
            this.D3button.Text = "1D3";
            this.D3button.UseVisualStyleBackColor = true;
            this.D3button.Click += new System.EventHandler(this.D3button_Click);
            // 
            // D66button
            // 
            this.D66button.Location = new System.Drawing.Point(12, 244);
            this.D66button.Name = "D66button";
            this.D66button.Size = new System.Drawing.Size(75, 23);
            this.D66button.TabIndex = 9;
            this.D66button.Text = "D66";
            this.D66button.UseVisualStyleBackColor = true;
            this.D66button.Click += new System.EventHandler(this.D66button_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.D66button);
            this.Controls.Add(this.D3button);
            this.Controls.Add(this.D4button);
            this.Controls.Add(this.D6button);
            this.Controls.Add(this.D8button);
            this.Controls.Add(this.D10button);
            this.Controls.Add(this.D12button);
            this.Controls.Add(this.D100button);
            this.Controls.Add(this.Resultsbox);
            this.Controls.Add(this.D20button);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button D20button;
        private System.Windows.Forms.TextBox Resultsbox;
        private System.Windows.Forms.Button D100button;
        private System.Windows.Forms.Button D12button;
        private System.Windows.Forms.Button D10button;
        private System.Windows.Forms.Button D8button;
        private System.Windows.Forms.Button D6button;
        private System.Windows.Forms.Button D4button;
        private System.Windows.Forms.Button D3button;
        private System.Windows.Forms.Button D66button;
    }
}

