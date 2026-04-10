using System;
using System.Collections.Generic;
using System.Text;

namespace Barin_DeStefano_Weather
{
    public class Citta
    {
        public string Nome { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

        //costruttore con parametri
        public Citta(string nome, double lat, double lon)
        {
            Nome = nome;
            Lat = lat;
            Lon = lon;
        }
    }
}
