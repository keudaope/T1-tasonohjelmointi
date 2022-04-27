namespace LLPP
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
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.ONroTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(15, 197);
            this.TietotauluDG.Margin = new System.Windows.Forms.Padding(6);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1202, 473);
            this.TietotauluDG.TabIndex = 0;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(146, 24);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(220, 29);
            this.IdTB.TabIndex = 1;
            // 
            // EnimiTB
            // 
            this.EnimiTB.Location = new System.Drawing.Point(146, 59);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(220, 29);
            this.EnimiTB.TabIndex = 2;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Location = new System.Drawing.Point(146, 94);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(220, 29);
            this.SnimiTB.TabIndex = 3;
            // 
            // ONroTB
            // 
            this.ONroTB.Location = new System.Drawing.Point(580, 94);
            this.ONroTB.Name = "ONroTB";
            this.ONroTB.Size = new System.Drawing.Size(220, 29);
            this.ONroTB.TabIndex = 6;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(580, 59);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(220, 29);
            this.EmailTB.TabIndex = 5;
            // 
            // PuhTB
            // 
            this.PuhTB.Location = new System.Drawing.Point(580, 24);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(220, 29);
            this.PuhTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "SUKUNIMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "OPISKELIJANRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "PUHELIN:";
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(20, 137);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(173, 51);
            this.TyhjennaBT.TabIndex = 13;
            this.TyhjennaBT.Text = "TYHJENNÄ";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(222, 137);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(173, 51);
            this.TallennaBT.TabIndex = 14;
            this.TallennaBT.Text = "TALLENNA";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(626, 137);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(173, 51);
            this.PoistaBT.TabIndex = 16;
            this.PoistaBT.Text = "POISTA";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(424, 137);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(173, 51);
            this.PaivitaBT.TabIndex = 15;
            this.PaivitaBT.Text = "PÄIVITÄ";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 676);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ONroTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.TietotauluDG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox ONroTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button PaivitaBT;
    }
}

