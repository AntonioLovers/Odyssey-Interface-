using Proyecto_2.src.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class MainWindow : Form
    {
        private Boolean scrolling = false;
        private Gestor gestor;
        public MainWindow(Gestor gest)
        {
            this.gestor = gest;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void ArtistaLBL_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ShareBTN_Click(object sender, EventArgs e)
        {

        }

        private void SearchBAR_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
            gestor.Stop();
            
        }

        private void MinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
 
        private void SearchBAR_Click_1(object sender, EventArgs e)
        {
            this.SearchBAR.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void scrollPNL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PageFRM_Click(object sender, EventArgs e)
        {

        }

        private void CancionesBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
