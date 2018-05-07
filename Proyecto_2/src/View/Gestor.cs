using Proyecto_2.src.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_2.src.View
{
    public class Gestor
    {
        private Cliente client;
        private Login login;
        private MainWindow musicwdw;

        public Gestor()
        {
            this.client = new Cliente();
            Thread cliente = new Thread(new ThreadStart(client.Run));
            cliente.Start();
            this.login = new Login(client,this);
            this.musicwdw = new MainWindow(this);

        }

        public void showLogin()
        {
            this.login.Show();
        }
        public Login getLogin()
        {
            return this.login;
        }
        public void showMain()
        {
            this.musicwdw.Show();
        }
        public void Stop()
        {
            client.Stop();
        }
    }
}
