using System.IO;


namespace Stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreArchivo = @"c:\patron.txt";


            StreamWriter flujoSalida = File.CreateText(nombreArchivo);
            for (int l�neas = 1; l�neas <= 10; l�neas++)
            {
                for (int estrellas = 1; estrellas <= l�neas; estrellas++)
                {
                    flujoSalida.Write("*");
                }
                flujoSalida.WriteLine();
            }
            flujoSalida.Close();
        }
    }
}