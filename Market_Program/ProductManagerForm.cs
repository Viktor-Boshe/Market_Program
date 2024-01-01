using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Market_Program
{
    public partial class ProductManagerForm : Form
    {
        private const string ConnectionString = @"Data Source=C:\Users\vbosh\source\repos\Market_Program\Market_Program\Database.db;Version=3;";
        private ProductManager productManager;

        public ProductManagerForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
        }

        private void AddCategory_Button_Click(object sender, EventArgs e)
        {
            CategoryName.Visible = false;
            AddCategory_Button.Visible = false;
            string categoryName = CategoryName.Text;
            int categoryId = productManager.AddCategory(categoryName);

            List<string> categories = productManager.GetCategories();
            CategoryComboBox.DataSource = categories;

            CategoryComboBox.SelectedItem = categoryName;
        }

        private void ProductManagerForm_Load(object sender, EventArgs e)
        {
            List<string> categories = productManager.GetCategories();
            CategoryComboBox.DataSource = categories;
        }

        private void NewCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryName.Visible = true;
            AddCategory_Button.Visible = true;
        }

        private void AddProductButton_Click_1(object sender, EventArgs e)
        {
            string productName = ProductName.Text;
            string description = Description.Text;
            decimal price = Convert.ToDecimal(Price.Text);
            int stockQuantity = Convert.ToInt32(StockQuantity.Text);
            string categoryName = CategoryComboBox.SelectedItem.ToString();

            productManager.AddProduct(productName, description, price, stockQuantity, categoryName);
        }

    }

}
