using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Market_Program
{
    public class ProductManager
    {
        private const string ConnectionString = @"Data Source=C:\Users\vbosh\source\repos\Market_Program\Market_Program\Database.db;Version=3;";

        public int AddCategory(string categoryName)
        {
            if (CategoryExists(categoryName))
            {
                MessageBox.Show("Category already exists.");
                return -1;
            }
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Categories (Name) VALUES (@Name);";
                string selectQuery = "SELECT last_insert_rowid();";

                using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Name", categoryName);
                    insertCommand.ExecuteNonQuery();
                }

                using (var selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    object result = selectCommand.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
        private bool CategoryExists(string categoryName)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Categories WHERE Name = @Name";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", categoryName);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public void AddProduct(string productName, string description, decimal price, int stockQuantity, string categoryName)
        {
            int categoryId = GetOrCreateCategory(categoryName);

            if (ProductExists(productName, categoryId))
            {
                MessageBox.Show("Product already exists.");
                return;
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Products (Name, Description, Price, StockQuantity, CategoryID) " +
                               "VALUES (@Name, @Description, @Price, @StockQuantity, @CategoryID)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product added successfully!");
        }

        private bool ProductExists(string productName, int categoryId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Products WHERE Name = @Name AND CategoryID = @CategoryID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@CategoryID", categoryId);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        private int GetOrCreateCategory(string categoryName)
        {
            int categoryId = GetCategoryId(categoryName);

            if (categoryId == -1)
            {
                categoryId = AddCategory(categoryName);
            }

            return categoryId;
        }

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Categories";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return categories;
        }

        public int GetCategoryId(string categoryName)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT CategoryID FROM Categories WHERE Name = @Name";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", categoryName);

                    object result = command.ExecuteScalar();

                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}
