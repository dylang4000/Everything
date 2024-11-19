namespace _2024_25_02_02_02
{
    partial class DigitCounterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SubmitButton = new Button();
            AnswerTextBox = new TextBox();
            ResultsBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 81);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter A Number";
            label1.Click += label1_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(98, 178);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(150, 48);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(98, 125);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(150, 31);
            AnswerTextBox.TabIndex = 2;
            // 
            // ResultsBox
            // 
            ResultsBox.FormattingEnabled = true;
            ResultsBox.ItemHeight = 25;
            ResultsBox.Location = new Point(59, 240);
            ResultsBox.Name = "ResultsBox";
            ResultsBox.Size = new Size(228, 29);
            ResultsBox.TabIndex = 3;
            // 
            // DigitCounterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(ResultsBox);
            Controls.Add(AnswerTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(label1);
            Name = "DigitCounterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Digit Counter Form";
            Load += DigitCounterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SubmitButton;
        private TextBox AnswerTextBox;
        private ListBox ResultsBox;
    }
}