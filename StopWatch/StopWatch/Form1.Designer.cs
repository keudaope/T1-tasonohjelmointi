
namespace StopWatch
{
    partial class StopwatchForm
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
            this.components = new System.ComponentModel.Container();
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLB.Location = new System.Drawing.Point(12, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(585, 128);
            this.TimeLB.TabIndex = 0;
            this.TimeLB.Text = "00:00:00.000";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(42, 158);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(93, 49);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(466, 158);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(93, 49);
            this.ResetBT.TabIndex = 2;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(254, 158);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(93, 49);
            this.StopBT.TabIndex = 3;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ajastinTM
            // 
            this.ajastinTM.Enabled = true;
            this.ajastinTM.Tick += new System.EventHandler(this.ajastinTM_Tick);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 225);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StopwatchForm";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.StopwatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button ResetBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}

