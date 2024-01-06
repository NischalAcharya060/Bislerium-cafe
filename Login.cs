namespace BrewHub
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Simulate admin and staff roles with hardcoded usernames and passwords
            string adminUsername = "admin";
            string adminPassword = "admin123";

            string staffUsername = "staff";
            string staffPassword = "staff123";

            string enteredUsername = enteryourusername.Text;
            string enteredPassword = enteryourpassword.Text;

            if (enteredUsername == adminUsername && enteredPassword == adminPassword)
            {
                // Common action for both admin and staff (for example, displaying a message)
                MessageBox.Show("Login successful! Welcome, Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide the login form
            }
            else if (enteredUsername == staffUsername && enteredPassword == staffPassword)
            {
                // Common action for both admin and staff (for example, displaying a message)
                MessageBox.Show("Login successful! Welcome, Staff.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
