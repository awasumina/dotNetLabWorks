namespace calculatorWinform
{
    partial class calculator
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
            title = new Label();
            number1 = new Label();
            number2 = new Label();
            result = new Label();
            number1text = new TextBox();
            number2text = new TextBox();
            answerText = new TextBox();
            add = new Button();
            subtract = new Button();
            multiply = new Button();
            divide = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(259, 25);
            title.Name = "title";
            title.Size = new Size(126, 20);
            title.TabIndex = 0;
            title.Text = "Simple Calculator";
            title.Click += label1_Click;
            // 
            // number1
            // 
            number1.AutoSize = true;
            number1.Location = new Point(36, 80);
            number1.Name = "number1";
            number1.Size = new Size(75, 20);
            number1.TabIndex = 1;
            number1.Text = "Number 1";
            // 
            // number2
            // 
            number2.AutoSize = true;
            number2.Location = new Point(36, 137);
            number2.Name = "number2";
            number2.Size = new Size(75, 20);
            number2.TabIndex = 2;
            number2.Text = "Number 2";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(190, 239);
            result.Name = "result";
            result.Size = new Size(49, 20);
            result.TabIndex = 3;
            result.Text = "Result";
            // 
            // number1text
            // 
            number1text.Location = new Point(133, 78);
            number1text.Name = "number1text";
            number1text.Size = new Size(125, 27);
            number1text.TabIndex = 4;
            number1text.TextChanged += number1text_TextChanged;
            // 
            // number2text
            // 
            number2text.Location = new Point(134, 135);
            number2text.Name = "number2text";
            number2text.Size = new Size(125, 27);
            number2text.TabIndex = 5;
            // 
            // answerText
            // 
            answerText.Location = new Point(245, 236);
            answerText.Name = "answerText";
            answerText.ReadOnly = true;
            answerText.Size = new Size(219, 27);
            answerText.TabIndex = 6;
            // 
            // add
            // 
            add.BackColor = Color.AntiqueWhite;
            add.Location = new Point(486, 55);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 7;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = false;
            add.Click += button1_Click;
            // 
            // subtract
            // 
            subtract.BackColor = Color.AntiqueWhite;
            subtract.Location = new Point(486, 90);
            subtract.Name = "subtract";
            subtract.Size = new Size(94, 29);
            subtract.TabIndex = 8;
            subtract.Text = "SUBTRACT";
            subtract.UseVisualStyleBackColor = false;
            subtract.Click += subtract_Click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.AntiqueWhite;
            multiply.Location = new Point(486, 125);
            multiply.Name = "multiply";
            multiply.Size = new Size(94, 29);
            multiply.TabIndex = 9;
            multiply.Text = "MULTIPLY";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.BackColor = Color.AntiqueWhite;
            divide.Location = new Point(486, 160);
            divide.Name = "divide";
            divide.Size = new Size(94, 29);
            divide.TabIndex = 10;
            divide.Text = "DIVIDE";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.SkyBlue;
            clear.Location = new Point(486, 195);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 11;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(number1text);
            Controls.Add(answerText);
            Controls.Add(result);
            Controls.Add(clear);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(subtract);
            Controls.Add(add);
            Controls.Add(number2);
            Controls.Add(number2text);
            Controls.Add(number1);
            Controls.Add(title);
            Name = "calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label number1;
        private Label number2;
        private Label result;
        private TextBox number1text;
        private TextBox number2text;
        private TextBox answerText;
        private Button add;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Button clear;
    }
}
