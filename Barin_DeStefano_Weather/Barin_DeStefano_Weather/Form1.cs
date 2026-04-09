using Microsoft.VisualBasic.Logging;
using ScottPlot;
using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barin_DeStefano_Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CityList.DisplayMember = "Nome";
            CityList.DataSource = ListaCittà;
            progressBarTemp.Minimum = 0;
            progressBarTemp.Maximum = 45;
            Chart_Temperature.Height = 150;
            Chart_AirQuality.Height = 150;
            Refreshpage(ListaCittà[0]);
        }

        List<Citta> ListaCittà = new List<Citta>
        {
            new Citta { Nome = "New York", Lat = 40.7128, Lon = -74.0060 },
            new Citta { Nome = "Londra", Lat = 51.5074, Lon = -0.1278 },
            new Citta { Nome = "Parigi", Lat = 48.8566, Lon = 2.3522 },
            new Citta { Nome = "Tokyo", Lat = 35.6895, Lon = 139.6917 },
            new Citta { Nome = "Pechino", Lat = 39.9042, Lon = 116.4074 },
            new Citta { Nome = "Shanghai", Lat = 31.2304, Lon = 121.4737 },
            new Citta { Nome = "Dubai", Lat = 25.2048, Lon = 55.2708 },
            new Citta { Nome = "Roma", Lat = 41.9028, Lon = 12.4964 },
            new Citta { Nome = "Milano", Lat = 45.4642, Lon = 9.1900 },
            new Citta { Nome = "Berlino", Lat = 52.5200, Lon = 13.4050 },
            new Citta { Nome = "Madrid", Lat = 40.4168, Lon = -3.7038 },
            new Citta { Nome = "Mosca", Lat = 55.7558, Lon = 37.6173 },
            new Citta { Nome = "Los Angeles", Lat = 34.0522, Lon = -118.2437 },
            new Citta { Nome = "Chicago", Lat = 41.8781, Lon = -87.6298 },
            new Citta { Nome = "Toronto", Lat = 43.6532, Lon = -79.3832 },
            new Citta { Nome = "Sydney", Lat = -33.8688, Lon = 151.2093 },
            new Citta { Nome = "Singapore", Lat = 1.3521, Lon = 103.8198 },
            new Citta { Nome = "Hong Kong", Lat = 22.3193, Lon = 114.1694 },
            new Citta { Nome = "Istanbul", Lat = 41.0082, Lon = 28.9784 },
            new Citta { Nome = "San Paolo", Lat = -23.5505, Lon = -46.6333 },
            new Citta { Nome = "Città del Messico", Lat = 19.4326, Lon = -99.1332 },
            new Citta { Nome = "Mumbai", Lat = 19.0760, Lon = 72.8777 },
            new Citta { Nome = "Delhi", Lat = 28.6139, Lon = 77.2090 },
            new Citta { Nome = "Bangkok", Lat = 13.7563, Lon = 100.5018 },
            new Citta { Nome = "Seoul", Lat = 37.5665, Lon = 126.9780 }
        };
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public async Task<DatiMeteo> GetMeteoData(Citta selectedcity)
        {
            DatiMeteo dati;

            using (HttpClient client = new HttpClient())
            {//due link per le api, ai qual inserisco le coordinate per una ricerca migliore
                // la strina .ToString(CultureInfo.InvariantCulture) serve perché il link non funziona con ola virgola come separatore ma solo col punto
                string urlMeteo = $"https://api.open-meteo.com/v1/forecast?latitude={selectedcity.Lat.ToString(CultureInfo.InvariantCulture)}&longitude={selectedcity.Lon.ToString(CultureInfo.InvariantCulture)}&hourly=temperature_2m,relativehumidity_2m,pressure_msl&timezone=auto";
                string urlAria = $"https://air-quality-api.open-meteo.com/v1/air-quality?latitude={selectedcity.Lat.ToString(CultureInfo.InvariantCulture)}&longitude={selectedcity.Lon.ToString(CultureInfo.InvariantCulture)}&hourly=pm2_5,european_aqi&timezone=auto";

                //chiamata api per dati temperatura
                var responseMeteo = await client.GetStringAsync(urlMeteo);
                MeteoResponse meteo = JsonSerializer.Deserialize<MeteoResponse>(responseMeteo);


                // chiamata api per dati aria
                var responseAria = await client.GetStringAsync(urlAria);
                MeteoResponse aria = JsonSerializer.Deserialize<MeteoResponse>(responseAria);

                int ora = DateTime.Now.Hour;

                dati = new DatiMeteo(
                    selectedcity.Nome,
                    meteo.hourly.temperature_2m[ora],
                    meteo.hourly.pressure_msl[ora],
                    meteo.hourly.relativehumidity_2m[ora],
                    aria.hourly.pm2_5[ora],
                    aria.hourly.european_aqi[ora],
                    DateTime.Now
                );

                AggiornaGrafico(meteo.hourly.temperature_2m);
            }

            

            return dati;
        }


        private async void button1_Click(object sender, EventArgs e)
        {

            Citta selectedcity = (Citta)CityList.SelectedItem;/*
            DatiMeteo dati = await GetMeteoData(selectedcity);

            progressBarTemp.Value = (int)dati.Temperatura;
            lbl_City.Text = dati.NomeCitta;
            lbl_Temperature.Text = $"{(float)Math.Round(dati.Temperatura, 1)} °C";*/
            Refreshpage(selectedcity);
        }

        private async void Refreshpage(Citta selectedcity)
        {
            DatiMeteo dati = await GetMeteoData(selectedcity);

            progressBarTemp.Value = (int)dati.Temperatura;
            lbl_City.Text = dati.NomeCitta;
            lbl_Temperature.Text = $"{(float)Math.Round(dati.Temperatura, 1)} °C";
        }

        private void AggiornaGrafico(float[] datiRaw)
        {
            if (datiRaw == null || datiRaw.Length == 0) return;

            // toglei eventuali punti vecchi 
            Chart_Temperature.Plot.Clear();

            // trasforma da float a double perché sennò non va
            double[] valoriY = datiRaw.Select(v => (double)v).ToArray();

            // "disegnamo " i punti e gli diamo determinato valori di spessore  
            var sig = Chart_Temperature.Plot.Add.Signal(valoriY);
            sig.Color = ScottPlot.Color.FromHex("#FF5733");
            sig.LineWidth = 2;
            sig.MarkerSize = 5;

            // impostiamo una scala costante perché con lauto cambia sempre
            Chart_Temperature.Plot.Axes.SetLimits(0, valoriY.Length, -10, 45);

            // scriviamo cosa è
            Chart_Temperature.Plot.Title("Andamento Temperatura");
            Chart_Temperature.Plot.XLabel("Ore");
            Chart_Temperature.Plot.YLabel("Temp(°C)");

            // rinfreschiamo il grafico
            Chart_Temperature.Refresh();
        }


        private void lbl_Temperature_Click(object sender, EventArgs e)
        {

        }

        private void lbl_City_Click(object sender, EventArgs e)
        {

        }

        
    }
}
