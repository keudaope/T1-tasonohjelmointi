
namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            this.SalasanaOikeinPn = new System.Windows.Forms.Panel();
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaOikeinPn.SuspendLayout();
            this.SalasanaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaOikeinPn
            // 
            this.SalasanaOikeinPn.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPn.Controls.Add(this.SalasanaPanel);
            this.SalasanaOikeinPn.Controls.Add(this.label1);
            this.SalasanaOikeinPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPn.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPn.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPn.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPn.Name = "SalasanaOikeinPn";
            this.SalasanaOikeinPn.Size = new System.Drawing.Size(639, 195);
            this.SalasanaOikeinPn.TabIndex = 0;
            this.SalasanaOikeinPn.Visible = false;
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.VirheviestiLB);
            this.SalasanaPanel.Controls.Add(this.button1);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label3);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(639, 195);
            this.SalasanaPanel.TabIndex = 10;
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Location = new System.Drawing.Point(12, 146);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(86, 40);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "Virhe";
            this.VirheviestiLB.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tarkista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(304, 92);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(322, 46);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(304, 36);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(322, 46);
            this.KayttajaTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salasana: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Käyttäjätunnus: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 195);
            this.Controls.Add(this.SalasanaOikeinPn);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.Load += new System.EventHandler(this.SalasanaForm_Load);
            this.SalasanaOikeinPn.ResumeLayout(false);
            this.SalasanaOikeinPn.PerformLayout();
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaOikeinPn;
        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.Label VirheviestiLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

