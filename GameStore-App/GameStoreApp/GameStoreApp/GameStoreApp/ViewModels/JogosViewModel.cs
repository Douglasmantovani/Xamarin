using GameStoreApp.Models;
using GameStoreApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GameStoreApp.ViewModels
{
    class JogosViewModel:BaseViewModel
    {
        public List<JogoClass> Jogos { get; set; }

        public JogosViewModel()
        {
            Jogos = new List<JogoClass>();

            getJogo();
        }
        private void getJogo()
        {
            try
            {
                HttpClient client = Utils.getClient;

                HttpResponseMessage response = client.GetAsync("Jogos").Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Jogos = JsonConvert.DeserializeObject<List<JogoClass>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
