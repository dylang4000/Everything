namespace _2024_25_02_02_02
{
    partial class FizzBuzzForm
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
            MaximumBox = new TextBox();
            outputLabel = new ListBox();
            MinInputBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 77);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a Number Range";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(27, 188);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 34);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // MaximumBox
            // 
            MaximumBox.Location = new Point(27, 148);
            MaximumBox.Name = "MaximumBox";
            MaximumBox.PlaceholderText = "Maximum";
            MaximumBox.Size = new Size(150, 31);
            MaximumBox.TabIndex = 3;
            MaximumBox.TextChanged += MaximumBox_TextChanged;
            // 
            // outputLabel
            // 
            outputLabel.FormattingEnabled = true;
            outputLabel.ItemHeight = 25;
            outputLabel.Location = new Point(237, 30);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(243, 179);
            outputLabel.TabIndex = 4;
            // 
            // MinInputBox
            // 
            MinInputBox.Location = new Point(26, 110);
            MinInputBox.Name = "MinInputBox";
            MinInputBox.PlaceholderText = "Min";
            MinInputBox.Size = new Size(150, 31);
            MinInputBox.TabIndex = 5;
            MinInputBox.TextChanged += MinInputBox_TextChanged;
            // 
            // FizzBuzzForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 277);
            Controls.Add(MinInputBox);
            Controls.Add(outputLabel);
            Controls.Add(MaximumBox);
            Controls.Add(SubmitButton);
            Controls.Add(label1);
            Name = "FizzBuzzForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FizzBuzz";
            Load += FizzBuzzForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SubmitButton;
        private TextBox MaximumBox;
        private ListBox outputLabel;
        private TextBox MinInputBox;
    }
}