using System.IO;

namespace Cuadrado
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se guarda el valor ingresado
            int valor = int.Parse(textBox1.Text);

            //Se especifica la ruta y el nombre del archivo
            string nombreArchivo = @"c:\cuadrado.txt";
            //Se abre y escribe lo que contiene el ciclo for
            StreamWriter flujoSalida = File.CreateText(nombreArchivo);

            //Ciclo que dibujara un cuadrado basado en el valor ingresado
            for (int fila = 1; fila <= valor; fila++) 
            {
                for (int columna = 1; columna <= valor; columna++)
                {
                    flujoSalida.Write("*");
                }
                flujoSalida.WriteLine(); //Salto de linea
            }
            flujoSalida.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}