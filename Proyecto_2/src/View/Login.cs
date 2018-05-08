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
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Proyecto_2.src.Controller.Conversores;

namespace Proyecto_2.src.View
{
    public partial class Login : Form
    {
        private Cliente cln;
        private Gestor gestor;
        private String respuesta;

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
                    try
                    {
                        cln.sendMessage("login");
                        respuesta = cln.ReceivedMessage();
                        Console.WriteLine(respuesta);
                        if (respuesta == "\0\u0004send")
                        {
                            LogU user = new LogU()
                            {
                                name = UsernameTXTB.Text,
                                password = PasswordTXTB.Text,
                            };
                            var serializer = new XmlSerializer(user.GetType());
                            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                            ns.Add("", "");
                            string utf8;
                            using (StringWriter writer = new Utf8StringWriter())
                            {
                                serializer.Serialize(writer, user, ns);
                                utf8 = writer.ToString();
                            }
                            cln.sendMessage(utf8);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    respuesta = cln.ReceivedMessage();
                    Console.WriteLine(respuesta);
                    if(respuesta.ToLower()== "\0\u0004true")
                    {
                        PopLBL.Text = "Succesful login!";
                        this.Refresh();
                        Transition();
                    }
                    else if(respuesta.ToLower() == "\0\u0005false")
                    {
                        PopLBL.Text = "Unknown user or password!";
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
            this.Hide();
            gestor.showMain();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestor.showReg();
        }

        private void PasswordTXTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
