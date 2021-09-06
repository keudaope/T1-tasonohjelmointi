<<<<<<< HEAD
﻿
namespace Paivakirja
{
    partial class DiaryForm
    {
        /// <summary>
        ///  Required designer variable.
=======
﻿namespace Paivakirja
{
    partial class PaivakirjaForm
    {
        /// <summary>
        /// Required designer variable.
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
<<<<<<< HEAD
        ///  Clean up any resources being used.
=======
        /// Clean up any resources being used.
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
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
<<<<<<< HEAD
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
=======
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
        /// </summary>
        private void InitializeComponent()
        {
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
<<<<<<< HEAD
            this.SyottoTB.Location = new System.Drawing.Point(11, 10);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(745, 355);
=======
            this.SyottoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyottoTB.Location = new System.Drawing.Point(13, 7);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(768, 300);
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
            this.SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
<<<<<<< HEAD
            this.TallennaBT.Location = new System.Drawing.Point(13, 377);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(732, 67);
=======
            this.TallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennaBT.Location = new System.Drawing.Point(15, 321);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(765, 96);
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
<<<<<<< HEAD
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DiaryForm";
=======
            // PaivakirjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Name = "PaivakirjaForm";
>>>>>>> 075c3158648bf91aee786882c2f9c89cf646b65c
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SyottoTB;
        private System.Windows.Forms.Button TallennaBT;
    }
}

