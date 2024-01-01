using Merchendise_Store_Database;
using System;
using System.Windows.Forms;

namespace Market_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void CreateAcoount_Button_Click(object sender, EventArgs e)
        {
            OpenForm(new UserCreation());
        }
        private void LogIn_button_Click(object sender, EventArgs e)
        {
            OpenForm(new LogIn());
        }
        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += FormClosed;
            form.ShowDialog();
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
