using System;
using System.Diagnostics.Metrics;
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
            CityList.DataSource = citta;
        }

        string[] citta = new string[]
        {
            "New York",
            "Londra",
            "Parigi",
            "Tokyo",
            "Pechino",
            "Shanghai",
            "Dubai",
            "Roma",
            "Milano",
            "Berlino",
            "Madrid",
            "Mosca",
            "Los Angeles",
            "Chicago",
            "Toronto",
            "Sydney",
            "Singapore",
            "Hong Kong",
            "Istanbul",
            "San Paolo",
            "Città del Messico",
            "Mumbai",
            "Delhi",
            "Bangkok",
            "Seoul"
        };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public string città;
        private string chiave = "6c5ab5627257c53b6b93127767fc8afb";


        public async Task<Meteo> GetMeteoAsync(string citta)
        {

            using (HttpClient client = new HttpClient())
            {
                string link = $"https://api.openweathermap.org/data/2.5/weather?q={citta}&appid={chiave}&units=metric&lang=it";
                string risposta = await client.GetStringAsync(link);

                Root Dati = JsonSerializer.Deserialize<Root>(risposta);


                Meteo meteo = new Meteo();
                meteo.Citta = Dati.name;
                meteo.Temperatura = Dati.main.temp; //
                meteo.Descrizione = Dati.weather[0].description;//siccome e un array di stringhe prendo sempre la prima descrizione

                return meteo;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string città = CityList.SelectedItem.ToString();

            Meteo meteo = await GetMeteoAsync(città);
            MessageBox.Show(meteo.Temperatura.ToString());
        }
    }
}
