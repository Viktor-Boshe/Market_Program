namespace Merchendise_Store_Database
{
    partial class LogIn
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(66, 47);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 28);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(66, 86);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 28);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // LogIn_button
            // 
            this.LogIn_button.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.Location = new System.Drawing.Point(66, 155);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(83, 32);
            this.LogIn_button.TabIndex = 2;
            this.LogIn_button.Text = "Log in";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LogIn_button;
    }
}