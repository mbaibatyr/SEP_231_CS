namespace MyWinForm
{
    partial class FormException
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
            tbTest = new TextBox();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(506, 31);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 0;
            button1.Text = "Деление на ноль";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(507, 72);
            button2.Name = "button2";
            button2.Size = new Size(239, 23);
            button2.TabIndex = 1;
            button2.Text = "Ошибка с индексами в массиве";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(511, 120);
            button3.Name = "button3";
            button3.Size = new Size(235, 23);
            button3.TabIndex = 2;
            button3.Text = "не созданный объект";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(516, 167);
            button4.Name = "button4";
            button4.Size = new Size(230, 23);
            button4.TabIndex = 3;
            button4.Text = "Ошибка преобразования";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(517, 207);
            button5.Name = "button5";
            button5.Size = new Size(229, 23);
            button5.TabIndex = 4;
            button5.Text = "Файловая ошибка";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(520, 258);
            button6.Name = "button6";
            button6.Size = new Size(226, 23);
            button6.TabIndex = 5;
            button6.Text = "throw";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tbTest
            // 
            tbTest.Location = new Point(271, 258);
            tbTest.Name = "tbTest";
            tbTest.Size = new Size(145, 23);
            tbTest.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 261);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // button7
            // 
            button7.Location = new Point(527, 324);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(272, 319);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 9;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(214, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(211, 139);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // FormException
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(tbTest);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormException";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox tbTest;
        private Label label1;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
    }
}