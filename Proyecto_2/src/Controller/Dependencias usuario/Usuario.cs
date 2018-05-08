using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proyecto_2.src.Controller.Dependencias_usuario
{
    [XmlRoot("usuario")]
    public class Usuario
    {
        [XmlElement("username")]
        public String username { get; set; }

        [XmlElement("password")]
        public String password { get; set; }

        [XmlElement("name")]
        public String name { get; set; }

        [XmlElement("lastname")]
        public String lastname { get; set; }

        [XmlElement("age")]
        public String age { get; set; }

        [XmlElement("genres")]
        public String genres { get; set; }

        [XmlElement("friends")]
        public String friends { get; set; }

        public Usuario(String usn, String pass, String nam, String last, String age, String genres, String friends)
        {
            this.username = usn;
            this.password = pass;
            this.name = nam;
            this.lastname = last;
            this.age = age;
            this.genres = genres;
            this.friends = friends;
        }
        public Usuario()
        {

        }
    }
}
