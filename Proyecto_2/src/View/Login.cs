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
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;

namespace Proyecto_2.src.View
{
    public partial class Login : Form
    {
        private Cliente cln;
        private Gestor gestor;

        public Login(Cliente cln, Gestor gest)
        {
            InitializeComponent();
            this.cln = cln;
            this.gestor = gest;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void UsernameTXTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LogBTN_Click(object sender, EventArgs e)
        {

            if(UsernameTXTB.Text!="")
            {
                if(PasswordTXTB.Text!="")
                {
                    Usuario user = new Usuario
                    {
                        code= "login",
                        name = UsernameTXTB.Text,
                        password = PasswordTXTB.Text,
                    };
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    String response=serializer.Serialize(user);
                    cln.sendMessage(response);
                    String respuesta = cln.ReceivedMessage();
                    if(respuesta.ToLower()== "\0\u0004true")
                    {
                        PopLBL.Text = "Succesful login!";
                        this.Refresh();
                        Transition();
                    }
                    else
                    {
                        PopLBL.Text = "Unknown user/password!";
                        PopLBL.Font = new System.Drawing.Font("hooge 05_55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }

                }
                else
                {
                    PopLBL.Text = "Missing data!";
                }
            }
            else
            {
                PopLBL.Text = "Missing data!";
            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void Transition()
        {
            System.Threading.Thread.Sleep(2000);
            this.Dispose();
            gestor.showMain();
        }
    }
}
