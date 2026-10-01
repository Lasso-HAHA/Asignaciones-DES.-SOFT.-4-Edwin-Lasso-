namespace Probando_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1 = int.Parse(suma1.Text);
            int num2 = int.Parse(suma2.Text);

           // int num1 = Convert.ToInt32(suma1.Text);
           // int num2 = Convert.ToInt32(suma2.Text);

            int total = num1 + num2;
            resultado.Text = total.ToString();
            MessageBox.Show("El resultado es: " + total);
            
        }
    }
}
