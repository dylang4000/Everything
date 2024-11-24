using _2024_25_02_02_02;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FizzBuzzForm fizzBuzzForm = new FizzBuzzForm();
            fizzBuzzForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecretNumberForm secretNumberForm = new SecretNumberForm();
            secretNumberForm.ShowDialog(this);
        }

        private void DigitCounterButton_Click(object sender, EventArgs e)
        {
            DigitCounterForm digitCounterForm = new DigitCounterForm();
            digitCounterForm.ShowDialog(this);
        }

        private void EvenOddButton_Click(object sender, EventArgs e)
        {
            EvenOddForm evenOddForm = new EvenOddForm();
            evenOddForm.ShowDialog(this);
        }
    }
}
