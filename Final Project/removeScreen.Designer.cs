namespace Final_Project
{
    partial class removeScreen
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
            this.components = new System.ComponentModel.Container();
            this.flight1Status = new System.Windows.Forms.Label();
            this.flight1Gate = new System.Windows.Forms.Label();
            this.flight1fnumber = new System.Windows.Forms.Label();
            this.flight1Destination = new System.Windows.Forms.Label();
            this.flight1Time = new System.Windows.Forms.Label();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.flightNumberInput = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flight1Status
            // 
            this.flight1Status.BackColor = System.Drawing.Color.Transparent;
            this.flight1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Status.ForeColor = System.Drawing.Color.White;
            this.flight1Status.Location = new System.Drawing.Point(591, 91);
            this.flight1Status.Name = "flight1Status";
            this.flight1Status.Size = new System.Drawing.Size(205, 336);
            this.flight1Status.TabIndex = 9;
            // 
            // flight1Gate
            // 
            this.flight1Gate.BackColor = System.Drawing.Color.Transparent;
            this.flight1Gate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Gate.ForeColor = System.Drawing.Color.White;
            this.flight1Gate.Location = new System.Drawing.Point(528, 91);
            this.flight1Gate.Name = "flight1Gate";
            this.flight1Gate.Size = new System.Drawing.Size(57, 336);
            this.flight1Gate.TabIndex = 8;
            // 
            // flight1fnumber
            // 
            this.flight1fnumber.BackColor = System.Drawing.Color.Transparent;
            this.flight1fnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1fnumber.ForeColor = System.Drawing.Color.White;
            this.flight1fnumber.Location = new System.Drawing.Point(391, 91);
            this.flight1fnumber.Name = "flight1fnumber";
            this.flight1fnumber.Size = new System.Drawing.Size(131, 336);
            this.flight1fnumber.TabIndex = 7;
            // 
            // flight1Destination
            // 
            this.flight1Destination.BackColor = System.Drawing.Color.Transparent;
            this.flight1Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Destination.ForeColor = System.Drawing.Color.White;
            this.flight1Destination.Location = new System.Drawing.Point(90, 91);
            this.flight1Destination.Name = "flight1Destination";
            this.flight1Destination.Size = new System.Drawing.Size(295, 336);
            this.flight1Destination.TabIndex = 6;
            // 
            // flight1Time
            // 
            this.flight1Time.BackColor = System.Drawing.Color.Transparent;
            this.flight1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight1Time.ForeColor = System.Drawing.Color.White;
            this.flight1Time.Location = new System.Drawing.Point(2, 91);
            this.flight1Time.Name = "flight1Time";
            this.flight1Time.Size = new System.Drawing.Size(82, 336);
            this.flight1Time.TabIndex = 5;
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 20;
            // 
            // flightNumberInput
            // 
            this.flightNumberInput.Location = new System.Drawing.Point(317, 427);
            this.flightNumberInput.Name = "flightNumberInput";
            this.flightNumberInput.Size = new System.Drawing.Size(351, 20);
            this.flightNumberInput.TabIndex = 10;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(713, 422);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(83, 28);
            this.doneButton.TabIndex = 11;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.flightNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightNumberLabel.ForeColor = System.Drawing.Color.White;
            this.flightNumberLabel.Location = new System.Drawing.Point(4, 427);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(307, 23);
            this.flightNumberLabel.TabIndex = 12;
            this.flightNumberLabel.Text = "Input Flight Number Of Flight To Be Removed";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.Control;
            this.homeButton.Location = new System.Drawing.Point(713, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(76, 39);
            this.homeButton.TabIndex = 13;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(570, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(98, 38);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "8:00";
            // 
            // removeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.displayBoard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.flightNumberLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.flightNumberInput);
            this.Controls.Add(this.flight1Status);
            this.Controls.Add(this.flight1Gate);
            this.Controls.Add(this.flight1fnumber);
            this.Controls.Add(this.flight1Destination);
            this.Controls.Add(this.flight1Time);
            this.Name = "removeScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flight1Status;
        private System.Windows.Forms.Label flight1Gate;
        private System.Windows.Forms.Label flight1fnumber;
        private System.Windows.Forms.Label flight1Destination;
        private System.Windows.Forms.Label flight1Time;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.TextBox flightNumberInput;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label flightNumberLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label timeLabel;
    }
}
