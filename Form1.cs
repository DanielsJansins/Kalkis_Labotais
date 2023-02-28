using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double sweetsPrice = 9.88;  // cena saldumiem eiro/kg

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           double budget;
            if (Double.TryParse(budgetTextBox.Text, out budget))
            {
                double sweetsAmount = budget / sweetsPrice;
                label1.Text = "Jūsu budžets ļauj iegādāties " + sweetsAmount.ToString("F2") + " kg saldumu.";
            }
            else
            {
                MessageBox.Show("Lūdzu, ievadiet derīgu budžetu!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void budgetTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
