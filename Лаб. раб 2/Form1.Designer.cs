namespace Лаб._раб_2
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

            button11 = new Button();
            button12 = new Button();
            button18 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1-10
            // 
            // Создание и инициализация массива текстов для кнопок
            string[] buttonTexts = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            // Создание и настройка кнопок через цикл
            for (int i = 0; i < buttonTexts.Length; i++)
            {
                Button button = new Button();
                button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                button.Location = new Point(24 + 129 * (i % 3), 247 + 80 * (i / 3));
                button.Name = "button" + (i + 1);
                button.Size = new Size(109, 60);
                button.TabIndex = i;
                button.Text = buttonTexts[i];
                button.UseVisualStyleBackColor = true;
                button.Click += NumberButton_Click;

                // Добавление кнопки на форму (замените "this" на соответствующий объект формы)
                this.Controls.Add(button);
            }
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(153, 489);
            button11.Name = "button11";
            button11.Size = new Size(109, 60);
            button11.TabIndex = 11;
            button11.Text = ",";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DecimalButton_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(282, 489);
            button12.Name = "button12";
            button12.Size = new Size(238, 60);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += EqualsButton_Click;

            string[] buttonTexts_operator = { "+", "-", "x", "/", "%" };
            Point[] buttonPositions = new Point[]
            {
                new Point(411, 409),
                new Point(411, 327),
                new Point(411, 247),
                new Point(411, 171),
                new Point(282, 171),
            };

            for (int i = 0; i < buttonTexts_operator.Length; i++)
            {
                Button button = new Button();
                button.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
                button.Location = buttonPositions[i];
                button.Name = "button" + (i + 13).ToString();
                button.Size = new Size(109, 60);
                button.TabIndex = i + 13;
                button.Text = buttonTexts_operator[i];
                button.UseVisualStyleBackColor = true;
                button.Click += OperatorButton_Click;
                this.Controls.Add(button);
            }
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(24, 171);
            button18.Name = "button18";
            button18.Size = new Size(238, 60);
            button18.TabIndex = 18;
            button18.Text = "АС";
            button18.UseVisualStyleBackColor = true;
            button18.Click += ClearButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(24, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(496, 65);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 612);
            Controls.Add(richTextBox1);
            Button[] buttons_main = { button18, button17, button16, button15, button14, button13, 
                button12, button11, button10, button9, button8, button7, button6, button5, button4, button3, button2, button1 };

            foreach (Button button in buttons_main)
            {
                Controls.Add(button);
            }

            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
        }

        #endregion

        private Button button1, button2, button3, button4, button5, button6, button7, button8, button9, 
            button10, button11, button12, button13, button14, button15, button16, button17, button18;
        private RichTextBox richTextBox1;
    }
}