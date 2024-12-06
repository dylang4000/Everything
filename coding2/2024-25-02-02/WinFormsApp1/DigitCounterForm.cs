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
            string mininput0 = MinTextBox.Text;
            string maxinput0 = MaxBox.Text;
            int maxinput = 0;
            int mininput = 0;
            int currentdigit = 0;
            int digits = 0;
            try
            {

                maxinput= int.Parse(maxinput0);
                mininput = int.Parse(mininput0);
                while (currentdigit < maxinput)
                {
                    MessageBox.Show("" + currentdigit);
                    digits = 0;
                    while (currentdigit / 10 != 0) 
                    { 
                    currentdigit /= 10;
                    digits++;
                    }
                    digits++;
                    ResultsBox.Items.Add("there are " + digits + " digits in " + currentdigit);
                }

            }
            catch (FormatException fe)
            {
                Debug.WriteLine(fe);
                ResultsBox.Text = "Enter a Valid Number";
                MessageBox.Show(mininput0+" or "+maxinput0 + " isnt a vilid number enter a number doofus");
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
