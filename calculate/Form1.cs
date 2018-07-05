using System;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Click(object sender, EventArgs e)
        {
            string firstValuetext = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValuetext);
            string secondValuetext = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValuetext);
            ITwoArgumentCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button) sender).Name);
            double result = calculator.Calculate(firstValue, secondValue);
            textBox3.Text = result.ToString();

        }

        private void OneClick(object sender, EventArgs e)
        {
            string thirdValueText = textBox4.Text;
            double thirdValue = Convert.ToDouble(thirdValueText);
            IOneArgumentCalculator calculator = CalculatorOneFactory.CreateCalculator(((Button)sender).Name);
            double thirdValueResult = calculator.Calculate(thirdValue);
            textBox4.Text = thirdValueResult.ToString();
        }
    }
}