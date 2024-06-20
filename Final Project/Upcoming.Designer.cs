namespace Final_Project
{
    partial class Upcoming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upcomingLabel = new System.Windows.Forms.Label();
            this.flight1Time = new System.Windows.Forms.Label();
            this.flight1Destination = new System.Windows.Forms.Label();
            this.flight1fnumber = new System.Windows.Forms.Label();
            this.flight1Gate = new System.Windows.Forms.Label();
            this.flight1Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upcomingLabel
            // 
            this.upcomingLabel.BackColor = System.Drawing.Color.Yellow;
            this.upcomingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingLabel.Location = new System.Drawing.Point(97, 9);
            this.upcomingLabel.Name = "upcomingLabel";
            this.upcomingLabel.Size = new System.Drawing.Size(317, 50);
            this.upcomingLabel.TabIndex = 0;
            this.upcomingLabel.Text = "UPCOMING";
            this.upcomingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flight1Time
            // 
            this.flight1Time.BackColor = System.Drawing.Color.Transparent;
            this.flight1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Time.ForeColor = System.Drawing.Color.White;
            this.flight1Time.Location = new System.Drawing.Point(3, 86);
            this.flight1Time.Name = "flight1Time";
            this.flight1Time.Size = new System.Drawing.Size(82, 336);
            this.flight1Time.TabIndex = 6;
            // 
            // flight1Destination
            // 
            this.flight1Destination.BackColor = System.Drawing.Color.Transparent;
            this.flight1Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Destination.ForeColor = System.Drawing.Color.White;
            this.flight1Destination.Location = new System.Drawing.Point(91, 86);
            this.flight1Destination.Name = "flight1Destination";
            this.flight1Destination.Size = new System.Drawing.Size(295, 336);
            this.flight1Destination.TabIndex = 7;
            // 
            // flight1fnumber
            // 
            this.flight1fnumber.BackColor = System.Drawing.Color.Transparent;
            this.flight1fnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1fnumber.ForeColor = System.Drawing.Color.White;
            this.flight1fnumber.Location = new System.Drawing.Point(392, 86);
            this.flight1fnumber.Name = "flight1fnumber";
            this.flight1fnumber.Size = new System.Drawing.Size(131, 336);
            this.flight1fnumber.TabIndex = 8;
            // 
            // flight1Gate
            // 
            this.flight1Gate.BackColor = System.Drawing.Color.Transparent;
            this.flight1Gate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Gate.ForeColor = System.Drawing.Color.White;
            this.flight1Gate.Location = new System.Drawing.Point(529, 86);
            this.flight1Gate.Name = "flight1Gate";
            this.flight1Gate.Size = new System.Drawing.Size(57, 336);
            this.flight1Gate.TabIndex = 9;
            // 
            // flight1Status
            // 
            this.flight1Status.BackColor = System.Drawing.Color.Transparent;
            this.flight1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Status.ForeColor = System.Drawing.Color.White;
            this.flight1Status.Location = new System.Drawing.Point(592, 86);
            this.flight1Status.Name = "flight1Status";
            this.flight1Status.Size = new System.Drawing.Size(205, 336);
            this.flight1Status.TabIndex = 10;
            // 
            // Upcoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Final_Project.Properties.Resources.displayBoard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.flight1Status);
            this.Controls.Add(this.flight1Gate);
            this.Controls.Add(this.flight1fnumber);
            this.Controls.Add(this.flight1Destination);
            this.Controls.Add(this.flight1Time);
            this.Controls.Add(this.upcomingLabel);
            this.Name = "Upcoming";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label upcomingLabel;
        private System.Windows.Forms.Label flight1Time;
        private System.Windows.Forms.Label flight1Destination;
        private System.Windows.Forms.Label flight1fnumber;
        private System.Windows.Forms.Label flight1Gate;
        private System.Windows.Forms.Label flight1Status;
    }
}
