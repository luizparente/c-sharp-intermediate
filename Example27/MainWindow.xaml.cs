using System.Windows;

namespace Example27
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.pwdPassword.Password; // <-- NOOOOOOO!!!!

            // Authentication logic.
            if (username == "john" && password == "123")
            {
                MessageBox.Show("Login successful!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}