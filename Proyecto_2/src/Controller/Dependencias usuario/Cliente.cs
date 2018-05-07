using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2.src.Controller
{
    public class Cliente
    {
        private Socket sck;
        private IPEndPoint remendPoint;
        private Boolean running;
        public Cliente()
        {
            this.sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.remendPoint = new IPEndPoint(IPAddress.Parse("192.168.100.69"), 9090);
            this.running = true;
        }
        public void Run()
        {
            while (running)
            {
                var attempts = 1;
                while (running && !sck.Connected)
                {
                    try
                    {
                        Console.WriteLine("Connecting....");
                        sck.Connect(this.remendPoint);
                        Console.WriteLine("Connected!");
                        Console.WriteLine(ReceivedMessage());
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Failed to connect");
                        Console.WriteLine("Conection Attempts: " + attempts.ToString());
                        attempts++;
                    }
                }
            }

        }
        public String ReceivedMessage()
        {
            try
            {
                byte[] b = new byte[1654];
                int k = sck.Receive(b);
                string Received = Encoding.ASCII.GetString(b, 0, k);
                return Received;



            }
            catch (Exception e)
            {
                return null;
            }
        }
        public void sendMessage(string respuesta)
        {
            byte[] byData = System.Text.Encoding.UTF8.GetBytes(respuesta);
            sck.Send(byData);

        } 
        public void Stop()
        {
            this.running = false;
        }
    }
}

