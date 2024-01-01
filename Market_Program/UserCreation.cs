using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Market_Program
{
    public partial class UserCreation : Form
    {
        private const string ConnectionString = @"Data Source=C:\Users\vbosh\source\repos\Market_Program\Market_Program\Database.db;Version=3;";
        private ToolTip emailToolTip;
        private ToolTip passwordToolTip;
        public UserCreation()
        {
            InitializeComponent();
            passwordToolTip = new ToolTip();
            passwordToolTip.ToolTipTitle = "Password";
            passwordToolTip.SetToolTip(Password, "Enter a password between 8 and 12 characters");
            emailToolTip = new ToolTip();
            emailToolTip.ToolTipTitle = "Email Address";
            emailToolTip.SetToolTip(Email, "Enter email address (e.g., example@gmail.com)");
        }

        private bool IsUsernameInUse(string username)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private bool IsEmailInUse(string email)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        private bool CheckPassword(string password)
        {
            if (password.Length >= 8 && password.Length <= 12)
            {
                return true;
            }
            return false;
        }

        private void InsertUser(string username, string password, string firstName, string lastName, string address, string email)
        {
            if (IsUsernameInUse(username))
            {
                MessageBox.Show("Username is already in use. Please choose a different username.");
                Username.Clear();
                return;
            }

            if (IsEmailInUse(email))
            {
                MessageBox.Show("Email is already in use. Please use a different Email.");
                Email.Clear();
                return;
            }
            if(!CheckPassword(password))
            {
                MessageBox.Show("Incorrect password length. Please followin instructions.");
                Password.Clear();
                return;
            }
            string hashedPassword = PasswordHasher.HashPassword(password); ;
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (Username, Password, FirstName, LastName, Address, Email) " +
                                "VALUES (@Username, @Password, @FirstName, @LastName, @Address, @Email)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User created successfully!");
            this.Close();
        }

        private void UserCreation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Username.Text;
                string password = Password.Text;
                string firstName = FirstName.Text;
                string lastName = LastName.Text;
                string address = Address.Text;
                string email = Email.Text;

                InsertUser(username, password, firstName, lastName, address, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}");
            }
        }
    }
}
