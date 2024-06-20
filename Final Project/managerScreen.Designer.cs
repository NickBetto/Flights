namespace Final_Project
{
    partial class managerScreen
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
            this.codeInput = new System.Windows.Forms.TextBox();
            this.managerLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(-2, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 174);
            this.label1.TabIndex = 1;
            // 
            // codeInput
            // 
            this.codeInput.Location = new System.Drawing.Point(242, 356);
            this.codeInput.Name = "codeInput";
            this.codeInput.Size = new System.Drawing.Size(320, 20);
            this.codeInput.TabIndex = 2;
            // 
            // managerLabel
            // 
            this.managerLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.managerLabel.Location = new System.Drawing.Point(283, 318);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(238, 22);
            this.managerLabel.TabIndex = 4;
            this.managerLabel.Text = "Manager Code";
            this.managerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Aquamarine;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Location = new System.Drawing.Point(308, 401);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(184, 34);
            this.doneButton.TabIndex = 10;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // managerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.torontoairport;
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.codeInput);
            this.Controls.Add(this.label1);
            this.Name = "managerScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeInput;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Button doneButton;
    }
}
