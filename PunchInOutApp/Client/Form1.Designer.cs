namespace PunchInOutApp
{
    partial class PunchCard
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
            this.ClockInButton = new System.Windows.Forms.Button();
            this.ClockOutButton = new System.Windows.Forms.Button();
            this.ClockInList = new System.Windows.Forms.ListBox();
            this.ClockOutList = new System.Windows.Forms.ListBox();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lstWorkDuration = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ClockInButton
            // 
            this.ClockInButton.Location = new System.Drawing.Point(31, 51);
            this.ClockInButton.Name = "ClockInButton";
            this.ClockInButton.Size = new System.Drawing.Size(131, 50);
            this.ClockInButton.TabIndex = 0;
            this.ClockInButton.Text = "CLOCK IN";
            this.ClockInButton.UseVisualStyleBackColor = true;
            this.ClockInButton.Click += new System.EventHandler(this.ClockInButton_Click);
            // 
            // ClockOutButton
            // 
            this.ClockOutButton.Location = new System.Drawing.Point(31, 120);
            this.ClockOutButton.Name = "ClockOutButton";
            this.ClockOutButton.Size = new System.Drawing.Size(131, 45);
            this.ClockOutButton.TabIndex = 1;
            this.ClockOutButton.Text = "CLOCK OUT";
            this.ClockOutButton.UseVisualStyleBackColor = true;
            this.ClockOutButton.Click += new System.EventHandler(this.ClockOutButton_Click);
            // 
            // ClockInList
            // 
            this.ClockInList.FormattingEnabled = true;
            this.ClockInList.ItemHeight = 20;
            this.ClockInList.Location = new System.Drawing.Point(31, 256);
            this.ClockInList.Name = "ClockInList";
            this.ClockInList.Size = new System.Drawing.Size(284, 484);
            this.ClockInList.TabIndex = 2;
            // 
            // ClockOutList
            // 
            this.ClockOutList.FormattingEnabled = true;
            this.ClockOutList.ItemHeight = 20;
            this.ClockOutList.Location = new System.Drawing.Point(334, 256);
            this.ClockOutList.Name = "ClockOutList";
            this.ClockOutList.Size = new System.Drawing.Size(290, 484);
            this.ClockOutList.TabIndex = 3;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(642, 201);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(51, 20);
            this.lblTotalHours.TabIndex = 4;
            this.lblTotalHours.Text = "label1";
            // 
            // lstWorkDuration
            // 
            this.lstWorkDuration.FormattingEnabled = true;
            this.lstWorkDuration.ItemHeight = 20;
            this.lstWorkDuration.Location = new System.Drawing.Point(646, 256);
            this.lstWorkDuration.Name = "lstWorkDuration";
            this.lstWorkDuration.Size = new System.Drawing.Size(281, 484);
            this.lstWorkDuration.TabIndex = 5;
            // 
            // PunchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 891);
            this.Controls.Add(this.lstWorkDuration);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.ClockOutList);
            this.Controls.Add(this.ClockInList);
            this.Controls.Add(this.ClockOutButton);
            this.Controls.Add(this.ClockInButton);
            this.Name = "PunchCard";
            this.Text = "Punch Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClockInButton;
        private System.Windows.Forms.Button ClockOutButton;
        private System.Windows.Forms.ListBox ClockInList;
        private System.Windows.Forms.ListBox ClockOutList;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.ListBox lstWorkDuration;
    }
}

