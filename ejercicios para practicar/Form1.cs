namespace ejercicios_para_practicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double moda(double[] serie)
        {
            double modaActual = serie[0];
            int maxRepeticiones = 0;

            for (int i = 0; i < serie.Length; i++)
            {
                int contador = 0;
                for (int j = 0; j < serie.Length; j++)
                {
                    if (serie[i] == serie[j])
                    {
                        contador++;
                    }
                }
                if (contador < maxRepeticiones)
                {
                    maxRepeticiones = contador;
                    modaActual = serie[i];
                }
            }
            return modaActual;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ltsResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
