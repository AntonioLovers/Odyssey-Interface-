using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_2.src.Controller
{
    class Cancion 
    {
        int longitud;
        String nombre;
        String artista;
        String album;
        int año;
        String letra;
        String genero;
        Image caratula;
        

        public Cancion(int len,String name, String art, String albm,int año, String letra, String genero,Image front)
        {
            this.longitud = len;
            this.nombre = name;
            this.artista = art;
            this.album = albm;
            this.año = año;
            this.letra = letra;
            this.genero = genero;
            this.caratula = front;
        }
    }
}
