﻿namespace Celcius2Fahrenheit
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
            this.AsteetLB = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.MuuntoGB = new System.Windows.Forms.GroupBox();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuuntoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AsteetLB
            // 
            this.AsteetLB.AutoSize = true;
            this.AsteetLB.Location = new System.Drawing.Point(15, 54);
            this.AsteetLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AsteetLB.Name = "AsteetLB";
            this.AsteetLB.Size = new System.Drawing.Size(119, 24);
            this.AsteetLB.TabIndex = 0;
            this.AsteetLB.Text = "Anna asteet: ";
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(143, 51);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(51, 29);
            this.AsteetTB.TabIndex = 1;
            // 
            // MuuntoGB
            // 
            this.MuuntoGB.Controls.Add(this.FahrenheitRB);
            this.MuuntoGB.Controls.Add(this.CelsiusRB);
            this.MuuntoGB.Location = new System.Drawing.Point(200, 12);
            this.MuuntoGB.Name = "MuuntoGB";
            this.MuuntoGB.Size = new System.Drawing.Size(159, 100);
            this.MuuntoGB.TabIndex = 2;
            this.MuuntoGB.TabStop = false;
            this.MuuntoGB.Text = "Miten muunnat?";
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(7, 29);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(89, 28);
            this.CelsiusRB.TabIndex = 0;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(6, 63);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(119, 28);
            this.FahrenheitRB.TabIndex = 1;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(377, 47);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(91, 38);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(15, 128);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 24);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 161);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.MuuntoGB);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.AsteetLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MuuntoGB.ResumeLayout(false);
            this.MuuntoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AsteetLB;
        private System.Windows.Forms.TextBox AsteetTB;
        private System.Windows.Forms.GroupBox MuuntoGB;
        private System.Windows.Forms.RadioButton FahrenheitRB;
        private System.Windows.Forms.RadioButton CelsiusRB;
        private System.Windows.Forms.Button MuunnaBT;
        private System.Windows.Forms.Label VastausLB;
    }
}

