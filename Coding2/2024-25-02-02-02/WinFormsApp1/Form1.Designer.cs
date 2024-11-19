namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LaunchFizzBuzz = new Button();
            SecretNumberButton = new Button();
            DigitCounterButton = new Button();
            EvenOddButton = new Button();
            SuspendLayout();
            // 
            // LaunchFizzBuzz
            // 
            LaunchFizzBuzz.Location = new Point(38, 28);
            LaunchFizzBuzz.Name = "LaunchFizzBuzz";
            LaunchFizzBuzz.Size = new Size(187, 34);
            LaunchFizzBuzz.TabIndex = 0;
            LaunchFizzBuzz.Text = "Launch FizzBuzz";
            LaunchFizzBuzz.UseVisualStyleBackColor = true;
            LaunchFizzBuzz.Click += button1_Click;
            // 
            // SecretNumberButton
            // 
            SecretNumberButton.Location = new Point(38, 73);
            SecretNumberButton.Name = "SecretNumberButton";
            SecretNumberButton.Size = new Size(187, 34);
            SecretNumberButton.TabIndex = 1;
            SecretNumberButton.Text = "LaunchSecretNumber";
            SecretNumberButton.UseVisualStyleBackColor = true;
            SecretNumberButton.Click += button2_Click;
            // 
            // DigitCounterButton
            // 
            DigitCounterButton.Location = new Point(38, 118);
            DigitCounterButton.Name = "DigitCounterButton";
            DigitCounterButton.Size = new Size(187, 34);
            DigitCounterButton.TabIndex = 2;
            DigitCounterButton.Text = "LaunchDigitCounter";
            DigitCounterButton.UseVisualStyleBackColor = true;
            DigitCounterButton.Click += DigitCounterButton_Click;
            // 
            // EvenOddButton
            // 
            EvenOddButton.Location = new Point(38, 163);
            EvenOddButton.Name = "EvenOddButton";
            EvenOddButton.Size = new Size(187, 34);
            EvenOddButton.TabIndex = 3;
            EvenOddButton.Text = "Launch Even Odd";
            EvenOddButton.UseVisualStyleBackColor = true;
            EvenOddButton.Click += EvenOddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 224);
            Controls.Add(EvenOddButton);
            Controls.Add(DigitCounterButton);
            Controls.Add(SecretNumberButton);
            Controls.Add(LaunchFizzBuzz);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button LaunchFizzBuzz;
        private Button SecretNumberButton;
        private Button DigitCounterButton;
        private Button EvenOddButton;
    }
}
