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
            this.Resultsbox = new System.Windows.Forms.TextBox();
            this.NudMultiD6 = new System.Windows.Forms.NumericUpDown();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMultiD6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbtotal = new System.Windows.Forms.TextBox();
            this.Nudmod01 = new System.Windows.Forms.NumericUpDown();
            this.Cbtype = new System.Windows.Forms.ComboBox();
            this.Nudcustom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbdisad = new System.Windows.Forms.CheckBox();
            this.Cbad = new System.Windows.Forms.CheckBox();
            this.Cbtmin = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudMultiD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudmod01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudcustom)).BeginInit();
            this.SuspendLayout();
            // 
            // Resultsbox
            // 
            this.Resultsbox.Location = new System.Drawing.Point(12, 275);
            this.Resultsbox.Multiline = true;
            this.Resultsbox.Name = "Resultsbox";
            this.Resultsbox.Size = new System.Drawing.Size(217, 58);
            this.Resultsbox.TabIndex = 1;
            // 
            // NudMultiD6
            // 
            this.NudMultiD6.Location = new System.Drawing.Point(63, 40);
            this.NudMultiD6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMultiD6.Name = "NudMultiD6";
            this.NudMultiD6.Size = new System.Drawing.Size(70, 20);
            this.NudMultiD6.TabIndex = 10;
            this.NudMultiD6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(229, 275);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(43, 78);
            this.Clearbutton.TabIndex = 11;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Roll A Die";
            // 
            // BtnMultiD6
            // 
            this.BtnMultiD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiD6.Location = new System.Drawing.Point(63, 118);
            this.BtnMultiD6.Name = "BtnMultiD6";
            this.BtnMultiD6.Size = new System.Drawing.Size(156, 39);
            this.BtnMultiD6.TabIndex = 13;
            this.BtnMultiD6.Text = "Roll";
            this.BtnMultiD6.UseVisualStyleBackColor = true;
            this.BtnMultiD6.Click += new System.EventHandler(this.BtnMultiD6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Modifier";
            // 
            // Tbtotal
            // 
            this.Tbtotal.Location = new System.Drawing.Point(12, 332);
            this.Tbtotal.Name = "Tbtotal";
            this.Tbtotal.Size = new System.Drawing.Size(217, 20);
            this.Tbtotal.TabIndex = 19;
            this.Tbtotal.Text = "Total";
            this.Tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Nudmod01
            // 
            this.Nudmod01.Location = new System.Drawing.Point(139, 66);
            this.Nudmod01.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Nudmod01.Name = "Nudmod01";
            this.Nudmod01.Size = new System.Drawing.Size(80, 20);
            this.Nudmod01.TabIndex = 20;
            // 
            // Cbtype
            // 
            this.Cbtype.FormattingEnabled = true;
            this.Cbtype.Items.AddRange(new object[] {
            "D100",
            "D20",
            "D12",
            "D10",
            "D8",
            "D6",
            "D4",
            "D3",
            "D66",
            "Custom"});
            this.Cbtype.Location = new System.Drawing.Point(139, 39);
            this.Cbtype.Name = "Cbtype";
            this.Cbtype.Size = new System.Drawing.Size(80, 21);
            this.Cbtype.TabIndex = 21;
            this.Cbtype.Text = "D6";
            // 
            // Nudcustom
            // 
            this.Nudcustom.Location = new System.Drawing.Point(139, 92);
            this.Nudcustom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nudcustom.Name = "Nudcustom";
            this.Nudcustom.Size = new System.Drawing.Size(80, 20);
            this.Nudcustom.TabIndex = 22;
            this.Nudcustom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Custom die \r\n     sides";
            // 
            // Cbdisad
            // 
            this.Cbdisad.AutoSize = true;
            this.Cbdisad.Location = new System.Drawing.Point(12, 187);
            this.Cbdisad.Name = "Cbdisad";
            this.Cbdisad.Size = new System.Drawing.Size(92, 17);
            this.Cbdisad.TabIndex = 25;
            this.Cbdisad.Text = "Disadvantage";
            this.Cbdisad.UseVisualStyleBackColor = true;
            // 
            // Cbad
            // 
            this.Cbad.AutoSize = true;
            this.Cbad.Location = new System.Drawing.Point(12, 163);
            this.Cbad.Name = "Cbad";
            this.Cbad.Size = new System.Drawing.Size(78, 17);
            this.Cbad.TabIndex = 24;
            this.Cbad.Text = "Advantage";
            this.Cbad.UseVisualStyleBackColor = true;
            // 
            // Cbtmin
            // 
            this.Cbtmin.AutoSize = true;
            this.Cbtmin.Location = new System.Drawing.Point(12, 211);
            this.Cbtmin.Name = "Cbtmin";
            this.Cbtmin.Size = new System.Drawing.Size(82, 17);
            this.Cbtmin.TabIndex = 26;
            this.Cbtmin.Text = "Track Ones";
            this.Cbtmin.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 235);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Cbtmin);
            this.Controls.Add(this.Cbdisad);
            this.Controls.Add(this.Cbad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nudcustom);
            this.Controls.Add(this.Cbtype);
            this.Controls.Add(this.Nudmod01);
            this.Controls.Add(this.Tbtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnMultiD6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.NudMultiD6);
            this.Controls.Add(this.Resultsbox);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudMultiD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudmod01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudcustom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Resultsbox;
        private System.Windows.Forms.NumericUpDown NudMultiD6;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMultiD6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbtotal;
        private System.Windows.Forms.NumericUpDown Nudmod01;
        private System.Windows.Forms.ComboBox Cbtype;
        private System.Windows.Forms.NumericUpDown Nudcustom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Cbdisad;
        private System.Windows.Forms.CheckBox Cbad;
        private System.Windows.Forms.CheckBox Cbtmin;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

