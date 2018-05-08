using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proyecto_2.src.Controller
{
    [XmlRoot("usuario")]
    public class Usuario
    {
        [XmlElement("code")]
        public String code { get; set; }

        [XmlElement("name")]
        public String name { get; set; }

        [XmlElement("password")]
        public String password { get; set; }
    }
}
