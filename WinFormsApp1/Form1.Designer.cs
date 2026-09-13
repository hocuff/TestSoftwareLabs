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
            textBox1 = new TextBox();
            four = new Button();
            five = new Button();
            six = new Button();
            add = new Button();
            subtraction = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            division = new Button();
            multiplication = new Button();
            clear = new Button();
            delete = new Button();
            equal = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            comma = new Button();
            zero = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(490, 165);
            textBox1.TabIndex = 0;
            // 
            // four
            // 
            four.Font = new Font("Segoe UI", 27.75F);
            four.Location = new Point(12, 431);
            four.Name = "four";
            four.Size = new Size(118, 118);
            four.TabIndex = 12;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // five
            // 
            five.Font = new Font("Segoe UI", 27.75F);
            five.Location = new Point(136, 431);
            five.Name = "five";
            five.Size = new Size(118, 118);
            five.TabIndex = 13;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.Font = new Font("Segoe UI", 27.75F);
            six.Location = new Point(260, 431);
            six.Name = "six";
            six.Size = new Size(118, 118);
            six.TabIndex = 14;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 27.75F);
            add.Location = new Point(384, 431);
            add.Name = "add";
            add.Size = new Size(118, 118);
            add.TabIndex = 15;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // subtraction
            // 
            subtraction.Font = new Font("Segoe UI", 27.75F);
            subtraction.Location = new Point(384, 307);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(118, 118);
            subtraction.TabIndex = 19;
            subtraction.Text = "-";
            subtraction.UseVisualStyleBackColor = true;
            subtraction.Click += subtraction_Click;
            // 
            // nine
            // 
            nine.Font = new Font("Segoe UI", 27.75F);
            nine.Location = new Point(260, 307);
            nine.Name = "nine";
            nine.Size = new Size(118, 118);
            nine.TabIndex = 18;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.Font = new Font("Segoe UI", 27.75F);
            eight.Location = new Point(136, 307);
            eight.Name = "eight";
            eight.Size = new Size(118, 118);
            eight.TabIndex = 17;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Font = new Font("Segoe UI", 27.75F);
            seven.Location = new Point(12, 307);
            seven.Name = "seven";
            seven.Size = new Size(118, 118);
            seven.TabIndex = 16;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // division
            // 
            division.Font = new Font("Segoe UI", 27.75F);
            division.Location = new Point(384, 183);
            division.Name = "division";
            division.Size = new Size(118, 118);
            division.TabIndex = 23;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // multiplication
            // 
            multiplication.Font = new Font("Segoe UI", 27.75F);
            multiplication.Location = new Point(260, 183);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(118, 118);
            multiplication.TabIndex = 22;
            multiplication.Text = "*";
            multiplication.UseVisualStyleBackColor = true;
            multiplication.Click += multiplication_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.RosyBrown;
            clear.Font = new Font("Segoe UI", 27.75F);
            clear.ForeColor = SystemColors.ControlText;
            clear.Location = new Point(12, 183);
            clear.Name = "clear";
            clear.Size = new Size(118, 118);
            clear.TabIndex = 21;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 255, 128);
            delete.Font = new Font("Segoe UI", 27.75F);
            delete.Location = new Point(136, 183);
            delete.Name = "delete";
            delete.Size = new Size(118, 118);
            delete.TabIndex = 20;
            delete.Text = "DEL";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.FromArgb(128, 255, 128);
            equal.Font = new Font("Segoe UI", 27.75F);
            equal.Location = new Point(384, 558);
            equal.Name = "equal";
            equal.Size = new Size(118, 241);
            equal.TabIndex = 27;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // three
            // 
            three.Font = new Font("Segoe UI", 27.75F);
            three.Location = new Point(260, 558);
            three.Name = "three";
            three.Size = new Size(118, 118);
            three.TabIndex = 26;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Font = new Font("Segoe UI", 27.75F);
            two.Location = new Point(136, 558);
            two.Name = "two";
            two.Size = new Size(118, 118);
            two.TabIndex = 25;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Font = new Font("Segoe UI", 27.75F);
            one.Location = new Point(12, 558);
            one.Name = "one";
            one.Size = new Size(118, 118);
            one.TabIndex = 24;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // comma
            // 
            comma.Font = new Font("Segoe UI", 27.75F);
            comma.Location = new Point(12, 682);
            comma.Name = "comma";
            comma.Size = new Size(118, 118);
            comma.TabIndex = 28;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = true;
            comma.Click += comma_Click;
            // 
            // zero
            // 
            zero.Font = new Font("Segoe UI", 27.75F);
            zero.Location = new Point(136, 682);
            zero.Name = "zero";
            zero.Size = new Size(242, 118);
            zero.TabIndex = 29;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 811);
            Controls.Add(zero);
            Controls.Add(comma);
            Controls.Add(equal);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(division);
            Controls.Add(multiplication);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(subtraction);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(add);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button four;
        private Button five;
        private Button six;
        private Button add;
        private Button subtraction;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button division;
        private Button multiplication;
        private Button clear;
        private Button delete;
        private Button equal;
        private Button three;
        private Button two;
        private Button one;
        private Button comma;
        private Button zero;
    }
}
