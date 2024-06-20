using System;
using System.Data;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace calculatorActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button button && button.Text != "=")
                {
                    button.Click += Button_Click;
                }
            }

            
            equal.Click += ButtonEquals_Click;

            clear.Click += Clear_click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                display.Text += button.Text;
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = EvaluateExpression(display.Text);
                display.Text = result.ToString();
            }
            catch (Exception)
            {
                display.Text = "Error";
            }
        }

        private double EvaluateExpression(string expression)
        {
          
            expression = expression.Replace("x", "*");

            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, "");
            return Convert.ToDouble(value);
        }

        private void Clear_click(object sender, EventArgs e)
        {
            display.Text = " ";
        }
    }
}
