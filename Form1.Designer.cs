namespace Calculator
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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_equal = new Button();
            btn_0 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_plus = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_clear = new Button();
            tbx_ans = new TextBox();
            tbx_equation = new TextBox();
            btn_minus = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            btn_delete = new Button();
            btn_decimal = new Button();
            btn_posneg = new Button();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.Location = new Point(64, 595);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(80, 80);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(224, 595);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(80, 80);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(379, 595);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(80, 80);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_equal
            // 
            btn_equal.Location = new Point(379, 721);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(80, 80);
            btn_equal.TabIndex = 3;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(224, 721);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(80, 80);
            btn_0.TabIndex = 4;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(64, 468);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(80, 80);
            btn_4.TabIndex = 5;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(224, 468);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(80, 80);
            btn_5.TabIndex = 6;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(379, 468);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(80, 80);
            btn_6.TabIndex = 7;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(543, 341);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(80, 80);
            btn_plus.TabIndex = 8;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(64, 341);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(80, 80);
            btn_7.TabIndex = 9;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(224, 341);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(80, 80);
            btn_8.TabIndex = 10;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(379, 341);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(80, 80);
            btn_9.TabIndex = 11;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(64, 721);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(80, 80);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // tbx_ans
            // 
            tbx_ans.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_ans.Location = new Point(64, 110);
            tbx_ans.Name = "tbx_ans";
            tbx_ans.Size = new Size(559, 66);
            tbx_ans.TabIndex = 13;
            tbx_ans.Text = "0";
            tbx_ans.TextAlign = HorizontalAlignment.Right;
            // 
            // tbx_equation
            // 
            tbx_equation.Location = new Point(64, 53);
            tbx_equation.Name = "tbx_equation";
            tbx_equation.Size = new Size(559, 31);
            tbx_equation.TabIndex = 14;
            tbx_equation.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(543, 468);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(80, 80);
            btn_minus.TabIndex = 15;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Location = new Point(543, 595);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(80, 80);
            btn_multiply.TabIndex = 16;
            btn_multiply.Text = "x";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_divide
            // 
            btn_divide.Location = new Point(543, 721);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(80, 80);
            btn_divide.TabIndex = 17;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(543, 215);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(80, 80);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "<-";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_decimal
            // 
            btn_decimal.Location = new Point(379, 215);
            btn_decimal.Name = "btn_decimal";
            btn_decimal.Size = new Size(80, 80);
            btn_decimal.TabIndex = 19;
            btn_decimal.Text = ".";
            btn_decimal.UseVisualStyleBackColor = true;
            btn_decimal.Click += btn_decimal_Click;
            // 
            // btn_posneg
            // 
            btn_posneg.Location = new Point(224, 215);
            btn_posneg.Name = "btn_posneg";
            btn_posneg.Size = new Size(80, 80);
            btn_posneg.TabIndex = 20;
            btn_posneg.Text = "+/-";
            btn_posneg.UseVisualStyleBackColor = true;
            btn_posneg.Click += btn_posneg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 846);
            Controls.Add(btn_posneg);
            Controls.Add(btn_decimal);
            Controls.Add(btn_delete);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_minus);
            Controls.Add(tbx_equation);
            Controls.Add(tbx_ans);
            Controls.Add(btn_clear);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_plus);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_0);
            Controls.Add(btn_equal);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_equal;
        private Button btn_0;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_plus;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_clear;
        private TextBox tbx_ans;
        private TextBox tbx_equation;
        private Button btn_minus;
        private Button btn_multiply;
        private Button btn_divide;
        private Button btn_delete;
        private Button btn_decimal;
        private Button btn_posneg;
    }
}
