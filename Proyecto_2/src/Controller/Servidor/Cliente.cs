using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2.src.Controller
{
    public class Cliente
    {
        private TcpClient sck;
        private Boolean running;
        private NetworkStream streamer;
        public Cliente()
        {
            this.sck = new TcpClient();
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
                        this.sck.Connect("192.168.100.69", 9090);
                        this.streamer = sck.GetStream();
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
                streamer.Flush();
                byte[]data = new byte[1654];
                String received = string.Empty;
                Int32 bytes = streamer.Read(data, 0, data.Length);
                received= System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                return received;



            }
            catch (Exception e)
            {
                return String.Empty;
            }
        }
        public void sendMessage(string respuesta)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(respuesta);
            streamer.Write(data,0,data.Length);
            streamer.Flush();

        } 
        public void Stop()
        {
            this.running = false;
        }
    }
}

