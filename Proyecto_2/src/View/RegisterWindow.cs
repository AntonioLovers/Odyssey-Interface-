using Proyecto_2.src.Controller;
using Proyecto_2.src.Controller.Conversores;
using Proyecto_2.src.Controller.Dependencias_usuario;
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
using System.Xml.Serialization;

namespace Proyecto_2.src.View
{
   
    public partial class RegisterWindow : Form
    {
        private Gestor gestor;
        private Cliente client;
        public RegisterWindow(Gestor gest,Cliente cln)
        {
            InitializeComponent();
            this.gestor = gest;
            this.client = cln;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestor.showLogin();
        }

        private void RockRBTN_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void MetalRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LatinRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RapRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClassicRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PopRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ElectronicRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RaggaeRBTN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            if(UsernameTXTB.Text!=String.Empty &&PasswordLBL.Text!=String.Empty && NameTXTB.Text!=String.Empty && LastnameTXTB.Text!=String.Empty && AgeTXTB.Text!=String.Empty&&(Rock.Checked||Latin.Checked||Reggae.Checked||Classic.Checked||Metal.Checked||Rap.Checked||Electronic.Checked||Pop.Checked))
            {
                if(autenticate(UsernameTXTB.Text))
                {
                    client.sendMessage("signup");
                    String respuesta = client.ReceivedMessage();
                    if(respuesta =="\0\u0004send")

                    {
                        Usuario user = new Usuario(UsernameTXTB.Text, PasswordTXTB.Text, NameTXTB.Text, LastnameTXTB.Text, AgeTXTB.Text, check(), friends());
                        var serializer = new XmlSerializer(user.GetType());
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                        ns.Add("", "");
                        string utf8;
                        using (StringWriter writer = new Utf8StringWriter())
                        {
                            serializer.Serialize(writer, user, ns);
                            utf8 = writer.ToString();
                        }
                        client.sendMessage(utf8);
                        StatusLBL.Text = "Succesfully signed!";
                        this.Refresh();
                        Transition();
                    }
                   
                }
                else
                {
                    StatusLBL.Text = "Username already in use!";
                }
            }
            else
            {
                this.StatusLBL.Text = "Missing Data!";
            }
        }
        public Boolean autenticate(String info)
        {
            client.sendMessage("verify");
            string respuesta = client.ReceivedMessage();
            if(respuesta== "\0\u0004send")
            {
                client.sendMessage(info);
                respuesta = client.ReceivedMessage();
                if(respuesta== "\0\u0004true")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public String check()
        {
            CheckBox[] check = new CheckBox[8] { this.Rock, this.Reggae, this.Rap, this.Pop, this.Classic, this.Metal, this.Electronic, this.Latin };
            String selected = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                if (check[i].Checked)
                {
                    if(selected==string.Empty)
                    {
                        selected = selected + check[i].Name;
                    }
                    else
                    {
                        selected = selected +"@" +check[i].Name ;
                    }
                }
            }
            return selected;
        }
        public String friends()
        {
            String selected = String.Empty;
            for (int i = 0; i < FriendsCHKL.Items.Count; i++)
                if (FriendsCHKL.GetItemChecked(i))
                {
                    if (selected==string.Empty)
                    {
                        selected = selected + (string)FriendsCHKL.Items[i];
                    }
                    else
                    {

                        selected =selected+"@" + (string)FriendsCHKL.Items[i];
                    }
                }
            return selected;
                    
        }
        public void Transition()
        {
            System.Threading.Thread.Sleep(2000);

            this.Hide();
            gestor.showLogin();
        }
    }
}
