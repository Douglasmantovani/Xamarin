using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GameStoreApp.Services
{
    class Utils
    {
        private static HttpClient client;

        public static HttpClient getClient
        {
            get
            {
                if (client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://0000.00000.00000/api/");//Coloque o ip da sua maquina aqui caso esteja usando o celular
                }
                return client;
            }
        }
    }
}
