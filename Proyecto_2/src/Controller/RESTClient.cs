using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Proyecto_2.src.Controller
{ 
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE

    }
    class RESTClient
    {
        public string endPoint{ get; set; }
        public httpVerb httpMethod { get; set; }

        public RESTClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;

        }

        public Persona makeRequest()
        {
            string responseValue = string.Empty;
            //Persona persona = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            try
            {

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Error en el codigo: " + response.StatusCode);
                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                                Persona persona = JsonConvert.DeserializeObject<Persona>(responseValue);
                                return persona;

                            }
                        }
                    }
                }
             
        
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR 404: Elemento no encontrado");
            }
            return null;
        }
    }
}
