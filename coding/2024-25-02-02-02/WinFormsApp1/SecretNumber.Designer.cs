namespace _2024_25_02_02_02
{
    partial class SecretNumberForm
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
            Answerbox = new TextBox();
            secretNumLabel = new Label();
            SubmitButton = new Button();
            Resultsbox = new ListBox();
            SuspendLayout();
            // 
            // Answerbox
            // 
            Answerbox.Location = new Point(90, 107);
            Answerbox.Margin = new Padding(2);
            Answerbox.Name = "Answerbox";
            Answerbox.Size = new Size(106, 23);
            Answerbox.TabIndex = 0;
            // 
            // secretNumLabel
            // 
            secretNumLabel.AutoSize = true;
            secretNumLabel.Location = new Point(71, 80);
            secretNumLabel.Margin = new Padding(2, 0, 2, 0);
            secretNumLabel.Name = "secretNumLabel";
            secretNumLabel.Size = new Size(137, 15);
            secretNumLabel.TabIndex = 1;
            secretNumLabel.Text = "Guess the secret number";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(100, 139);
            SubmitButton.Margin = new Padding(2);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(78, 20);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Resultsbox
            // 
            Resultsbox.FormattingEnabled = true;
            Resultsbox.ItemHeight = 15;
            Resultsbox.Location = new Point(100, 172);
            Resultsbox.Margin = new Padding(2);
            Resultsbox.Name = "Resultsbox";
            Resultsbox.Size = new Size(83, 19);
            Resultsbox.TabIndex = 3;
            // 
            // SecretNumberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 270);
            Controls.Add(Resultsbox);
            Controls.Add(SubmitButton);
            Controls.Add(secretNumLabel);
            Controls.Add(Answerbox);
            Margin = new Padding(2);
            Name = "SecretNumberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SecretNumber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Answerbox;
        private Label secretNumLabel;
        private Button SubmitButton;
        private ListBox Resultsbox;
    }
}