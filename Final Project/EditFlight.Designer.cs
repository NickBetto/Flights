namespace Final_Project
{
    partial class EditFlight
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
            this.label1 = new System.Windows.Forms.Label();
            this.flightNumberInput = new System.Windows.Forms.TextBox();
            this.timeChangeInput = new System.Windows.Forms.TextBox();
            this.destinationChangeInput = new System.Windows.Forms.TextBox();
            this.fnumberInput = new System.Windows.Forms.TextBox();
            this.gateChangeInput = new System.Windows.Forms.TextBox();
            this.statusChangeInput = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(393, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 450);
            this.label1.TabIndex = 2;
            // 
            // flightNumberInput
            // 
            this.flightNumberInput.Location = new System.Drawing.Point(45, 287);
            this.flightNumberInput.Name = "flightNumberInput";
            this.flightNumberInput.Size = new System.Drawing.Size(288, 20);
            this.flightNumberInput.TabIndex = 3;
            // 
            // timeChangeInput
            // 
            this.timeChangeInput.Enabled = false;
            this.timeChangeInput.Location = new System.Drawing.Point(481, 45);
            this.timeChangeInput.Name = "timeChangeInput";
            this.timeChangeInput.Size = new System.Drawing.Size(245, 20);
            this.timeChangeInput.TabIndex = 4;
            // 
            // destinationChangeInput
            // 
            this.destinationChangeInput.Enabled = false;
            this.destinationChangeInput.Location = new System.Drawing.Point(481, 111);
            this.destinationChangeInput.Name = "destinationChangeInput";
            this.destinationChangeInput.Size = new System.Drawing.Size(245, 20);
            this.destinationChangeInput.TabIndex = 5;
            // 
            // fnumberInput
            // 
            this.fnumberInput.Enabled = false;
            this.fnumberInput.Location = new System.Drawing.Point(481, 178);
            this.fnumberInput.Name = "fnumberInput";
            this.fnumberInput.Size = new System.Drawing.Size(245, 20);
            this.fnumberInput.TabIndex = 6;
            // 
            // gateChangeInput
            // 
            this.gateChangeInput.Enabled = false;
            this.gateChangeInput.Location = new System.Drawing.Point(481, 247);
            this.gateChangeInput.Name = "gateChangeInput";
            this.gateChangeInput.Size = new System.Drawing.Size(245, 20);
            this.gateChangeInput.TabIndex = 7;
            // 
            // statusChangeInput
            // 
            this.statusChangeInput.Enabled = false;
            this.statusChangeInput.Location = new System.Drawing.Point(481, 308);
            this.statusChangeInput.Name = "statusChangeInput";
            this.statusChangeInput.Size = new System.Drawing.Size(245, 20);
            this.statusChangeInput.TabIndex = 8;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(481, 366);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(245, 60);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(45, 354);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(288, 25);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.Control;
            this.homeButton.Location = new System.Drawing.Point(13, 399);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(76, 39);
            this.homeButton.TabIndex = 17;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.torontoairport;
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.statusChangeInput);
            this.Controls.Add(this.gateChangeInput);
            this.Controls.Add(this.fnumberInput);
            this.Controls.Add(this.destinationChangeInput);
            this.Controls.Add(this.timeChangeInput);
            this.Controls.Add(this.flightNumberInput);
            this.Controls.Add(this.label1);
            this.Name = "EditFlight";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flightNumberInput;
        private System.Windows.Forms.TextBox timeChangeInput;
        private System.Windows.Forms.TextBox destinationChangeInput;
        private System.Windows.Forms.TextBox fnumberInput;
        private System.Windows.Forms.TextBox gateChangeInput;
        private System.Windows.Forms.TextBox statusChangeInput;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button homeButton;
    }
}
