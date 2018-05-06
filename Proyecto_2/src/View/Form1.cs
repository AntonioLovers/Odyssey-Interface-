using Proyecto_2.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2.src.View
{
    public partial class Form1 : Form
    {
        private RESTClient cliente;
        public Form1()
        {
            InitializeComponent();
            cliente = new RESTClient();
            Console.WriteLine("Initialized!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cliente.endPoint = textBox1.Text;
            Persona response = cliente.makeRequest();
            try
            {
                textBox2.Clear();
                textBox2.AppendText("ID: " + response.getID());
                textBox2.AppendText("\r\n"+"Nombre: " + response.getName());
                textBox2.AppendText("\r\n"+"Nationality: " + response.getNationality());
                textBox2.AppendText("\r\n"+"Email: " + response.getEmail());
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
