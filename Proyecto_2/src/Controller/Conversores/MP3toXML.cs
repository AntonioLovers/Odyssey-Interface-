using Proyecto_2.src.Controller.Dependencias_usuario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proyecto_2.src.Controller.Conversores
{
    class MP3toXML
    {
        String basicRoute;

        public MP3toXML()
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            this.basicRoute =Path.Combine(projectPath, @"Resources\Library\"); ;
        }
        public String ConverttoXML(String name)
        {
            String route = basicRoute + name;
            if (File.Exists(route))
            {
                byte[] song = File.ReadAllBytes(route);
                String converted = Convert.ToBase64String(song);
                if (File.Exists(basicRoute + "prueba.txt"))
                {
                    var tw = new StreamWriter(basicRoute + "prueba.txt", true);
                    tw.WriteLine();
                }
                Cancion user = new Cancion
                {
                    Song64 = converted,
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
                return utf8;

            }
            else
            {
                return String.Empty;
            }
        }

    }
}
