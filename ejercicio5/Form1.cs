namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int resultado = numero * numero * numero;

            label2.Text = $"el resultado es: {resultado}";
        }
    }
}