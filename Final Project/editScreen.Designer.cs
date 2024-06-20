namespace Final_Project
{
    partial class editScreen
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
            this.addButton = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.destinationInput = new System.Windows.Forms.TextBox();
            this.fillLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Aquamarine;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(29, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(209, 186);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Aquamarine;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove.Location = new System.Drawing.Point(288, 14);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(209, 186);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Aquamarine;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Location = new System.Drawing.Point(545, 14);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(209, 186);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // destinationInput
            // 
            this.destinationInput.Location = new System.Drawing.Point(245, 334);
            this.destinationInput.Name = "destinationInput";
            this.destinationInput.Size = new System.Drawing.Size(317, 20);
            this.destinationInput.TabIndex = 3;
            // 
            // fillLabel
            // 
            this.fillLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.fillLabel.Location = new System.Drawing.Point(275, 254);
            this.fillLabel.Name = "fillLabel";
            this.fillLabel.Size = new System.Drawing.Size(244, 61);
            this.fillLabel.TabIndex = 4;
            this.fillLabel.Text = "Enter your desired Destination";
            this.fillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.torontoairport;
            this.Controls.Add(this.fillLabel);
            this.Controls.Add(this.destinationInput);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.addButton);
            this.Name = "editScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox destinationInput;
        private System.Windows.Forms.Label fillLabel;
    }
}
