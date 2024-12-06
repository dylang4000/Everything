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
            AnswerBox = new TextBox();
            secretNumLabel = new Label();
            SubmitButton = new Button();
            label1 = new Label();
            AttemptsLabel = new Label();
            NewGameButton = new Button();
            SuspendLayout();
            // 
            // AnswerBox
            // 
            AnswerBox.Location = new Point(115, 214);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.PlaceholderText = "Enter Your Number";
            AnswerBox.Size = new Size(179, 31);
            AnswerBox.TabIndex = 0;
            // 
            // secretNumLabel
            // 
            secretNumLabel.AutoSize = true;
            secretNumLabel.Location = new Point(101, 149);
            secretNumLabel.Name = "secretNumLabel";
            secretNumLabel.Size = new Size(207, 25);
            secretNumLabel.TabIndex = 1;
            secretNumLabel.Text = "Guess the secret number";
            secretNumLabel.Click += secretNumLabel_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(148, 267);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 73);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 181);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 3;
            label1.Text = "Attempts:";
            // 
            // AttemptsLabel
            // 
            AttemptsLabel.AutoSize = true;
            AttemptsLabel.Location = new Point(222, 181);
            AttemptsLabel.Name = "AttemptsLabel";
            AttemptsLabel.Size = new Size(32, 25);
            AttemptsLabel.TabIndex = 4;
            AttemptsLabel.Text = "10";
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new Point(148, 346);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(112, 73);
            NewGameButton.TabIndex = 5;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // SecretNumberForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(NewGameButton);
            Controls.Add(AttemptsLabel);
            Controls.Add(label1);
            Controls.Add(SubmitButton);
            Controls.Add(secretNumLabel);
            Controls.Add(AnswerBox);
            Name = "SecretNumberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SecretNumber";
            Load += SecretNumberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AnswerBox;
        private Label secretNumLabel;
        private Button SubmitButton;
        private Label label1;
        private Label AttemptsLabel;
        private Button NewGameButton;
    }
}