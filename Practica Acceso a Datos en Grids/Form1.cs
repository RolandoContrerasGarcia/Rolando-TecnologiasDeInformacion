using System;
using System.Drawing;
using System.Windows.Forms;
namespace Practica_Acceso_a_Datos_en_Grids
{
    public partial class Form1 : Form
    {
        public Form1()=>InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)=>panel1.Height=Size.Height/4;
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = Size.Height / 4;
            listView1.Width = dataGridView1.Width = Size.Width / 2 - 8;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Acciones.LlenarGrid(textBox1.Text,dataGridView1);
            Acciones.LlenarList(textBox1.Text,listView1);
        }
    }
}