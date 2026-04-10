using Microsoft.VisualBasic.Logging;
using ScottPlot;
using ScottPlot.Plottables;
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
            CityList.DisplayMember = "Nome";//campo da mostrare
            CityList.DataSource = ListaCittà;
            progressBarTemp.Minimum = 0;
            progressBarTemp.Maximum = 45;
            Chart_Temperature.Height = 150;
            Chart_AirQuality.Height = 150;
            Refreshpage(ListaCittà[0]);
        }

        List<Citta> ListaCittà = new List<Citta>
        {
            new Citta("New York", 40.7128, -74.0060),
            new Citta("Londra", 51.5074, -0.1278),
            new Citta("Parigi", 48.8566, 2.3522),
            new Citta("Tokyo", 35.6895, 139.6917),
            new Citta("Pechino", 39.9042, 116.4074),
            new Citta("Shanghai", 31.2304, 121.4737),
            new Citta("Dubai", 25.2048, 55.2708),
            new Citta("Roma", 41.9028, 12.4964),
            new Citta("Milano", 45.4642, 9.1900),
            new Citta("Berlino", 52.5200, 13.4050),
            new Citta("Madrid", 40.4168, -3.7038),
            new Citta("Mosca", 55.7558, 37.6173),
            new Citta("Los Angeles", 34.0522, -118.2437),
            new Citta("Chicago", 41.8781, -87.6298),
            new Citta("Toronto", 43.6532, -79.3832),
            new Citta("Sydney", -33.8688, 151.2093),
            new Citta("Singapore", 1.3521, 103.8198),
            new Citta("Hong Kong", 22.3193, 114.1694),
            new Citta("Istanbul", 41.0082, 28.9784),
            new Citta("San Paolo", -23.5505, -46.6333),
            new Citta("Città del Messico", 19.4326, -99.1332),
            new Citta("Mumbai", 19.0760, 72.8777),
            new Citta("Delhi", 28.6139, 77.2090),
            new Citta("Bangkok", 13.7563, 100.5018),
            new Citta("Seoul", 37.5665, 126.9780)
        };

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

                //aggiorna i due grafici
                AggiornaGrafico(meteo.hourly.temperature_2m);
                AggiornaGraficoAria(aria.hourly.european_aqi);
            }

            

            return dati;
        }


        private async void button1_Click(object sender, EventArgs e)
        {

            Citta selectedcity = (Citta)CityList.SelectedItem;
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
            
            // toglei eventuali punti vecchi 
            Chart_Temperature.Plot.Clear();

            // trasforma da float a double perché sennò non va
            double[] valoriY = datiRaw.Select(v => (double)v ).ToArray();

            // "disegnamo " i punti e gli diamo determinato valori di spessore  
            var sig = Chart_Temperature.Plot.Add.Signal(valoriY);
            sig.Color = ScottPlot.Color.FromHex("#FF5733");
            sig.LineWidth = 2;
            sig.MarkerSize = 5;

            // impostiamo una scala costante perché se usassimo l'automatica cambia sempre
            Chart_Temperature.Plot.Axes.SetLimits(0, valoriY.Length, -10, 45);

            // scriviamo cosa è
            Chart_Temperature.Plot.Title("Andamento Temperatura");
            Chart_Temperature.Plot.XLabel("Ore");
            Chart_Temperature.Plot.YLabel("Temp(°C)");

            // rinfreschiamo il grafico
            Chart_Temperature.Refresh();
        }

        private void AggiornaGraficoAria(int?[] datiRaw)
        {
            //il regionamento è lo stesso di prima ma aggiungiamo il controllo nel caso fosse null
            Chart_AirQuality.Plot.Clear();

            double[] valoriY = datiRaw.Select(v => v.HasValue ? (double)v.Value : 0.0).ToArray();//conversione da int a double se null assegna 0

            // Aggiunge il segnale con un altro colore 
            var sig = Chart_AirQuality.Plot.Add.Signal(valoriY);
            sig.Color = ScottPlot.Color.FromHex("#2ECC71"); 
            sig.LineWidth = 2;
            sig.MarkerSize = 5;

            // Imposta i limiti degli assi
            Chart_AirQuality.Plot.Axes.SetLimits(0, valoriY.Length, 0, 100);

            // tipi di valori
            Chart_AirQuality.Plot.Title("Qualità dell'Aria (AQI)");
            Chart_AirQuality.Plot.XLabel("Ore");
            Chart_AirQuality.Plot.YLabel("Indice AQI");

            Chart_AirQuality.Refresh();
        }

        
    }
}
