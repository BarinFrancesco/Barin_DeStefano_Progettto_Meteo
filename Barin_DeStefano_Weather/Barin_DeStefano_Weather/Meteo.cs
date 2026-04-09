using System;
using System.Collections.Generic;
using System.Text;

namespace Barin_DeStefano_Weather
{
    public class Meteo
    {
        public string Citta { get; set; }
        public double Temperatura { get; set; }
        public string Descrizione { get; set; }

        public Meteo()
        {
        }
    }

    public class DatiMeteo
    {
        public string NomeCitta { get; set; }
        public float Temperatura { get; set; }
        public float Umidita { get; set; }
        public float Pressione { get; set; }
        public float? PM25 { get; set; }
        public int? AQI { get; set; } //nullable perché non tutte le città hanno dati sulla qualità dell'aria
        public DateTime Ora { get; set; }

        public DatiMeteo(string nomeCitta, float temperatura, float pressione, float umidita, float? pm25, int? aqi, DateTime ora)
        {
            NomeCitta = nomeCitta ?? "N/D";  
            Temperatura = temperatura;          
            Pressione = pressione;
            Umidita = umidita;
            PM25 = pm25 ?? 0f;
            AQI = aqi ?? 0;
            Ora = ora;
        }
    }
}
