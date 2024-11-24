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
            textBox1 = new TextBox();
            secretNumLabel = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // secretNumLabel
            // 
            secretNumLabel.AutoSize = true;
            secretNumLabel.Location = new Point(101, 134);
            secretNumLabel.Name = "secretNumLabel";
            secretNumLabel.Size = new Size(207, 25);
            secretNumLabel.TabIndex = 1;
            secretNumLabel.Text = "Guess the secret number";
            // 
            // button1
            // 
            button1.Location = new Point(143, 231);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(143, 287);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(117, 29);
            listBox1.TabIndex = 3;
            // 
            // SecretNumberForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(secretNumLabel);
            Controls.Add(textBox1);
            Name = "SecretNumberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SecretNumber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label secretNumLabel;
        private Button button1;
        private ListBox listBox1;
    }
}