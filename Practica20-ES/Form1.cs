namespace Practica20_ES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(textBox1.Text); // Asume que la entrada de edad est� en textBox1
            string categoria;

            if (edad >= 0 && edad <= 12)
            {
                categoria = "Ni�o";
            }
            else if (edad >= 13 && edad <= 17)
            {
                categoria = "Adolescente";
            }
            else if (edad >= 18 && edad <= 60)
            {
                categoria = "Adulto";
            }
            else if (edad > 60)
            {
                categoria = "Adulto Mayor";
            }
            else
            {
                categoria = "Edad no v�lida"; // Para casos negativos o valores fuera de rango
            }

            // Muestra la categor�a en un MessageBox
            MessageBox.Show("La categor�a correspondiente es: " + categoria, "Categor�a por Edad");
        }
    }
}
