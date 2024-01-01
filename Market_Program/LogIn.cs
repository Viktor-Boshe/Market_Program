using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Market_Program;

namespace Merchendise_Store_Database
{
    public partial class LogIn : Form
    {
        private const string ConnectionString = @"Data Source=C:\Users\vbosh\source\repos\Market_Program\Market_Program\Database.db;Version=3;";

        public LogIn()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Password FROM Users WHERE Username = @Username";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string hashedPassword = result.ToString();

                        if (PasswordHasher.VerifyPassword(password, hashedPassword))
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Username.Text;
                string password = Password.Text;

                if (ValidateUser(username, password))
                {
                    ProductManagerForm productManagerForm = new ProductManagerForm();
                    this.Hide();

                    productManagerForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}");
            }
        }
    }
}