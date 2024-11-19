using System.Diagnostics;

namespace _2024_25_02_02_02
{
    public partial class FizzBuzzForm : Form
    {
        public FizzBuzzForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            outputLabel.Items.Clear();
            string MaxInput = MaximumBox.Text;
            string MinInput = MinInputBox.Text;
            int MaxNum = 0;
            int MinNum = 0;
            try
            {

                MaxNum = int.Parse(MaxInput);
                MinNum = int.Parse(MinInput);
                for (int i = MinNum; i < MaxNum; i++)
                {

                    if (i % 15 == 0)
                    {

                        outputLabel.Items.Add("FIZZBUZZ");

                    }
                    else if (i % 3 == 0)
                    {
                        outputLabel.Items.Add("FIZZ");
                    }
                    else if (i % 5 == 0)
                    {
                        outputLabel.Items.Add("BUZZ");
                    }
                    else
                    {

                        outputLabel.Items.Add(i);
                    }
                }
            }
            catch (FormatException fe)
            {
                Debug.WriteLine(fe);
                outputLabel.Text = "Enter a Valid Number";
                MessageBox.Show(MaxNum + " or " + MinNum + " isnt a vilid number enter a number doofus");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void FizzBuzzForm_Load(object sender, EventArgs e)
        {
            outputLabel.Items.Clear();
        }

        private void MaximumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
