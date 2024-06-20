namespace Final_Project
{
    partial class mainScreen
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.managerButton = new System.Windows.Forms.Button();
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
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.usernameLabel.Location = new System.Drawing.Point(285, 289);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(238, 22);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(242, 314);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(320, 20);
            this.usernameInput.TabIndex = 5;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(242, 379);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(320, 20);
            this.passwordInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(285, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.Aquamarine;
            this.managerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerButton.Location = new System.Drawing.Point(714, 376);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(83, 71);
            this.managerButton.TabIndex = 8;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Aquamarine;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Location = new System.Drawing.Point(313, 413);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(184, 34);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.torontoairport;
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "mainScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button doneButton;
    }
}
