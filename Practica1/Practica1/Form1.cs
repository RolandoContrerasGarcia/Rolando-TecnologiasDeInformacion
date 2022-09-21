using System;
using System.Windows.Forms;
namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()=>InitializeComponent();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Acciones.LlenarCombo(textBox1.Text, comboBox1, "CI", "NOMBRES");
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "id= " + comboBox1.SelectedValue;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }
    }
}