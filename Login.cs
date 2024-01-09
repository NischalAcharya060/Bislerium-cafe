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
            try
            {
                string adminUsername = "admin";
                string adminPassword = "admin123";

                string staffUsername = "staff";
                string staffPassword = "staff123";

                string enteredUsername = enteryourusername.Text;
                string enteredPassword = enteryourpassword.Text;

                if (enteredUsername == adminUsername && enteredPassword == adminPassword)
                {
                    MessageBox.Show("Login successful! Welcome, Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                    this.Hide();
                }
                else if (enteredUsername == staffUsername && enteredPassword == staffPassword)
                {
                    MessageBox.Show("Login successful! Welcome, Staff.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
