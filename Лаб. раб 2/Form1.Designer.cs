﻿namespace Лаб._раб_2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1-10
            // 
            // Создание и инициализация массива текстов для кнопок
            string[] buttonTexts = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            // Определение обработчика события клика на кнопку
            EventHandler numberButtonClickHandler = new EventHandler(NumberButton_Click);

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
                button.Click += numberButtonClickHandler;

                // Добавление кнопки на форму (замените "this" на соответствующий объект формы)
                this.Controls.Add(button);
            }
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(153, 493);
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
            button12.Location = new Point(282, 493);
            button12.Name = "button12";
            button12.Size = new Size(238, 60);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += EqualsButton_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(411, 409);
            button13.Name = "button13";
            button13.Size = new Size(109, 60);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += OperatorButton_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(411, 327);
            button14.Name = "button14";
            button14.Size = new Size(109, 60);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += OperatorButton_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(411, 247);
            button15.Name = "button15";
            button15.Size = new Size(109, 60);
            button15.TabIndex = 15;
            button15.Text = "x";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OperatorButton_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(411, 171);
            button16.Name = "button16";
            button16.Size = new Size(109, 60);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += OperatorButton_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(282, 171);
            button17.Name = "button17";
            button17.Size = new Size(109, 60);
            button17.TabIndex = 17;
            button17.Text = "%";
            button17.UseVisualStyleBackColor = true;
            button17.Click += OperatorButton_Click;
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
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private RichTextBox richTextBox1;
    }
}
/*
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(24, 247);
            button1.Name = "button1";
            button1.Size = new Size(109, 60);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(153, 247);
            button2.Name = "button2";
            button2.Size = new Size(109, 60);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(282, 247);
            button3.Name = "button3";
            button3.Size = new Size(109, 60);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(24, 327);
            button4.Name = "button4";
            button4.Size = new Size(109, 60);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(153, 327);
            button5.Name = "button5";
            button5.Size = new Size(109, 60);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(282, 327);
            button6.Name = "button6";
            button6.Size = new Size(109, 60);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(24, 409);
            button7.Name = "button7";
            button7.Size = new Size(109, 60);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(153, 409);
            button8.Name = "button8";
            button8.Size = new Size(109, 60);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(282, 409);
            button9.Name = "button9";
            button9.Size = new Size(109, 60);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(24, 493);
            button10.Name = "button10";
            button10.Size = new Size(109, 60);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(153, 493);
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
            button12.Location = new Point(282, 493);
            button12.Name = "button12";
            button12.Size = new Size(238, 60);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += EqualsButton_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(411, 409);
            button13.Name = "button13";
            button13.Size = new Size(109, 60);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += OperatorButton_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(411, 327);
            button14.Name = "button14";
            button14.Size = new Size(109, 60);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += OperatorButton_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(411, 247);
            button15.Name = "button15";
            button15.Size = new Size(109, 60);
            button15.TabIndex = 15;
            button15.Text = "x";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OperatorButton_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(411, 171);
            button16.Name = "button16";
            button16.Size = new Size(109, 60);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += OperatorButton_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(282, 171);
            button17.Name = "button17";
            button17.Size = new Size(109, 60);
            button17.TabIndex = 17;
            button17.Text = "%";
            button17.UseVisualStyleBackColor = true;
            button17.Click += OperatorButton_Click;
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
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private RichTextBox richTextBox1;
    }
}

*/