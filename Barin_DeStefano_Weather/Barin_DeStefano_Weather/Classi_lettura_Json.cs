using System;
using System.Collections.Generic;
using System.Text;

namespace Barin_DeStefano_Weather
{
    public class Root
    {
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public string name { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
    }
}
