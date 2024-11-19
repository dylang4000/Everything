using System.Diagnostics;

namespace _2024_25_02_02_02
{
    public partial class EvenOddForm : Form
    {
        public EvenOddForm()
        {
            InitializeComponent();
        }

        private Label EvenOddLabel;
        private TextBox MaximumBox;
        private Label minNumberLabel;
        private Label maxnumlabel;
        private TextBox MinTextBox;
        private TextBox maxTextBox;
        private ListBox ResultsListbox;
        private Button SubmitButton;
        private TextBox MinimumBox;

        private void InitializeComponent()
        {
            minNumberLabel = new Label();
            maxnumlabel = new Label();
            MinTextBox = new TextBox();
            maxTextBox = new TextBox();
            ResultsListbox = new ListBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // minNumberLabel
            // 
            minNumberLabel.AutoSize = true;
            minNumberLabel.Location = new Point(76, 105);
            minNumberLabel.Name = "minNumberLabel";
            minNumberLabel.Size = new Size(28, 15);
            minNumberLabel.TabIndex = 0;
            minNumberLabel.Text = "min";
            // 
            // maxnumlabel
            // 
            maxnumlabel.AutoSize = true;
            maxnumlabel.Location = new Point(76, 220);
            maxnumlabel.Name = "maxnumlabel";
            maxnumlabel.Size = new Size(30, 15);
            maxnumlabel.TabIndex = 1;
            maxnumlabel.Text = "max";
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(156, 105);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(150, 23);
            MinTextBox.TabIndex = 2;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(156, 220);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(150, 23);
            maxTextBox.TabIndex = 3;
            // 
            // ResultsListbox
            // 
            ResultsListbox.FormattingEnabled = true;
            ResultsListbox.ItemHeight = 15;
            ResultsListbox.Location = new Point(413, 116);
            ResultsListbox.Name = "ResultsListbox";
            ResultsListbox.Size = new Size(180, 124);
            ResultsListbox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(284, 316);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 34);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "button1";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // EvenOddForm
            // 
            ClientSize = new Size(631, 389);
            Controls.Add(SubmitButton);
            Controls.Add(ResultsListbox);
            Controls.Add(maxTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(maxnumlabel);
            Controls.Add(minNumberLabel);
            Name = "EvenOddForm";
            Text = "EvenOdd";
            ResumeLayout(false);
            PerformLayout();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            ResultsListbox.Items.Clear();
            string strMaxNumber = MinTextBox.Text;
            string strMinNumber = maxTextBox.Text;

            try
            {

                int minNumber = int.Parse(strMinNumber);
                int maxNumber = int.Parse(strMaxNumber);

                for (int i = minNumber; i <= maxNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        //even
                        ResultsListbox.Items.Add(i + "is even");
                    }
                    else
                    {
                        //odd
                        ResultsListbox.Items.Add(i + "is odd");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
