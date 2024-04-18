using System;

namespace POB2312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x + y;
                lbResalt.Text = $"{x}+{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x - y;
                lbResalt.Text = $"{x}-{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUmnogenie_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x * y;
                lbResalt.Text = $"{x}*{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelenie_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                if (y==0||x==0) throw new DivideByZeroException();
                double s = x / y;
                lbResalt.Text = $"{x}/{y}={s}";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("На ноль делить нельзя!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
