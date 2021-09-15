
namespace CRUDNET
{
    partial class YllapitoForm
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
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.oNroTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.puhTB = new System.Windows.Forms.TextBox();
            this.idLB = new System.Windows.Forms.Label();
            this.enimiLB = new System.Windows.Forms.Label();
            this.snimiLB = new System.Windows.Forms.Label();
            this.oNroLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.Tietotaulu = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tietotaulu)).BeginInit();
            this.SuspendLayout();
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Location = new System.Drawing.Point(144, 26);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(245, 29);
            this.idTB.TabIndex = 0;
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(144, 61);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(245, 29);
            this.enimiTB.TabIndex = 1;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(144, 96);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(245, 29);
            this.snimiTB.TabIndex = 2;
            // 
            // oNroTB
            // 
            this.oNroTB.Location = new System.Drawing.Point(655, 96);
            this.oNroTB.Name = "oNroTB";
            this.oNroTB.Size = new System.Drawing.Size(245, 29);
            this.oNroTB.TabIndex = 5;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(655, 61);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(245, 29);
            this.emailTB.TabIndex = 4;
            // 
            // puhTB
            // 
            this.puhTB.Location = new System.Drawing.Point(655, 26);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(245, 29);
            this.puhTB.TabIndex = 3;
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.BackColor = System.Drawing.Color.Transparent;
            this.idLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.Location = new System.Drawing.Point(12, 28);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(40, 27);
            this.idLB.TabIndex = 6;
            this.idLB.Text = "ID:";
            // 
            // enimiLB
            // 
            this.enimiLB.AutoSize = true;
            this.enimiLB.BackColor = System.Drawing.Color.Transparent;
            this.enimiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enimiLB.Location = new System.Drawing.Point(12, 63);
            this.enimiLB.Name = "enimiLB";
            this.enimiLB.Size = new System.Drawing.Size(110, 27);
            this.enimiLB.TabIndex = 7;
            this.enimiLB.Text = "ETUNIMI:";
            // 
            // snimiLB
            // 
            this.snimiLB.AutoSize = true;
            this.snimiLB.BackColor = System.Drawing.Color.Transparent;
            this.snimiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snimiLB.Location = new System.Drawing.Point(12, 98);
            this.snimiLB.Name = "snimiLB";
            this.snimiLB.Size = new System.Drawing.Size(128, 27);
            this.snimiLB.TabIndex = 8;
            this.snimiLB.Text = "SUKUNIMI:";
            // 
            // oNroLB
            // 
            this.oNroLB.AutoSize = true;
            this.oNroLB.BackColor = System.Drawing.Color.Transparent;
            this.oNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oNroLB.Location = new System.Drawing.Point(406, 96);
            this.oNroLB.Name = "oNroLB";
            this.oNroLB.Size = new System.Drawing.Size(242, 27);
            this.oNroLB.TabIndex = 11;
            this.oNroLB.Text = "OPISKELIJANUMERO:";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.BackColor = System.Drawing.Color.Transparent;
            this.emailLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLB.Location = new System.Drawing.Point(406, 61);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(159, 27);
            this.emailLB.TabIndex = 10;
            this.emailLB.Text = "SÄHKÖPOSTI:";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.BackColor = System.Drawing.Color.Transparent;
            this.puhLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhLB.Location = new System.Drawing.Point(406, 26);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(114, 27);
            this.puhLB.TabIndex = 9;
            this.puhLB.Text = "PUHELIN:";
            // 
            // Tietotaulu
            // 
            this.Tietotaulu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tietotaulu.Location = new System.Drawing.Point(17, 185);
            this.Tietotaulu.Name = "Tietotaulu";
            this.Tietotaulu.Size = new System.Drawing.Size(1063, 289);
            this.Tietotaulu.TabIndex = 12;
            this.Tietotaulu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tietotaulu_CellClick);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(17, 135);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(202, 39);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(244, 135);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(202, 39);
            this.tallennaBT.TabIndex = 14;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(471, 135);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(202, 39);
            this.paivitaBT.TabIndex = 15;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(698, 135);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(202, 39);
            this.poistaBT.TabIndex = 16;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // YllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(172)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::CRUDNET.Properties.Resources.tausta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 486);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.Tietotaulu);
            this.Controls.Add(this.oNroLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.snimiLB);
            this.Controls.Add(this.enimiLB);
            this.Controls.Add(this.idLB);
            this.Controls.Add(this.oNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YllapitoForm";
            this.Text = "Opiskelijatietokannan ylläpitolomake";
            this.Load += new System.EventHandler(this.YllapitoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tietotaulu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox oNroTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox puhTB;
        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label enimiLB;
        private System.Windows.Forms.Label snimiLB;
        private System.Windows.Forms.Label oNroLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.DataGridView Tietotaulu;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
    }
}

