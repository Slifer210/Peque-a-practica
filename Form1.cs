using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_EJERCICIO_1
{
    public partial class Form1 : Form
    {
        List<Musica> objmusica = new List<Musica>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
                      
            Musica music = new Musica();
            string tipo = CBOinstrumento.Text;
            string marca = CBOmarca.Text;
            string color = CBOcolor.Text;

            music.Tipo = tipo;
            music.Color = color;
            music.Marca = marca;

            objmusica.Add(music);

            if (CBOinstrumento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione una de las opciones");
            }
            else if (CBOmarca.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione una de las opciones");
            }
            if (CBOcolor.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione una de las opciones");
            }
            try
            {
                string ruta = "datos.txt";
                if (File.Exists(ruta))
                {
                    StreamWriter escribir = new StreamWriter(ruta, append: true);
                    escribir.WriteLine(music.Tipo + "," + music.Marca + "," + music.Color + "," + LBLNOTA.Text);
                    MessageBox.Show("Se guardaron los datos correctamente en el archivo datos.txt");
                    escribir.Close();
                }
                else
                {
                    try
                    {
                        string ruta2 = "datos.txt";
                        StreamWriter escribir = File.CreateText(ruta2);
                        escribir.WriteLine("Tipo Instrumento, Marca, Color, Nota");                        
                        foreach (Musica Msa in objmusica)
                        {
                            escribir.WriteLine(music.Tipo + "," + music.Marca + "," + music.Color + "," + LBLNOTA.Text);
                        }
                        escribir.Close();
                    }
                    catch(Exception ea)
                    {
                        MessageBox.Show("Error de registro" + ea.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de registro" + ex.ToString());
            }

        }

        private void BTNSTOP_Click(object sender, EventArgs e)
        {
            if (BTNSTOP.Text == "Stop")
            {
                timer1.Interval = 1000;
                BTNSTOP.Text = "Play";
            }
            else
            {
                timer1.Interval = 200;
                BTNSTOP.Text = "Stop";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int lineas = File.ReadAllLines("Notas.txt").Length;
            Random ra = new Random();
            int lineasrandom = ra.Next(0, lineas);
            StreamReader archivo = File.OpenText("Notas.txt");
            string lins = null;
            int i = 0;
            while (!archivo.EndOfStream)
            {
                lins = archivo.ReadLine();
                if (++i == lineasrandom)
                    break;
            }
            LBLNOTA.Text = lins;
        }

        private void BTNAGREGARDGV_Click(object sender, EventArgs e)
        {
            DGV.DataSource = null;
            DGV.DataSource = objmusica;
            
        }

        private void BTNMOSTRARLV_Click(object sender, EventArgs e)
        {
            StreamReader lectura = new StreamReader("datos.txt");
            string lin;
            try
            {
                lin = lectura.ReadLine();
                while (lin != null)
                {
                    richTextBox1.AppendText(lin + "\n");
                    lin = lectura.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
