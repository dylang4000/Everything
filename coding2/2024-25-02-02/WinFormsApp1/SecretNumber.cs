namespace _2024_25_02_02_02
{
    public partial class SecretNumberForm : Form
    {
        public Random rand = new();
        public int secretnumber = 0;
        public SecretNumberForm()
        {
            InitializeComponent();
        }

        private void secretNumLabel_Click(object sender, EventArgs e)
        {


        }

        public int attempts = 10;

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                int userInput = int.Parse(AnswerBox.Text);
                if (attempts == 0)
                {
                    NewGameButton.Visible = true;
                    SubmitButton.Enabled = false;
                }
                else if (userInput < secretnumber)
                {
                    MessageBox.Show(userInput + " is lower than the secret number.");
                    attempts--;
                    AttemptsLabel.Text = ("" + attempts);
                }
                else if (userInput > secretnumber)
                {
                    MessageBox.Show(userInput + " is higher than the secret number.");
                    attempts--;
                    AttemptsLabel.Text = ("" + attempts);

                }
                else if (userInput == secretnumber)
                {
                    MessageBox.Show(userInput + " is Equal to the secret number!");
                    NewGameButton.Visible = true;
                    SubmitButton.Enabled = false;
                    attempts--;
                    AttemptsLabel.Text = ("" + attempts);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("enter a valid number" + AnswerBox.Text + "is not a valid number");
            }

        }

        private void SecretNumberForm_Load(object sender, EventArgs e)
        {
            secretnumber = rand.Next(1, 100);
            NewGameButton.Visible = false;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            secretnumber = rand.Next(1, 100);
            NewGameButton.Visible = false;
            attempts = 10;
            AttemptsLabel.Text=("" + attempts);
            SubmitButton.Enabled = true;
            AnswerBox.Text = "";
        }
    }
}
