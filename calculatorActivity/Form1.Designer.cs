namespace calculatorActivity
{
    partial class Form1
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
            display = new TextBox();
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
            equal = new Button();
            button15 = new Button();
            clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // display
            // 
            display.Font = new Font("Segoe UI", 20F);
            display.Location = new Point(111, 24);
            display.Multiline = true;
            display.Name = "display";
            display.Size = new Size(484, 69);
            display.TabIndex = 0;
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(111, 99);
            button1.Name = "button1";
            button1.Size = new Size(111, 73);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(243, 99);
            button2.Name = "button2";
            button2.Size = new Size(111, 73);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(368, 99);
            button3.Name = "button3";
            button3.Size = new Size(111, 73);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(111, 178);
            button4.Name = "button4";
            button4.Size = new Size(111, 73);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(243, 178);
            button5.Name = "button5";
            button5.Size = new Size(111, 73);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(368, 178);
            button6.Name = "button6";
            button6.Size = new Size(111, 73);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(111, 257);
            button7.Name = "button7";
            button7.Size = new Size(111, 73);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(243, 257);
            button8.Name = "button8";
            button8.Size = new Size(111, 73);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(368, 257);
            button9.Name = "button9";
            button9.Size = new Size(111, 73);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(484, 178);
            button10.Name = "button10";
            button10.Size = new Size(111, 73);
            button10.TabIndex = 12;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(243, 331);
            button11.Name = "button11";
            button11.Size = new Size(111, 73);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(484, 99);
            button12.Name = "button12";
            button12.Size = new Size(111, 73);
            button12.TabIndex = 10;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(484, 257);
            button13.Name = "button13";
            button13.Size = new Size(111, 73);
            button13.TabIndex = 13;
            button13.Text = "x";
            button13.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            equal.Location = new Point(368, 331);
            equal.Name = "equal";
            equal.Size = new Size(111, 73);
            equal.TabIndex = 14;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(484, 331);
            button15.Name = "button15";
            button15.Size = new Size(111, 73);
            button15.TabIndex = 15;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            clear.Location = new Point(111, 331);
            clear.Name = "clear";
            clear.Size = new Size(111, 73);
            clear.TabIndex = 16;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += Clear_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(601, 40);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 17;
            label1.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(clear);
            Controls.Add(button15);
            Controls.Add(equal);
            Controls.Add(button13);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
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
        private Button equal;
        private Button button15;
        private Button clear;
        private Label label1;
    }
}
