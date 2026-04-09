using System;
using System.Collections.Generic;
using System.Text;

namespace Barin_DeStefano_Weather
{

    public class MeteoResponse
    {
        public Hourly hourly { get; set; }
    }

    public class Hourly 
    {
        public string[] time { get; set; }
        public float[] temperature_2m { get; set; }
        public float[] relativehumidity_2m { get; set; }
        public float[] pressure_msl { get; set; }
        public float?[] pm2_5 { get; set; }
        public int?[] european_aqi { get; set; }
    }

   
}
