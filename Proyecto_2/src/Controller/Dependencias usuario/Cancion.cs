using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proyecto_2.src.Controller.Dependencias_usuario
{
    [XmlRoot("cancion")]
    public class Cancion
    {
        [XmlElement("song64")]
        public String Song64{get; set;}
    }
}
