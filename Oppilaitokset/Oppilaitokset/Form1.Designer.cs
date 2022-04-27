
namespace Oppilaitokset
{
    partial class AvainhenkilotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.oppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.katuosoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.sijaintiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // oppilaitoksetCB
            // 
            this.oppilaitoksetCB.FormattingEnabled = true;
            this.oppilaitoksetCB.Location = new System.Drawing.Point(13, 116);
            this.oppilaitoksetCB.Name = "oppilaitoksetCB";
            this.oppilaitoksetCB.Size = new System.Drawing.Size(159, 33);
            this.oppilaitoksetCB.TabIndex = 1;
            this.oppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitoksetCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // katuosoiteLB
            // 
            this.katuosoiteLB.AutoSize = true;
            this.katuosoiteLB.Location = new System.Drawing.Point(13, 162);
            this.katuosoiteLB.Name = "katuosoiteLB";
            this.katuosoiteLB.Size = new System.Drawing.Size(101, 25);
            this.katuosoiteLB.TabIndex = 3;
            this.katuosoiteLB.Text = "Katuosoite";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(13, 200);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(118, 25);
            this.PostinumeroLB.TabIndex = 4;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(13, 238);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(149, 25);
            this.PostitoimipaikkaLB.TabIndex = 5;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(13, 276);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(96, 25);
            this.PuhelinLB.TabIndex = 6;
            this.PuhelinLB.Text = "PuhelinLB";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Location = new System.Drawing.Point(248, 276);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(76, 25);
            this.phoneLB.TabIndex = 11;
            this.phoneLB.Text = "Puhelin";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(248, 238);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(104, 25);
            this.emailLB.TabIndex = 10;
            this.emailLB.Text = "Sähköposti";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(248, 162);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(59, 25);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "Titteli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valitse vastuuhenkilö:";
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(248, 116);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(208, 33);
            this.vastuuhloCB.TabIndex = 7;
            this.vastuuhloCB.TextChanged += new System.EventHandler(this.vastuuhloCB_TextChanged);
            // 
            // sijaintiLB
            // 
            this.sijaintiLB.AutoSize = true;
            this.sijaintiLB.Location = new System.Drawing.Point(248, 200);
            this.sijaintiLB.Name = "sijaintiLB";
            this.sijaintiLB.Size = new System.Drawing.Size(69, 25);
            this.sijaintiLB.TabIndex = 12;
            this.sijaintiLB.Text = "Sijainti";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 320);
            this.Controls.Add(this.sijaintiLB);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.katuosoiteLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oppilaitoksetCB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox oppilaitoksetCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label katuosoiteLB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label phoneLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label titteliLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox vastuuhloCB;
        private System.Windows.Forms.Label sijaintiLB;
    }
}

