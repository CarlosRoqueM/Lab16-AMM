using Lab16.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab16
{
    public partial class MainPage : ContentPage
    {
        private string url = "https://jsonplaceholder.typicode.com/todos";
        HttpClient client = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string contenido = await client.GetStringAsync(url);
            IEnumerable<UsuarioModel>lista= JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(contenido);
            ltUsuario.ItemsSource = new ObservableCollection<UsuarioModel>(lista);
            base.OnAppearing();
        }
    }
}
