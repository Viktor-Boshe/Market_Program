namespace Market_Program
{
    partial class ProductManagerForm
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
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.StockQuantity = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.AddCategory_Button = new System.Windows.Forms.Button();
            this.NewCategoryButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(53, 50);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(118, 28);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Product Name";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(53, 94);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(251, 96);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(53, 207);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(118, 28);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            // 
            // StockQuantity
            // 
            this.StockQuantity.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuantity.Location = new System.Drawing.Point(53, 241);
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.Size = new System.Drawing.Size(118, 28);
            this.StockQuantity.TabIndex = 3;
            this.StockQuantity.Text = "Stock Quantity";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(423, 50);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(199, 31);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.Text = "Choose Category";
            // 
            // CategoryName
            // 
            this.CategoryName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.Location = new System.Drawing.Point(423, 207);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(128, 28);
            this.CategoryName.TabIndex = 5;
            this.CategoryName.Text = "Category Name";
            this.CategoryName.Visible = false;
            // 
            // AddCategory_Button
            // 
            this.AddCategory_Button.Location = new System.Drawing.Point(423, 241);
            this.AddCategory_Button.Name = "AddCategory_Button";
            this.AddCategory_Button.Size = new System.Drawing.Size(105, 23);
            this.AddCategory_Button.TabIndex = 6;
            this.AddCategory_Button.Text = "Add Category";
            this.AddCategory_Button.UseVisualStyleBackColor = true;
            this.AddCategory_Button.Visible = false;
            this.AddCategory_Button.Click += new System.EventHandler(this.AddCategory_Button_Click);
            // 
            // NewCategoryButton
            // 
            this.NewCategoryButton.Location = new System.Drawing.Point(423, 166);
            this.NewCategoryButton.Name = "NewCategoryButton";
            this.NewCategoryButton.Size = new System.Drawing.Size(105, 23);
            this.NewCategoryButton.TabIndex = 7;
            this.NewCategoryButton.Text = "New Category";
            this.NewCategoryButton.UseVisualStyleBackColor = true;
            this.NewCategoryButton.Click += new System.EventHandler(this.NewCategoryButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(53, 353);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(85, 23);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click_1);
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.NewCategoryButton);
            this.Controls.Add(this.AddCategory_Button);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.StockQuantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ProductName);
            this.Name = "ProductManagerForm";
            this.Text = "ProductManagerForm";
            this.Load += new System.EventHandler(this.ProductManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox StockQuantity;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.Button AddCategory_Button;
        private System.Windows.Forms.Button NewCategoryButton;
        private System.Windows.Forms.Button AddProductButton;
    }
}