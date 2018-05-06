using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2.src.Controller
{
    class Persona
    {
        public int id { get; set; }
        public string name { get;  set; }
        public string email { get; set; }
        public string nationality { get; set; }
        
        public int getID()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getNationality()
        {
            return this.nationality;
        }

    }
}
