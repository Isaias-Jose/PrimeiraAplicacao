namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int valor_inicial = 10000;

            //label_title.Text = "Valor inicial é " + valor_inicial.ToString();

            int valor_inicial = int.Parse(textBox_valor_inicial.Text);
            int valor_final = int.Parse(textBox_valor_final.Text);
            int resultado = valor_inicial + valor_final;
            textBox_resultado.Text = resultado.ToString();

        }

        private void textBox_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_empilhar_valor_inicial_Click(object sender, EventArgs e)
        {
            int empilhar_valor_inicial = int.Parse(textBox_valor_inicial.Text);
            textBox_valor_da_variavel_valor_inicial.Text = empilhar_valor_inicial.ToString();
        }

        private void button_empilhar_valor_final_Click(object sender, EventArgs e)
        {
            int empilhar_valor_final = int.Parse(textBox_valor_final.Text);
            textBox_valor_da_variavel_valor_final.Text = empilhar_valor_final.ToString();
        }

        private void button_empilhar_resultado_Click(object sender, EventArgs e)
        {
            int empilhar_valor_resultado = int.Parse(textBox_resultado.Text);
            textBox_valor_da_variavel_resultado.Text = empilhar_valor_resultado.ToString();
        }
    }
}
