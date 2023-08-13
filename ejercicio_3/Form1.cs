namespace restaaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int primernumero = int.Parse(textBox1.Text);
            int segundonumero = int.Parse(textBox2.Text);

            int resultado = primernumero - segundonumero;

            label3.Text = $"El resultado de la resta es: {resultado}";
        }
    }
}