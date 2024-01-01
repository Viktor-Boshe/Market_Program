namespace Market_Program
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
            this.LogIn_button = new System.Windows.Forms.Button();
            this.CreateAcoount_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn_button
            // 
            this.LogIn_button.Location = new System.Drawing.Point(40, 37);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(94, 23);
            this.LogIn_button.TabIndex = 0;
            this.LogIn_button.Text = "Log in";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // CreateAcoount_Button
            // 
            this.CreateAcoount_Button.Location = new System.Drawing.Point(40, 66);
            this.CreateAcoount_Button.Name = "CreateAcoount_Button";
            this.CreateAcoount_Button.Size = new System.Drawing.Size(94, 23);
            this.CreateAcoount_Button.TabIndex = 1;
            this.CreateAcoount_Button.Text = "Create Account";
            this.CreateAcoount_Button.UseVisualStyleBackColor = true;
            this.CreateAcoount_Button.Click += new System.EventHandler(this.CreateAcoount_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateAcoount_Button);
            this.Controls.Add(this.LogIn_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Button CreateAcoount_Button;
    }
}

