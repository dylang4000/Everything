using System.Diagnostics;

namespace _2024_25_02_02_02
{
    public partial class DigitCounterForm : Form
    {
        public DigitCounterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Items.Clear();
            string input0 = AnswerTextBox.Text;
            int input = 0;
            try
            {
                input = int.Parse(input0);
                int digits = 0;

                while (input/10 != 0)
                {
                    input /= 10;
                    digits++;
                }
                digits++;
                ResultsBox.Items.Add("there are "+digits+" digits in "+input0);


            }
            catch (FormatException fe)
            {
                Debug.WriteLine(fe);
                ResultsBox.Text = "Enter a Valid Number";
                MessageBox.Show(input0 + " isnt a vilid number enter a number doofus");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        private void DigitCounterForm_Load(object sender, EventArgs e)
        {
            ResultsBox.Items.Clear();
        }
    }
}
