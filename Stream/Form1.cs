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
            for (int líneas = 1; líneas <= 10; líneas++)
            {
                for (int estrellas = 1; estrellas <= líneas; estrellas++)
                {
                    flujoSalida.Write("*");
                }
                flujoSalida.WriteLine();
            }
            flujoSalida.Close();
        }
    }
}