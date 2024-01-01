namespace Market_Program
{
    partial class UserCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreation));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(34, 62);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 28);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(34, 96);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 28);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(34, 130);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 28);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(34, 164);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 28);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "LastName";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(34, 232);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 28);
            this.Email.TabIndex = 5;
            this.Email.Text = "E-mail";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(34, 198);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 28);
            this.Address.TabIndex = 4;
            this.Address.Text = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserCreation";
            this.Text = "UserCreation";
            this.Load += new System.EventHandler(this.UserCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}